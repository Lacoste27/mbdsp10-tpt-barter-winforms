﻿using barter.Services.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Services.Messages
{
	public class MessageService : IMessageService
	{
		private IApiService ApiService { get; set; }
		private string endpoint = "api/chats";

		public MessageService()
		{
			ApiService = Service.GetService<IApiService>();
		}
	}
}
