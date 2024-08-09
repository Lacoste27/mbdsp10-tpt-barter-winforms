using barter.Windows;

namespace barter.Components
{
	public partial class ObjectView : UserControl
	{
		private Models.Object Object { get; set; }
		public DetailObject details { get; set; }

		public ObjectView()
		{
			InitializeComponent();
		}

		public ObjectView(Models.Object _Object)
		{
			InitializeComponent();
			this.Object = _Object;
			details = new DetailObject(_Object);
		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ObjectView_Load(object sender, EventArgs e)
		{
			this.nameText.Text = this.Object.Name;
			this.categoryText.Text = this.Object.Category.Title;

			LoadImagesAsync();
		}

		private async void LoadImagesAsync()
		{
			foreach (var item in this.Object.Photos)
			{
				ImageView view = new ImageView(item);
				await Task.Run(() => this.imageLayout.Invoke(new Action(() => this.imageLayout.Controls.Add(view))));
			}
		}

		private void imageLayout_DoubleClick(object sender, EventArgs e)
		{
			details.ShowDialog();
		}
	}
}
