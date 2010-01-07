namespace Sheet
{
    partial class CharacterSheetForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button sellButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSheetForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LevelTextBox = new System.Windows.Forms.TextBox();
            this.BABTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.StrTextBox = new System.Windows.Forms.TextBox();
            this.DexTextBox = new System.Windows.Forms.TextBox();
            this.ConTextBox = new System.Windows.Forms.TextBox();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.WisTextBox = new System.Windows.Forms.TextBox();
            this.ChaTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GrappleTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ACTextBox = new System.Windows.Forms.TextBox();
            this.CurrentHPTextBox = new System.Windows.Forms.TextBox();
            this.MaxHPTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AtkTextBox = new System.Windows.Forms.TextBox();
            this.FullAtkTextBox = new System.Windows.Forms.TextBox();
            this.sheetTabControl = new System.Windows.Forms.TabControl();
            this.SheetTabPage = new System.Windows.Forms.TabPage();
            this.initiativeTextBox = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.modifyFeatButton = new System.Windows.Forms.Button();
            this.featListView = new System.Windows.Forms.ListView();
            this.featContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewFeatInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SQListView = new System.Windows.Forms.ListView();
            this.skillListView = new System.Windows.Forms.ListView();
            this.skillContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewSkillInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseIntTextBox = new System.Windows.Forms.TextBox();
            this.baseChaTextBox = new System.Windows.Forms.TextBox();
            this.baseWisTextBox = new System.Windows.Forms.TextBox();
            this.baseConTextBox = new System.Windows.Forms.TextBox();
            this.baseDexTextBox = new System.Windows.Forms.TextBox();
            this.baseStrTextBox = new System.Windows.Forms.TextBox();
            this.modifySkillButton = new System.Windows.Forms.Button();
            this.modifyLevelButton = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.willTextBox = new System.Windows.Forms.TextBox();
            this.refTextBox = new System.Windows.Forms.TextBox();
            this.fortTextBox = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.alignmentTextBox = new System.Windows.Forms.TextBox();
            this.raceTextBox = new System.Windows.Forms.TextBox();
            this.teamTextBox = new System.Windows.Forms.TextBox();
            this.playerTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.itemTabPage = new System.Windows.Forms.TabPage();
            this.addItemButton = new System.Windows.Forms.Button();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.sellPriceTextBox = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.goldTextBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.removeEquipmentButton = new System.Windows.Forms.Button();
            this.equipButton = new System.Windows.Forms.Button();
            this.inventoryListView = new System.Windows.Forms.ListView();
            this.loadLabel = new System.Windows.Forms.Label();
            this.equipListView = new System.Windows.Forms.ListView();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.SpellTabPage = new System.Windows.Forms.TabPage();
            this.descriptionTabPage = new System.Windows.Forms.TabPage();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.effectTabPage = new System.Windows.Forms.TabPage();
            this.effectDataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.새로만들기ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.열기ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.저장ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.인쇄ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.잘라내기ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.복사ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.붙여넣기ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.도움말ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openSheetFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveSheetFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SQContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewSQInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeSQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sellButton = new System.Windows.Forms.Button();
            this.sheetTabControl.SuspendLayout();
            this.SheetTabPage.SuspendLayout();
            this.featContextMenuStrip.SuspendLayout();
            this.skillContextMenuStrip.SuspendLayout();
            this.itemTabPage.SuspendLayout();
            this.descriptionTabPage.SuspendLayout();
            this.effectTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SQContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sellButton
            // 
            sellButton.Location = new System.Drawing.Point(152, 513);
            sellButton.Name = "sellButton";
            sellButton.Size = new System.Drawing.Size(75, 23);
            sellButton.TabIndex = 14;
            sellButton.Text = "판매";
            sellButton.UseVisualStyleBackColor = true;
            sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAB/Grapple";
            // 
            // LevelTextBox
            // 
            this.LevelTextBox.Location = new System.Drawing.Point(71, 115);
            this.LevelTextBox.Name = "LevelTextBox";
            this.LevelTextBox.ReadOnly = true;
            this.LevelTextBox.Size = new System.Drawing.Size(344, 21);
            this.LevelTextBox.TabIndex = 4;
            // 
            // BABTextBox
            // 
            this.BABTextBox.Location = new System.Drawing.Point(117, 300);
            this.BABTextBox.Name = "BABTextBox";
            this.BABTextBox.ReadOnly = true;
            this.BABTextBox.Size = new System.Drawing.Size(49, 21);
            this.BABTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Str";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Con";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "Int";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "Wiz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cha";
            // 
            // StrTextBox
            // 
            this.StrTextBox.Location = new System.Drawing.Point(71, 246);
            this.StrTextBox.Name = "StrTextBox";
            this.StrTextBox.ReadOnly = true;
            this.StrTextBox.Size = new System.Drawing.Size(31, 21);
            this.StrTextBox.TabIndex = 13;
            // 
            // DexTextBox
            // 
            this.DexTextBox.Location = new System.Drawing.Point(212, 246);
            this.DexTextBox.Name = "DexTextBox";
            this.DexTextBox.ReadOnly = true;
            this.DexTextBox.Size = new System.Drawing.Size(31, 21);
            this.DexTextBox.TabIndex = 14;
            // 
            // ConTextBox
            // 
            this.ConTextBox.Location = new System.Drawing.Point(346, 246);
            this.ConTextBox.Name = "ConTextBox";
            this.ConTextBox.ReadOnly = true;
            this.ConTextBox.Size = new System.Drawing.Size(31, 21);
            this.ConTextBox.TabIndex = 15;
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(71, 273);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.ReadOnly = true;
            this.IntTextBox.Size = new System.Drawing.Size(31, 21);
            this.IntTextBox.TabIndex = 16;
            // 
            // WisTextBox
            // 
            this.WisTextBox.Location = new System.Drawing.Point(212, 273);
            this.WisTextBox.Name = "WisTextBox";
            this.WisTextBox.ReadOnly = true;
            this.WisTextBox.Size = new System.Drawing.Size(31, 21);
            this.WisTextBox.TabIndex = 17;
            // 
            // ChaTextBox
            // 
            this.ChaTextBox.Location = new System.Drawing.Point(346, 273);
            this.ChaTextBox.Name = "ChaTextBox";
            this.ChaTextBox.ReadOnly = true;
            this.ChaTextBox.Size = new System.Drawing.Size(31, 21);
            this.ChaTextBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "Atk";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "/";
            // 
            // GrappleTextBox
            // 
            this.GrappleTextBox.Location = new System.Drawing.Point(195, 300);
            this.GrappleTextBox.Name = "GrappleTextBox";
            this.GrappleTextBox.ReadOnly = true;
            this.GrappleTextBox.Size = new System.Drawing.Size(49, 21);
            this.GrappleTextBox.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "AC";
            // 
            // ACTextBox
            // 
            this.ACTextBox.Location = new System.Drawing.Point(71, 169);
            this.ACTextBox.Name = "ACTextBox";
            this.ACTextBox.ReadOnly = true;
            this.ACTextBox.Size = new System.Drawing.Size(51, 21);
            this.ACTextBox.TabIndex = 23;
            // 
            // CurrentHPTextBox
            // 
            this.CurrentHPTextBox.Location = new System.Drawing.Point(71, 142);
            this.CurrentHPTextBox.Name = "CurrentHPTextBox";
            this.CurrentHPTextBox.Size = new System.Drawing.Size(51, 21);
            this.CurrentHPTextBox.TabIndex = 24;
            this.CurrentHPTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.CurrentHPTextBox.Leave += new System.EventHandler(this.Leave);
            this.CurrentHPTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // MaxHPTextBox
            // 
            this.MaxHPTextBox.Location = new System.Drawing.Point(147, 142);
            this.MaxHPTextBox.Name = "MaxHPTextBox";
            this.MaxHPTextBox.ReadOnly = true;
            this.MaxHPTextBox.Size = new System.Drawing.Size(51, 21);
            this.MaxHPTextBox.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(129, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 26;
            this.label13.Text = "/";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 356);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 12);
            this.label14.TabIndex = 27;
            this.label14.Text = "Full Attack";
            // 
            // AtkTextBox
            // 
            this.AtkTextBox.Location = new System.Drawing.Point(117, 326);
            this.AtkTextBox.Multiline = true;
            this.AtkTextBox.Name = "AtkTextBox";
            this.AtkTextBox.ReadOnly = true;
            this.AtkTextBox.Size = new System.Drawing.Size(282, 25);
            this.AtkTextBox.TabIndex = 28;
            // 
            // FullAtkTextBox
            // 
            this.FullAtkTextBox.Location = new System.Drawing.Point(117, 357);
            this.FullAtkTextBox.Multiline = true;
            this.FullAtkTextBox.Name = "FullAtkTextBox";
            this.FullAtkTextBox.ReadOnly = true;
            this.FullAtkTextBox.Size = new System.Drawing.Size(282, 24);
            this.FullAtkTextBox.TabIndex = 29;
            // 
            // sheetTabControl
            // 
            this.sheetTabControl.Controls.Add(this.SheetTabPage);
            this.sheetTabControl.Controls.Add(this.itemTabPage);
            this.sheetTabControl.Controls.Add(this.SpellTabPage);
            this.sheetTabControl.Controls.Add(this.descriptionTabPage);
            this.sheetTabControl.Controls.Add(this.effectTabPage);
            this.sheetTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sheetTabControl.Location = new System.Drawing.Point(0, 25);
            this.sheetTabControl.Name = "sheetTabControl";
            this.sheetTabControl.SelectedIndex = 0;
            this.sheetTabControl.Size = new System.Drawing.Size(436, 623);
            this.sheetTabControl.TabIndex = 30;
            // 
            // SheetTabPage
            // 
            this.SheetTabPage.Controls.Add(this.initiativeTextBox);
            this.SheetTabPage.Controls.Add(this.label39);
            this.SheetTabPage.Controls.Add(this.button2);
            this.SheetTabPage.Controls.Add(this.button1);
            this.SheetTabPage.Controls.Add(this.modifyFeatButton);
            this.SheetTabPage.Controls.Add(this.featListView);
            this.SheetTabPage.Controls.Add(this.SQListView);
            this.SheetTabPage.Controls.Add(this.skillListView);
            this.SheetTabPage.Controls.Add(this.baseIntTextBox);
            this.SheetTabPage.Controls.Add(this.baseChaTextBox);
            this.SheetTabPage.Controls.Add(this.baseWisTextBox);
            this.SheetTabPage.Controls.Add(this.baseConTextBox);
            this.SheetTabPage.Controls.Add(this.baseDexTextBox);
            this.SheetTabPage.Controls.Add(this.baseStrTextBox);
            this.SheetTabPage.Controls.Add(this.modifySkillButton);
            this.SheetTabPage.Controls.Add(this.modifyLevelButton);
            this.SheetTabPage.Controls.Add(this.label34);
            this.SheetTabPage.Controls.Add(this.label33);
            this.SheetTabPage.Controls.Add(this.label32);
            this.SheetTabPage.Controls.Add(this.willTextBox);
            this.SheetTabPage.Controls.Add(this.refTextBox);
            this.SheetTabPage.Controls.Add(this.fortTextBox);
            this.SheetTabPage.Controls.Add(this.label31);
            this.SheetTabPage.Controls.Add(this.label30);
            this.SheetTabPage.Controls.Add(this.label29);
            this.SheetTabPage.Controls.Add(this.speedTextBox);
            this.SheetTabPage.Controls.Add(this.sizeTextBox);
            this.SheetTabPage.Controls.Add(this.label26);
            this.SheetTabPage.Controls.Add(this.label25);
            this.SheetTabPage.Controls.Add(this.alignmentTextBox);
            this.SheetTabPage.Controls.Add(this.raceTextBox);
            this.SheetTabPage.Controls.Add(this.teamTextBox);
            this.SheetTabPage.Controls.Add(this.playerTextBox);
            this.SheetTabPage.Controls.Add(this.nameTextBox);
            this.SheetTabPage.Controls.Add(this.label19);
            this.SheetTabPage.Controls.Add(this.label18);
            this.SheetTabPage.Controls.Add(this.label17);
            this.SheetTabPage.Controls.Add(this.label16);
            this.SheetTabPage.Controls.Add(this.label15);
            this.SheetTabPage.Controls.Add(this.label1);
            this.SheetTabPage.Controls.Add(this.FullAtkTextBox);
            this.SheetTabPage.Controls.Add(this.LevelTextBox);
            this.SheetTabPage.Controls.Add(this.AtkTextBox);
            this.SheetTabPage.Controls.Add(this.label14);
            this.SheetTabPage.Controls.Add(this.label3);
            this.SheetTabPage.Controls.Add(this.GrappleTextBox);
            this.SheetTabPage.Controls.Add(this.label12);
            this.SheetTabPage.Controls.Add(this.label11);
            this.SheetTabPage.Controls.Add(this.label13);
            this.SheetTabPage.Controls.Add(this.label10);
            this.SheetTabPage.Controls.Add(this.ACTextBox);
            this.SheetTabPage.Controls.Add(this.BABTextBox);
            this.SheetTabPage.Controls.Add(this.MaxHPTextBox);
            this.SheetTabPage.Controls.Add(this.label2);
            this.SheetTabPage.Controls.Add(this.ChaTextBox);
            this.SheetTabPage.Controls.Add(this.CurrentHPTextBox);
            this.SheetTabPage.Controls.Add(this.WisTextBox);
            this.SheetTabPage.Controls.Add(this.StrTextBox);
            this.SheetTabPage.Controls.Add(this.IntTextBox);
            this.SheetTabPage.Controls.Add(this.label4);
            this.SheetTabPage.Controls.Add(this.ConTextBox);
            this.SheetTabPage.Controls.Add(this.label5);
            this.SheetTabPage.Controls.Add(this.DexTextBox);
            this.SheetTabPage.Controls.Add(this.label6);
            this.SheetTabPage.Controls.Add(this.label7);
            this.SheetTabPage.Controls.Add(this.label9);
            this.SheetTabPage.Controls.Add(this.label8);
            this.SheetTabPage.Location = new System.Drawing.Point(4, 21);
            this.SheetTabPage.Name = "SheetTabPage";
            this.SheetTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SheetTabPage.Size = new System.Drawing.Size(428, 598);
            this.SheetTabPage.TabIndex = 0;
            this.SheetTabPage.Text = "캐릭터 시트";
            this.SheetTabPage.UseVisualStyleBackColor = true;
            // 
            // initiativeTextBox
            // 
            this.initiativeTextBox.Location = new System.Drawing.Point(361, 87);
            this.initiativeTextBox.Name = "initiativeTextBox";
            this.initiativeTextBox.ReadOnly = true;
            this.initiativeTextBox.Size = new System.Drawing.Size(54, 21);
            this.initiativeTextBox.TabIndex = 77;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(333, 90);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(21, 12);
            this.label39.TabIndex = 76;
            this.label39.Text = "Init";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 21);
            this.button2.TabIndex = 75;
            this.button2.Text = "스킬 삭제";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 21);
            this.button1.TabIndex = 74;
            this.button1.Text = "피트 삭제";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // modifyFeatButton
            // 
            this.modifyFeatButton.Location = new System.Drawing.Point(202, 443);
            this.modifyFeatButton.Name = "modifyFeatButton";
            this.modifyFeatButton.Size = new System.Drawing.Size(96, 21);
            this.modifyFeatButton.TabIndex = 73;
            this.modifyFeatButton.Text = "피트 추가";
            this.modifyFeatButton.UseVisualStyleBackColor = true;
            this.modifyFeatButton.Click += new System.EventHandler(this.modifyFeatButton_Click);
            // 
            // featListView
            // 
            this.featListView.ContextMenuStrip = this.featContextMenuStrip;
            this.featListView.Location = new System.Drawing.Point(117, 389);
            this.featListView.Name = "featListView";
            this.featListView.Size = new System.Drawing.Size(282, 49);
            this.featListView.TabIndex = 71;
            this.featListView.UseCompatibleStateImageBehavior = false;
            this.featListView.View = System.Windows.Forms.View.List;
            this.featListView.DoubleClick += new System.EventHandler(this.viewFeatInfoToolStripMenuItem_Click);
            // 
            // featContextMenuStrip
            // 
            this.featContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewFeatInfoToolStripMenuItem});
            this.featContextMenuStrip.Name = "featContextMenuStrip";
            this.featContextMenuStrip.Size = new System.Drawing.Size(157, 26);
            // 
            // viewFeatInfoToolStripMenuItem
            // 
            this.viewFeatInfoToolStripMenuItem.Name = "viewFeatInfoToolStripMenuItem";
            this.viewFeatInfoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.viewFeatInfoToolStripMenuItem.Text = "피트 설명 보기";
            this.viewFeatInfoToolStripMenuItem.Click += new System.EventHandler(this.viewFeatInfoToolStripMenuItem_Click);
            // 
            // SQListView
            // 
            this.SQListView.ContextMenuStrip = this.SQContextMenuStrip;
            this.SQListView.Location = new System.Drawing.Point(117, 473);
            this.SQListView.Name = "SQListView";
            this.SQListView.Size = new System.Drawing.Size(282, 43);
            this.SQListView.TabIndex = 70;
            this.SQListView.UseCompatibleStateImageBehavior = false;
            this.SQListView.SelectedIndexChanged += new System.EventHandler(this.SQListView_SelectedIndexChanged);
            this.SQListView.DoubleClick += new System.EventHandler(this.viewSQInfoToolStripMenuItem_Click);
            // 
            // skillListView
            // 
            this.skillListView.ContextMenuStrip = this.skillContextMenuStrip;
            this.skillListView.Location = new System.Drawing.Point(117, 521);
            this.skillListView.Name = "skillListView";
            this.skillListView.Size = new System.Drawing.Size(282, 48);
            this.skillListView.TabIndex = 69;
            this.skillListView.UseCompatibleStateImageBehavior = false;
            this.skillListView.View = System.Windows.Forms.View.SmallIcon;
            this.skillListView.DoubleClick += new System.EventHandler(this.viewSkillInfoToolStripMenuItem_Click);
            // 
            // skillContextMenuStrip
            // 
            this.skillContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSkillInfoToolStripMenuItem});
            this.skillContextMenuStrip.Name = "skillContextMenuStrip";
            this.skillContextMenuStrip.Size = new System.Drawing.Size(157, 26);
            // 
            // viewSkillInfoToolStripMenuItem
            // 
            this.viewSkillInfoToolStripMenuItem.Name = "viewSkillInfoToolStripMenuItem";
            this.viewSkillInfoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.viewSkillInfoToolStripMenuItem.Text = "스킬 정보 보기";
            this.viewSkillInfoToolStripMenuItem.Click += new System.EventHandler(this.viewSkillInfoToolStripMenuItem_Click);
            // 
            // baseIntTextBox
            // 
            this.baseIntTextBox.Location = new System.Drawing.Point(107, 273);
            this.baseIntTextBox.Name = "baseIntTextBox";
            this.baseIntTextBox.Size = new System.Drawing.Size(31, 21);
            this.baseIntTextBox.TabIndex = 68;
            this.baseIntTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.baseIntTextBox.Leave += new System.EventHandler(this.Leave);
            this.baseIntTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // baseChaTextBox
            // 
            this.baseChaTextBox.Location = new System.Drawing.Point(384, 273);
            this.baseChaTextBox.Name = "baseChaTextBox";
            this.baseChaTextBox.Size = new System.Drawing.Size(31, 21);
            this.baseChaTextBox.TabIndex = 67;
            this.baseChaTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.baseChaTextBox.Leave += new System.EventHandler(this.Leave);
            this.baseChaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // baseWisTextBox
            // 
            this.baseWisTextBox.Location = new System.Drawing.Point(248, 273);
            this.baseWisTextBox.Name = "baseWisTextBox";
            this.baseWisTextBox.Size = new System.Drawing.Size(31, 21);
            this.baseWisTextBox.TabIndex = 66;
            this.baseWisTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.baseWisTextBox.Leave += new System.EventHandler(this.Leave);
            this.baseWisTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // baseConTextBox
            // 
            this.baseConTextBox.Location = new System.Drawing.Point(384, 246);
            this.baseConTextBox.Name = "baseConTextBox";
            this.baseConTextBox.Size = new System.Drawing.Size(31, 21);
            this.baseConTextBox.TabIndex = 65;
            this.baseConTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.baseConTextBox.Leave += new System.EventHandler(this.Leave);
            this.baseConTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // baseDexTextBox
            // 
            this.baseDexTextBox.Location = new System.Drawing.Point(248, 246);
            this.baseDexTextBox.Name = "baseDexTextBox";
            this.baseDexTextBox.Size = new System.Drawing.Size(31, 21);
            this.baseDexTextBox.TabIndex = 64;
            this.baseDexTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.baseDexTextBox.Leave += new System.EventHandler(this.Leave);
            this.baseDexTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // baseStrTextBox
            // 
            this.baseStrTextBox.Location = new System.Drawing.Point(107, 246);
            this.baseStrTextBox.Name = "baseStrTextBox";
            this.baseStrTextBox.Size = new System.Drawing.Size(31, 21);
            this.baseStrTextBox.TabIndex = 58;
            this.baseStrTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.baseStrTextBox.Leave += new System.EventHandler(this.Leave);
            this.baseStrTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // modifySkillButton
            // 
            this.modifySkillButton.Location = new System.Drawing.Point(208, 570);
            this.modifySkillButton.Name = "modifySkillButton";
            this.modifySkillButton.Size = new System.Drawing.Size(91, 23);
            this.modifySkillButton.TabIndex = 57;
            this.modifySkillButton.Text = "스킬 추가";
            this.modifySkillButton.UseVisualStyleBackColor = true;
            this.modifySkillButton.Click += new System.EventHandler(this.modifySkillButton_Click);
            // 
            // modifyLevelButton
            // 
            this.modifyLevelButton.Location = new System.Drawing.Point(321, 144);
            this.modifyLevelButton.Name = "modifyLevelButton";
            this.modifyLevelButton.Size = new System.Drawing.Size(94, 23);
            this.modifyLevelButton.TabIndex = 56;
            this.modifyLevelButton.Text = "레벨 수정";
            this.modifyLevelButton.UseVisualStyleBackColor = true;
            this.modifyLevelButton.Click += new System.EventHandler(this.modifyLevelButton_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(27, 473);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(29, 12);
            this.label34.TabIndex = 53;
            this.label34.Text = "SQs";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(28, 389);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(36, 12);
            this.label33.TabIndex = 52;
            this.label33.Text = "Feats";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(27, 521);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 12);
            this.label32.TabIndex = 50;
            this.label32.Text = "Skills";
            // 
            // willTextBox
            // 
            this.willTextBox.Location = new System.Drawing.Point(303, 197);
            this.willTextBox.Name = "willTextBox";
            this.willTextBox.ReadOnly = true;
            this.willTextBox.Size = new System.Drawing.Size(51, 21);
            this.willTextBox.TabIndex = 49;
            // 
            // refTextBox
            // 
            this.refTextBox.Location = new System.Drawing.Point(184, 197);
            this.refTextBox.Name = "refTextBox";
            this.refTextBox.ReadOnly = true;
            this.refTextBox.Size = new System.Drawing.Size(51, 21);
            this.refTextBox.TabIndex = 48;
            // 
            // fortTextBox
            // 
            this.fortTextBox.Location = new System.Drawing.Point(71, 197);
            this.fortTextBox.Name = "fortTextBox";
            this.fortTextBox.ReadOnly = true;
            this.fortTextBox.Size = new System.Drawing.Size(51, 21);
            this.fortTextBox.TabIndex = 47;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(265, 200);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(24, 12);
            this.label31.TabIndex = 46;
            this.label31.Text = "Will";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(147, 200);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 12);
            this.label30.TabIndex = 45;
            this.label30.Text = "Ref";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(27, 201);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(26, 12);
            this.label29.TabIndex = 44;
            this.label29.Text = "Fort";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(212, 87);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.ReadOnly = true;
            this.speedTextBox.Size = new System.Drawing.Size(98, 21);
            this.speedTextBox.TabIndex = 43;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(71, 87);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.ReadOnly = true;
            this.sizeTextBox.Size = new System.Drawing.Size(70, 21);
            this.sizeTextBox.TabIndex = 42;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(164, 90);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 12);
            this.label26.TabIndex = 41;
            this.label26.Text = "Speed";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(28, 90);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 12);
            this.label25.TabIndex = 40;
            this.label25.Text = "Size";
            // 
            // alignmentTextBox
            // 
            this.alignmentTextBox.Location = new System.Drawing.Point(94, 60);
            this.alignmentTextBox.Name = "alignmentTextBox";
            this.alignmentTextBox.Size = new System.Drawing.Size(103, 21);
            this.alignmentTextBox.TabIndex = 39;
            this.alignmentTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.alignmentTextBox.Leave += new System.EventHandler(this.Leave);
            this.alignmentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // raceTextBox
            // 
            this.raceTextBox.Location = new System.Drawing.Point(94, 35);
            this.raceTextBox.Name = "raceTextBox";
            this.raceTextBox.Size = new System.Drawing.Size(103, 21);
            this.raceTextBox.TabIndex = 38;
            this.raceTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.raceTextBox.Leave += new System.EventHandler(this.Leave);
            this.raceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // teamTextBox
            // 
            this.teamTextBox.Location = new System.Drawing.Point(296, 35);
            this.teamTextBox.Name = "teamTextBox";
            this.teamTextBox.Size = new System.Drawing.Size(103, 21);
            this.teamTextBox.TabIndex = 37;
            this.teamTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.teamTextBox.Leave += new System.EventHandler(this.Leave);
            this.teamTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // playerTextBox
            // 
            this.playerTextBox.Location = new System.Drawing.Point(296, 10);
            this.playerTextBox.Name = "playerTextBox";
            this.playerTextBox.Size = new System.Drawing.Size(103, 21);
            this.playerTextBox.TabIndex = 36;
            this.playerTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.playerTextBox.Leave += new System.EventHandler(this.Leave);
            this.playerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(94, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(103, 21);
            this.nameTextBox.TabIndex = 35;
            this.nameTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.nameTextBox.Leave += new System.EventHandler(this.Leave);
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 12);
            this.label19.TabIndex = 34;
            this.label19.Text = "Alignment";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 12);
            this.label18.TabIndex = 33;
            this.label18.Text = "Race";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(239, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 12);
            this.label17.TabIndex = 32;
            this.label17.Text = "Team";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(239, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 31;
            this.label16.Text = "Player";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 12);
            this.label15.TabIndex = 30;
            this.label15.Text = "Name";
            // 
            // itemTabPage
            // 
            this.itemTabPage.Controls.Add(this.addItemButton);
            this.itemTabPage.Controls.Add(this.label38);
            this.itemTabPage.Controls.Add(this.label37);
            this.itemTabPage.Controls.Add(sellButton);
            this.itemTabPage.Controls.Add(this.sellPriceTextBox);
            this.itemTabPage.Controls.Add(this.label36);
            this.itemTabPage.Controls.Add(this.label35);
            this.itemTabPage.Controls.Add(this.goldTextBox);
            this.itemTabPage.Controls.Add(this.button5);
            this.itemTabPage.Controls.Add(this.removeEquipmentButton);
            this.itemTabPage.Controls.Add(this.equipButton);
            this.itemTabPage.Controls.Add(this.inventoryListView);
            this.itemTabPage.Controls.Add(this.loadLabel);
            this.itemTabPage.Controls.Add(this.equipListView);
            this.itemTabPage.Controls.Add(this.label28);
            this.itemTabPage.Controls.Add(this.label27);
            this.itemTabPage.Location = new System.Drawing.Point(4, 21);
            this.itemTabPage.Name = "itemTabPage";
            this.itemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemTabPage.Size = new System.Drawing.Size(428, 598);
            this.itemTabPage.TabIndex = 3;
            this.itemTabPage.Text = "장비/아이템";
            this.itemTabPage.UseVisualStyleBackColor = true;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(232, 542);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(156, 23);
            this.addItemButton.TabIndex = 17;
            this.addItemButton.Text = "아이템 추가";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(121, 519);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(25, 12);
            this.label38.TabIndex = 16;
            this.label38.Text = "(%)";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(9, 517);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(41, 12);
            this.label37.TabIndex = 15;
            this.label37.Text = "판매가";
            // 
            // sellPriceTextBox
            // 
            this.sellPriceTextBox.Location = new System.Drawing.Point(63, 514);
            this.sellPriceTextBox.Name = "sellPriceTextBox";
            this.sellPriceTextBox.Size = new System.Drawing.Size(52, 21);
            this.sellPriceTextBox.TabIndex = 13;
            this.sellPriceTextBox.Text = "50";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(170, 259);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(32, 12);
            this.label36.TabIndex = 12;
            this.label36.Text = "(GP)";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(9, 259);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(41, 12);
            this.label35.TabIndex = 11;
            this.label35.Text = "소지금";
            // 
            // goldTextBox
            // 
            this.goldTextBox.Location = new System.Drawing.Point(63, 257);
            this.goldTextBox.Name = "goldTextBox";
            this.goldTextBox.Size = new System.Drawing.Size(100, 21);
            this.goldTextBox.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(313, 513);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "버리기";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // removeEquipmentButton
            // 
            this.removeEquipmentButton.Location = new System.Drawing.Point(283, 228);
            this.removeEquipmentButton.Name = "removeEquipmentButton";
            this.removeEquipmentButton.Size = new System.Drawing.Size(104, 23);
            this.removeEquipmentButton.TabIndex = 8;
            this.removeEquipmentButton.Text = "장비 해제";
            this.removeEquipmentButton.UseVisualStyleBackColor = true;
            this.removeEquipmentButton.Click += new System.EventHandler(this.removeEquipmentButton_Click);
            // 
            // equipButton
            // 
            this.equipButton.Location = new System.Drawing.Point(234, 513);
            this.equipButton.Name = "equipButton";
            this.equipButton.Size = new System.Drawing.Size(75, 23);
            this.equipButton.TabIndex = 7;
            this.equipButton.Text = "장비";
            this.equipButton.UseVisualStyleBackColor = true;
            this.equipButton.Click += new System.EventHandler(this.equipButton_Click);
            // 
            // inventoryListView
            // 
            this.inventoryListView.Location = new System.Drawing.Point(17, 307);
            this.inventoryListView.Name = "inventoryListView";
            this.inventoryListView.Size = new System.Drawing.Size(370, 200);
            this.inventoryListView.TabIndex = 6;
            this.inventoryListView.UseCompatibleStateImageBehavior = false;
            this.inventoryListView.View = System.Windows.Forms.View.List;
            // 
            // loadLabel
            // 
            this.loadLabel.AutoSize = true;
            this.loadLabel.Location = new System.Drawing.Point(261, 292);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(110, 12);
            this.loadLabel.TabIndex = 5;
            this.loadLabel.Text = "하중 : 0.0/0.0 (lbs)";
            // 
            // equipListView
            // 
            this.equipListView.Location = new System.Drawing.Point(20, 35);
            this.equipListView.Name = "equipListView";
            this.equipListView.Size = new System.Drawing.Size(368, 187);
            this.equipListView.TabIndex = 4;
            this.equipListView.UseCompatibleStateImageBehavior = false;
            this.equipListView.View = System.Windows.Forms.View.List;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, 292);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 12);
            this.label28.TabIndex = 3;
            this.label28.Text = "인벤토리";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(17, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 12);
            this.label27.TabIndex = 2;
            this.label27.Text = "장비";
            // 
            // SpellTabPage
            // 
            this.SpellTabPage.Location = new System.Drawing.Point(4, 21);
            this.SpellTabPage.Name = "SpellTabPage";
            this.SpellTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SpellTabPage.Size = new System.Drawing.Size(428, 598);
            this.SpellTabPage.TabIndex = 1;
            this.SpellTabPage.Text = "주문";
            this.SpellTabPage.UseVisualStyleBackColor = true;
            // 
            // descriptionTabPage
            // 
            this.descriptionTabPage.Controls.Add(this.weightTextBox);
            this.descriptionTabPage.Controls.Add(this.heightTextBox);
            this.descriptionTabPage.Controls.Add(this.ageTextBox);
            this.descriptionTabPage.Controls.Add(this.memoTextBox);
            this.descriptionTabPage.Controls.Add(this.label24);
            this.descriptionTabPage.Controls.Add(this.label23);
            this.descriptionTabPage.Controls.Add(this.label22);
            this.descriptionTabPage.Controls.Add(this.label21);
            this.descriptionTabPage.Controls.Add(this.label20);
            this.descriptionTabPage.Controls.Add(this.descriptionTextBox);
            this.descriptionTabPage.Location = new System.Drawing.Point(4, 21);
            this.descriptionTabPage.Name = "descriptionTabPage";
            this.descriptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.descriptionTabPage.Size = new System.Drawing.Size(428, 598);
            this.descriptionTabPage.TabIndex = 2;
            this.descriptionTabPage.Text = "소개";
            this.descriptionTabPage.UseVisualStyleBackColor = true;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(346, 6);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(73, 21);
            this.weightTextBox.TabIndex = 9;
            this.weightTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.weightTextBox.Leave += new System.EventHandler(this.Leave);
            this.weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(195, 6);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(70, 21);
            this.heightTextBox.TabIndex = 8;
            this.heightTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.heightTextBox.Leave += new System.EventHandler(this.Leave);
            this.heightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(48, 6);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(54, 21);
            this.ageTextBox.TabIndex = 7;
            this.ageTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.ageTextBox.Leave += new System.EventHandler(this.Leave);
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            // 
            // memoTextBox
            // 
            this.memoTextBox.Location = new System.Drawing.Point(10, 307);
            this.memoTextBox.Multiline = true;
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.memoTextBox.Size = new System.Drawing.Size(409, 246);
            this.memoTextBox.TabIndex = 6;
            this.memoTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.memoTextBox.Leave += new System.EventHandler(this.Leave);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 292);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 12);
            this.label24.TabIndex = 5;
            this.label24.Text = "Memo";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 12);
            this.label23.TabIndex = 4;
            this.label23.Text = "Description";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(143, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 12);
            this.label22.TabIndex = 3;
            this.label22.Text = "Height";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(292, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 12);
            this.label21.TabIndex = 2;
            this.label21.Text = "Weight";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 12);
            this.label20.TabIndex = 1;
            this.label20.Text = "Age";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(10, 57);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(409, 210);
            this.descriptionTextBox.TabIndex = 0;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.TextChanged);
            this.descriptionTextBox.Leave += new System.EventHandler(this.Leave);
            // 
            // effectTabPage
            // 
            this.effectTabPage.Controls.Add(this.effectDataGridView);
            this.effectTabPage.Location = new System.Drawing.Point(4, 21);
            this.effectTabPage.Name = "effectTabPage";
            this.effectTabPage.Size = new System.Drawing.Size(428, 598);
            this.effectTabPage.TabIndex = 4;
            this.effectTabPage.Text = "이펙트";
            this.effectTabPage.UseVisualStyleBackColor = true;
            // 
            // effectDataGridView
            // 
            this.effectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.effectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.effectDataGridView.Location = new System.Drawing.Point(24, 30);
            this.effectDataGridView.MultiSelect = false;
            this.effectDataGridView.Name = "effectDataGridView";
            this.effectDataGridView.ReadOnly = true;
            this.effectDataGridView.RowHeadersVisible = false;
            this.effectDataGridView.RowTemplate.Height = 23;
            this.effectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.effectDataGridView.Size = new System.Drawing.Size(395, 474);
            this.effectDataGridView.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "출처";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "효과";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripButton,
            this.열기ToolStripButton,
            this.저장ToolStripButton,
            this.인쇄ToolStripButton,
            this.toolStripSeparator,
            this.잘라내기ToolStripButton,
            this.복사ToolStripButton,
            this.붙여넣기ToolStripButton,
            this.toolStripSeparator1,
            this.도움말ToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(436, 25);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 새로만들기ToolStripButton
            // 
            this.새로만들기ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.새로만들기ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("새로만들기ToolStripButton.Image")));
            this.새로만들기ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.새로만들기ToolStripButton.Name = "새로만들기ToolStripButton";
            this.새로만들기ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.새로만들기ToolStripButton.Text = "새로 만들기";
            this.새로만들기ToolStripButton.Click += new System.EventHandler(this.새로만들기ToolStripButton_Click);
            // 
            // 열기ToolStripButton
            // 
            this.열기ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.열기ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("열기ToolStripButton.Image")));
            this.열기ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.열기ToolStripButton.Name = "열기ToolStripButton";
            this.열기ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.열기ToolStripButton.Text = "열기";
            this.열기ToolStripButton.Click += new System.EventHandler(this.열기ToolStripButton_Click);
            // 
            // 저장ToolStripButton
            // 
            this.저장ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.저장ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("저장ToolStripButton.Image")));
            this.저장ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.저장ToolStripButton.Name = "저장ToolStripButton";
            this.저장ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.저장ToolStripButton.Text = "저장";
            this.저장ToolStripButton.Click += new System.EventHandler(this.저장ToolStripButton_Click);
            // 
            // 인쇄ToolStripButton
            // 
            this.인쇄ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.인쇄ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("인쇄ToolStripButton.Image")));
            this.인쇄ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.인쇄ToolStripButton.Name = "인쇄ToolStripButton";
            this.인쇄ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.인쇄ToolStripButton.Text = "인쇄";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // 잘라내기ToolStripButton
            // 
            this.잘라내기ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.잘라내기ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("잘라내기ToolStripButton.Image")));
            this.잘라내기ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.잘라내기ToolStripButton.Name = "잘라내기ToolStripButton";
            this.잘라내기ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.잘라내기ToolStripButton.Text = "잘라내기";
            // 
            // 복사ToolStripButton
            // 
            this.복사ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.복사ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("복사ToolStripButton.Image")));
            this.복사ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.복사ToolStripButton.Name = "복사ToolStripButton";
            this.복사ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.복사ToolStripButton.Text = "복사";
            // 
            // 붙여넣기ToolStripButton
            // 
            this.붙여넣기ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.붙여넣기ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("붙여넣기ToolStripButton.Image")));
            this.붙여넣기ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.붙여넣기ToolStripButton.Name = "붙여넣기ToolStripButton";
            this.붙여넣기ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.붙여넣기ToolStripButton.Text = "붙여넣기";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // 도움말ToolStripButton
            // 
            this.도움말ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.도움말ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("도움말ToolStripButton.Image")));
            this.도움말ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.도움말ToolStripButton.Name = "도움말ToolStripButton";
            this.도움말ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.도움말ToolStripButton.Text = "도움말";
            // 
            // saveSheetFileDialog
            // 
            this.saveSheetFileDialog.DefaultExt = "xml";
            // 
            // SQContextMenuStrip
            // 
            this.SQContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSQInfoToolStripMenuItem,
            this.activeSQToolStripMenuItem});
            this.SQContextMenuStrip.Name = "SQContextMenuStrip";
            this.SQContextMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // viewSQInfoToolStripMenuItem
            // 
            this.viewSQInfoToolStripMenuItem.Name = "viewSQInfoToolStripMenuItem";
            this.viewSQInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewSQInfoToolStripMenuItem.Text = "툭수능력 정보 보기";
            this.viewSQInfoToolStripMenuItem.Click += new System.EventHandler(this.viewSQInfoToolStripMenuItem_Click);
            // 
            // activeSQToolStripMenuItem
            // 
            this.activeSQToolStripMenuItem.Name = "activeSQToolStripMenuItem";
            this.activeSQToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activeSQToolStripMenuItem.Text = "특수능력 활성화";
            this.activeSQToolStripMenuItem.Click += new System.EventHandler(this.activeSQToolStripMenuItem_Click);
            // 
            // CharacterSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 648);
            this.Controls.Add(this.sheetTabControl);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CharacterSheetForm";
            this.Text = "Sheet";
            this.sheetTabControl.ResumeLayout(false);
            this.SheetTabPage.ResumeLayout(false);
            this.SheetTabPage.PerformLayout();
            this.featContextMenuStrip.ResumeLayout(false);
            this.skillContextMenuStrip.ResumeLayout(false);
            this.itemTabPage.ResumeLayout(false);
            this.itemTabPage.PerformLayout();
            this.descriptionTabPage.ResumeLayout(false);
            this.descriptionTabPage.PerformLayout();
            this.effectTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.effectDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SQContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox LevelTextBox;
		private System.Windows.Forms.TextBox BABTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox StrTextBox;
		private System.Windows.Forms.TextBox DexTextBox;
		private System.Windows.Forms.TextBox ConTextBox;
		private System.Windows.Forms.TextBox IntTextBox;
		private System.Windows.Forms.TextBox WisTextBox;
		private System.Windows.Forms.TextBox ChaTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox GrappleTextBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox ACTextBox;
		private System.Windows.Forms.TextBox CurrentHPTextBox;
		private System.Windows.Forms.TextBox MaxHPTextBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox AtkTextBox;
		private System.Windows.Forms.TextBox FullAtkTextBox;
		private System.Windows.Forms.TabControl sheetTabControl;
		private System.Windows.Forms.TabPage SheetTabPage;
		private System.Windows.Forms.TabPage SpellTabPage;
		private System.Windows.Forms.TabPage descriptionTabPage;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox memoTextBox;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox weightTextBox;
		private System.Windows.Forms.TextBox heightTextBox;
		private System.Windows.Forms.TextBox ageTextBox;
		private System.Windows.Forms.TextBox alignmentTextBox;
		private System.Windows.Forms.TextBox raceTextBox;
		private System.Windows.Forms.TextBox teamTextBox;
		private System.Windows.Forms.TextBox playerTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox speedTextBox;
		private System.Windows.Forms.TextBox sizeTextBox;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TabPage itemTabPage;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ListView equipListView;
        private System.Windows.Forms.Label loadLabel;
        private System.Windows.Forms.ListView inventoryListView;
        private System.Windows.Forms.TextBox willTextBox;
        private System.Windows.Forms.TextBox refTextBox;
        private System.Windows.Forms.TextBox fortTextBox;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TabPage effectTabPage;
        private System.Windows.Forms.DataGridView effectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 새로만들기ToolStripButton;
        private System.Windows.Forms.ToolStripButton 열기ToolStripButton;
        private System.Windows.Forms.ToolStripButton 저장ToolStripButton;
        private System.Windows.Forms.ToolStripButton 인쇄ToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton 잘라내기ToolStripButton;
        private System.Windows.Forms.ToolStripButton 복사ToolStripButton;
        private System.Windows.Forms.ToolStripButton 붙여넣기ToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton 도움말ToolStripButton;
        private System.Windows.Forms.Button modifySkillButton;
        private System.Windows.Forms.Button modifyLevelButton;
        private System.Windows.Forms.Button equipButton;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox sellPriceTextBox;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox goldTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button removeEquipmentButton;
        private System.Windows.Forms.TextBox baseIntTextBox;
        private System.Windows.Forms.TextBox baseChaTextBox;
        private System.Windows.Forms.TextBox baseWisTextBox;
        private System.Windows.Forms.TextBox baseConTextBox;
        private System.Windows.Forms.TextBox baseDexTextBox;
        private System.Windows.Forms.TextBox baseStrTextBox;
        private System.Windows.Forms.Button addItemButton;
		private System.Windows.Forms.ListView skillListView;
		private System.Windows.Forms.ListView featListView;
		private System.Windows.Forms.ListView SQListView;
		private System.Windows.Forms.OpenFileDialog openSheetFileDialog;
		private System.Windows.Forms.SaveFileDialog saveSheetFileDialog;
		private System.Windows.Forms.Button modifyFeatButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ContextMenuStrip featContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem viewFeatInfoToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip skillContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem viewSkillInfoToolStripMenuItem;
        private System.Windows.Forms.TextBox initiativeTextBox;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ContextMenuStrip SQContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewSQInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeSQToolStripMenuItem;
    }
}

