using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter;
using Presenter.IViews;

namespace PetsFeeder
{
    public partial class LogsUserControl : UserControl, ILogsUserControlView
    {
        LogsUserControlPresenter presenter;
        public LogsUserControl()
        {
            InitializeComponent();
            presenter = new LogsUserControlPresenter(this);
            presenter.GetLogs();
        }

        public void ImportLogs(string username, string time, string data)
		{
            LogsListItem item = new LogsListItem(username, time, data);
            flowLogsPanel.Controls.Add(item);
		}

        public void ShowMessage(string message)
		{
            MessageBox.Show(message);
		}

		private void exportButton_Click(object sender, EventArgs e)
		{
            if (!(saveFileDialog.ShowDialog() == DialogResult.OK))
            {
                return;
            }

            presenter.ExportLogs(saveFileDialog.FileName);
        }
	}
}
