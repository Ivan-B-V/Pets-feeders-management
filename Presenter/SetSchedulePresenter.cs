using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.IViews;
using Model;
using System.Collections;

namespace Presenter
{
    public class SetSchedulePresenter
    {
        ISetScheduleView _setScheduleView;
        FeederService feederService;
        public SetSchedulePresenter(ISetScheduleView setScheduleView)
        {
            _setScheduleView = setScheduleView;
            feederService = new FeederService();
        }
        public void SetSchedule(int feederID, string[] day1, bool[] day1Check, string[] day2, bool[] day2Check)
		{
            ArrayList day1Schedule = new ArrayList();
            for (int i = 0; i < day1Check.Length; i++)
            { 
                if (day1Check[i])
        		{
                    day1Schedule.Add(day1[i]);
        		}
            }
            ArrayList day2Schedule = new ArrayList();
            for (int i = 0; i < day2Check.Length; i++)
            {
                if (day2Check[i])
                {
                    day2Schedule.Add(day2[i]);
                }
            }
            string message = feederService.SetSchedule(feederID, day1Schedule, day2Schedule);
            _setScheduleView.ShowMessage(message);
		}

        public void ExportSchedule(string[] day1, string[] day2, string fileName)
		{
            ArrayList day1Schedule = new ArrayList();
            for (int i = 0; i < day1.Length; i++)
            {
                day1Schedule.Add(day1[i]);
            }
            ArrayList day2Schedule = new ArrayList();
            for (int i = 0; i < day2.Length; i++)
            {
                day2Schedule.Add(day2[i]);
            }
            string message = feederService.ExportSchedule(day1Schedule, day2Schedule, fileName);
            _setScheduleView.ShowMessage(message);
        }

        public void ImportSchedule(string fileName)
		{
            string[] day1;
            string[] day2;
            bool done = feederService.ImportSchedule(fileName, out day1, out day2);

            if (!done)
			{
                _setScheduleView.ShowMessage("shit happens");
                return;
			}

            _setScheduleView.ImportSchedule(day1, day2);
        }
    }
}
