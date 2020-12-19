using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.IViews;
using Model;

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
        public void SetSchedule(int feederID, string[] day1, string[] day2)
		{
            string message = feederService.SetSchedule(feederID, day1, day2);
            _setScheduleView.ShowMessage(message);
		}
    }
}
