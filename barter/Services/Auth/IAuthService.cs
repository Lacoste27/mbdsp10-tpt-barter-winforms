using barter.Requests;
using barter.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Services.Auth
{
	public interface IAuthService
	{
		public Task<Response<AuthResponse>> Login(AuthRequest request);
	}
}
