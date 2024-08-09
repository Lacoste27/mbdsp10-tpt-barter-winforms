using barter.Responses;
using barter.Services.Notifications;

namespace barter.Components
{
	public partial class NotificationView : UserControl
	{
		private Color READ_COLOR = Color.White;
		private Color UNREAD_COLOR = Color.WhiteSmoke;
		private INotificationService NotificationService { get; set; }

		private Models.Notification _notification { get; set; }

		public NotificationView()
		{
			InitializeComponent();
			NotificationService = Service.GetService<INotificationService>();
		}

		public NotificationView(Models.Notification notification)
		{
			InitializeComponent();
			_notification = notification;
			NotificationService = Service.GetService<INotificationService>();
		}


		private void NotificationView_Load(object sender, EventArgs e)
		{
			this.timeText.Text = this._notification.FormatDateString();
			this.notificationTitle.Text = this._notification.Subject;
			this.notificationMessage.Text = this._notification.Message;
			this.BackColor = _notification.IsRead ? READ_COLOR : UNREAD_COLOR;
			this.BorderStyle = BorderStyle.FixedSingle;
		}

		private async void NotificationView_Click(object sender, EventArgs e)
		{
			try
			{
				var data = await this.NotificationService.MarkNotificationAsRead(_notification);

				if (data.Status == Status.Success)
				{
					this.BackColor = READ_COLOR;
				}
				else
				{
					MessageBox.Show(data.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception Exception)
			{
				MessageBox.Show(Exception.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
