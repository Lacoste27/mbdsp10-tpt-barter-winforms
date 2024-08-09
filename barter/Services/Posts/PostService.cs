using barter.Models;
using barter.Requests;
using barter.Responses;
using barter.Services.Api;
using barter.Utils;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;

namespace barter.Services.Posts
{
	public class PostService : IPostService
	{
		private IApiService ApiService { get; set; }
		private string endpoint = "api/posts";

		public PostService()
		{
			ApiService = Service.GetService<IApiService>();
		}

		public async Task<Response<ListResponse<Post>>> GetAllPosts(int page = 1, int limit = 10)
		{
			int userId = TokenStorage.GetUserId();
			string url = $"{endpoint}/explore/{userId}?page={page}&limit={limit}";

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(url);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<ListResponse<Post>>();
					return new Response<ListResponse<Post>>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<ListResponse<Post>>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<ListResponse<Post>>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<ListResponse<Post>>> GetUserPost(int userId, int page = 1, int limit = 10)
		{
			string path = string.Format("{0}/user/{1}", endpoint, userId);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(path);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<ListResponse<Post>>();
					return new Response<ListResponse<Post>>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<ListResponse<Post>>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<ListResponse<Post>>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Post>> GetPostById(int Id)
		{
			string path = string.Format("{0}/{1}", endpoint, Id);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(path);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Post>();
					return new Response<Post>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Post>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<Post>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Post>> AddPost(PostRequest request)
		{
			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().PostAsJsonAsync(
				endpoint, request);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Post>();
					return new Response<Post>(Status.Success, data);
				}
				else if (response.StatusCode == HttpStatusCode.BadRequest)
				{
					var errorContent = await response.Content.ReadAsStringAsync();
					var badRequestResponse = JsonConvert.DeserializeObject<BadRequest>(errorContent);
					var errorMessage = string.Join(";\n ", badRequestResponse.Errors.Select(e => e.Msg));
					return new Response<Post>(Status.Error, null, errorMessage);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Post>(Status.Error, null, errorMessage);
				}
			}
			catch (Exception Exception)
			{
				return new Response<Post>(Status.Error, null, Exception.Message, Exception);
			}
		}
	}
}
