using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.IViews
{
    public interface ISetScheduleView
    {
        void ImportSchedule();
        void ExportSchedule();
        void ShowMessage(string message);
    }
}
