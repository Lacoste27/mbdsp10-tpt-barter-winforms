﻿namespace barter.Windows
{
	partial class MapView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapView));
			gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
			SuspendLayout();
			// 
			// gMapControl1
			// 
			gMapControl1.Bearing = 0F;
			gMapControl1.CanDragMap = true;
			gMapControl1.Dock = DockStyle.Fill;
			gMapControl1.EmptyTileColor = Color.Navy;
			gMapControl1.GrayScaleMode = false;
			gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			gMapControl1.LevelsKeepInMemory = 5;
			gMapControl1.Location = new Point(0, 0);
			gMapControl1.MarkersEnabled = true;
			gMapControl1.MaxZoom = 2;
			gMapControl1.MinZoom = 2;
			gMapControl1.MouseWheelZoomEnabled = true;
			gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			gMapControl1.Name = "gMapControl1";
			gMapControl1.NegativeMode = false;
			gMapControl1.PolygonsEnabled = true;
			gMapControl1.RetryLoadTile = 0;
			gMapControl1.RoutesEnabled = true;
			gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
			gMapControl1.ShowTileGridLines = false;
			gMapControl1.Size = new Size(1162, 748);
			gMapControl1.TabIndex = 0;
			gMapControl1.Zoom = 0D;
			// 
			// MapView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1162, 748);
			Controls.Add(gMapControl1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "MapView";
			Text = "Map view";
			Load += MapView_Load;
			ResumeLayout(false);
		}

		#endregion

		private GMap.NET.WindowsForms.GMapControl gMapControl1;
	}
}