using barter.Components;
using barter.ModelsView;

namespace barter.Windows
{
	public partial class Notification : Form
	{
		private NotificationModelView NotificationModelView { get; set; } = new NotificationModelView();
		private List<Models.Notification> Notifications { get; set; }

		public Notification()
		{
			InitializeComponent();
		}

		public Notification(int UserId)
		{
			InitializeComponent();
		}

		private async void Notification_Load(object sender, EventArgs e)
		{
			var notifications = await NotificationModelView.GetNotifications();

			if (notifications is not null)
			{
				this.Notifications = notifications;

				foreach (var notification in notifications)
				{
					NotificationView view = new NotificationView(notification);
					notificationPanel.Controls.Add(view);
				}
			}
		}

		private async void Notification_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				List<Models.Notification> unreadNotifications = this.Notifications.Where(notification => !notification.IsRead).ToList();

				await this.NotificationModelView.MarkNotificationRead(unreadNotifications);
			}
			catch (Exception Exception)
			{
				MessageBox.Show(Exception.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
