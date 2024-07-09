using barter.Services.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Services.Auth
{
	public class AuthService  : IAuthService
	{
		private IApiService ApiService { get; set; }
		private string endpoint = "api/auth";


		public AuthService()
		{
			ApiService = Service.GetService<IApiService>();
		}
	}
}
