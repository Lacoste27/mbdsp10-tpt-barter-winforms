namespace barter.Windows
{
	partial class AddPost
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPost));
			splitContainer1 = new SplitContainer();
			panel3 = new Panel();
			panel1 = new Panel();
			descriptionText = new RichTextBox();
			label1 = new Label();
			panel2 = new Panel();
			saveButton = new Button();
			splitContainer2 = new SplitContainer();
			objectCheckList = new CheckedListBox();
			gMapControl = new GMap.NET.WindowsForms.GMapControl();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			panel3.SuspendLayout();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(panel3);
			splitContainer1.Panel1.Controls.Add(panel1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(panel2);
			splitContainer1.Size = new Size(826, 563);
			splitContainer1.SplitterDistance = 519;
			splitContainer1.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.Controls.Add(splitContainer2);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 116);
			panel3.Name = "panel3";
			panel3.Size = new Size(826, 403);
			panel3.TabIndex = 1;
			// 
			// panel1
			// 
			panel1.Controls.Add(descriptionText);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(826, 116);
			panel1.TabIndex = 0;
			// 
			// descriptionText
			// 
			descriptionText.Location = new Point(91, 18);
			descriptionText.Name = "descriptionText";
			descriptionText.Size = new Size(697, 78);
			descriptionText.TabIndex = 1;
			descriptionText.Text = "";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 18);
			label1.Name = "label1";
			label1.Size = new Size(73, 15);
			label1.TabIndex = 0;
			label1.Text = "Description :";
			// 
			// panel2
			// 
			panel2.Controls.Add(saveButton);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(826, 40);
			panel2.TabIndex = 0;
			// 
			// saveButton
			// 
			saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			saveButton.Image = Properties.Resources.save;
			saveButton.ImageAlign = ContentAlignment.MiddleLeft;
			saveButton.Location = new Point(758, 6);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(65, 28);
			saveButton.TabIndex = 0;
			saveButton.Text = "Save";
			saveButton.TextAlign = ContentAlignment.MiddleRight;
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += saveButton_Click;
			// 
			// splitContainer2
			// 
			splitContainer2.Dock = DockStyle.Fill;
			splitContainer2.Location = new Point(0, 0);
			splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			splitContainer2.Panel1.Controls.Add(objectCheckList);
			// 
			// splitContainer2.Panel2
			// 
			splitContainer2.Panel2.Controls.Add(gMapControl);
			splitContainer2.Size = new Size(826, 403);
			splitContainer2.SplitterDistance = 461;
			splitContainer2.TabIndex = 0;
			// 
			// objectCheckList
			// 
			objectCheckList.CheckOnClick = true;
			objectCheckList.Dock = DockStyle.Fill;
			objectCheckList.FormattingEnabled = true;
			objectCheckList.HorizontalScrollbar = true;
			objectCheckList.Location = new Point(0, 0);
			objectCheckList.MultiColumn = true;
			objectCheckList.Name = "objectCheckList";
			objectCheckList.ScrollAlwaysVisible = true;
			objectCheckList.Size = new Size(461, 403);
			objectCheckList.TabIndex = 1;
			objectCheckList.ThreeDCheckBoxes = true;
			// 
			// gMapControl
			// 
			gMapControl.Bearing = 0F;
			gMapControl.CanDragMap = true;
			gMapControl.Dock = DockStyle.Fill;
			gMapControl.EmptyTileColor = Color.Navy;
			gMapControl.GrayScaleMode = false;
			gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			gMapControl.LevelsKeepInMemory = 5;
			gMapControl.Location = new Point(0, 0);
			gMapControl.MarkersEnabled = true;
			gMapControl.MaxZoom = 2;
			gMapControl.MinZoom = 2;
			gMapControl.MouseWheelZoomEnabled = true;
			gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			gMapControl.Name = "gMapControl";
			gMapControl.NegativeMode = false;
			gMapControl.PolygonsEnabled = true;
			gMapControl.RetryLoadTile = 0;
			gMapControl.RoutesEnabled = true;
			gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			gMapControl.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
			gMapControl.ShowTileGridLines = false;
			gMapControl.Size = new Size(361, 403);
			gMapControl.TabIndex = 0;
			gMapControl.Zoom = 0D;
			// 
			// AddPost
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(826, 563);
			Controls.Add(splitContainer1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(842, 602);
			MinimumSize = new Size(842, 602);
			Name = "AddPost";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add new post";
			Load += AddPost_Load;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private Panel panel1;
		private Panel panel2;
		private Button saveButton;
		private Panel panel3;
		private Label label1;
		private RichTextBox descriptionText;
		private SplitContainer splitContainer2;
		private CheckedListBox objectCheckList;
		private GMap.NET.WindowsForms.GMapControl gMapControl;
	}
}