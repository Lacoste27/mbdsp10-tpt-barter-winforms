namespace barter.Components
{
	partial class Posts
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
			panel2 = new Panel();
			flowLayoutPanel1 = new FlowLayoutPanel();
			card1 = new Card();
			label1 = new Label();
			card2 = new Card();
			card3 = new Card();
			card4 = new Card();
			card5 = new Card();
			card6 = new Card();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1192, 53);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(flowLayoutPanel1);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 53);
			panel2.Name = "panel2";
			panel2.Size = new Size(1192, 558);
			panel2.TabIndex = 1;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoScroll = true;
			flowLayoutPanel1.AutoSize = true;
			flowLayoutPanel1.Controls.Add(card1);
			flowLayoutPanel1.Controls.Add(card2);
			flowLayoutPanel1.Controls.Add(card3);
			flowLayoutPanel1.Controls.Add(card4);
			flowLayoutPanel1.Controls.Add(card5);
			flowLayoutPanel1.Controls.Add(card6);
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.Location = new Point(0, 0);
			flowLayoutPanel1.Margin = new Padding(10);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Padding = new Padding(10);
			flowLayoutPanel1.Size = new Size(1192, 558);
			flowLayoutPanel1.TabIndex = 1;
			// 
			// card1
			// 
			card1.BackColor = Color.White;
			card1.BorderStyle = BorderStyle.Fixed3D;
			card1.Location = new Point(30, 30);
			card1.Margin = new Padding(20);
			card1.Name = "card1";
			card1.Size = new Size(387, 222);
			card1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(26, 18);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 0;
			label1.Text = "Mes posts";
			// 
			// card2
			// 
			card2.BackColor = Color.White;
			card2.BorderStyle = BorderStyle.Fixed3D;
			card2.Location = new Point(457, 30);
			card2.Margin = new Padding(20);
			card2.Name = "card2";
			card2.Size = new Size(387, 222);
			card2.TabIndex = 1;
			// 
			// card3
			// 
			card3.BackColor = Color.White;
			card3.BorderStyle = BorderStyle.Fixed3D;
			card3.Location = new Point(30, 292);
			card3.Margin = new Padding(20);
			card3.Name = "card3";
			card3.Size = new Size(387, 222);
			card3.TabIndex = 2;
			// 
			// card4
			// 
			card4.BackColor = Color.White;
			card4.BorderStyle = BorderStyle.Fixed3D;
			card4.Location = new Point(457, 292);
			card4.Margin = new Padding(20);
			card4.Name = "card4";
			card4.Size = new Size(387, 222);
			card4.TabIndex = 3;
			// 
			// card5
			// 
			card5.BackColor = Color.White;
			card5.BorderStyle = BorderStyle.Fixed3D;
			card5.Location = new Point(30, 554);
			card5.Margin = new Padding(20);
			card5.Name = "card5";
			card5.Size = new Size(387, 222);
			card5.TabIndex = 4;
			// 
			// card6
			// 
			card6.BackColor = Color.White;
			card6.BorderStyle = BorderStyle.Fixed3D;
			card6.Location = new Point(457, 554);
			card6.Margin = new Padding(20);
			card6.Name = "card6";
			card6.Size = new Size(387, 222);
			card6.TabIndex = 5;
			// 
			// Posts
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "Posts";
			Size = new Size(1192, 611);
			Load += Posts_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			flowLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private FlowLayoutPanel flowLayoutPanel1;
		private Card card1;
		private Label label1;
		private Card card2;
		private Card card3;
		private Card card4;
		private Card card5;
		private Card card6;
	}
}
