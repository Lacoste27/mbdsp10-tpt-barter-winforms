namespace barter.Components
{
	partial class MessageView
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
			pictureBox1 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.user;
			pictureBox1.Location = new Point(15, 14);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(53, 44);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.Location = new Point(89, 14);
			label1.Name = "label1";
			label1.Size = new Size(79, 15);
			label1.TabIndex = 1;
			label1.Text = "Projet MBDS";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.Gray;
			label2.Location = new Point(89, 43);
			label2.Name = "label2";
			label2.Size = new Size(140, 15);
			label2.TabIndex = 2;
			label2.Text = "Tsisy resume ve any . mer";
			// 
			// MessageView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			MaximumSize = new Size(334, 73);
			MinimumSize = new Size(334, 73);
			Name = "MessageView";
			Size = new Size(334, 73);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
	}
}
