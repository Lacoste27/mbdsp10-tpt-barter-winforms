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
			if(this.profil1 is null)
			{
				this.profil1 = new Components.Profil();
				this.profil1.Dock = DockStyle.Fill;
			}
			this.panel2.Controls.Add(this.profil1);

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

		private void home1_Load(object sender, EventArgs e)
		{

		}

		private void toolStripProgressBar1_Click(object sender, EventArgs e)
		{

		}
	}
}
