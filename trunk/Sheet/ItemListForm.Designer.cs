namespace Sheet
{
	partial class ItemListForm
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
			this.itemListView = new System.Windows.Forms.ListView();
			this.itemInfoTextBox = new System.Windows.Forms.TextBox();
			this.selectItemButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// itemListView
			// 
			this.itemListView.Location = new System.Drawing.Point(25, 44);
			this.itemListView.Name = "itemListView";
			this.itemListView.Size = new System.Drawing.Size(207, 168);
			this.itemListView.TabIndex = 0;
			this.itemListView.UseCompatibleStateImageBehavior = false;
			this.itemListView.View = System.Windows.Forms.View.List;
			this.itemListView.SelectedIndexChanged += new System.EventHandler(this.itemListView_SelectedIndexChanged);
			// 
			// itemInfoTextBox
			// 
			this.itemInfoTextBox.Location = new System.Drawing.Point(249, 44);
			this.itemInfoTextBox.Multiline = true;
			this.itemInfoTextBox.Name = "itemInfoTextBox";
			this.itemInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.itemInfoTextBox.Size = new System.Drawing.Size(187, 168);
			this.itemInfoTextBox.TabIndex = 1;
			// 
			// selectItemButton
			// 
			this.selectItemButton.Location = new System.Drawing.Point(280, 231);
			this.selectItemButton.Name = "selectItemButton";
			this.selectItemButton.Size = new System.Drawing.Size(75, 23);
			this.selectItemButton.TabIndex = 2;
			this.selectItemButton.Text = "선택";
			this.selectItemButton.UseVisualStyleBackColor = true;
			this.selectItemButton.Click += new System.EventHandler(this.selectItemButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(361, 231);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "취소";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// ItemListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 266);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.selectItemButton);
			this.Controls.Add(this.itemInfoTextBox);
			this.Controls.Add(this.itemListView);
			this.Name = "ItemListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "아이템 목록";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView itemListView;
		private System.Windows.Forms.TextBox itemInfoTextBox;
		private System.Windows.Forms.Button selectItemButton;
		private System.Windows.Forms.Button cancelButton;
	}
}