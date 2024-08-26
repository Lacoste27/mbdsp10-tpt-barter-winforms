using barter.Components;
using barter.Models;
using barter.Services.Categories;
using barter.Services.Messages;
using barter.Services.Posts;
using barter.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.ModelsView
{
	public class ChatModelView
	{
		private IMessageService MessageService { get; set; }

		public ChatModelView()
		{
			MessageService = Service.GetService<IMessageService>();
		}

		public async Task<List<Chat>> GetUserChat()
		{
			int userId = TokenStorage.GetUserId();

			var response = await MessageService.GetUserChat(userId);

			if (response.Status == Responses.Status.Success)
			{
				return response.Data;
			}
			else
			{
				MessageBox.Show(response.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		public async Task<Chat> ContinueChat(string chatId, Models.Message message)
		{
			var response = await MessageService.ContinueChat(chatId, message);

			if (response.Status == Responses.Status.Success)
			{
				return response.Data;
			}
			else
			{
				MessageBox.Show(response.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
	}
}
