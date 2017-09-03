namespace maduka_QnAMaker.Forms
{
    partial class frmQnA
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.gvAnswerList = new System.Windows.Forms.DataGridView();
            this.question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOtherAnswer = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblKbId = new System.Windows.Forms.Label();
            this.cbxKbId = new System.Windows.Forms.ComboBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.lblTopCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnswerList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(109, 53);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(90, 24);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(119, 193);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(80, 24);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "Answer";
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Location = new System.Drawing.Point(205, 50);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(1291, 137);
            this.txtQuery.TabIndex = 2;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswer.Location = new System.Drawing.Point(205, 193);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(1291, 175);
            this.txtAnswer.TabIndex = 3;
            // 
            // gvAnswerList
            // 
            this.gvAnswerList.AllowUserToAddRows = false;
            this.gvAnswerList.AllowUserToDeleteRows = false;
            this.gvAnswerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvAnswerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAnswerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.question,
            this.answer,
            this.score});
            this.gvAnswerList.Location = new System.Drawing.Point(205, 416);
            this.gvAnswerList.Name = "gvAnswerList";
            this.gvAnswerList.ReadOnly = true;
            this.gvAnswerList.RowTemplate.Height = 38;
            this.gvAnswerList.Size = new System.Drawing.Size(1291, 374);
            this.gvAnswerList.TabIndex = 4;
            // 
            // question
            // 
            this.question.DataPropertyName = "question";
            this.question.HeaderText = "question";
            this.question.Name = "question";
            this.question.ReadOnly = true;
            // 
            // answer
            // 
            this.answer.DataPropertyName = "answer";
            this.answer.HeaderText = "answer";
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            // 
            // score
            // 
            this.score.DataPropertyName = "score";
            this.score.HeaderText = "score";
            this.score.Name = "score";
            this.score.ReadOnly = true;
            // 
            // lblOtherAnswer
            // 
            this.lblOtherAnswer.AutoSize = true;
            this.lblOtherAnswer.Location = new System.Drawing.Point(78, 441);
            this.lblOtherAnswer.Name = "lblOtherAnswer";
            this.lblOtherAnswer.Size = new System.Drawing.Size(121, 24);
            this.lblOtherAnswer.TabIndex = 5;
            this.lblOtherAnswer.Text = "Answer List";
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(1421, 796);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 33);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblKbId
            // 
            this.lblKbId.AutoSize = true;
            this.lblKbId.Location = new System.Drawing.Point(12, 15);
            this.lblKbId.Name = "lblKbId";
            this.lblKbId.Size = new System.Drawing.Size(187, 24);
            this.lblKbId.TabIndex = 7;
            this.lblKbId.Text = "Knowledge Base Id";
            // 
            // cbxKbId
            // 
            this.cbxKbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxKbId.DisplayMember = "name";
            this.cbxKbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKbId.FormattingEnabled = true;
            this.cbxKbId.Location = new System.Drawing.Point(205, 12);
            this.cbxKbId.Name = "cbxKbId";
            this.cbxKbId.Size = new System.Drawing.Size(1291, 32);
            this.cbxKbId.TabIndex = 8;
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(205, 374);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(100, 36);
            this.txtTop.TabIndex = 9;
            this.txtTop.Text = "3";
            // 
            // lblTopCount
            // 
            this.lblTopCount.AutoSize = true;
            this.lblTopCount.Location = new System.Drawing.Point(161, 374);
            this.lblTopCount.Name = "lblTopCount";
            this.lblTopCount.Size = new System.Drawing.Size(38, 24);
            this.lblTopCount.TabIndex = 10;
            this.lblTopCount.Text = "top";
            // 
            // frmQnA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 955);
            this.Controls.Add(this.lblTopCount);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.cbxKbId);
            this.Controls.Add(this.lblKbId);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblOtherAnswer);
            this.Controls.Add(this.gvAnswerList);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmQnA";
            this.Text = "開始問答";
            this.Load += new System.EventHandler(this.frmQnA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAnswerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.DataGridView gvAnswerList;
        private System.Windows.Forms.Label lblOtherAnswer;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblKbId;
        private System.Windows.Forms.ComboBox cbxKbId;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Label lblTopCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn question;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
    }
}