using barter.Models;
using barter.Responses;
using barter.Services.Api;
using barter.Services.Notifications;

namespace barter
{
	public partial class App : Form
	{

		private INotificationService NotificationService { get; set; }

		public App()
		{
			NotificationService = Service.GetService<INotificationService>();

			InitializeComponent();
		}

		private void App_Load(object sender, EventArgs e)
		{

		}

		private async void label1_Click(object sender, EventArgs e)
		{
			var response = await NotificationService.GetUserNotification();

			this.Invoke((Action)(() =>
			{
				if (response.Status == Status.Success)
				{
					LabelStatus.Text = $"Success: {response.Data.ToString()}";
				}
				else
				{
					LabelStatus.Text = $"Error: {response.Message}";
				}
			}));

			var addNotification = await NotificationService.AddNotification(new Requests.NotificationRequest() { Message = "", Subject = "World", UserId = 1 });

			this.Invoke((Action)(() =>
			{
				if (addNotification.Status == Status.Success)
				{
					LabelStatus.Text = $"Success: {addNotification.Data.ToString()}";
				}
				else
				{
					LabelStatus.Text = $"Error: {addNotification.Message}";
				}
			}));

			var updateNotification = await NotificationService.MarkNotificationAsRead(new Notification() { _Id = "668cbfeacddcb7fab7ddc882", UserId = 1, Message = "", Subject = "World" });

			this.Invoke((Action)(() =>
			{
				if (addNotification.Status == Status.Success)
				{
					LabelStatus.Text = $"Success: {updateNotification.Data.IsRead.ToString()}";
				}
				else
				{
					LabelStatus.Text = $"Error: {updateNotification.Message}";
				}
			}));
		}
	}
}
