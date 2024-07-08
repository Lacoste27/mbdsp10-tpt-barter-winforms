using barter.Models;
using barter.Services.Api;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

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

		public async Task<List<Notification>> GetUserNotification()
		{
			List<Notification> result = new List<Notification>();

			HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(endpoint);

			if (response.IsSuccessStatusCode)
			{
				result = await response.Content.ReadFromJsonAsync<List<Notification>>();
			}

			return result;
		}

		public async Task<List<Notification>> GetUserNotification(int UserId)
		{
			string path = string.Format("{0}/user/{1}", endpoint, UserId);
			List<Notification>? result = new List<Notification>();

			HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(path);

			if (response.IsSuccessStatusCode) {
				result = await response.Content.ReadFromJsonAsync<List<Notification>>();
			}

			return result;
		}
	}
}
