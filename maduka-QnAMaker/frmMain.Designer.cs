namespace maduka_QnAMaker
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.管理KBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKBMng = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKbCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKbQnA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAlterationsMngItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQnA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMain
            // 
            this.mnMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理KBToolStripMenuItem,
            this.mnQnA});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(1369, 38);
            this.mnMain.TabIndex = 4;
            this.mnMain.Text = "menuStrip1";
            // 
            // 管理KBToolStripMenuItem
            // 
            this.管理KBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnKBMng,
            this.mnAlterationsMngItem,
            this.mnClose});
            this.管理KBToolStripMenuItem.Name = "管理KBToolStripMenuItem";
            this.管理KBToolStripMenuItem.Size = new System.Drawing.Size(103, 34);
            this.管理KBToolStripMenuItem.Text = "管理KB";
            // 
            // mnKBMng
            // 
            this.mnKBMng.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnKbCreate,
            this.mnKbQnA});
            this.mnKBMng.Name = "mnKBMng";
            this.mnKBMng.Size = new System.Drawing.Size(278, 38);
            this.mnKBMng.Text = "KB資料管理";
            // 
            // mnKbCreate
            // 
            this.mnKbCreate.Name = "mnKbCreate";
            this.mnKbCreate.Size = new System.Drawing.Size(246, 38);
            this.mnKbCreate.Text = "建立新KB";
            this.mnKbCreate.Click += new System.EventHandler(this.mnKbCreate_Click);
            // 
            // mnKbQnA
            // 
            this.mnKbQnA.Name = "mnKbQnA";
            this.mnKbQnA.Size = new System.Drawing.Size(246, 38);
            this.mnKbQnA.Text = "KB QnA管理";
            this.mnKbQnA.Click += new System.EventHandler(this.mnKbQnA_Click);
            // 
            // mnAlterationsMngItem
            // 
            this.mnAlterationsMngItem.Name = "mnAlterationsMngItem";
            this.mnAlterationsMngItem.Size = new System.Drawing.Size(278, 38);
            this.mnAlterationsMngItem.Text = "關鍵字變更管理";
            this.mnAlterationsMngItem.Click += new System.EventHandler(this.mnAlterationsMngItem_Click);
            // 
            // mnClose
            // 
            this.mnClose.Name = "mnClose";
            this.mnClose.Size = new System.Drawing.Size(278, 38);
            this.mnClose.Text = "關閉";
            this.mnClose.Click += new System.EventHandler(this.mnClose_Click);
            // 
            // mnQnA
            // 
            this.mnQnA.Name = "mnQnA";
            this.mnQnA.Size = new System.Drawing.Size(121, 34);
            this.mnQnA.Text = "開始問答";
            this.mnQnA.Click += new System.EventHandler(this.mnQnA_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 836);
            this.Controls.Add(this.mnMain);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmMain";
            this.Text = "Microsoft QnAMaker";
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem 管理KBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnKBMng;
        private System.Windows.Forms.ToolStripMenuItem mnAlterationsMngItem;
        private System.Windows.Forms.ToolStripMenuItem mnQnA;
        private System.Windows.Forms.ToolStripMenuItem mnClose;
        private System.Windows.Forms.ToolStripMenuItem mnKbCreate;
        private System.Windows.Forms.ToolStripMenuItem mnKbQnA;
    }
}



