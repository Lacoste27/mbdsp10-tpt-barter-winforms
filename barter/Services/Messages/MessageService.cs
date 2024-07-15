using barter.Services.Api;

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
