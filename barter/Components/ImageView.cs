using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barter.Components
{
	public partial class ImageView : UserControl
	{
		public ImageView()
		{
			InitializeComponent();
		}

		public ImageView(Image image)
		{
			InitializeComponent();

			this.picture.Image = image;
		}
	}
}
