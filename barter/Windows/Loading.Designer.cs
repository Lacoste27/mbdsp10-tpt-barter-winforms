namespace barter.Windows
{
	partial class Loading
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
			progress = new ProgressBar();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// progress
			// 
			progress.Location = new Point(127, 27);
			progress.Name = "progress";
			progress.Size = new Size(264, 33);
			progress.Style = ProgressBarStyle.Marquee;
			progress.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.Group_15;
			pictureBox1.Location = new Point(35, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(68, 66);
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			// 
			// Loading
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(427, 90);
			Controls.Add(pictureBox1);
			Controls.Add(progress);
			FormBorderStyle = FormBorderStyle.None;
			MaximumSize = new Size(427, 90);
			MinimumSize = new Size(427, 90);
			Name = "Loading";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Loading";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private PictureBox pictureBox1;
		public ProgressBar progress;
	}
}