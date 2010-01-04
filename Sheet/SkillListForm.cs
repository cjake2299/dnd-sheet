using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sheet
{
	public partial class SkillListForm : Form
	{
		CharacterSheet m_sheet;
		string m_selectedSkill = string.Empty;

		public string SelectedSkill { get { return m_selectedSkill; } }

		public SkillListForm(CharacterSheet sheet)
		{
			m_sheet = sheet;
			InitializeComponent();
			DisplaySkillList();
		}

		public SkillListForm(string skillCode, CharacterSheet sheet)
		{
			m_sheet = sheet;
			InitializeComponent();
			DisplaySkillList();

			// 입력받은 코드에 해당하는 스킬이 있으면 해당 스킬을 선택한 상태로 만든다.
			ListViewItem[] items = skillListView.Items.Find(skillCode, false);
			if (items.Length > 0) items[0].Selected = true;
		}

		public void DisplaySkillList()
		{
			skillListView.Items.Clear();
			foreach (SkillInfo skill in DataManager.Instance.SkillData.Values)
			{
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = skill.Name;
				listViewItem.Name = skill.Code;
				skillListView.Items.Add(listViewItem);
			}
		}

		public void DisplaySkillInfo(string skillCode)
		{
			// 스킬 존재 여부 체크.
			if (!DataManager.Instance.SkillData.ContainsKey(skillCode))
			{
				MessageBox.Show("'" + skillCode + "' : 존재하지 않는 스킬 코드입니다.");
				return;
			}

			// 스킬 정보 가져오기
			SkillInfo skill = DataManager.Instance.SkillData[skillCode];

			// 스킬 정보 문자열로 생성
			string msg = "";
			msg += "이름 : " + skill.Name + "\r\n";
			msg += "설명 : " + skill.Description + "\r\n";

			// 출력
			skillInfoTextBox.Text = msg;
		}

		private void skillListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (skillListView.SelectedItems.Count < 1) return;

			m_selectedSkill = skillListView.SelectedItems[0].Name;
			DisplaySkillInfo(m_selectedSkill);
		}

		private void selectSkillButton_Click(object sender, EventArgs e)
		{
			if (m_selectedSkill == string.Empty)
			{
				MessageBox.Show("스킬이 선택되지 않았습니다.");
				return;
			}

			int rank = Util.ParseToInt(skillRankTextBox.Text);
			if (rank < 1) return;

			m_sheet.AddSkill(m_selectedSkill, rank);
			((CharacterSheetForm)this.Owner).DisplayCharacterInfo();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Hide();
		}
	}
}
