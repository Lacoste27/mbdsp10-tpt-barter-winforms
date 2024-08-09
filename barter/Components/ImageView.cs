using barter.Utils;
using System.Net;
namespace barter.Components
{
	public partial class ImageView : UserControl
	{
		private readonly ImageCache ImageCache = new ImageCache();

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
			LoadImage(url);
		}

		private void picture_Click(object sender, EventArgs e)
		{

		}

		private async void LoadImage(string url)
		{
			try
			{
				var image = await ImageCache.GetImageAsync(url);
				if (image != null)
				{
					this.picture.Image = image;
					this.picture.SizeMode = PictureBoxSizeMode.StretchImage;
				}
			}
			catch (ArgumentException ex)
			{
			}
			catch (WebException ex)
			{
			}
		}
	}
}
