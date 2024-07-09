using barter.Models;
using barter.Responses;
using barter.Services.Api;
using barter.Services.Notifications;
using barter.Services.Reports;

namespace barter
{
	public partial class App : Form
	{

		private INotificationService NotificationService { get; set; }
		private IReportService ReportService { get; set; }

		public App()
		{
			NotificationService = Service.GetService<INotificationService>();
			ReportService = Service.GetService<IReportService>();

			InitializeComponent();
		}

		private void App_Load(object sender, EventArgs e)
		{

		}

		private async void label1_Click(object sender, EventArgs e)
		{
			var response = await ReportService.GetAllReport();

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
		}
	}
}
