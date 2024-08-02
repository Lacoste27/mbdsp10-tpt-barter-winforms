using barter.ModelsView;
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
	public partial class AddPost : Form
	{
		private AddPostModelView addPostModelView { get; set; } = new AddPostModelView();

		public AddPost()
		{
			InitializeComponent();
		}

		private async void saveButton_Click(object sender, EventArgs e)
		{
			int authodId = 1;
			List<int> objectIds = new List<int>();

			var _object = await addPostModelView.AddPost(authodId, objectIds);

			if (_object is not null)
			{
				MessageBox.Show("Post added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			}
		}
	}
}
