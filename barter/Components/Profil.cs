using barter.ModelsView;
using barter.Windows;
using System.ComponentModel;

namespace barter.Components
{
	public partial class Profil : UserControl
	{
		private ProfilModelView ProfilModelView { get; set; } = new ProfilModelView();

		public bool loadObject { get; set; } = false;
		public bool loadPost { get; set; } = false;

		public Profil()
		{
			InitializeComponent();
		}

		private void addObjectButton_Click(object sender, EventArgs e)
		{
			AddObject add = new AddObject();
			add.FormClosing += AddObject_Closing;
			add.ShowDialog();
		}

		private void addPostButton_Click(object sender, EventArgs e)
		{
			AddPost add = new AddPost();
			add.ShowDialog();
		}

		private async void Profil_Load(object sender, EventArgs e)
		{
		}

		private void AddObject_Closing(object sender, CancelEventArgs e)
		{
			ProfilModelView.userObjectChanged = true;
			Load_Object();
		}

		public async Task Load_Object(int page = 1, int limit = 10)
		{
			if (ProfilModelView.UserObjects is null || ProfilModelView.userObjectChanged)
			{
				var objects = await ProfilModelView.GetUserObjects(page, limit).ConfigureAwait(false);

				if (objects is not null)
				{
					this.Invoke((MethodInvoker)delegate
					{
						layout.SuspendLayout();
						layout.Controls.Clear();
						progression.Visible = true;
					});

					List<ObjectView> controlsToAdd = new List<ObjectView>();

					foreach (var obj in objects)
					{
						ObjectView view = new ObjectView(obj);
						view.details.FormClosing += OnClose;
						controlsToAdd.Add(view);
					}

					this.Invoke((MethodInvoker)delegate
					{
						layout.Controls.AddRange(controlsToAdd.ToArray());
						layout.ResumeLayout(true);
						progression.Visible = false;
					});
					DoubleBuffered = true;
				}
			}
		}

		private void OnClose(object sender, CancelEventArgs e)
		{
			ProfilModelView.userObjectChanged = true;
			Load_Object();
		}


		public async Task Load_Post(int page = 1, int limit = 10)
		{
			if (ProfilModelView.UserPosts is null || ProfilModelView.userPostChanged)
			{
				var posts = await ProfilModelView.GetUserPosts().ConfigureAwait(false);

				if (posts is not null)
				{
					this.Invoke((MethodInvoker)delegate
					{
						layout.SuspendLayout();
						layout.Controls.Clear();
						progression.Visible = true;
					});

					List<PostView> controlsToAdd = new List<PostView>();

					foreach (var post in posts)
					{
						PostView view = new PostView(post);
						controlsToAdd.Add(view);
					}

					this.Invoke((MethodInvoker)delegate
					{
						layout.Controls.AddRange(controlsToAdd.ToArray());
						layout.ResumeLayout(true);
						progression.Visible = false;
					});

					DoubleBuffered = true;
				}
			}
		}

		private async void objectButton_Click(object sender, EventArgs e)
		{
			this.addObjectButton.Visible = true;
			this.addPostButton.Visible = false;

			await Load_Object();

			this.previousButton.Enabled = this.ProfilModelView.Objects.HasPrevPage;
			this.nextButton.Enabled = this.ProfilModelView.Objects.HasNextPage;
			this.pageNumber.Text = (this.ProfilModelView.Objects.NextPage == 2) ? "1" : (this.ProfilModelView.Objects.NextPage - 1).ToString();

		}

		private async void postButton_Click(object sender, EventArgs e)
		{
			this.addObjectButton.Visible = false;
			this.addPostButton.Visible = true;

			await Load_Post();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private async void previousButton_Click(object sender, EventArgs e)
		{
			ProfilModelView.userObjectChanged = true;
			await Load_Object(this.ProfilModelView.Objects.NextPage.GetValueOrDefault());

			this.previousButton.Enabled = this.ProfilModelView.Objects.HasPrevPage;
			this.nextButton.Enabled = this.ProfilModelView.Objects.HasNextPage;
			this.pageNumber.Text = (this.ProfilModelView.Objects.NextPage == 2) ? "1" : (this.ProfilModelView.Objects.NextPage - 1).ToString();
		}

		private async void nextButton_Click(object sender, EventArgs e)
		{
			ProfilModelView.userObjectChanged = true;

			await Load_Object(this.ProfilModelView.Objects.NextPage.GetValueOrDefault());

			this.previousButton.Enabled = this.ProfilModelView.Objects.HasPrevPage;
			this.nextButton.Enabled = this.ProfilModelView.Objects.HasNextPage;
			this.pageNumber.Text = (this.ProfilModelView.Objects.NextPage == 2) ? "1" : (this.ProfilModelView.Objects.NextPage - 1).ToString();
		}

		private void pageNumber_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
