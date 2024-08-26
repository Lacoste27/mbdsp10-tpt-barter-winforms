using barter.Components;
using barter.ModelsView;

namespace barter.Windows
{
	public partial class Main : Form
	{
		private Suggestions suggestion { get; set; }
		private MainModelView MainModelView { get; set; } = new MainModelView();

		public Main()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void profileButton_Click(object sender, EventArgs e)
		{
			if (this.profil1 is null)
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
			if(this.messages1 is null)
			{
				this.messages1 = new Components.Messages();
				this.messages1.Dock = DockStyle.Fill;
			}

			this.messages1.LoadMessages();

			this.panel2.Controls.Add(this.messages1);
			this.messages1.BringToFront();

			this.suggestionButton.FlatStyle = FlatStyle.Flat;
			this.notificationButton.FlatStyle = FlatStyle.Flat;
			this.messageButton.FlatStyle = FlatStyle.Standard;
		}

		private void accueilButton_Click(object sender, EventArgs e)
		{

			if (this.home1 is null)
			{
				this.home1 = new Components.Home();
				this.home1.Dock = DockStyle.Fill;
			}

			this.panel2.Controls.Add(this.home1);

			this.home1.BringToFront();
		}

		private void notificationButton_Click(object sender, EventArgs e)
		{
			this.suggestionButton.FlatStyle = FlatStyle.Flat;
			this.notificationButton.FlatStyle = FlatStyle.Standard;
			this.messageButton.FlatStyle = FlatStyle.Flat;

			Notification notification = new Notification();
			if(notification.ShowDialog() == DialogResult.OK)
			{
				this.notificationButton.BackColor = Color.White;
			}
		}

		private void home1_Load(object sender, EventArgs e)
		{

		}

		private void toolStripProgressBar1_Click(object sender, EventArgs e)
		{

		}

		private void suggestionButton_Click(object sender, EventArgs e)
		{
			if (this.suggestion is null)
			{
				this.suggestion = new Suggestions();
				this.suggestion.Dock = DockStyle.Fill;
			}

			this.suggestionButton.FlatStyle = FlatStyle.Standard;
			this.notificationButton.FlatStyle = FlatStyle.Flat;
			this.messageButton.FlatStyle = FlatStyle.Flat;

			this.panel2.Controls.Add(this.suggestion);
			this.suggestion.BringToFront();
		}

		private async void Main_Load(object sender, EventArgs e)
		{
			if (this.home1 is null)
			{
				this.home1 = new Components.Home();
				this.home1.Dock = DockStyle.Fill;
			}

			this.panel2.Controls.Add(this.home1);
			this.home1.BringToFront();

			var hasNotification = await this.MainModelView.HasNewNotification();

			if(hasNotification)
			{
				this.notificationButton.BackColor = Color.FromArgb(39, 194, 64);
			}
		}
	}
}
