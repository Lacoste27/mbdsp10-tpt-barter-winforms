using barter.Models;
using barter.Responses;
using barter.Services.Notifications;
using barter.Utils;

namespace barter.ModelsView
{
	public class NotificationModelView
	{
		private INotificationService NotificationService { get; set; }

		public NotificationModelView()
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
	}
}
