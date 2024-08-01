using barter.Models;
using System;
using System.Net;
using System.Windows.Forms;
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

		public ImageView(string url)
		{
			InitializeComponent();
			try
			{
				this.picture.Load(url);
				this.picture.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			catch (ArgumentException ex)
			{
			}
			catch (WebException ex)
			{
			}
		}

		private void picture_Click(object sender, EventArgs e)
		{
			
		}
	}
}
