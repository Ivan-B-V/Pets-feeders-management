﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.IViews
{
    public interface ISetScheduleView
    {
        void ImportSchedule(string[] day1, string[] day2);
        void ShowMessage(string message);
    }
}
