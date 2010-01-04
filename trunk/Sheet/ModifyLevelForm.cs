using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sheet
{
    public partial class ModifyLevelForm : Form
    {
        CharacterSheet m_sheet;
        Dictionary<string, string> classNameTable = new Dictionary<string, string>();

        public ModifyLevelForm(CharacterSheet sheet)
        {
            m_sheet = sheet;
            InitializeComponent();
            DisplayLevelInfo();

			classComboBox.Items.Clear();
			classNameTable.Clear();
			foreach (ClassInfo c in DataManager.Instance.ClassData.Values)
			{
				classComboBox.Items.Add(c.Name);
				classNameTable.Add(c.Name, c.Code);
			}
        }

        public void DisplayLevelInfo()
        {
            levelDataGridView.Rows.Clear();
            int i=1;
            foreach (LevelData lv in m_sheet.Levels)
            {
                levelDataGridView.Rows.Add(i++, lv.ClassCode, lv.HP, "-");
            }
        }

        private void addLevelButton_Click(object sender, EventArgs e)
        {
            // 클래스 선택 안 되어있으면 리턴.
            if(classComboBox.SelectedItem == null)
            {
                MessageBox.Show("클래스가 선택되지 않았습니다.");
                return;
            }

            // 클래스코드 얻기.
            string classCode = classNameTable[classComboBox.SelectedItem.ToString()];

            // HP 얻기
            int hp = 0;
            try
            {
                hp = int.Parse(HPTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("HP 값이 입력되지 않았거나 올바른 숫자가 아닙니다.");
                return;
            }

            // 캐릭터 레벨정보 추가
            m_sheet.Levels.Add(new LevelData(classCode, hp));

            // 시트 업데이트
            ((CharacterSheetForm)this.Owner).DisplayCharacterInfo();
            DisplayLevelInfo();
        }
    }
}
