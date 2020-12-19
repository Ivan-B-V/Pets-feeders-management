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
            day1[0] = firstDateTimePicker1.Value.Hour.ToString() + ":" + firstDateTimePicker1.Value.Minute.ToString();
            day1[1] = firstDateTimePicker2.Value.Hour.ToString() + ":" + firstDateTimePicker2.Value.Minute.ToString();
            day1[2] = firstDateTimePicker3.Value.Hour.ToString() + ":" + firstDateTimePicker3.Value.Minute.ToString();
            day1[3] = firstDateTimePicker4.Value.Hour.ToString() + ":" + firstDateTimePicker4.Value.Minute.ToString();
            day1[4] = firstDateTimePicker5.Value.Hour.ToString() + ":" + firstDateTimePicker5.Value.Minute.ToString();

            string[] day2 = new string[5];
            day2[0] = secondDateTimePicker1.Value.Hour.ToString() + ":" + secondDateTimePicker1.Value.Minute.ToString();
            day2[1] = secondDateTimePicker2.Value.Hour.ToString() + ":" + secondDateTimePicker2.Value.Minute.ToString();
            day2[2] = secondDateTimePicker3.Value.Hour.ToString() + ":" + secondDateTimePicker3.Value.Minute.ToString();
            day2[3] = secondDateTimePicker4.Value.Hour.ToString() + ":" + secondDateTimePicker4.Value.Minute.ToString();
            day2[4] = secondDateTimePicker5.Value.Hour.ToString() + ":" + secondDateTimePicker5.Value.Minute.ToString();

            presenter.SetSchedule(_feederID, day1, day2);
        }

        public void ShowMessage(string message)
		{
            MessageBox.Show(message);
        }
    }
}
