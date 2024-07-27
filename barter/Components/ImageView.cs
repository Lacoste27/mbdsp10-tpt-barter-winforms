using barter.Models;
using System;
namespace barter.Components
{
	public partial class ImageView : UserControl
	{
		public string Filename { get; set; }

		public ImageView()
		{
			InitializeComponent();
		}

		public ImageView(Image image, string filename)
		{
			InitializeComponent();

			this.picture.Image = image;
			this.picture.SizeMode = PictureBoxSizeMode.StretchImage;
			this.Filename = filename;
		}

		private void picture_Click(object sender, EventArgs e)
		{
			
		}
	}
}
