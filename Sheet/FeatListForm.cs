using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sheet
{
	public partial class FeatListForm : Form
	{
		string m_selectedFeat = string.Empty;

		public string SelectedFeat { get { return m_selectedFeat; } }

		public FeatListForm()
		{
			InitializeComponent();
			DisplayFeatList();
		}

		public FeatListForm(string featCode)
		{
			InitializeComponent();
			DisplayFeatList();

			// 입력받은 코드에 해당하는 피트가 있으면 해당 피트를 선택한 상태로 만든다.
			ListViewItem[] items = featListView.Items.Find(featCode, false);
			if (items.Length > 0) items[0].Selected = true;
			//DisplayFeatInfo(featCode);
		}

		public void DisplayFeatList()
		{
			featListView.Items.Clear();
			foreach (FeatInfo feat in DataManager.Instance.FeatData.Values)
			{
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = feat.Name;
				listViewItem.Name = feat.Code;
				featListView.Items.Add(listViewItem);
			}
		}

		public void DisplayFeatInfo(string featCode)
		{
			// 피트 존재 여부 체크.
			if (!DataManager.Instance.FeatData.ContainsKey(featCode))
			{
				MessageBox.Show("'" + featCode + "' : 존재하지 않는 피트 코드입니다.");
				return;
			}

			// 피트 정보 가져오기
			FeatInfo feat = DataManager.Instance.FeatData[featCode];

			// 피트 정보 문자열로 생성
			string msg = "";
			msg += "이름 : " + feat.Name + "\r\n";
			msg += "설명 : " + feat.Description + "\r\n";

			// 출력
			featInfoTextBox.Text = msg;
		}

		private void featListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (featListView.SelectedItems.Count < 1) return;

			m_selectedFeat = featListView.SelectedItems[0].Name;
			DisplayFeatInfo(m_selectedFeat);
		}

		private void selectFeatButton_Click(object sender, EventArgs e)
		{
			if (m_selectedFeat == string.Empty)
			{
				MessageBox.Show("피트가 선택되지 않았습니다.");
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
