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
	public partial class ObjectView : UserControl
	{
		private Models.Object Object { get; set; }

		public ObjectView()
		{
			InitializeComponent();
		}

		public ObjectView(Models.Object _Object)
		{
			InitializeComponent();
			this.Object = _Object;
		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ObjectView_Load(object sender, EventArgs e)
		{
			this.nameText.Text = this.Object.Name;
			this.categoryText.Text = this.Object.CategoryId.ToString();

            foreach (var item in this.Object.Photos)
            {
				ImageView view = new (item);
				this.imageLayout.Controls.Add(view);
			}
        }
	}
}
