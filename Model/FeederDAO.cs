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
		private const string AddFeederURL = "https://srl8nmr4qg.execute-api.eu-central-1.amazonaws.com/prod";
		private const string ChangeFeederPropertiesURL = "";

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

			HttpWebResponse httpWebResponse = (HttpWebResponse)request.GetResponse();
			Response response;
			try
			{ 
				using (Stream stream = httpWebResponse.GetResponseStream())
				{
					using (StreamReader reader = new StreamReader(stream))
					{
						string responseString = reader.ReadToEnd();
						response = JsonSerializer.Deserialize<Response>(responseString);
					}
				}
			}
			catch (JsonException e)
			{
				Console.WriteLine(e.Message);
				return null;
			}
			httpWebResponse.Close();

			return response;
		}

		public Response ChangeProperties(Feeder feeder)
		{
			string requestString = JsonSerializer.Serialize<Feeder>(feeder);

			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(ChangeFeederPropertiesURL);
			request.Headers.Add(apiKeyHeader);
			request.Method = "POST";
			byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(requestString);
			request.ContentType = "application/x-www-form-urlencoded";
			request.ContentLength = byteArray.Length;
			using (Stream dataStream = request.GetRequestStream())
			{
				dataStream.Write(byteArray, 0, byteArray.Length);
			}

			HttpWebResponse httpWebResponse = (HttpWebResponse)request.GetResponse();
			Response response;
			try 
			{ 
				using (Stream stream = httpWebResponse.GetResponseStream())
				{
					using (StreamReader reader = new StreamReader(stream))
					{
						string responseString = reader.ReadToEnd();
						response = JsonSerializer.Deserialize<Response>(responseString);
					}
				}
			}
			catch (JsonException e)
			{
				Console.WriteLine(e.Message);
				return null;
			}
			httpWebResponse.Close();

			return response;
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

			HttpWebResponse httpWebResponse = (HttpWebResponse)request.GetResponse();
			FeedersResponse response;
			try
			{ 
				using (Stream stream = httpWebResponse.GetResponseStream())
				{
					using (StreamReader reader = new StreamReader(stream))
					{
						string responseString = reader.ReadToEnd();
						response = JsonSerializer.Deserialize<FeedersResponse>(responseString);
					}
				}
			}
			catch (JsonException e)
			{
				Console.WriteLine(e.Message);
				return null;
			}
			httpWebResponse.Close();

			return response;
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

			HttpWebResponse httpWebResponse = (HttpWebResponse)request.GetResponse();
			Response response;
			try
			{ 
				using (Stream stream = httpWebResponse.GetResponseStream())
				{
					using (StreamReader reader = new StreamReader(stream))
					{
						string responseString = reader.ReadToEnd();
						response = JsonSerializer.Deserialize<Response>(responseString);
					}
				}
			}
			catch (JsonException e)
			{
				Console.WriteLine(e.Message);
				return null;
			}
			httpWebResponse.Close();

			return response;
		}
	}
}
