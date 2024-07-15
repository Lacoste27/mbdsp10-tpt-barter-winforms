namespace barter.Components
{
	partial class ImageView
	{
		/// <summary> 
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			picture = new PictureBox();
			((System.ComponentModel.ISupportInitialize)picture).BeginInit();
			SuspendLayout();
			// 
			// picture
			// 
			picture.BackColor = Color.White;
			picture.BorderStyle = BorderStyle.Fixed3D;
			picture.Dock = DockStyle.Fill;
			picture.Image = Properties.Resources.plus;
			picture.Location = new Point(0, 0);
			picture.Name = "picture";
			picture.Size = new Size(100, 100);
			picture.SizeMode = PictureBoxSizeMode.CenterImage;
			picture.TabIndex = 0;
			picture.TabStop = false;
			picture.WaitOnLoad = true;
			// 
			// ImageView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(picture);
			Name = "ImageView";
			Size = new Size(100, 100);
			((System.ComponentModel.ISupportInitialize)picture).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox picture;
	}
}
