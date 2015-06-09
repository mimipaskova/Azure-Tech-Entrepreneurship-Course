﻿using System;

namespace ChatBackend.Models
{
	public class Message
	{
		public string Text { get; set; }

		public string User { get; set; }

		public DateTimeOffset Date { get; set; }
	}
}