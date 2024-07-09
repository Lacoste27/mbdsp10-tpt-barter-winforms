using barter.Models;
using barter.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Services.Users
{
	public interface IUsersService
	{
		public Task<Response<List<User>>> GetAllUser();
		public Task<Response<User>> GetUserById(int id);
	}
}
