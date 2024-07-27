using barter.Windows;

namespace barter.Components
{
	public partial class Posts : UserControl
	{
		public Posts()
		{
			InitializeComponent();
		}

		private void Posts_Load(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void mapViewButton_Click(object sender, EventArgs e)
		{
			MapView map = new();
			map.ShowDialog();
		}
	}
}
