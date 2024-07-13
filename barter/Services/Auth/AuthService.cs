using barter.Requests;
using barter.Responses;
using barter.Services.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
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

		public async Task<Response<AuthResponse>> Login(AuthRequest request)
		{
			string path = string.Format("{0}/login", endpoint);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient(false).PostAsJsonAsync(
				path, request);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<AuthResponse>();
					return new Response<AuthResponse>(Status.Success, data);
				}
				else if (response.StatusCode == HttpStatusCode.BadRequest)
				{
					var errorContent = await response.Content.ReadAsStringAsync();
					var badRequestResponse = JsonConvert.DeserializeObject<BadRequest>(errorContent);
					var errorMessage = string.Join(";\n ", badRequestResponse.Errors.Select(e => e.Msg));
					return new Response<AuthResponse>(Status.Error, null, errorMessage);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<AuthResponse>(Status.Error, null, errorMessage);
				}
			}
			catch (Exception Exception)
			{
				return new Response<AuthResponse>(Status.Error, null, Exception.Message, Exception);
			}
		}
	}
}
