using barter.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barter.Windows
{
	public partial class AddObject : Form
	{
		public AddObject()
		{
			InitializeComponent();
		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void newCategoryButton_Click(object sender, EventArgs e)
		{
			AddCategory addCategory = new();
			addCategory.ShowDialog();
		}

		private void imageView1_Load(object sender, EventArgs e)
		{

		}

		private void addImageButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				foreach (string fileName in openFileDialog.FileNames)
				{
					Image image = Image.FromFile(fileName);
					ImageView imageView = new ImageView(image);
					imagePanel.Controls.Add(imageView);
				}
			}
		}
	}
}
