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
using System.Reflection;

namespace PetsFeeder
{
    public partial class SetScheduleUserControl : UserControl, ISetScheduleView
    {
        SetSchedulePresenter presenter;
        private int _feederID;
        public SetScheduleUserControl(int feederID)
        {
            InitializeComponent();
            presenter = new SetSchedulePresenter(this);
            _feederID = feederID;
            presenter.LoadSchedule(feederID);
        }

        private void SetScheduleUserControl_Load(object sender, EventArgs e)
        {
            
        }

        public void ImportSchedule(string[] day1, string[] day2)
        {
            char[] separators = { ':' };
            string[] t;
            DateTime time;

            DateTimePicker[] first = new DateTimePicker[5];
            first[0] = firstDateTimePicker1;
            first[1] = firstDateTimePicker2;
            first[2] = firstDateTimePicker3;
            first[3] = firstDateTimePicker4;
            first[4] = firstDateTimePicker5;
            for (int i = 0; i < day1.Length; i++)
			{
                t = day1[i].Split(separators);
                time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(t[0]), int.Parse(t[1]), 0);
                first[i].Value = time;
            }

            DateTimePicker[] second = new DateTimePicker[5];
            second[0] = secondDateTimePicker1;
            second[1] = secondDateTimePicker2;
            second[2] = secondDateTimePicker3;
            second[3] = secondDateTimePicker4;
            second[4] = secondDateTimePicker5;
            for (int i = 0; i < day1.Length; i++)
            {
                t = day2[i].Split(separators);
                time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(t[0]), int.Parse(t[1]), 0);
                second[i].Value = time;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string[] day1;
            string[] day2;
            CollectTime(out day1, out day2);

            bool[] day1Check;
            bool[] day2Check;
			CollectCheckboxes(out day1Check, out day2Check);

            presenter.SetSchedule(_feederID, day1, day1Check, day2, day2Check);
        }

        private void CollectTime(out string[] day1, out string[] day2)
		{
            day1 = new string[5];
            day1[0] = firstDateTimePicker1.Value.ToShortTimeString();
            day1[1] = firstDateTimePicker2.Value.ToShortTimeString();
            day1[2] = firstDateTimePicker3.Value.ToShortTimeString();
            day1[3] = firstDateTimePicker4.Value.ToShortTimeString();
            day1[4] = firstDateTimePicker5.Value.ToShortTimeString();
            day2 = new string[5];
            day2[0] = secondDateTimePicker1.Value.ToShortTimeString();
            day2[1] = secondDateTimePicker2.Value.ToShortTimeString();
            day2[2] = secondDateTimePicker3.Value.ToShortTimeString();
            day2[3] = secondDateTimePicker4.Value.ToShortTimeString();
            day2[4] = secondDateTimePicker5.Value.ToShortTimeString();
        }
        private void CollectCheckboxes(out bool[] day1Check, out bool[] day2Check)
		{
            day1Check = new bool[5];
            day1Check[0] = firstDayTime1.Checked;
            day1Check[1] = firstDayTime2.Checked;
            day1Check[2] = firstDayTime3.Checked;
            day1Check[3] = firstDayTime4.Checked;
            day1Check[4] = firstDayTime5.Checked;
            day2Check = new bool[5];
            day2Check[0] = secondDayTime1.Checked;
            day2Check[1] = secondDayTime2.Checked;
            day2Check[2] = secondDayTime3.Checked;
            day2Check[3] = secondDayTime4.Checked;
            day2Check[4] = secondDayTime5.Checked;
        }

        public void ShowMessage(string message)
		{
            MessageBox.Show(message);
        }

		private void ExportButton_Click(object sender, EventArgs e)
		{
            if (!(saveFileDialog.ShowDialog() == DialogResult.OK))
            {
                return;
            }

            string[] day1;
            string[] day2;
            CollectTime(out day1, out day2);

            presenter.ExportSchedule(day1, day2, saveFileDialog.FileName);
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            if (!(openFileDialog.ShowDialog() == DialogResult.OK))
            {
                return;
            }

            presenter.ImportSchedule(openFileDialog.FileName);
		}
	}
}
