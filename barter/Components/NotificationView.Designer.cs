namespace barter.Components
{
	partial class NotificationView
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
			notificationTitle = new Label();
			notificationMessage = new Label();
			label3 = new Label();
			SuspendLayout();
			// 
			// notificationTitle
			// 
			notificationTitle.AutoSize = true;
			notificationTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			notificationTitle.ForeColor = Color.FromArgb(39, 194, 64);
			notificationTitle.Location = new Point(18, 10);
			notificationTitle.Name = "notificationTitle";
			notificationTitle.Size = new Size(135, 15);
			notificationTitle.TabIndex = 0;
			notificationTitle.Text = "This is your notification";
			// 
			// notificationMessage
			// 
			notificationMessage.AutoSize = true;
			notificationMessage.Location = new Point(18, 35);
			notificationMessage.Name = "notificationMessage";
			notificationMessage.Size = new Size(38, 15);
			notificationMessage.TabIndex = 1;
			notificationMessage.Text = "lorem";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.Silver;
			label3.Location = new Point(383, 47);
			label3.Name = "label3";
			label3.Size = new Size(41, 15);
			label3.TabIndex = 2;
			label3.Text = "1 hour";
			// 
			// NotificationView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.WhiteSmoke;
			BorderStyle = BorderStyle.FixedSingle;
			Controls.Add(label3);
			Controls.Add(notificationMessage);
			Controls.Add(notificationTitle);
			Name = "NotificationView";
			Size = new Size(434, 72);
			Load += NotificationView_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label notificationTitle;
		private Label notificationMessage;
		private Label label3;
	}
}
