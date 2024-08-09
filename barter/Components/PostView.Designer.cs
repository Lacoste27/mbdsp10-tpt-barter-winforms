namespace barter.Components
{
	partial class PostView
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
			usernameText = new Label();
			objectList = new CheckedListBox();
			publishDate = new Label();
			detailButton = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.user;
			pictureBox1.Location = new Point(28, 32);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(68, 64);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// usernameText
			// 
			usernameText.AutoSize = true;
			usernameText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			usernameText.Location = new Point(117, 54);
			usernameText.Name = "usernameText";
			usernameText.Size = new Size(57, 21);
			usernameText.TabIndex = 1;
			usernameText.Text = "label1";
			usernameText.Click += usernameText_Click;
			// 
			// objectList
			// 
			objectList.FormattingEnabled = true;
			objectList.Location = new Point(28, 132);
			objectList.MultiColumn = true;
			objectList.Name = "objectList";
			objectList.ScrollAlwaysVisible = true;
			objectList.Size = new Size(340, 166);
			objectList.TabIndex = 2;
			// 
			// publishDate
			// 
			publishDate.AutoSize = true;
			publishDate.Location = new Point(28, 313);
			publishDate.Name = "publishDate";
			publishDate.Size = new Size(66, 15);
			publishDate.TabIndex = 3;
			publishDate.Text = "7 years ago";
			// 
			// detailButton
			// 
			detailButton.Location = new Point(293, 55);
			detailButton.Name = "detailButton";
			detailButton.Size = new Size(75, 23);
			detailButton.TabIndex = 4;
			detailButton.Text = "Detail";
			detailButton.UseVisualStyleBackColor = true;
			detailButton.Click += button1_Click;
			// 
			// PostView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(detailButton);
			Controls.Add(publishDate);
			Controls.Add(objectList);
			Controls.Add(usernameText);
			Controls.Add(pictureBox1);
			MaximumSize = new Size(404, 342);
			MinimumSize = new Size(404, 342);
			Name = "PostView";
			Size = new Size(400, 338);
			Load += PostView_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label usernameText;
		private CheckedListBox objectList;
		private Label publishDate;
		private Button detailButton;
	}
}
