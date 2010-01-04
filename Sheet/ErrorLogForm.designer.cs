namespace Sheet
{
    partial class ErrorLogForm
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
			this.errorLogDataGridView = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.errorLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.errorLogDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// errorLogDataGridView
			// 
			this.errorLogDataGridView.AllowUserToAddRows = false;
			this.errorLogDataGridView.AllowUserToDeleteRows = false;
			this.errorLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.errorLogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
			this.errorLogDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.errorLogDataGridView.Location = new System.Drawing.Point(0, 48);
			this.errorLogDataGridView.Name = "errorLogDataGridView";
			this.errorLogDataGridView.ReadOnly = true;
			this.errorLogDataGridView.RowHeadersVisible = false;
			this.errorLogDataGridView.RowTemplate.Height = 23;
			this.errorLogDataGridView.Size = new System.Drawing.Size(459, 516);
			this.errorLogDataGridView.TabIndex = 1;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "작업";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "오류 내용";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "세부메세지";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.Location = new System.Drawing.Point(10, 16);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(235, 13);
			this.errorLabel.TabIndex = 2;
			this.errorLabel.Text = "작업 도중 총 0개의 오류가 발견되었습니다.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.errorLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(459, 48);
			this.panel1.TabIndex = 3;
			// 
			// ErrorLogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 564);
			this.Controls.Add(this.errorLogDataGridView);
			this.Controls.Add(this.panel1);
			this.Name = "ErrorLogForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "오류 목록";
			((System.ComponentModel.ISupportInitialize)(this.errorLogDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView errorLogDataGridView;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel1;

    }
}