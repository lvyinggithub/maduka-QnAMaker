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
            Models.KBModel.CreateKBModel objKb = new Models.KBModel.CreateKBModel()
            {
                name = txtKbName.Text,
                urls = txtQnADocUrl.Text,
                qnaPairs = new List<Models.KBModel.QnAList>(),
            };

            for (int i = 0; i < gvQnA.Rows.Count; i++)
            {
                string strQuestion = gvQnA.Rows[i].Cells[0].Value.ToString();
                string strAnswer = gvQnA.Rows[i].Cells[1].Value.ToString();

                objKb.qnaPairs.Add(
                    new Models.KBModel.QnAList()
                    {
                        answer = strAnswer,
                        question = strQuestion,
                    }
                );
            }

            // 送出新增的動作
            this.SendRequestAsync(objKb);
        }

        /// <summary>
        /// 呼叫API進行KB建立的動作
        /// </summary>
        /// <param name="objKb">要建立KB的物件</param>
        /// <returns></returns>
        private async Task SendRequestAsync(Models.KBModel.CreateKBModel objKb)
        {
            var msg = await CallQnAMaker("/create", "POST", JsonConvert.SerializeObject(objKb));
        }
    }
}
