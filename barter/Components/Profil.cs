using barter.ModelsView;
using barter.Windows;
using System.ComponentModel;

namespace barter.Components
{
	public partial class Profil : UserControl
	{
		private ProfilModelView ProfilModelView { get;set; } = new ProfilModelView(); 

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
			Load_Object();
		}

		private async void Load_Object()
		{
			var objects = await ProfilModelView.GetUserObjects();

			if (objects is not null)
			{
				objectLayout.Controls.Clear();

				foreach (var obj in objects)
				{
					ObjectView view = new ObjectView(obj);
					objectLayout.Controls.Add(view);
				}
			}
		}

		private void AddObject_Closing(object sender, CancelEventArgs e)
		{
			Load_Object();
		}
	}
}
