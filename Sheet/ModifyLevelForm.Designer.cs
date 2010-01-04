﻿namespace Sheet
{
    partial class ModifyLevelForm
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
			this.levelDataGridView = new System.Windows.Forms.DataGridView();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classComboBox = new System.Windows.Forms.ComboBox();
			this.HPTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.addLevelButton = new System.Windows.Forms.Button();
			this.deleteLevelButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.levelDataGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// levelDataGridView
			// 
			this.levelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.levelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
			this.levelDataGridView.Location = new System.Drawing.Point(18, 27);
			this.levelDataGridView.MultiSelect = false;
			this.levelDataGridView.Name = "levelDataGridView";
			this.levelDataGridView.ReadOnly = true;
			this.levelDataGridView.RowHeadersVisible = false;
			this.levelDataGridView.RowTemplate.Height = 23;
			this.levelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.levelDataGridView.Size = new System.Drawing.Size(326, 275);
			this.levelDataGridView.TabIndex = 0;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "LV";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 25;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "클래스";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "HP";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 50;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "능력";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// classComboBox
			// 
			this.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.classComboBox.FormattingEnabled = true;
			this.classComboBox.Location = new System.Drawing.Point(42, 15);
			this.classComboBox.Name = "classComboBox";
			this.classComboBox.Size = new System.Drawing.Size(131, 21);
			this.classComboBox.TabIndex = 1;
			// 
			// HPTextBox
			// 
			this.HPTextBox.Location = new System.Drawing.Point(203, 15);
			this.HPTextBox.Name = "HPTextBox";
			this.HPTextBox.Size = new System.Drawing.Size(34, 20);
			this.HPTextBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Class";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(180, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "HP";
			// 
			// addLevelButton
			// 
			this.addLevelButton.Location = new System.Drawing.Point(172, 60);
			this.addLevelButton.Name = "addLevelButton";
			this.addLevelButton.Size = new System.Drawing.Size(64, 25);
			this.addLevelButton.TabIndex = 5;
			this.addLevelButton.Text = "추가";
			this.addLevelButton.UseVisualStyleBackColor = true;
			this.addLevelButton.Click += new System.EventHandler(this.addLevelButton_Click);
			// 
			// deleteLevelButton
			// 
			this.deleteLevelButton.Location = new System.Drawing.Point(279, 320);
			this.deleteLevelButton.Name = "deleteLevelButton";
			this.deleteLevelButton.Size = new System.Drawing.Size(64, 25);
			this.deleteLevelButton.TabIndex = 6;
			this.deleteLevelButton.Text = "삭제";
			this.deleteLevelButton.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.addLevelButton);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.HPTextBox);
			this.groupBox1.Controls.Add(this.classComboBox);
			this.groupBox1.Location = new System.Drawing.Point(18, 309);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(252, 94);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "레벨 추가";
			// 
			// ModifyLevelForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 411);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.deleteLevelButton);
			this.Controls.Add(this.levelDataGridView);
			this.Name = "ModifyLevelForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "레벨정보 수정";
			((System.ComponentModel.ISupportInitialize)(this.levelDataGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView levelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.TextBox HPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addLevelButton;
        private System.Windows.Forms.Button deleteLevelButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}