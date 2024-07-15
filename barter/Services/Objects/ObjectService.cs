using barter.Responses;
using barter.Services.Api;
using System.Net.Http.Json;

namespace barter.Services.Objects
{
	public class ObjectService : IObjectService
	{
		private IApiService ApiService { get; set; }
		private string endpoint = "api/objects";


		public ObjectService()
		{
			ApiService = Service.GetService<IApiService>();
		}

		public async Task<Response<List<Models.Object>>> GetAllObjects()
		{
			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(endpoint);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<List<Models.Object>>();
					return new Response<List<Models.Object>>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<List<Models.Object>>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<List<Models.Object>>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Models.Object>> GetUserObjects(int userId)
		{
			string path = string.Format("{0}/{1}", endpoint, userId);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(path);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Models.Object>();
					return new Response<Models.Object>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Models.Object>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<Models.Object>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Models.Object>> GetObjectByid(int Id)
		{
			string path = string.Format("{0}/{1}", endpoint, Id);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(path);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Models.Object>();
					return new Response<Models.Object>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Models.Object>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<Models.Object>(Status.Error, null, Exception.Message);
			}
		}
	}
}
