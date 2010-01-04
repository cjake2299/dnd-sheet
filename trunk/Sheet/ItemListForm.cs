using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sheet
{
	public partial class ItemListForm : Form
	{
		string m_selectedItem = string.Empty;

		public string SelectedItem { get { return m_selectedItem; } }

		public ItemListForm()
		{
			InitializeComponent();
			DisplayItemList();
		}

		public void DisplayItemList()
		{
			itemListView.Items.Clear();
			foreach (Item item in DataManager.Instance.ItemData.Values)
			{
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = item.Name;
				listViewItem.Name = item.Code;
				itemListView.Items.Add(listViewItem);
			}
		}

		public void DisplayItemInfo(string itemCode)
		{
			// 아이템 존재 여부 체크.
			if(!DataManager.Instance.ItemData.ContainsKey(itemCode))
			{
				MessageBox.Show("'" + itemCode + "' : 존재하지 않는 아이템 코드입니다.");
				return;
			}

			// 아이템 정보 가져오기
			Item item = DataManager.Instance.ItemData[itemCode];

			// 아이템 정보 문자열로 생성
			string msg = "";
			msg += "이름 : " + item.Name + "\r\n";
			msg += "설명 : " + item.Description + "\r\n";

			// 출력
			itemInfoTextBox.Text = msg;
		}

		private void itemListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (itemListView.SelectedItems.Count < 1) return;

			m_selectedItem = itemListView.SelectedItems[0].Name;
			DisplayItemInfo(m_selectedItem);
		}

		private void selectItemButton_Click(object sender, EventArgs e)
		{
			if (m_selectedItem == string.Empty)
			{
				MessageBox.Show("아이템이 선택되지 않았습니다.");
				return;
			}

			this.DialogResult = DialogResult.OK;
			this.Hide();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Hide();
		}
	}
}
