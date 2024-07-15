using barter.Models;
using barter.Requests;
using barter.Responses;
using barter.Services.Api;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Http.Json;

namespace barter.Services.Categories
{
	public class CategoryService : ICategoryService
	{
		private IApiService ApiService { get; set; }
		private string endpoint = "api/categories";


		public CategoryService()
		{
			ApiService = Service.GetService<IApiService>();
		}

		public async Task<Response<List<Category>>> GetAllCategory()
		{
			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(endpoint);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<List<Category>>();
					return new Response<List<Category>>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<List<Category>>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<List<Category>>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Category>> GetCategoryById(int Id)
		{
			string path = string.Format("{0}/{1}", endpoint, Id);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(path);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Category>();
					return new Response<Category>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Category>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<Category>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Category>> AddCategory(CategoryRequest request)
		{
			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().PostAsJsonAsync(
				endpoint, request);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Category>();
					return new Response<Category>(Status.Success, data);
				}
				else if (response.StatusCode == HttpStatusCode.BadRequest)
				{
					var errorContent = await response.Content.ReadAsStringAsync();
					var badRequestResponse = JsonConvert.DeserializeObject<BadRequest>(errorContent);
					var errorMessage = string.Join(";\n ", badRequestResponse.Errors.Select(e => e.Msg));
					return new Response<Category>(Status.Error, null, errorMessage);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Category>(Status.Error, null, errorMessage);
				}
			}
			catch (Exception Exception)
			{
				return new Response<Category>(Status.Error, null, Exception.Message, Exception);
			}
		}
	}
}
