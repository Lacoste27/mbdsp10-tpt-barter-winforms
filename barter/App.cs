using barter.Models;
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
			List<Notification> list = await NotificationService.GetUserNotification();
			Console.WriteLine(list);
			int a = 10;
		}
	}
}
