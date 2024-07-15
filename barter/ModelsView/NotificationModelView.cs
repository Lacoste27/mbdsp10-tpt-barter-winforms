using barter.Models;
using barter.Responses;
using barter.Services.Notifications;

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
			var response = await NotificationService.GetUserNotification(1);

			if (response.Status == Status.Success)
			{
				return response.Data;
			}
			else
			{
				MessageBox.Show(response.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
	}
}
