using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sheet
{
    public partial class SpellListForm : Form
    {
        CharacterSheet m_sheet;
        string m_selectedSpell = string.Empty;

        public string SelectedSpell { get { return m_selectedSpell; } }

        public SpellListForm(CharacterSheet sheet)
        {
            m_sheet = sheet;
            InitializeComponent();
            DisplaySpellList();
        }

        public SpellListForm(string spellCode, CharacterSheet sheet)
        {
            m_sheet = sheet;
            InitializeComponent();
            DisplaySpellList();

            // 입력받은 코드에 해당하는 주문이 있으면 해당 주문을 선택한 상태로 만든다.
            ListViewItem[] items = spellListView.Items.Find(spellCode, false);
            if (items.Length > 0) items[0].Selected = true;
        }

        public void DisplaySpellList()
        {
            spellListView.Items.Clear();
            foreach (SpellInfo spell in DataManager.Instance.SpellData.Values)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = spell.Name;
                listViewItem.Name = spell.Code;
                spellListView.Items.Add(listViewItem);
            }
        }

        public void DisplaySpellInfo(string spellCode)
        {
            // 주문 정보 가져오기
            SpellInfo spell = DataManager.Instance.GetSpell(spellCode);
            if (spell == null)
            {
                MessageBox.Show("'" + spellCode + "' : 존재하지 않는 주문 코드입니다.");
                return;
            }

            // 주문 정보 문자열로 생성
            string msg = "";
            msg += "이름 : " + spell.Name + "\r\n";
            msg += "설명 : " + spell.Description + "\r\n";

            // 출력
            spellInfoTextBox.Text = msg;
        }

        private void spellListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (spellListView.SelectedItems.Count < 1) return;

            m_selectedSpell = spellListView.SelectedItems[0].Name;
            DisplaySpellInfo(m_selectedSpell);
        }
    }
}
