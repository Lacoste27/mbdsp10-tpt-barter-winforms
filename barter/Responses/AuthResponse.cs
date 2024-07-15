using barter.Models;

namespace barter.Responses
{
	public class AuthResponse
	{
		public User User { get; set; }
		public string Token { get; set; }
	}
}
