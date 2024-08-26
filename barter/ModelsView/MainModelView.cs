using barter.Models;
using barter.Responses;
using barter.Services.Notifications;
using barter.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.ModelsView
{
	public class MainModelView
	{
		private INotificationService NotificationService { get; set; }

		public MainModelView()
		{
			NotificationService = Service.GetService<INotificationService>();
		}

		public async Task<List<Notification>> GetNotifications()
		{
			int userId = TokenStorage.GetUserId();
			var response = await NotificationService.GetUserNotification(userId);

			if (response.Status == Status.Success)
			{
				return response.Data.OrderBy(notification => notification.CreatedAt).ThenByDescending(notification => notification.IsRead).ToList();
			}
			else
			{
				MessageBox.Show(response.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		public async Task<Boolean> HasNewNotification()
		{
			int userId = TokenStorage.GetUserId();
			var response = await NotificationService.GetUserNotification(userId);

			if (response.Status == Status.Success)
			{
				List<Notification> notifications = response.Data.OrderBy(notification => notification.CreatedAt).ThenByDescending(notification => notification.IsRead).ToList();
				return notifications.Any(notification => notification.IsRead == false);
			}
			else
			{
				MessageBox.Show(response.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
	}
}
