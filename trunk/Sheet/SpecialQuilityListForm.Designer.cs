namespace Sheet
{
    partial class SpecialQuilityListForm
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
            this.SQListView = new System.Windows.Forms.ListView();
            this.SQInfoTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SQListView
            // 
            this.SQListView.Location = new System.Drawing.Point(12, 40);
            this.SQListView.Name = "SQListView";
            this.SQListView.Size = new System.Drawing.Size(212, 162);
            this.SQListView.TabIndex = 1;
            this.SQListView.UseCompatibleStateImageBehavior = false;
            this.SQListView.View = System.Windows.Forms.View.List;
            this.SQListView.SelectedIndexChanged += new System.EventHandler(this.SQListView_SelectedIndexChanged);
            // 
            // SQInfoTextBox
            // 
            this.SQInfoTextBox.Location = new System.Drawing.Point(241, 40);
            this.SQInfoTextBox.Multiline = true;
            this.SQInfoTextBox.Name = "SQInfoTextBox";
            this.SQInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SQInfoTextBox.Size = new System.Drawing.Size(217, 162);
            this.SQInfoTextBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(371, 220);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 21);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "취소";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SpecialQuilityListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 266);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SQInfoTextBox);
            this.Controls.Add(this.SQListView);
            this.Name = "SpecialQuilityListForm";
            this.Text = "특수능력 정보";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView SQListView;
        private System.Windows.Forms.TextBox SQInfoTextBox;
        private System.Windows.Forms.Button cancelButton;
    }
}