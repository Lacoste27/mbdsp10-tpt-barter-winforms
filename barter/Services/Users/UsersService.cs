using barter.Models;
using barter.Responses;
using barter.Services.Api;
using System.Net.Http.Json;

namespace barter.Services.Users
{
	public class UsersService : IUsersService
	{
		private IApiService ApiService { get; set; }
		private string endpoint = "api/users";


		public UsersService()
		{
			ApiService = Service.GetService<IApiService>();
		}

		public async Task<Response<List<User>>> GetAllUser()
		{
			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(endpoint);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<List<User>>();
					return new Response<List<User>>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<List<User>>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<List<User>>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<User>> GetUserById(int Id)
		{
			string path = string.Format("{0}/{1}", endpoint, Id);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(path);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<User>();
					return new Response<User>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<User>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<User>(Status.Error, null, Exception.Message);
			}
		}
	}
}
