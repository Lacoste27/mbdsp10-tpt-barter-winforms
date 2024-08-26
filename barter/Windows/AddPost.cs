using barter.ModelsView;
using barter.Utils;
using GMap.NET.MapProviders;
using GMap.NET;
using System.Data;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using barter.Responses;

namespace barter.Windows
{
	public partial class AddPost : Form
	{
		private AddPostModelView addPostModelView { get; set; } = new AddPostModelView();
		private ListView listView;
		private GMapOverlay MarkersOverlay;
		private GMarkerGoogle Location;

		public AddPost()
		{
			InitializeComponent();
			InitializeMap();
		}

		private void InitializeMap()
		{
			gMapControl.MapProvider = GMapProviders.GoogleMap;
			gMapControl.Position = new PointLatLng(-18.913974, 47.282408);
			gMapControl.MinZoom = 1;
			gMapControl.MaxZoom = 18;
			gMapControl.Zoom = 6;
			gMapControl.AutoScroll = true;

			MarkersOverlay = new GMapOverlay("markers");
			gMapControl.Overlays.Add(MarkersOverlay);

			gMapControl.MouseClick += GMapControl_MouseClick;
		}

		private void GMapControl_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				var point = gMapControl.FromLocalToLatLng(e.X, e.Y);

				var marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin)
				{
					ToolTipMode = MarkerTooltipMode.OnMouseOver,
					ToolTipText = $"Lat: {point.Lat}, Lng: {point.Lng}"
				};

				this.Location = marker;

				MarkersOverlay.Markers.Add(marker);
			}
		}

		private async void saveButton_Click(object sender, EventArgs e)
		{
			saveButton.Enabled = false;
			saveButton.Text = "Loading...";

			try
			{
				int authodId = TokenStorage.GetUserId();
				String description = descriptionText.Text;
				List<int> objectIds = new List<int>();

				string Adress = "Madagascar";
				double Latittude = this.Location.Position.Lat;
				double Longitude = this.Location.Position.Lng;

				foreach (var item in objectCheckList.CheckedItems)
				{
					dynamic data = item;
					Models.Object _objects = this.addPostModelView.UserObjects.Where(post => post.Id == data.Value).FirstOrDefault();

					if (_objects is not null)
					{
						objectIds.Add(data.Value);
					}
				}


				var _object = await addPostModelView.AddPost(authodId, description, Latittude, Longitude, Adress, objectIds);

				if (_object is not null)
				{
					MessageBox.Show("Post added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				} else
				{
					saveButton.Text = "Save";
					saveButton.Enabled = true;
				}
			}
			catch(Exception Exception)
			{
				MessageBox.Show(Exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

				saveButton.Text = "Save";
				saveButton.Enabled = true;
			}
			finally
			{
				saveButton.Text = "Save";
				saveButton.Enabled = true;
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

							objectCheckList.Items.Insert(0, new { Text = item.Name, Value = item.Id });
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
