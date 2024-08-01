namespace barter.Components
{
	partial class ListView
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
			NameText = new Label();
			richTextBox1 = new RichTextBox();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.user;
			pictureBox1.Location = new Point(19, 16);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(98, 97);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// NameText
			// 
			NameText.AutoSize = true;
			NameText.Location = new Point(160, 16);
			NameText.Name = "NameText";
			NameText.Size = new Size(29, 15);
			NameText.TabIndex = 1;
			NameText.Text = "Title";
			// 
			// richTextBox1
			// 
			richTextBox1.BackColor = Color.WhiteSmoke;
			richTextBox1.BorderStyle = BorderStyle.None;
			richTextBox1.Location = new Point(160, 34);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(682, 50);
			richTextBox1.TabIndex = 2;
			richTextBox1.Text = "";
			// 
			// button1
			// 
			button1.Location = new Point(160, 90);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 3;
			button1.Text = "Details";
			button1.UseVisualStyleBackColor = true;
			// 
			// ListView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = Color.WhiteSmoke;
			BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(button1);
			Controls.Add(richTextBox1);
			Controls.Add(NameText);
			Controls.Add(pictureBox1);
			Name = "ListView";
			Size = new Size(845, 135);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label NameText;
		private RichTextBox richTextBox1;
		private Button button1;
	}
}
