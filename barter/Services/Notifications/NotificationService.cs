using barter.Models;
using barter.Requests;
using barter.Responses;
using barter.Services.Api;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;

namespace barter.Services.Notifications
{
	public class NotificationService : INotificationService
	{
		private IApiService ApiService { get; set; }
		private string endpoint = "api/notifications";


		public NotificationService()
		{
			ApiService = Service.GetService<IApiService>();
		}

		public async Task<Response<List<Notification>>> GetAllNotification()
		{
			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(endpoint);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<List<Notification>>();
					return new Response<List<Notification>>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<List<Notification>>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<List<Notification>>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<List<Notification>>> GetUserNotification(int UserId = 0)
		{
			try
			{
				string path = string.Format("{0}/user/{1}", endpoint, UserId);
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(path);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<List<Notification>>();
					return new Response<List<Notification>>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<List<Notification>>(Status.Error, null, errorMessage);
				}
			}
			catch (Exception Exception)
			{
				return new Response<List<Notification>>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Notification>> AddNotification(NotificationRequest request)
		{
			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().PostAsJsonAsync(
				endpoint, request);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Notification>();
					return new Response<Notification>(Status.Success, data);
				}
				/*else if (response.StatusCode == HttpStatusCode.BadRequest)
				{
					var errorContent = await response.Content.ReadAsStringAsync();
					var badRequestResponse = JsonConvert.DeserializeObject<BadRequest>(errorContent);
					var errorMessage = string.Join(";\n ", badRequestResponse.Errors.Select(e => e.Msg));
					return new Response<Notification>(Status.Error, null, errorMessage);
				}*/
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Notification>(Status.Error, null, errorMessage);
				}
			}
			catch (Exception Exception)
			{
				return new Response<Notification>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Notification>> MarkNotificationAsRead(Notification request)
		{
			try
			{
				string path = string.Format("{0}/{1}/read", endpoint, request._Id);

				HttpResponseMessage response = await this.ApiService.GetClient().PutAsJsonAsync(
					path, request);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Notification>();
					return new Response<Notification>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Notification>(Status.Error, null, errorMessage);
				}
			}
			catch (Exception Exception)
			{
				return new Response<Notification>(Status.Error, null, Exception.Message);
			}
		}
	}
}
