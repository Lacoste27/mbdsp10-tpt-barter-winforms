using barter.Models;
using barter.Responses;

namespace barter.Services.Messages
{
	public interface IMessageService
	{
		public Task<Response<List<Chat>>> GetUserChat(int userId);
	}
}
