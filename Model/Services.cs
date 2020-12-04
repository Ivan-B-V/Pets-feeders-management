﻿using System;
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
		private static Services instance;
		private string keyHeader = "x-api-key: SMmRuTFKGzsQ0WtvI5z46qjDeHfv260249fYxyQ6";
		private User user;
		public User userInfo { get { return user; } set { user = value; } }

		private Services()
		{
			
		}

		public static Services GetInstance()
		{
			if(instance == null)
			{
				instance = new Services();
			}

			return instance;
		}

		public void SendRequest(string requestString)//????????????
		{
			string site = "https://7zws77q7z3.execute-api.eu-central-1.amazonaws.com/prod/";
			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(site);

			request.Headers.Add(keyHeader);
			request.Method = "POST";
			byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(requestString);
			request.ContentType = "application/x-www-form-urlencoded";
			request.ContentLength = byteArray.Length;

			using (Stream dataStream = request.GetRequestStream())
			{
				dataStream.Write(byteArray, 0, byteArray.Length);
			}
		}

		public FeedersResponse FeedersRequest()
		{
			string requestString = JsonSerializer.Serialize<User>(user);
			string site = "https://lkwhpvi6nf.execute-api.eu-central-1.amazonaws.com/prod";

			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(site);
			request.Headers.Add(keyHeader);
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
			string site = "https://3a7sazfvyj.execute-api.eu-central-1.amazonaws.com/prod/";

			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(site);
			request.Headers.Add(keyHeader);
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
