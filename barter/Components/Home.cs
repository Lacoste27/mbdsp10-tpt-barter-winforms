using barter.ModelsView;
using barter.Windows;

namespace barter.Components
{
	public partial class Home : UserControl
	{

		private HomeModelView HomeModelView { get; set; } = new HomeModelView();


		public Home()
		{
			InitializeComponent();
		}

		private void mapViewButton_Click(object sender, EventArgs e)
		{
			MapView map = new();
			map.ShowDialog();
		}

		public async Task Load_Post(int page = 1, int limit = 10)
		{
			try
			{
				if (HomeModelView.PostChanged)
				{
					var posts = await HomeModelView.GetPosts(page, limit).ConfigureAwait(false);

					if (posts is not null)
					{
						this.Invoke((MethodInvoker)delegate
						{
							layout.SuspendLayout();
							layout.Controls.Clear();
							progression.Visible = true;

							Cursor.Current = Cursors.WaitCursor;
						});

						List<PostView> controlsToAdd = new List<PostView>();

						foreach (var post in posts)
						{
							PostView view = new PostView(post);
							view.Margin = new Padding(0, 0, 20, 30);

							controlsToAdd.Add(view);
						}

						this.Invoke((MethodInvoker)delegate
						{
							layout.Controls.AddRange(controlsToAdd.ToArray());
							layout.ResumeLayout(true);
							progression.Visible = false;

							Cursor.Current = Cursors.Default;

							this.previousButton.Enabled = this.HomeModelView.Posts.HasPrevPage;
							this.nextButton.Enabled = this.HomeModelView.Posts.HasNextPage;
							this.pageNumber.Text = (this.HomeModelView.Posts.NextPage == 2) ? "1" : (this.HomeModelView.Posts.NextPage - 1).ToString();
						});

						DoubleBuffered = true;

					}
				}
			}
			catch (Exception Exception)
			{
				MessageBox.Show($"Une erreur est survenue lors du chargement des données: {Exception.Message}");
			}
			finally
			{
			}
		}

		private void postLayout_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Home_Load(object sender, EventArgs e)
		{
			Load_Post();
		}

		private async void nextButton_Click(object sender, EventArgs e)
		{
			int nextPage = this.HomeModelView.Posts.NextPage.GetValueOrDefault();

			await Load_Post(nextPage);

			this.previousButton.Enabled = this.HomeModelView.Posts.HasPrevPage;
			this.nextButton.Enabled = this.HomeModelView.Posts.HasNextPage;
			this.pageNumber.Text = (this.HomeModelView.Posts.NextPage == 2) ? "1" : (this.HomeModelView.Posts.NextPage - 1).ToString();
		}

		private async void previousButton_Click(object sender, EventArgs e)
		{
			int prevPage = this.HomeModelView.Posts.PrevPage.GetValueOrDefault();

			await Load_Post(prevPage);

			this.previousButton.Enabled = this.HomeModelView.Posts.HasPrevPage;
			this.nextButton.Enabled = this.HomeModelView.Posts.HasNextPage;
			this.pageNumber.Text = (this.HomeModelView.Posts.NextPage == 2) ? "1" : (this.HomeModelView.Posts.NextPage - 1).ToString();
		}
	}
}
