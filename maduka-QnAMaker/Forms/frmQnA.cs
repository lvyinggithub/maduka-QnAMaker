using maduka_QnAMakerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maduka_QnAMaker.Forms
{
    public partial class frmQnA : Base.BaseForm
    {
        public frmQnA()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 頁面讀取的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmQnA_Load(object sender, EventArgs e)
        {
            base.ReadKBList();
            cbxKbId.DataSource = base.KBList;
        }

        /// <summary>
        /// 開始進行問答的動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            KBModel.GenerateAnswerModel objQuery = new KBModel.GenerateAnswerModel()
            {
                question = txtQuery.Text,
                top = int.Parse(txtTop.Text),
            };

            HttpStatusCode code = HttpStatusCode.OK;
            string strKbId = base.KBList[cbxKbId.SelectedIndex].kbId;
            KBModel.GenerateAnswerResultModel result =  base.iQnAMaker.GenerateAnswer(strKbId, objQuery, out code);

            if (code == HttpStatusCode.OK)
            {
                for (int i = 0; i < result.answers.Count; i++)
                    result.answers[i].question = result.answers[i].questions[0];

                this.BindData(result);
            }
            else
            {
                MessageBox.Show("Generate Answer Fail:" + code.ToString());
            }
        }

        /// <summary>
        /// 將取得的回答資料放入到控制項之中
        /// </summary>
        private void BindData(KBModel.GenerateAnswerResultModel value)
        {
            // 取出最相似的回覆，並放在文字方塊中
            if (value.answers.Count > 0)
            {
                txtAnswer.Text = value.answers[0].answer;

                gvAnswerList.DataSource = null;
                gvAnswerList.Refresh();
                gvAnswerList.DataSource = value.answers;
            }
            else
            {
                MessageBox.Show("found not any answer");
            }
        }
    }
}
