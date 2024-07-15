namespace barter.Windows
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void profileButton_Click(object sender, EventArgs e)
		{
			this.profil1.BringToFront();
		}

		private void postButton_Click(object sender, EventArgs e)
		{
			this.posts1.BringToFront();
		}

		private void messageButton_Click(object sender, EventArgs e)
		{
			this.messages1.BringToFront();
		}

		private void accueilButton_Click(object sender, EventArgs e)
		{
			this.home1.BringToFront();
		}

		private void notificationButton_Click(object sender, EventArgs e)
		{
			Notification notification = new Notification();
			notification.ShowDialog();
		}
	}
}
