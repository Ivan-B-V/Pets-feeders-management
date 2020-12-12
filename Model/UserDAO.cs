using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net;
using System.IO;
using Entities;

namespace Model
{
	class UserDAO
	{
		private const string apiKeyHeader = "x-api-key: SMmRuTFKGzsQ0WtvI5z46qjDeHfv260249fYxyQ6";
		private const string SignInURL = "https://3a7sazfvyj.execute-api.eu-central-1.amazonaws.com/prod/";
		private const string RegisterURL = "https://m27yhhkfbd.execute-api.eu-central-1.amazonaws.com/prod";
		public Response SignIn(User user)
		{
			string requestString = JsonSerializer.Serialize<User>(user);
			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(SignInURL);
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

		public Response Register(User user)
		{
			string requestString = JsonSerializer.Serialize<User>(user);

			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(RegisterURL);
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
