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
