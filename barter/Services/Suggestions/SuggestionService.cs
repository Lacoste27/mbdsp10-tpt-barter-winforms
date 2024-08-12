using barter.Models;
using barter.Requests;
using barter.Responses;
using barter.Services.Api;
using barter.Utils;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;

namespace barter.Services.Suggestions
{
	public class SuggestionService : ISuggestionService
	{
		private IApiService ApiService { get; set; }
		private string endpoint = "api/suggestions";

		public SuggestionService()
		{
			ApiService = Service.GetService<IApiService>();
		}

		public async Task<Response<ListResponse<Suggestion>>> GetUserSuggestion(string status = "PENDNG", int page = 1, int limit = 10)
		{
			int userId = TokenStorage.GetUserId();

			string url = $"{endpoint}/user/{userId}?page={page}&limit={limit}&status={status}";

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(url);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<ListResponse<Suggestion>>();
					return new Response<ListResponse<Suggestion>>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<ListResponse<Suggestion>>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<ListResponse<Suggestion>>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Suggestion>> SendSuggestion(SuggestionRequest request)
		{
			string path = $"{endpoint}/send";

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().PostAsJsonAsync(
				path, request);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Suggestion>();
					return new Response<Suggestion>(Status.Success, data);
				}
				/*else if (response.StatusCode == HttpStatusCode.BadRequest)
				{
					var errorContent = await response.Content.ReadAsStringAsync();
					var badRequestResponse = JsonConvert.DeserializeObject<BadRequest>(errorContent);
					var errorMessage = string.Join(";\n ", badRequestResponse.Errors.Select(e => e.Msg));
					return new Response<Suggestion>(Status.Error, null, errorMessage);
				}*/
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Suggestion>(Status.Error, null, errorMessage);
				}
			}
			catch (Exception Exception)
			{
				return new Response<Suggestion>(Status.Error, null, Exception.Message, Exception);
			}
		}
	}
}
