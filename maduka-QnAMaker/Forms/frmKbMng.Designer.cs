namespace maduka_QnAMaker.Forms
{
    partial class frmKbMng
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
            this.lblKBId = new System.Windows.Forms.Label();
            this.lblQnAList = new System.Windows.Forms.Label();
            this.cbxKbId = new System.Windows.Forms.ComboBox();
            this.gvQnA = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnAddQnA = new System.Windows.Forms.Button();
            this.btnDeleteQnA = new System.Windows.Forms.Button();
            this.btnUndelete = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvQnA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKBId
            // 
            this.lblKBId.AutoSize = true;
            this.lblKBId.Location = new System.Drawing.Point(6, 8);
            this.lblKBId.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblKBId.Name = "lblKBId";
            this.lblKBId.Size = new System.Drawing.Size(96, 12);
            this.lblKBId.TabIndex = 1;
            this.lblKBId.Text = "Knowledge Base Id";
            // 
            // lblQnAList
            // 
            this.lblQnAList.AutoSize = true;
            this.lblQnAList.Location = new System.Drawing.Point(55, 168);
            this.lblQnAList.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblQnAList.Name = "lblQnAList";
            this.lblQnAList.Size = new System.Drawing.Size(47, 12);
            this.lblQnAList.TabIndex = 1;
            this.lblQnAList.Text = "QnA List";
            // 
            // cbxKbId
            // 
            this.cbxKbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxKbId.DisplayMember = "name";
            this.cbxKbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKbId.FormattingEnabled = true;
            this.cbxKbId.Location = new System.Drawing.Point(104, 6);
            this.cbxKbId.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cbxKbId.Name = "cbxKbId";
            this.cbxKbId.Size = new System.Drawing.Size(554, 20);
            this.cbxKbId.TabIndex = 5;
            this.cbxKbId.SelectedIndexChanged += new System.EventHandler(this.cbxKbId_SelectedIndexChanged);
            // 
            // gvQnA
            // 
            this.gvQnA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvQnA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQnA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Source,
            this.question,
            this.answer});
            this.gvQnA.Location = new System.Drawing.Point(104, 168);
            this.gvQnA.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gvQnA.Name = "gvQnA";
            this.gvQnA.RowTemplate.Height = 38;
            this.gvQnA.Size = new System.Drawing.Size(554, 222);
            this.gvQnA.TabIndex = 6;
            this.gvQnA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvQnA_CellClick);
            this.gvQnA.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvQnA_DataBindingComplete);
            // 
            // Source
            // 
            this.Source.DataPropertyName = "source";
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            // 
            // question
            // 
            this.question.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.question.DataPropertyName = "question";
            this.question.FillWeight = 50F;
            this.question.HeaderText = "question";
            this.question.Name = "question";
            // 
            // answer
            // 
            this.answer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.answer.DataPropertyName = "answer";
            this.answer.FillWeight = 50F;
            this.answer.HeaderText = "answer";
            this.answer.Name = "answer";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(490, 394);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Location = new System.Drawing.Point(430, 394);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(58, 23);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrain.Location = new System.Drawing.Point(550, 394);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(53, 23);
            this.btnTrain.TabIndex = 9;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnAddQnA
            // 
            this.btnAddQnA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQnA.Location = new System.Drawing.Point(573, 141);
            this.btnAddQnA.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddQnA.Name = "btnAddQnA";
            this.btnAddQnA.Size = new System.Drawing.Size(85, 23);
            this.btnAddQnA.TabIndex = 10;
            this.btnAddQnA.Text = "Add or Save";
            this.btnAddQnA.UseVisualStyleBackColor = true;
            this.btnAddQnA.Click += new System.EventHandler(this.btnAddQnA_Click);
            // 
            // btnDeleteQnA
            // 
            this.btnDeleteQnA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteQnA.Location = new System.Drawing.Point(104, 394);
            this.btnDeleteQnA.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDeleteQnA.Name = "btnDeleteQnA";
            this.btnDeleteQnA.Size = new System.Drawing.Size(58, 23);
            this.btnDeleteQnA.TabIndex = 11;
            this.btnDeleteQnA.Text = "Delete Row";
            this.btnDeleteQnA.UseVisualStyleBackColor = true;
            this.btnDeleteQnA.Click += new System.EventHandler(this.btnDeleteQnA_Click);
            // 
            // btnUndelete
            // 
            this.btnUndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUndelete.Location = new System.Drawing.Point(164, 394);
            this.btnUndelete.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnUndelete.Name = "btnUndelete";
            this.btnUndelete.Size = new System.Drawing.Size(79, 23);
            this.btnUndelete.TabIndex = 12;
            this.btnUndelete.Text = "Undelete Row";
            this.btnUndelete.UseVisualStyleBackColor = true;
            this.btnUndelete.Click += new System.EventHandler(this.btnUndelete_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(56, 30);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(46, 12);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(104, 30);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(194, 134);
            this.txtQuestion.TabIndex = 13;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(300, 30);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(40, 12);
            this.lblAnswer.TabIndex = 14;
            this.lblAnswer.Text = "Answer";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswer.Location = new System.Drawing.Point(342, 30);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(229, 134);
            this.txtAnswer.TabIndex = 13;
            // 
            // btnPublish
            // 
            this.btnPublish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublish.Location = new System.Drawing.Point(605, 394);
            this.btnPublish.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(53, 23);
            this.btnPublish.TabIndex = 9;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // frmKbMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 423);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.btnUndelete);
            this.Controls.Add(this.btnDeleteQnA);
            this.Controls.Add(this.btnAddQnA);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gvQnA);
            this.Controls.Add(this.cbxKbId);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQnAList);
            this.Controls.Add(this.lblKBId);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "frmKbMng";
            this.Text = "KB QnA管理";
            this.Load += new System.EventHandler(this.frmKbMng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvQnA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKBId;
        private System.Windows.Forms.Label lblQnAList;
        private System.Windows.Forms.ComboBox cbxKbId;
        private System.Windows.Forms.DataGridView gvQnA;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnAddQnA;
        private System.Windows.Forms.Button btnDeleteQnA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn question;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
        private System.Windows.Forms.Button btnUndelete;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnPublish;
    }
}