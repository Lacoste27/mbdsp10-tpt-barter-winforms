using barter.Components;
using barter.ModelsView;
using barter.Requests;
using barter.Utils;
using System.ComponentModel;
using System.Data;

namespace barter.Windows
{
	public partial class AddObject : Form
	{
		private List<ImageView> imageList = new List<ImageView>();

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

			this.addImageButton.picture.Click += (s, e) =>
			{
				OpenFileDialog openFileDialog = new();
				openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
				openFileDialog.Multiselect = false;

				try
				{
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						string filename = openFileDialog.FileName;

						Image image = Image.FromFile(filename);
						ImageView imageView = new ImageView(image, filename);

						this.imagePanel.Controls.Add(imageView);
						this.imageList.Add(imageView);
					}
				}
				catch (Exception Exception)
				{
					MessageBox.Show("An error occurred !");
				}
			};
		}

		private async void SetCategoryDataSource()
		{
			categoryComboBox.Enabled = false;

			try
			{
				Dictionary<int, string> categoryData = await addObjectModelView.GetCategoryData();


				if (categoryData is not null && categoryData.Count != 0)
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
				int.TryParse(categoryComboBox.SelectedValue?.ToString() ?? "", out int categoryId);

				string name = nameTextBox.Text;
				string description = descriptionTextBox.Text;
				int ownerId = TokenStorage.GetUserId();
				List<string> images = this.imageList.Select(image => image.Filename).ToList();

				ObjectRequest request = new()
				{
					CategoryId = categoryId,
					Description = description,
					Name = name,
					OwnerId = ownerId,
					Image = images
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

	}
}
