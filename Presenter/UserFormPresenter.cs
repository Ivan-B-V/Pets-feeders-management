﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Collections;
using Presenter.IViews;
using Entities;

namespace Presenter
{
	public class UserFormPresenter
	{
		IUserView _userView;
		FeederService feederService;
		UserService userService;
		public UserFormPresenter(IUserView userView)
		{
			_userView = userView;
			feederService = new FeederService();
			userService = new UserService();
		}
		public void ShowFeeders()
		{
			ArrayList feeders = feederService.GetFeeders();
			
			if (feeders == null || feeders.Count == 0)
			{
				_userView.ShowMessage("No feeders found");
				return;
			}
			ArrayList IDs = new ArrayList();
			foreach (Feeder feeder in feeders)
			{
				IDs.Add(feeder.FeederID);
			}
			_userView.ShowFeeders(IDs);
		}
		public void LoadLogs()
		{
			string message = userService.LoadLogs();
			
			if (!"ok".Equals(message.ToLower()))
			{
				_userView.ShowMessage(message);
			}
		}
	}
}
