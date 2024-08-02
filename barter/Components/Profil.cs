using barter.ModelsView;
using barter.Windows;
using System.ComponentModel;

namespace barter.Components
{
	public partial class Profil : UserControl
	{
		private ProfilModelView ProfilModelView { get;set; } = new ProfilModelView(); 

		public bool loadObject { get; set; } = false;
		public bool loadPost { get; set; } = false;

		public Profil()
		{
			InitializeComponent();
		}

		private void addButton_Click(object sender, EventArgs e)
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

		private async  void Profil_Load(object sender, EventArgs e)
		{
		}

		private void AddObject_Closing(object sender, CancelEventArgs e)
		{
			ProfilModelView.userObjectChanged = true;
			Load_Object();
		}

		public async Task Load_Object()
		{
			if(ProfilModelView.UserObjects is null || ProfilModelView.userObjectChanged)
			{
				Loading loading = new Loading();
				loading.Visible = true;

				var objects = await Task.Run(() => ProfilModelView.GetUserObjects()).ConfigureAwait(false);

				if (objects is not null)
				{
					objectLayout.Invoke((Action)(() =>
					{
						objectLayout.Controls.Clear();

						foreach (var obj in objects)
						{
							ObjectView view = new ObjectView(obj);
							view.details.FormClosing += OnClose;
							objectLayout.Controls.Add(view);
						}
					}));

					loading.Invoke((Action)(() => loading.Close()));
				}

			}
		}

		private void OnClose(object sender, CancelEventArgs e)
		{
			ProfilModelView.userObjectChanged = true;
			Load_Object();
		}


		public async void Load_Post()
		{
			var posts = await ProfilModelView.GetUserPosts();

			if (posts is not null)
			{
				foreach (var post in posts)
				{
					
				}
			}
		}
	}
}
