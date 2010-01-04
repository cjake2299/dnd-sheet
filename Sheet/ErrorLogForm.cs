using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sheet
{
    public partial class ErrorLogForm : Form
    {
		public ErrorLogForm()
		{
			InitializeComponent();
		}

		public void ViewErrors()
		{
			// 에러 로그가 없다면 에러 로그 창을 띄우지 않는다.
			if (LogManager.Instance.GetErrorCount() < 1)
				return;

			LoadErrorLogs();
			this.ShowDialog();
		}

        private void LoadErrorLogs()
        {
            errorLabel.Text = "작업 도중 총 " + LogManager.Instance.GetErrorCount() + " 개의 오류가 발견되었습니다.";

            foreach (ErrorLog msg in LogManager.Instance.Logs)
            {
                errorLogDataGridView.Rows.Add(msg.TaskName, msg.Message, msg.Description);
            }

			LogManager.Instance.ClearLog();
        }
    }
}
