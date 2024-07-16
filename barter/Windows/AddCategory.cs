using barter.ModelsView;
using barter.Requests;
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
	public partial class AddCategory : Form
	{
		private readonly AddCategoryModelView addCategoryModelView = new AddCategoryModelView();

		public AddCategory()
		{
			InitializeComponent();
		}

		private async void saveButton_Click(object sender, EventArgs e)
		{
			saveButton.Enabled = false;
			saveButton.Text = "Loading...";
			try
			{
				var categoryRequest = new CategoryRequest()
				{
					Title = titleTextBox.Text
				};

				var category = await this.addCategoryModelView.AddCategory(categoryRequest);

				if (category is not null)
				{
					MessageBox.Show("Category added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
			}
			finally
			{
				saveButton.Text = "Save";
				saveButton.Enabled = true;
			}
		}
	}
}
