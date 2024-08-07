using barter.Models;
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
		private ListView listView;

		public AddPost()
		{
			InitializeComponent();
		}

		private async void saveButton_Click(object sender, EventArgs e)
		{
			int authodId = 1;
			String description = descriptionText.Text;
			List<int> objectIds = new List<int>();

			foreach (var item in objectCheckList.CheckedItems)
			{
				dynamic data = item;
				Models.Object _objects = this.addPostModelView.UserObjects.Where(post => post.Id == data.Value).FirstOrDefault();

				if(_objects is not null)
				{
					objectIds.Add(data.Value);
				}

			}


			var _object = await addPostModelView.AddPost(authodId, description, objectIds);

			if (_object is not null)
			{
				MessageBox.Show("Post added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			}
		}

		private async void AddPost_Load(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;

			try
			{

				var objects = await Task.Run(() => addPostModelView.GetUserObjects());

				if (objects is not null)
				{
					objectCheckList.Invoke(new Action(() =>
					{
						objectCheckList.Items.Clear(); 

						foreach (var item in objects)
						{
							objectCheckList.DisplayMember = "Text";
							objectCheckList.ValueMember = "Value";

							objectCheckList.Items.Insert(0, new {Text=item.Name, Value=item.Id});
							objectCheckList.Tag = item.Id;
						}

						AdjustColumnWidth();
					}));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Une erreur est survenue lors du chargement des données: {ex.Message}");
			}
			finally
			{
				// Réactiver les interactions utilisateur
				Cursor = Cursors.Default;
			}
		}

		private void AdjustColumnWidth()
		{
			int maxWidth = 0;
			using (Graphics g = objectCheckList.CreateGraphics())
			{
				foreach (var item in objectCheckList.Items)
				{
					int itemWidth = (int)g.MeasureString(item.ToString(), objectCheckList.Font).Width;
					if (itemWidth > maxWidth)
					{
						maxWidth = itemWidth;
					}
				}
			}
			objectCheckList.ColumnWidth = maxWidth + SystemInformation.VerticalScrollBarWidth;
		}
	}
}
