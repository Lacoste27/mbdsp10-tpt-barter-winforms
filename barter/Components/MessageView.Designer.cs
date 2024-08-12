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
			username = new Label();
			lastMessage = new Label();
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
			// username
			// 
			username.AutoSize = true;
			username.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			username.Location = new Point(89, 14);
			username.Name = "username";
			username.Size = new Size(62, 15);
			username.TabIndex = 1;
			username.Text = "username";
			// 
			// lastMessage
			// 
			lastMessage.AutoSize = true;
			lastMessage.ForeColor = Color.Gray;
			lastMessage.Location = new Point(89, 43);
			lastMessage.Name = "lastMessage";
			lastMessage.Size = new Size(140, 15);
			lastMessage.TabIndex = 2;
			lastMessage.Text = "Tsisy resume ve any . mer";
			// 
			// MessageView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(lastMessage);
			Controls.Add(username);
			Controls.Add(pictureBox1);
			MaximumSize = new Size(334, 73);
			MinimumSize = new Size(334, 73);
			Name = "MessageView";
			Size = new Size(330, 69);
			Load += MessageView_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label username;
		private Label lastMessage;
	}
}
