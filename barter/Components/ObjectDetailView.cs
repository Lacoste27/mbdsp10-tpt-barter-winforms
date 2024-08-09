using barter.Utils;
using System.Net;

namespace barter.Components
{
	public partial class ObjectDetailView : UserControl
	{
		public Models.Object _Object { get; set; }

		private int currentIndexImage = 0;
		private readonly ImageCache ImageCache = new ImageCache();


		public ObjectDetailView()
		{
			InitializeComponent();
		}

		public ObjectDetailView(Models.Object @object)
		{
			InitializeComponent();
			this._Object = @object;
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void ObjectDetailView_Load(object sender, EventArgs e)
		{
			this.objectName.Text = this._Object.Name;
			this.description.Text = this._Object.Description;

			LoadImage(currentIndexImage);
		}

		private async void LoadImage(int index)
		{
			if (index >= 0 && index < this._Object.Photos.Count)
			{
				try
				{
					var image = await ImageCache.GetImageAsync(this._Object.Photos[index]);
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

		private void prevButton_Click(object sender, EventArgs e)
		{
			currentIndexImage--;
			if (currentIndexImage < 0)
			{
				currentIndexImage = this._Object.Photos.Count - 1;
			}
			LoadImage(currentIndexImage);
		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			currentIndexImage++;
			if (currentIndexImage >= this._Object.Photos.Count)
			{
				currentIndexImage = 0; /// Boucle à la fin
			}
			LoadImage(currentIndexImage);
		}
	}
}
