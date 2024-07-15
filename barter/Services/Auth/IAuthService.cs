using barter.Requests;
using barter.Responses;

namespace barter.Services.Auth
{
	public interface IAuthService
	{
		public Task<Response<AuthResponse>> Login(AuthRequest request);
	}
}
