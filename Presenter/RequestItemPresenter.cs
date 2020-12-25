using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.IViews;
using Model;
using Entities;

namespace Presenter
{
	public class RequestItemPresenter
	{
		IRequestItemView _requestItemView;
		UserService userService;

		public RequestItemPresenter(IRequestItemView requestItemView)
		{
			_requestItemView = requestItemView;
			userService = new UserService();
		}

		public void GetUserRequest(int requestID)
		{
			UserRequest request = userService.GetRequest(requestID);
			_requestItemView.UpdateInformation(request.Username);
		}
	}
}
