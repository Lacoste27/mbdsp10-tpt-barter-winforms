using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace barter.Windows
{
	public partial class MapView : Form
	{
		public MapView()
		{
			InitializeComponent();
			InitializeMap();
		}

		private void InitializeMap()
		{
			gMapControl1.MapProvider = GMapProviders.GoogleMap;
			gMapControl1.Position = new PointLatLng(-18.913974, 47.282408); // Position initiale (Paris, France)
			gMapControl1.MinZoom = 1;
			gMapControl1.MaxZoom = 18;
			gMapControl1.Zoom = 100;
			gMapControl1.AutoScroll = true;

			// Ajout d'un marqueur
			GMapOverlay markersOverlay = new GMapOverlay("markers");
			GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-18.913974, 47.282408), GMarkerGoogleType.green_pushpin);
			marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
			marker.ToolTipText = "This is a tooltip";

			markersOverlay.Markers.Add(marker);
			gMapControl1.Overlays.Add(markersOverlay);
			gMapControl1.OnMarkerClick += new MarkerClick(gmap_OnMarkerClick);

		}

		private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
		{
			MessageBox.Show("Marker clicked");
		}
	}
}
