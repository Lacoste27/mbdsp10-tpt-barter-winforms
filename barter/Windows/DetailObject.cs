using barter.Components;
using barter.ModelsView;
using barter.Requests;
using barter.Utils;

namespace barter.Windows
{
	public partial class DetailObject : Form
	{
		private Models.Object _object { get; set; }
		private DetailsObjectModelView DetailsObjectModelView { get; set; } = new();

		public DetailObject()
		{
			InitializeComponent();
		}

		public DetailObject(Models.Object _object)
		{
			InitializeComponent();
			this._object = _object;
		}

		private async void saveButton_Click(object sender, EventArgs e)
		{
			string name = this.nameText.Text;
			string description = this.desctiptionText.Text;
			int categoryId = (int)categoryComboBox.SelectedValue;
			int ownerId = TokenStorage.GetUserId();

			UpdateObjectRequest request = new()
			{
				Name = name,
				Description = description,
				CategoryId = categoryId,
				OwnerId = ownerId
			};

			var _object = await DetailsObjectModelView.UpdateObject(request, this._object.Id);

			if (_object is not null)
			{
				MessageBox.Show("Object updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			}
		}

		private async void DetailObject_Load(object sender, EventArgs e)
		{
			this.nameText.Text = this._object.Name;
			this.desctiptionText.Text = this._object.Description;

			SetCategoryDataSource();

			foreach (var item in this._object.Photos)
			{
				ImageView view = new(item);
				this.imageLayout.Controls.Add(view);
			}
		}

		private async void SetCategoryDataSource()
		{
			categoryComboBox.Enabled = false;

			try
			{
				Dictionary<int, string> categoryData = await DetailsObjectModelView.GetCategoryData();


				if (categoryData is not null && categoryData.Count != 0)
				{
					categoryComboBox.DataSource = new BindingSource(categoryData, null);
					categoryComboBox.DisplayMember = "Value";
					categoryComboBox.ValueMember = "Key";

					categoryComboBox.SelectedValue = this._object.CategoryId;
				}
			}
			finally
			{
				categoryComboBox.Enabled = true;
			}
		}
	}
}
