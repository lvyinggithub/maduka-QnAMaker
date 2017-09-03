using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using maduka_QnAMakerLibrary;

namespace maduka_QnAMaker.Forms
{
    public partial class frmKbCreate : Base.BaseForm
    {
        public frmKbCreate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 點選建立KB的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // 取出資料
            KBModel.CreateKBModel objKb = new KBModel.CreateKBModel()
            {
                name = txtKbName.Text,
                urls = new List<string>() { txtQnADocUrl.Text },
                qnaPairs = new List<KBModel.QnAList>(),
            };

            for (int i = 0; i < gvQnA.Rows.Count; i++)
            {
                if (gvQnA.Rows[i].Cells[0].Value != null & gvQnA.Rows[i].Cells[1].Value != null)
                {
                    string strQuestion = gvQnA.Rows[i].Cells[0].Value.ToString();
                    string strAnswer = gvQnA.Rows[i].Cells[1].Value.ToString();

                    objKb.qnaPairs.Add(
                        new KBModel.QnAList()
                        {
                            answer = strAnswer,
                            question = strQuestion,
                        }
                    );
                }
            }

            // 送出新增的動作
            HttpStatusCode code = HttpStatusCode.OK;
            KBModel.CreateKBResultModel result =  base.iQnAMaker.CreateKB(objKb, out code);

            if (code == HttpStatusCode.Created)
            {
                // 寫入KBList的設定檔之
                base.ReadKBList();
                base.KBList.Add(
                    new KBModel.KBListModel()
                    {
                        kbId = result.kbId,
                        name = txtKbName.Text,
                    }
                );
                base.WriteKBList();
                MessageBox.Show("Create KB Success");
                this.ResetControls();
            }
            else
            {
                MessageBox.Show("Create KB Fail:" + code.ToString());
            }
        }

        void ResetControls()
        {
            txtKbName.Text = "";
            txtQnADocUrl.Text = "";
            gvQnA.DataSource = null;
            gvQnA.Update();
            gvQnA.Refresh();
        }
    }
}
