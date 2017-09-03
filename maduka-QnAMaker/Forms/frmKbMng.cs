using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using maduka_QnAMakerLibrary;

namespace maduka_QnAMaker.Forms
{
    public partial class frmKbMng : Base.BaseForm
    {
        List<KBModel.QnAQueryList> objQnA = new List<KBModel.QnAQueryList>();
        int intRowIndex = 0;
        bool blIsEditor = false;

        public frmKbMng()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 畫面讀取的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmKbMng_Load(object sender, EventArgs e)
        {
            base.ReadKBList();
            cbxKbId.DataSource = base.KBList;
            //string strFilePath = this.DownloadData();
            //this.BindData(strFilePath);
        }

        /// <summary>
        /// 變更Kb項目的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxKbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strFilePath = this.DownloadData();
            this.BindData(strFilePath);
        }

        /// <summary>
        /// 點選新增的動作，將新的QnA放入至物件清單中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddQnA_Click(object sender, EventArgs e)
        {
            if (blIsEditor)
            {
                objQnA[intRowIndex].answer = txtAnswer.Text;
                objQnA[intRowIndex].question = txtQuestion.Text;
            }
            else
            {
                objQnA.Add(
                    new KBModel.QnAQueryList()
                    {
                        answer = txtAnswer.Text,
                        question = txtQuestion.Text,
                        source = "add",
                    }
                );
            }

            blIsEditor = false;
            txtAnswer.Text = "";
            txtQuestion.Text = "";

            gvQnA.DataSource = new KBModel.QnAQueryList();
            gvQnA.Refresh();
            gvQnA.DataSource = objQnA;
        }

        /// <summary>
        /// 刪除資料的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteQnA_Click(object sender, EventArgs e)
        {
            if (intRowIndex > -1)
            {
                if (objQnA[intRowIndex].source == "add")
                {
                    objQnA.RemoveAt(intRowIndex);
                }
                else
                {
                    objQnA[intRowIndex].source = "delete";
                }

                gvQnA.DataSource = new KBModel.QnAQueryList();
                gvQnA.Refresh();
                gvQnA.DataSource = objQnA;
            }
        }

        /// <summary>
        /// 取消刪除的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndelete_Click(object sender, EventArgs e)
        {
            if (intRowIndex > -1)
            {
                if (objQnA[intRowIndex].source == "delete")
                    objQnA[intRowIndex].source = "Editorial";

                gvQnA.DataSource = new KBModel.QnAQueryList();
                gvQnA.Refresh();
                gvQnA.DataSource = objQnA;
            }
        }
        /// <summary>
        /// 下載tsv檔案至Download資料夾中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownload_Click(object sender, EventArgs e)
        {
            string strFilePath = this.DownloadData();
            MessageBox.Show("File is save to :" + strFilePath);
        }

        /// <summary>
        /// 送出更新的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            KBModel.UpdateKBModel objUpdate = new KBModel.UpdateKBModel()
            {
                add = new  KBModel.UpdateKBModel.Add()
                {
                    qnaPairs = new List<KBModel.QnAList>(),
                    urls = new List<string>()
                },
                delete = new KBModel.UpdateKBModel.Delete()
                {
                    qnaPairs = new List<KBModel.QnAList>()
                },
            };

            for (int i = 0; i < objQnA.Count; i++)
            {
                if (objQnA[i].source == "delete")
                {
                    objUpdate.delete.qnaPairs.Add(new KBModel.QnAList()
                    {
                        answer = objQnA[i].answer,
                        question = objQnA[i].question,
                    }
                    );
                }
                else if (objQnA[i].source == "add")
                {
                    objUpdate.add.qnaPairs.Add(new KBModel.QnAList()
                    {
                        answer = objQnA[i].answer,
                        question = objQnA[i].question,
                    }
                    );
                }
            }

            HttpStatusCode code = HttpStatusCode.OK;
            string strMsg = iQnAMaker.UpdateKB(base.KBList[cbxKbId.SelectedIndex].kbId, objUpdate, out code);

            if (code == HttpStatusCode.NoContent)
            {
                MessageBox.Show("Update KB Success");
                string strFilePath = this.DownloadData();
                this.BindData(strFilePath);
            }
            else
            {
                MessageBox.Show("Update KB Fail:" + code.ToString());
            }
        }

        /// <summary>
        /// 送出訓練的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrain_Click(object sender, EventArgs e)
        {
            HttpStatusCode code = HttpStatusCode.OK;
            iQnAMaker.TrainKB(base.KBList[cbxKbId.SelectedIndex].kbId, out code);

            if (code == HttpStatusCode.NoContent)
                MessageBox.Show("Train KB Success");
            else
                MessageBox.Show("Train KB Fail:" + code.ToString());
        }

        /// <summary>
        /// 在Gridview中點選欄位時，放入當下的資料列索引
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvQnA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQuestion.Text = "";
            txtAnswer.Text = "";
            blIsEditor = false;

            if (objQnA[e.RowIndex].source == "add")
            {
                txtQuestion.Text = objQnA[e.RowIndex].question;
                txtAnswer.Text = objQnA[e.RowIndex].answer;
                blIsEditor = true;
            }

            intRowIndex = e.RowIndex;
        }

        /// <summary>
        /// 下載並放入Kb的問答資料
        /// </summary>
        private string DownloadData()
        {
            string strFilePath = "";

            // 取得tsv的檔案網址
            if (cbxKbId.SelectedIndex > -1)
            {
                HttpStatusCode code = HttpStatusCode.OK;
                string strKbId = base.KBList[cbxKbId.SelectedIndex].kbId;
                string strTsvFileUrl = iQnAMaker.DownloadKB(strKbId, out code);

                // 下載tsv的內容
                strFilePath = Application.StartupPath + $"\\Download\\{strKbId}.tsv";

                // 刪除下載檔案
                File.Delete(strFilePath);

                using (var client = new WebClient())
                {
                    // 儲存新檔案
                    client.DownloadFile(strTsvFileUrl, strFilePath);
                }
            }

            return strFilePath;
        }

        /// <summary>
        /// 將指定的tsv檔案放入至清單物件之中
        /// </summary>
        /// <param name="strFilePath"></param>
        private void BindData(string strFilePath)
        {
            // 處理tsv內容並放到List之中
            List<string> strContents = File.OpenText(strFilePath)
                                           .ReadToEnd()
                                           .Split(new string[] { "\r\n" }, StringSplitOptions.None)
                                           .ToList();

            if (strContents.Count > 1)
            {
                for (int i = 1; i < strContents.Count; i++)
                {
                    if (!string.IsNullOrEmpty(strContents[i]))
                    {
                        List<string> strQnAs = strContents[i].Split(new string[] { "\t" }, StringSplitOptions.None)
                                                             .ToList();
                        objQnA.Add(new KBModel.QnAQueryList()
                        {
                            question = strQnAs[0],
                            answer = strQnAs[1],
                            source = strQnAs[2],
                        }
                        );
                    }
                }
            }

            // 放入Gridview裡
            gvQnA.DataSource = objQnA;
        }

        /// <summary>
        /// 資料繫結完成後的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvQnA_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < gvQnA.Rows.Count; i++)
            {
                gvQnA.Rows[i].ReadOnly = true;
                if (!string.IsNullOrEmpty(gvQnA.Rows[i].Cells[0].Value.ToString()))
                {
                    if (gvQnA.Rows[i].Cells[2].Value.ToString() == "add")
                        gvQnA.Rows[i].ReadOnly = false;
                }
            }
        }
    }
}
