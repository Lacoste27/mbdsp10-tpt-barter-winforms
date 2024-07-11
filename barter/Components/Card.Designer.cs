namespace barter.Components
{
	partial class Card
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
			richTextBox1 = new RichTextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.user;
			pictureBox1.Location = new Point(17, 16);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(42, 43);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(68, 29);
			label1.Name = "label1";
			label1.Size = new Size(90, 15);
			label1.TabIndex = 1;
			label1.Text = "User Guess who";
			// 
			// richTextBox1
			// 
			richTextBox1.AutoWordSelection = true;
			richTextBox1.BorderStyle = BorderStyle.None;
			richTextBox1.BulletIndent = 1;
			richTextBox1.Location = new Point(17, 85);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(348, 95);
			richTextBox1.TabIndex = 2;
			richTextBox1.Text = "Tables\nCamera\nTriped\nCar";
			// 
			// Card
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(richTextBox1);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Name = "Card";
			Size = new Size(387, 222);
			Load += Card_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private RichTextBox richTextBox1;
	}
}
