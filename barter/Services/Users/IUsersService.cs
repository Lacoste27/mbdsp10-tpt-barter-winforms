using barter.Models;
using barter.Responses;

namespace barter.Services.Users
{
	public interface IUsersService
	{
		public Task<Response<List<User>>> GetAllUser();
		public Task<Response<User>> GetUserById(int id);
	}
}
