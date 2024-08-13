namespace barter.Components
{
	partial class SuggestionView
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
			suggestStatus = new Button();
			detailButton = new Button();
			username = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.user;
			pictureBox1.Location = new Point(22, 14);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(47, 50);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// suggestStatus
			// 
			suggestStatus.BackColor = Color.FromArgb(255, 128, 0);
			suggestStatus.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
			suggestStatus.FlatStyle = FlatStyle.Flat;
			suggestStatus.ForeColor = Color.White;
			suggestStatus.Location = new Point(22, 88);
			suggestStatus.Name = "suggestStatus";
			suggestStatus.Size = new Size(106, 33);
			suggestStatus.TabIndex = 7;
			suggestStatus.Text = "Pending";
			suggestStatus.UseVisualStyleBackColor = false;
			// 
			// detailButton
			// 
			detailButton.BackColor = SystemColors.ButtonFace;
			detailButton.FlatAppearance.BorderColor = Color.FromArgb(39, 194, 64);
			detailButton.FlatStyle = FlatStyle.System;
			detailButton.ForeColor = Color.Black;
			detailButton.Location = new Point(241, 88);
			detailButton.Name = "detailButton";
			detailButton.Size = new Size(106, 33);
			detailButton.TabIndex = 8;
			detailButton.Text = "Details";
			detailButton.UseVisualStyleBackColor = false;
			detailButton.Click += detailButton_Click;
			// 
			// username
			// 
			username.AutoSize = true;
			username.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			username.Location = new Point(90, 14);
			username.Name = "username";
			username.Size = new Size(45, 17);
			username.TabIndex = 9;
			username.Text = "label1";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(90, 49);
			label1.Name = "label1";
			label1.Size = new Size(92, 15);
			label1.TabIndex = 10;
			label1.Text = "Suggered post : ";
			// 
			// SuggestionView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(label1);
			Controls.Add(username);
			Controls.Add(detailButton);
			Controls.Add(suggestStatus);
			Controls.Add(pictureBox1);
			Name = "SuggestionView";
			Size = new Size(363, 133);
			Load += SuggestionView_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Button suggestStatus;
		private Label username;
		private Label label1;
		public Button detailButton;
	}
}
