using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Presenter.IViews
{
	public interface IFeederListControlView
	{
		void UpdateSelectedFeeder(string name, string tag, int amount);
		void SetFeederData(string name, string tag);
		void ShowMessage(string message);
	}
}
