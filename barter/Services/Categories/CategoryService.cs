using barter.Models;
using barter.Responses;
using barter.Services.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace barter.Services.Categories
{
	public class CategoryService  : ICategoryService
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
	}
}
