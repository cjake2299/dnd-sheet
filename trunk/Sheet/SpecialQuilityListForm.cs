using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sheet
{
    public partial class SpecialQuilityListForm : Form
    {
        CharacterSheet m_sheet;
        string m_selectedSQ = string.Empty;

        public string SelectedSQ { get { return m_selectedSQ; } }

        public SpecialQuilityListForm(CharacterSheet sheet)
        {
            m_sheet = sheet;
            InitializeComponent();
            DisplaySpecialQuilities();
        }

		public SpecialQuilityListForm(string SQCode, CharacterSheet sheet)
		{
			m_sheet = sheet;
			InitializeComponent();
			DisplaySpecialQuilities();

			// 입력받은 코드에 해당하는 스킬이 있으면 해당 스킬을 선택한 상태로 만든다.
			ListViewItem[] items = SQListView.Items.Find(SQCode, false);
			if (items.Length > 0) items[0].Selected = true;
		}

		public void DisplaySpecialQuilities()
		{
			SQListView.Items.Clear();
			foreach (SpecialQuilityInfo SQ in DataManager.Instance.SpecialQuilityData.Values)
			{
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = SQ.Name;
				listViewItem.Name = SQ.Code;
				SQListView.Items.Add(listViewItem);
			}
		}

        public void DisplaySpecialQuilityInfo(string SQCode)
		{
			// 스킬 존재 여부 체크.
            if (!DataManager.Instance.SpecialQuilityData.ContainsKey(SQCode))
			{
                MessageBox.Show("'" + SQCode + "' : 존재하지 않는 특수능력 코드입니다.");
				return;
			}

			// 스킬 정보 가져오기
            SpecialQuilityInfo SQ = DataManager.Instance.SpecialQuilityData[SQCode];

			// 스킬 정보 문자열로 생성
			string msg = "";
			msg += "이름 : " + SQ.Name + "\r\n";
			msg += "설명 : " + SQ.Description + "\r\n";

			// 출력
			SQInfoTextBox.Text = msg;
		}



        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void SQListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SQListView.SelectedItems.Count < 1) return;

            m_selectedSQ = SQListView.SelectedItems[0].Name;
            DisplaySpecialQuilityInfo(m_selectedSQ);
        }
    }
}
