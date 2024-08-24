using Avalonia.Controls;
using barter.Components;
using barter.Models;
using barter.ModelsView;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace barter.Windows
{
	public partial class MapView : Form
	{
		public MapViewModelView MapViewModelView { get; set; } = new MapViewModelView();

		public MapView()
		{
			InitializeComponent();
			InitializeMap();
		}

		private void InitializeMap()
		{
			gMapControl1.MapProvider = GMapProviders.GoogleMap;
			gMapControl1.Position = new PointLatLng(-18.913974, 47.282408);
			gMapControl1.MinZoom = 1;
			gMapControl1.MaxZoom = 18;
			gMapControl1.Zoom = 6;
			gMapControl1.AutoScroll = true;
		}

		private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
		{
			if(item.Tag is Post post)
			{
				DetailPost details = new DetailPost(post);
				details.ShowDialog();
			}
		}

		private async void MapView_Load(object sender, EventArgs e)
		{
			var posts = await MapViewModelView.GetAllPost().ConfigureAwait(false);

			if (posts is not null)
			{
				var markersOverlay = new GMapOverlay("markers");

				foreach (var post in posts)
				{
					if (post.Latitude.HasValue && post.Longitude.HasValue)
					{
						
						var marker = new GMarkerGoogle(
							new PointLatLng(post.Latitude.Value, post.Longitude.Value),
							GMarkerGoogleType.red_dot
						)
						{
							ToolTipMode = MarkerTooltipMode.OnMouseOver,
							ToolTipText = post.Address,
							Tag = post 
						};

						var toolTip = new GMapToolTip(marker)
						{
							
						};

						markersOverlay.Markers.Add(marker);
					}
				}

				if (markersOverlay.Markers.Count > 0)
				{
					if (gMapControl1.InvokeRequired)
					{
						gMapControl1.Invoke((Action)(() =>
						{
							gMapControl1.Overlays.Add(markersOverlay);
							gMapControl1.OnMarkerClick += gmap_OnMarkerClick;
							gMapControl1.Refresh();
							gMapControl1.Invalidate();
							gMapControl1.Update();
							WindowState = FormWindowState.Maximized;
						}));
					}
					else
					{
						gMapControl1.Overlays.Add(markersOverlay);
						gMapControl1.OnMarkerClick += gmap_OnMarkerClick;
						gMapControl1.Refresh();
						gMapControl1.Invalidate();
						gMapControl1.Update();
						WindowState = FormWindowState.Maximized;
					}
				}
			}

		}
	}
}
