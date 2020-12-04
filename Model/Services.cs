using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.Json;

namespace Model
{
	class Services
	{
		private string keyHeader = "x-api-key: SMmRuTFKGzsQ0WtvI5z46qjDeHfv260249fYxyQ6";
		public void SendRequest(string requestString)
		{
			string site = "https://7zws77q7z3.execute-api.eu-central-1.amazonaws.com/prod/";
			HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(site);

			req.Headers.Add(keyHeader);
			req.Method = "POST";

			byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(requestString);
			req.ContentType = "application/x-www-form-urlencoded";
			req.ContentLength = byteArray.Length;

			using (Stream dataStream = req.GetRequestStream())
			{
				dataStream.Write(byteArray, 0, byteArray.Length);
			}
		}

		public string GetResponse(string requestString)
		{ 
			string site = "https://owlaxhfe2b.execute-api.eu-central-1.amazonaws.com/prod/";
			HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(site);

			req.Headers.Add(keyHeader);
			req.Method = "POST";

			byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(requestString);
			req.ContentType = "application/x-www-form-urlencoded";
			req.ContentLength = byteArray.Length;

			using (Stream dataStream = req.GetRequestStream())
			{
				dataStream.Write(byteArray, 0, byteArray.Length);
			}

			HttpWebResponse response = (HttpWebResponse) req.GetResponse();
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

			return resp.body;
		}
	}
}
