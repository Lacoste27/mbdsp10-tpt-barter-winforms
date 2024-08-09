using barter.Components;
using barter.ModelsView;

namespace barter.Windows
{
	public partial class Notification : Form
	{
		private NotificationModelView NotificationModelView { get; set; } = new NotificationModelView();

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
				foreach (var notification in notifications)
				{
					NotificationView view = new NotificationView(notification);
					notificationPanel.Controls.Add(view);
				}
			}
		}
	}
}
