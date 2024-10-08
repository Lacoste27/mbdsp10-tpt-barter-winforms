﻿using barter.Models;
using barter.Responses;
using barter.Services.Api;
using System.Net.Http.Json;

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

		public async Task<Response<List<Chat>>> GetUserChat(int userId)
		{
			string path = string.Format("{0}/user/{1}", endpoint, userId);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(path);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<List<Chat>>();
					return new Response<List<Chat>>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<List<Chat>>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<List<Chat>>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Chat>> ContinueChat(string chatId, Models.Message message)
		{
			string path = string.Format("{0}/continue/{1}", endpoint, chatId);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(path);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Chat>();
					return new Response<Chat>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Chat>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<Chat>(Status.Error, null, Exception.Message);
			}
		}
	}
}
