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
			Services services = Services.GetInstance();

			FeedersResponse response = services.FeedersRequest();

			services.userInfo.AddFeeders(response);

			return services.userInfo.GetFeeders();
		}
	}
}
