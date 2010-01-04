namespace Sheet
{
	partial class FeatListForm
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
			this.featListView = new System.Windows.Forms.ListView();
			this.featInfoTextBox = new System.Windows.Forms.TextBox();
			this.selectFeatButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// featListView
			// 
			this.featListView.Location = new System.Drawing.Point(23, 30);
			this.featListView.Name = "featListView";
			this.featListView.Size = new System.Drawing.Size(182, 175);
			this.featListView.TabIndex = 0;
			this.featListView.UseCompatibleStateImageBehavior = false;
			this.featListView.View = System.Windows.Forms.View.List;
			this.featListView.SelectedIndexChanged += new System.EventHandler(this.featListView_SelectedIndexChanged);
			// 
			// featInfoTextBox
			// 
			this.featInfoTextBox.Location = new System.Drawing.Point(220, 30);
			this.featInfoTextBox.Multiline = true;
			this.featInfoTextBox.Name = "featInfoTextBox";
			this.featInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.featInfoTextBox.Size = new System.Drawing.Size(187, 175);
			this.featInfoTextBox.TabIndex = 1;
			// 
			// selectFeatButton
			// 
			this.selectFeatButton.Location = new System.Drawing.Point(251, 227);
			this.selectFeatButton.Name = "selectFeatButton";
			this.selectFeatButton.Size = new System.Drawing.Size(75, 23);
			this.selectFeatButton.TabIndex = 2;
			this.selectFeatButton.Text = "선택";
			this.selectFeatButton.UseVisualStyleBackColor = true;
			this.selectFeatButton.Click += new System.EventHandler(this.selectFeatButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(332, 227);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "취소";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// FeatListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 266);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.selectFeatButton);
			this.Controls.Add(this.featInfoTextBox);
			this.Controls.Add(this.featListView);
			this.Name = "FeatListForm";
			this.Text = "피트 목록";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView featListView;
		private System.Windows.Forms.TextBox featInfoTextBox;
		private System.Windows.Forms.Button selectFeatButton;
		private System.Windows.Forms.Button cancelButton;
	}
}