using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class GetFeeders
	{
		public void TryGetFeeders()
		{
			Services servises = Services.GetInstance();

			FeedersResponse response = servises.FeedersRequest();

			servises.userInfo.AddFeeders(response);
		}
	}
}
