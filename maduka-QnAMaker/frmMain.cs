using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maduka_QnAMaker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 開啟指定的表單物件
        /// </summary>
        /// <param name="objFrm"></param>
        private void OpenForm(Form objFrm)
        {
            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }

        private void mnAlterationsMngItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 建立新KB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnKbCreate_Click(object sender, EventArgs e) => this.OpenForm(new Forms.frmKbCreate());

        /// <summary>
        /// KB QnA管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnKbQnA_Click(object sender, EventArgs e) => this.OpenForm(new Forms.frmKbMng());

        private void mnClose_Click(object sender, EventArgs e) => this.Close();

        /// <summary>
        /// 開始問答的畫面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnQnA_Click(object sender, EventArgs e) => this.OpenForm(new Forms.frmQnA());

    }
}
