using barter.Components;
using barter.ModelsView;
using barter.Requests;
using barter.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace barter.Windows
{
	public partial class AddObject : Form
	{
		private AddObjectModelView addObjectModelView { get; set; } = new AddObjectModelView();

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
			addCategory.FormClosing += AddCategory_Closing;
			addCategory.ShowDialog();
		}

		private void imageView1_Load(object sender, EventArgs e)
		{

		}

		private void addImageButton_Click(object sender, EventArgs e)
		{
			/*if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				foreach (string fileName in openFileDialog.FileNames)
				{
					Image image = Image.FromFile(fileName);
					ImageView imageView = new ImageView(image);
					imagePanel.Controls.Add(imageView);
				}
			}*/

			MessageBox.Show("Add object image", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void AddObject_Load(object sender, EventArgs e)
		{
			SetCategoryDataSource();
		}

		private async void SetCategoryDataSource()
		{
			categoryComboBox.Enabled = false;

			try
			{
				var categoryData = await addObjectModelView.GetCategoryData();

				if (categoryData is not null)
				{
					categoryComboBox.DataSource = new BindingSource(categoryData, null);
					categoryComboBox.DisplayMember = "Value";
					categoryComboBox.ValueMember = "Key";
				}
			}
			finally
			{
				categoryComboBox.Enabled = true;
			}
		}

		private void AddCategory_Closing(object sender, CancelEventArgs e)
		{
			SetCategoryDataSource();
		}

		private async void saveButton_Click(object sender, EventArgs e)
		{

			saveButton.Enabled = false;
			saveButton.Text = "Loading...";

			try
			{
				string name = nameTextBox.Text;
				int categoryId = (int)categoryComboBox.SelectedValue;
				string description = descriptionTextBox.Text;
				int ownerId = TokenStorage.GetUserId();

				ObjectRequest request = new()
				{
					CategoryId = categoryId,
					Description = description,
					Name = name,
					OwnerId = ownerId,
					Image = "Image",
				};

				var _object = await addObjectModelView.AddObject(request);

				if (_object is not null)
				{
					MessageBox.Show("Object added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
			}
			finally
			{
				saveButton.Text = "Save";
				saveButton.Enabled = true;
			}
		}

		private void addImageButton_Load(object sender, EventArgs e)
		{

		}
	}
}
