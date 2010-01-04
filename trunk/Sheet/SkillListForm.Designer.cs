namespace Sheet
{
	partial class SkillListForm
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
			this.skillListView = new System.Windows.Forms.ListView();
			this.skillInfoTextBox = new System.Windows.Forms.TextBox();
			this.selectSkillButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.skillRankTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// skillListView
			// 
			this.skillListView.Location = new System.Drawing.Point(24, 40);
			this.skillListView.Name = "skillListView";
			this.skillListView.Size = new System.Drawing.Size(183, 178);
			this.skillListView.TabIndex = 0;
			this.skillListView.UseCompatibleStateImageBehavior = false;
			this.skillListView.View = System.Windows.Forms.View.List;
			this.skillListView.SelectedIndexChanged += new System.EventHandler(this.skillListView_SelectedIndexChanged);
			// 
			// skillInfoTextBox
			// 
			this.skillInfoTextBox.Location = new System.Drawing.Point(214, 40);
			this.skillInfoTextBox.Multiline = true;
			this.skillInfoTextBox.Name = "skillInfoTextBox";
			this.skillInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.skillInfoTextBox.Size = new System.Drawing.Size(202, 178);
			this.skillInfoTextBox.TabIndex = 1;
			// 
			// selectSkillButton
			// 
			this.selectSkillButton.Location = new System.Drawing.Point(256, 224);
			this.selectSkillButton.Name = "selectSkillButton";
			this.selectSkillButton.Size = new System.Drawing.Size(75, 23);
			this.selectSkillButton.TabIndex = 2;
			this.selectSkillButton.Text = "선택";
			this.selectSkillButton.UseVisualStyleBackColor = true;
			this.selectSkillButton.Click += new System.EventHandler(this.selectSkillButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(341, 224);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "취소";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 229);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "추가할 랭크 :";
			// 
			// skillRankTextBox
			// 
			this.skillRankTextBox.Location = new System.Drawing.Point(115, 226);
			this.skillRankTextBox.Name = "skillRankTextBox";
			this.skillRankTextBox.Size = new System.Drawing.Size(60, 20);
			this.skillRankTextBox.TabIndex = 5;
			this.skillRankTextBox.Text = "1";
			// 
			// SkillListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 254);
			this.Controls.Add(this.skillRankTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.selectSkillButton);
			this.Controls.Add(this.skillInfoTextBox);
			this.Controls.Add(this.skillListView);
			this.Name = "SkillListForm";
			this.Text = "스킬 목록";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView skillListView;
		private System.Windows.Forms.TextBox skillInfoTextBox;
		private System.Windows.Forms.Button selectSkillButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox skillRankTextBox;
	}
}