using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Text.Json;
using System.Net;
using System.IO;

namespace Model
{
	class FeederDAO
	{
		private const string apiKeyHeader = "x-api-key: SMmRuTFKGzsQ0WtvI5z46qjDeHfv260249fYxyQ6";
		private const string FeedURL = "https://ljpq64ubzi.execute-api.eu-central-1.amazonaws.com/prod/";
		private const string GetFeedersURL = "https://lkwhpvi6nf.execute-api.eu-central-1.amazonaws.com/prod";
		private const string AddFeederURL = "";

		private CurrentUserData _currentUserData;
		public FeederDAO()
		{
			_currentUserData = new CurrentUserData();
		}

		public Response Feed(Feeder feeder)
		{
			string requestString = JsonSerializer.Serialize<Feeder>(feeder);

			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(FeedURL);
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

		public FeedersResponse GetFeeders()
		{
			string requestString = JsonSerializer.Serialize<User>(_currentUserData.GetUser());

			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(GetFeedersURL);
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

		public Response AddFeeder(Feeder feeder)
		{
			string requestString = JsonSerializer.Serialize<Feeder>(feeder);

			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(AddFeederURL);
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
	}
}
