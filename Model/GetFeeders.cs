using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Model
{
	public class GetFeeders
	{
		public ArrayList TryGetFeeders()
		{
			Services servises = Services.GetInstance();

			FeedersResponse response = servises.FeedersRequest();

			servises.userInfo.AddFeeders(response);

			return servises.userInfo.GetFeeders();
		}
	}
}
