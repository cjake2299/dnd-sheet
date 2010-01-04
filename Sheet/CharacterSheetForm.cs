﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sheet
{
    public partial class CharacterSheetForm : Form
    {
        CharacterSheet characterInfo = new CharacterSheet();
        bool isSheetChanged = false;

        public CharacterSheetForm()
        {
            InitializeComponent();
            DataManager.Instance.LoadAllData();

			//string path = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)
			//             + @"\..\data\charactersheet\test1.xml";
			//characterInfo.LoadSheetFile(path);
			DisplayCharacterInfo();


			// 오류정보 표시
			using (ErrorLogForm dlg = new ErrorLogForm())
			{
				dlg.ViewErrors();
			}
        }

        public void DisplayCharacterInfo()
        {
			// 이름 출력
			this.nameTextBox.Text = characterInfo.ChatacterName;
			// 플레이어 이름 출력
			this.playerTextBox.Text = characterInfo.PlayerName;
			// 팀 이름 출력
			this.teamTextBox.Text = characterInfo.TeamName;
			// 종족 출력
			this.raceTextBox.Text = characterInfo.RaceCode;
			// 가치관 출력
			this.alignmentTextBox.Text = characterInfo.Alignment;
			// 나이 출력
			this.ageTextBox.Text = characterInfo.Age;
			// 키 출력
			this.heightTextBox.Text = characterInfo.Height.ToString();
			// 몸무게 출력
			this.weightTextBox.Text = characterInfo.Weight.ToString();
			// 캐릭터 소개 출력
			this.descriptionTextBox.Text = characterInfo.Description;
			// 메모 출력
			this.memoTextBox.Text = characterInfo.Memo;

			// 사이즈 출력
			this.sizeTextBox.Text = characterInfo.GetSize();

			// 이동속도 출력
			this.speedTextBox.Text = characterInfo.GetSpeed();

			// 캐릭터 레벨 정보 출력
            this.LevelTextBox.Text = characterInfo.GetLevelInfoStr();

            /*
            List<string> levels = characterInfo.GetDetailLevelInfo();
            foreach (string str in levels)
            {
                this.LevelDetailInfoListView.Items.Add(str);
            }
            */

			// HP 정보 출력
			this.CurrentHPTextBox.Text = characterInfo.CurrentHP.ToString();
			this.MaxHPTextBox.Text = characterInfo.GetMaxHP().ToString();

			// AC 정보 출력
			this.ACTextBox.Text = characterInfo.GetAC().ToString();

            // 내성굴림 정보 출력
            this.fortTextBox.Text = string.Format("{0:+0;-0}", characterInfo.GetFort());
            this.refTextBox.Text = string.Format("{0:+0;-0}", characterInfo.GetRef());
            this.willTextBox.Text = string.Format("{0:+0;-0}", characterInfo.GetWill());


			// 능력치 정보 출력
            this.StrTextBox.Text = characterInfo.GetStr().ToString(); this.baseStrTextBox.Text = characterInfo.BaseStr.ToString();
            this.DexTextBox.Text = characterInfo.GetDex().ToString(); this.baseDexTextBox.Text = characterInfo.BaseDex.ToString();
            this.ConTextBox.Text = characterInfo.GetCon().ToString(); this.baseConTextBox.Text = characterInfo.BaseCon.ToString();
            this.IntTextBox.Text = characterInfo.GetInt().ToString(); this.baseIntTextBox.Text = characterInfo.BaseInt.ToString();
            this.WisTextBox.Text = characterInfo.GetWis().ToString(); this.baseWisTextBox.Text = characterInfo.BaseWis.ToString();
            this.ChaTextBox.Text = characterInfo.GetCha().ToString(); this.baseChaTextBox.Text = characterInfo.BaseCha.ToString();

			// 기본명중굴림 정보 출력
			this.BABTextBox.Text = "+" + characterInfo.GetBAB().ToString();

			// 그래플 수정치 정보 출력
			this.GrappleTextBox.Text = "+" + characterInfo.GetGrappleBonus().ToString();

			// 공격 정보 출력
			this.AtkTextBox.Text = characterInfo.GetAttackDescription();
			this.FullAtkTextBox.Text = characterInfo.GetFullAttackDescription();

            // 피트 정보 출력
			featListView.Items.Clear();
            foreach (string featCode in characterInfo.Feats)
            {
				ListViewItem feat = new ListViewItem();
				feat.Name = featCode;
				feat.Text = DataManager.Instance.FeatData[featCode].Name;
				featListView.Items.Add(feat);
            }

            // 스킬정보 출력
            skillListView.Items.Clear();
            string name;
            int bonus;
            string relatedAbility;
            foreach (KeyValuePair<string, int> skill in characterInfo.Skills)
            {
                name = DataManager.Instance.SkillData[skill.Key].Name;
                bonus = characterInfo.GetSkillBonus(skill.Key);
                relatedAbility = DataManager.Instance.SkillData[skill.Key].RelatedAbility;

				ListViewItem skillItem = new ListViewItem();
				skillItem.Name = skill.Key;
				skillItem.Text = string.Format("{0} {1:+0;-0}({2})", name, bonus, relatedAbility);

				skillListView.Items.Add(skillItem);
            }

            // 장비 목록 출력
            equipListView.Items.Clear();
            foreach (Item equip in characterInfo.Equipments)
            {
                ListViewItem item = new ListViewItem();
                item.Name = equip.Code;
                item.Text = equip.Name + "(" + equip.PartStr + ")";
                equipListView.Items.Add(item);
            }

            // 인벤토리 출력
            inventoryListView.Items.Clear();
            foreach (Item item in characterInfo.Inventroy)
            {
                ListViewItem buf = new ListViewItem();
                buf.Name = item.Code;
                buf.Text = item.Name;
                inventoryListView.Items.Add(buf);
            }

            // 하중 출력
            this.loadLabel.Text = "하중 : " + characterInfo.GetLoad() + " / " + 0.0 + " (lbs)";

            // 소지금 출력
            this.goldTextBox.Text = characterInfo.Gold.ToString();

            // 수정되지 않은 상태로 설정.
            isSheetChanged = false;
        }

        public void UpdateCharacterInfo()
        {
            #region 기본정보 업데이트
            characterInfo.ChatacterName = this.nameTextBox.Text.Trim();

            characterInfo.PlayerName = this.playerTextBox.Text.Trim();

            characterInfo.TeamName = this.teamTextBox.Text.Trim();

            characterInfo.RaceCode = this.raceTextBox.Text.Trim();

            characterInfo.Alignment = this.alignmentTextBox.Text.Trim();

            characterInfo.Age = this.ageTextBox.Text.Trim();

            characterInfo.Height = Util.ParseToDouble(this.heightTextBox.Text); 

            characterInfo.Weight = Util.ParseToDouble(this.weightTextBox.Text);

            characterInfo.Description = this.descriptionTextBox.Text.Trim();

            characterInfo.Memo = this.memoTextBox.Text.Trim();
            #endregion

            #region HP 정보 업데이트
			characterInfo.CurrentHP = Util.ParseToInt(this.CurrentHPTextBox.Text);
            #endregion

            #region 능력치 정보 업데이트
            characterInfo.BaseStr = Util.ParseToInt(this.baseStrTextBox.Text);
            characterInfo.BaseDex = Util.ParseToInt(this.baseDexTextBox.Text);
            characterInfo.BaseCon = Util.ParseToInt(this.baseConTextBox.Text);
            characterInfo.BaseInt = Util.ParseToInt(this.baseIntTextBox.Text);
            characterInfo.BaseWis = Util.ParseToInt(this.baseWisTextBox.Text);
            characterInfo.BaseCha = Util.ParseToInt(this.baseChaTextBox.Text);
            #endregion
        }

		#region 시트 업데이트 이벤트 처리
		private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 엔터키 입력
            {
                UpdateCharacterInfo();
                DisplayCharacterInfo();
            }
        }

        private void TextChanged(object sender, EventArgs e)
        {
            isSheetChanged = true;
        }

        private void Leave(object sender, EventArgs e)
        {
            if (isSheetChanged == true)
            {
                UpdateCharacterInfo();
                DisplayCharacterInfo();
                isSheetChanged = false;
            }
		}
		#endregion

        #region 장비/인벤토리 관련함수
        private void removeEquipmentButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in equipListView.SelectedItems)
                characterInfo.RemoveEquipment(item.Name);

            // 업데이트.
            DisplayCharacterInfo();
        }

        private void equipButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in inventoryListView.SelectedItems)
                characterInfo.EquipItem(item.Name);

            // 업데이트.
            DisplayCharacterInfo();
        }

		private void sellButton_Click(object sender, EventArgs e)
		{
			// 선택된 아이템이 있는지 체크하고 없으면 리턴.
			if (inventoryListView.SelectedItems.Count < 1)
			{
				MessageBox.Show("아이템이 선택되지 않았습니다.");
				return;
			}

			// 아이템 가격, 판매시 가격비율, 판매가를 메세지박스로 띄우고 팔건지 물어봄.
			double sellPercentage = Util.ParseToDouble(sellPriceTextBox.Text);
			string msg = "판매가 " + sellPercentage + "%\n";
			foreach (ListViewItem item in inventoryListView.SelectedItems)
			{
				double sellPrice = DataManager.Instance.ItemData[item.Name].Cost * sellPercentage / 100.0;
				msg += string.Format("{0} : {1:0.##}gp\n", item.Text, sellPrice);
			}
			DialogResult result = MessageBox.Show(msg, "아이템 판매", MessageBoxButtons.OKCancel);
			if (DialogResult.OK == result)
			{
				// 아이템 판매
				foreach (ListViewItem item in inventoryListView.SelectedItems)
					characterInfo.SellItem(item.Name, sellPercentage / 100.0);

				// 업데이트
				DisplayCharacterInfo();
			}
		}

		private void addItemButton_Click(object sender, EventArgs e)
		{
			using (ItemListForm dlg = new ItemListForm())
			{
				DialogResult result = dlg.ShowDialog();
				if (result == DialogResult.OK)
				{
					// 아이템 추가.
					characterInfo.AddItem(dlg.SelectedItem);
					// 업데이트
					DisplayCharacterInfo();
				}
			}
		}
        #endregion

		#region 파일 메뉴
		private void 열기ToolStripButton_Click(object sender, EventArgs e)
		{
			DialogResult result = openSheetFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				characterInfo.LoadSheetFile(openSheetFileDialog.FileName);
				DisplayCharacterInfo(); // 업데이트.
			}
		}

		private void 새로만들기ToolStripButton_Click(object sender, EventArgs e)
		{
			// 경고 출력


			characterInfo = new CharacterSheet();
			DisplayCharacterInfo();
		}

		private void 저장ToolStripButton_Click(object sender, EventArgs e)
		{
			DialogResult result = saveSheetFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				try
				{
					UpdateCharacterInfo();
					characterInfo.SaveSheetFile(saveSheetFileDialog.FileName);
					MessageBox.Show("정상적으로 저장되었습니다.");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
		#endregion

		#region 레벨, 스킬, 피트 수정/추가 버튼
		private void modifyLevelButton_Click(object sender, EventArgs e)
		{
			// 레벨창 열기
			ModifyLevelForm dlg = new ModifyLevelForm(characterInfo);
			dlg.Owner = this;
			dlg.Show();
		}

		private void modifyFeatButton_Click(object sender, EventArgs e)
		{
			using (FeatListForm dlg = new FeatListForm())
			{
				DialogResult result = dlg.ShowDialog();
				if (result == DialogResult.OK)
				{
					// 피트 추가.
					characterInfo.AddFeat(dlg.SelectedFeat);
					// 업데이트
					DisplayCharacterInfo();
				}
			}
		}
		#endregion

		private void modifySkillButton_Click(object sender, EventArgs e)
		{
			SkillListForm dlg = new SkillListForm(characterInfo);
			dlg.Owner = this;
			dlg.Show();
		}

		#region 컨텍스트 메뉴
		private void viewFeatInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (featListView.SelectedItems.Count < 1)
				return;

			FeatListForm dlg = new FeatListForm(featListView.SelectedItems[0].Name);
			dlg.Owner = this;
			dlg.Show();
		}

		private void viewSkillInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (skillListView.SelectedItems.Count < 1)
				return;

			SkillListForm dlg = new SkillListForm(skillListView.SelectedItems[0].Name, characterInfo);
			dlg.Owner = this;
			dlg.Show();
		}
		#endregion
	}
}
