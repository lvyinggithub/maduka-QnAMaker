namespace maduka_QnAMaker.Forms
{
    partial class frmKbCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvQnA = new System.Windows.Forms.DataGridView();
            this.question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQnADocUrl = new System.Windows.Forms.TextBox();
            this.txtKbName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblKbName = new System.Windows.Forms.Label();
            this.lblKbQnAList = new System.Windows.Forms.Label();
            this.lblKbQnARefUrl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvQnA)).BeginInit();
            this.SuspendLayout();
            // 
            // gvQnA
            // 
            this.gvQnA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvQnA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQnA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.question,
            this.answer});
            this.gvQnA.Location = new System.Drawing.Point(75, 32);
            this.gvQnA.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gvQnA.Name = "gvQnA";
            this.gvQnA.RowTemplate.Height = 38;
            this.gvQnA.Size = new System.Drawing.Size(413, 258);
            this.gvQnA.TabIndex = 1;
            // 
            // question
            // 
            this.question.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.question.FillWeight = 50F;
            this.question.HeaderText = "question";
            this.question.Name = "question";
            // 
            // answer
            // 
            this.answer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.answer.FillWeight = 50F;
            this.answer.HeaderText = "answer";
            this.answer.Name = "answer";
            // 
            // txtQnADocUrl
            // 
            this.txtQnADocUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQnADocUrl.Location = new System.Drawing.Point(75, 294);
            this.txtQnADocUrl.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtQnADocUrl.Name = "txtQnADocUrl";
            this.txtQnADocUrl.Size = new System.Drawing.Size(413, 22);
            this.txtQnADocUrl.TabIndex = 2;
            // 
            // txtKbName
            // 
            this.txtKbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKbName.Location = new System.Drawing.Point(75, 6);
            this.txtKbName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtKbName.Name = "txtKbName";
            this.txtKbName.Size = new System.Drawing.Size(413, 22);
            this.txtKbName.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(427, 320);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(61, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblKbName
            // 
            this.lblKbName.AutoSize = true;
            this.lblKbName.Location = new System.Drawing.Point(20, 9);
            this.lblKbName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblKbName.Name = "lblKbName";
            this.lblKbName.Size = new System.Drawing.Size(51, 12);
            this.lblKbName.TabIndex = 4;
            this.lblKbName.Text = "KB Name";
            // 
            // lblKbQnAList
            // 
            this.lblKbQnAList.AutoSize = true;
            this.lblKbQnAList.Location = new System.Drawing.Point(24, 32);
            this.lblKbQnAList.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblKbQnAList.Name = "lblKbQnAList";
            this.lblKbQnAList.Size = new System.Drawing.Size(47, 12);
            this.lblKbQnAList.TabIndex = 4;
            this.lblKbQnAList.Text = "QnA List";
            // 
            // lblKbQnARefUrl
            // 
            this.lblKbQnARefUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKbQnARefUrl.AutoSize = true;
            this.lblKbQnARefUrl.Location = new System.Drawing.Point(6, 297);
            this.lblKbQnARefUrl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblKbQnARefUrl.Name = "lblKbQnARefUrl";
            this.lblKbQnARefUrl.Size = new System.Drawing.Size(67, 12);
            this.lblKbQnARefUrl.TabIndex = 4;
            this.lblKbQnARefUrl.Text = "QnA Doc Url";
            // 
            // frmKbCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 354);
            this.Controls.Add(this.lblKbQnARefUrl);
            this.Controls.Add(this.lblKbQnAList);
            this.Controls.Add(this.lblKbName);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtKbName);
            this.Controls.Add(this.txtQnADocUrl);
            this.Controls.Add(this.gvQnA);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "frmKbCreate";
            this.Text = "建立新KB";
            ((System.ComponentModel.ISupportInitialize)(this.gvQnA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvQnA;
        private System.Windows.Forms.TextBox txtQnADocUrl;
        private System.Windows.Forms.TextBox txtKbName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblKbName;
        private System.Windows.Forms.Label lblKbQnAList;
        private System.Windows.Forms.Label lblKbQnARefUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn question;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
    }
}