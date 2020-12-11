﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Model
{
	public class Response
	{
		public int statusCode { get; set; }
		public Dictionary<string, string> headers { get; set; }
		public Dictionary<string, JsonElement> body { get; set; }
	}
}