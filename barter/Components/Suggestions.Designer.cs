namespace barter.Components
{
	partial class Suggestions
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
			panel1 = new Panel();
			label1 = new Label();
			panel2 = new Panel();
			layout = new FlowLayoutPanel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(939, 53);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(41, 20);
			label1.Name = "label1";
			label1.Size = new Size(95, 15);
			label1.TabIndex = 2;
			label1.Text = "Mes suggestions";
			// 
			// panel2
			// 
			panel2.Controls.Add(layout);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 53);
			panel2.Name = "panel2";
			panel2.Size = new Size(939, 474);
			panel2.TabIndex = 1;
			// 
			// layout
			// 
			layout.Dock = DockStyle.Fill;
			layout.Location = new Point(0, 0);
			layout.Name = "layout";
			layout.Size = new Size(939, 474);
			layout.TabIndex = 0;
			// 
			// Suggestions
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "Suggestions";
			Size = new Size(939, 527);
			Load += Suggestions_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Panel panel2;
		private FlowLayoutPanel layout;
	}
}
