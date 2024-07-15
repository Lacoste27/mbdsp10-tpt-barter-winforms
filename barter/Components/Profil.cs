using barter.Windows;

namespace barter.Components
{
	public partial class Profil : UserControl
	{
		public Profil()
		{
			InitializeComponent();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			AddObject add = new AddObject();
			add.ShowDialog();
		}

		private void addPostButton_Click(object sender, EventArgs e)
		{
			AddPost add = new AddPost();
			add.ShowDialog();
		}
	}
}
