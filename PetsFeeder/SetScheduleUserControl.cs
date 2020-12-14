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
        SetSchedulePresenter schedulePresenter;

        public SetScheduleUserControl()
        {
            InitializeComponent();
            schedulePresenter = new SetSchedulePresenter(this);
        }

        private void SetScheduleUserControl_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        public void GoBack()
        {
            this.Hide();
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

        }
    }
}
