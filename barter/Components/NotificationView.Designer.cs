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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.FromArgb(39, 194, 64);
			label1.Location = new Point(18, 10);
			label1.Name = "label1";
			label1.Size = new Size(135, 15);
			label1.TabIndex = 0;
			label1.Text = "This is your notification";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(18, 35);
			label2.Name = "label2";
			label2.Size = new Size(38, 15);
			label2.TabIndex = 1;
			label2.Text = "lorem";
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
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "NotificationView";
			Size = new Size(434, 72);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
	}
}
