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
using maduka_QnAMaker.Models;

namespace maduka_QnAMaker.Forms
{
    public partial class frmKbMng : Base.BaseForm
    {
        List<KBModel.QnAQueryList> objQnA = new List<KBModel.QnAQueryList>();
        int intRowIndex = 0;

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
            objQnA.Add(
                new KBModel.QnAQueryList()
                {
                    answer = "-",
                    question = "-",
                    source = "add",
                }
            );
            gvQnA.DataSource = null;
            gvQnA.Update();
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
                objQnA[intRowIndex].source = "delete";
                gvQnA.DataSource = objQnA;
                gvQnA.Refresh();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnTrain_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 在Gridview中點選欄位時，放入當下的資料列索引
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvQnA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            intRowIndex = e.RowIndex;
        }

        /// <summary>
        /// 下載並放入Kb的問答資料
        /// </summary>
        private string DownloadData()
        {
            HttpStatusCode code = HttpStatusCode.OK;
            string strFilePath = "";

            // 取得tsv的檔案網址
            if (cbxKbId.SelectedIndex > -1)
            {
                string strKbId = base.KBList[cbxKbId.SelectedIndex].kbId;
                string strTsvFileUrl = base.CallQnAMaker("/" + strKbId, "GET", "", out code).Replace("\"", "");

                // 下載tsv的內容
                strFilePath = Application.StartupPath + $"\\Download\\{strKbId}.tsv";
                new WebClient().DownloadFile(strTsvFileUrl, strFilePath);
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
    }
}
