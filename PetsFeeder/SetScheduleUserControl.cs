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
    public partial class SetScheduleUserControl : UserControl, ISetScheduleView
    {
        SetSchedulePresenter presenter;
        private int _feederID;
        public SetScheduleUserControl(int feederID)
        {
            InitializeComponent();
            presenter = new SetSchedulePresenter(this);
            _feederID = feederID;
        }

        private void SetScheduleUserControl_Load(object sender, EventArgs e)
        {
            
        }

        public void ImportSchedule()
        {
            throw new NotImplementedException();
        }

        public void ExportSchedule()
        {
            throw new NotImplementedException();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string[] day1 = new string[5];
            day1[0] = firstDateTimePicker1.Value.ToShortTimeString();
            day1[1] = firstDateTimePicker2.Value.ToShortTimeString();
            day1[2] = firstDateTimePicker3.Value.ToShortTimeString();
            day1[3] = firstDateTimePicker4.Value.ToShortTimeString();
            day1[4] = firstDateTimePicker5.Value.ToShortTimeString();
            bool[] day1Check = new bool[5];
            day1Check[0] = firstDayTime1.Checked;
            day1Check[1] = firstDayTime2.Checked;
            day1Check[2] = firstDayTime3.Checked;
            day1Check[3] = firstDayTime4.Checked;
            day1Check[4] = firstDayTime5.Checked;

            string[] day2 = new string[5];
            day2[0] = secondDateTimePicker1.Value.ToShortTimeString();
            day2[1] = secondDateTimePicker2.Value.ToShortTimeString();
            day2[2] = secondDateTimePicker3.Value.ToShortTimeString();
            day2[3] = secondDateTimePicker4.Value.ToShortTimeString();
            day2[4] = secondDateTimePicker5.Value.ToShortTimeString();
            bool[] day2Check = new bool[5];
            day2Check[0] = secondDayTime1.Checked;
            day2Check[1] = secondDayTime2.Checked;
            day2Check[2] = secondDayTime3.Checked;
            day2Check[3] = secondDayTime4.Checked;
            day2Check[4] = secondDayTime5.Checked;

            presenter.SetSchedule(_feederID, day1, day1Check, day2, day2Check);
        }

        public void ShowMessage(string message)
		{
            MessageBox.Show(message);
        }
    }
}
