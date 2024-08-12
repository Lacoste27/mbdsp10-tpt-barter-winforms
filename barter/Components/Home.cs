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

		public async void Load_Post()
		{
			try
			{
				var posts = await HomeModelView.GetPosts().ConfigureAwait(false);

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
						view.Margin = new Padding(0, 0, 20, 30);

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
	}
}
