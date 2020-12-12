using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.Json;
using Entities;

namespace Model
{
	class Services
	{
		private static Services instance;
		private const string apiKeyHeader = "x-api-key: SMmRuTFKGzsQ0WtvI5z46qjDeHfv260249fYxyQ6";
		private const string FeedURL = "https://ljpq64ubzi.execute-api.eu-central-1.amazonaws.com/prod/";
		private const string GetFeedersURL = "https://lkwhpvi6nf.execute-api.eu-central-1.amazonaws.com/prod";
		private const string SignInURL = "https://3a7sazfvyj.execute-api.eu-central-1.amazonaws.com/prod/";
		private User user;
		public User userInfo { get { return user; } set { user = value; } }
		CurrentUserData _currentUserData;
		private Services()
		{
			_currentUserData = new CurrentUserData();
		}

		public static Services GetInstance()
		{
			if(instance == null)
			{
				instance = new Services();
			}
			
			return instance;
		}

		public Response Feed(Feeder feeder)
		{
			string requestString = JsonSerializer.Serialize<Feeder>(feeder);
			string site = FeedURL;

			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(site);
			request.Headers.Add(apiKeyHeader);
			request.Method = "POST";
			byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(requestString);
			request.ContentType = "application/x-www-form-urlencoded";
			request.ContentLength = byteArray.Length;
			using (Stream dataStream = request.GetRequestStream())
			{
				dataStream.Write(byteArray, 0, byteArray.Length);
			}

			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			Response resp;
			using (Stream stream = response.GetResponseStream())
			{
				using (StreamReader reader = new StreamReader(stream))
				{
					string responseString = reader.ReadToEnd();
					resp = JsonSerializer.Deserialize<Response>(responseString);
				}
			}
			response.Close();

			return resp;
		}

		public FeedersResponse FeedersRequest()
		{
			string requestString = JsonSerializer.Serialize<User>(_currentUserData.GetUser());
			string site = GetFeedersURL;

			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(site);
			request.Headers.Add(apiKeyHeader);
			request.Method = "POST";
			byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(requestString);
			request.ContentType = "application/x-www-form-urlencoded";
			request.ContentLength = byteArray.Length;
			using (Stream dataStream = request.GetRequestStream())
			{
				dataStream.Write(byteArray, 0, byteArray.Length);
			}

			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			FeedersResponse resp;
			using (Stream stream = response.GetResponseStream())
			{
				using (StreamReader reader = new StreamReader(stream))
				{
					string responseString = reader.ReadToEnd();
					resp = JsonSerializer.Deserialize<FeedersResponse>(responseString);
				}
			}
			response.Close();

			return resp;
		}

		public Response SignIn(string requestString)
		{ 
			string site = SignInURL;

			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(site);
			request.Headers.Add(apiKeyHeader);
			request.Method = "POST";
			byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(requestString);
			request.ContentType = "application/x-www-form-urlencoded";
			request.ContentLength = byteArray.Length;

			using (Stream dataStream = request.GetRequestStream())
			{
				dataStream.Write(byteArray, 0, byteArray.Length);
			}

			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			Response resp;
			try
			{
				using (Stream stream = response.GetResponseStream())
				{
					using (StreamReader reader = new StreamReader(stream))
					{
						string responseString = reader.ReadToEnd();
						resp = JsonSerializer.Deserialize<Response>(responseString);
					}
				}
			}
			catch (JsonException e)
			{
				Console.WriteLine(e.Message);
				return null;
			}
			response.Close();

			return resp;
		}
	}
}
