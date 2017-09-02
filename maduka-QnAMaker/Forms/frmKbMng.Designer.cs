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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddQnA = new System.Windows.Forms.Button();
            this.btnDeleteQnA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvQnA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKBId
            // 
            this.lblKBId.AutoSize = true;
            this.lblKBId.Location = new System.Drawing.Point(12, 15);
            this.lblKBId.Name = "lblKBId";
            this.lblKBId.Size = new System.Drawing.Size(187, 24);
            this.lblKBId.TabIndex = 1;
            this.lblKBId.Text = "Knowledge Base Id";
            // 
            // lblQnAList
            // 
            this.lblQnAList.AutoSize = true;
            this.lblQnAList.Location = new System.Drawing.Point(105, 54);
            this.lblQnAList.Name = "lblQnAList";
            this.lblQnAList.Size = new System.Drawing.Size(94, 24);
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
            this.cbxKbId.Location = new System.Drawing.Point(205, 12);
            this.cbxKbId.Name = "cbxKbId";
            this.cbxKbId.Size = new System.Drawing.Size(882, 32);
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
            this.question,
            this.answer,
            this.Source});
            this.gvQnA.Location = new System.Drawing.Point(205, 50);
            this.gvQnA.Name = "gvQnA";
            this.gvQnA.ReadOnly = true;
            this.gvQnA.RowTemplate.Height = 38;
            this.gvQnA.Size = new System.Drawing.Size(882, 534);
            this.gvQnA.TabIndex = 6;
            this.gvQnA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvQnA_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(841, 590);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 36);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Location = new System.Drawing.Point(710, 590);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(125, 36);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrain.Location = new System.Drawing.Point(972, 590);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(115, 36);
            this.btnTrain.TabIndex = 9;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
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
            // Source
            // 
            this.Source.DataPropertyName = "source";
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            // 
            // btnAddQnA
            // 
            this.btnAddQnA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQnA.Location = new System.Drawing.Point(205, 590);
            this.btnAddQnA.Name = "btnAddQnA";
            this.btnAddQnA.Size = new System.Drawing.Size(125, 36);
            this.btnAddQnA.TabIndex = 10;
            this.btnAddQnA.Text = "Add Row";
            this.btnAddQnA.UseVisualStyleBackColor = true;
            this.btnAddQnA.Click += new System.EventHandler(this.btnAddQnA_Click);
            // 
            // btnDeleteQnA
            // 
            this.btnDeleteQnA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteQnA.Location = new System.Drawing.Point(336, 590);
            this.btnDeleteQnA.Name = "btnDeleteQnA";
            this.btnDeleteQnA.Size = new System.Drawing.Size(125, 36);
            this.btnDeleteQnA.TabIndex = 11;
            this.btnDeleteQnA.Text = "Delete Row";
            this.btnDeleteQnA.UseVisualStyleBackColor = true;
            this.btnDeleteQnA.Click += new System.EventHandler(this.btnDeleteQnA_Click);
            // 
            // frmKbMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 638);
            this.Controls.Add(this.btnDeleteQnA);
            this.Controls.Add(this.btnAddQnA);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gvQnA);
            this.Controls.Add(this.cbxKbId);
            this.Controls.Add(this.lblQnAList);
            this.Controls.Add(this.lblKBId);
            this.Name = "frmKbMng";
            this.Text = "KB資料管理";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn question;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.Button btnAddQnA;
        private System.Windows.Forms.Button btnDeleteQnA;
    }
}