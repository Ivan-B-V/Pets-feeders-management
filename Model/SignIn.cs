﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Model
{
	public class SignIn
	{
		public User SignInTry(User user)
		{
			Services services = Services.GetInstance();

			string requestString = JsonSerializer.Serialize<User>(user);

			Response response = services.SignIn(requestString);

			if (response == null)
			{
				return null;
			}

			User userInfo = new User(response);

			services.userInfo = userInfo;

			return userInfo;
		}
	}
}
