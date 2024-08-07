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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Posts));
			panel1 = new Panel();
			mapViewButton = new Button();
			label1 = new Label();
			panel2 = new Panel();
			flowLayoutPanel1 = new FlowLayoutPanel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(mapViewButton);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1192, 53);
			panel1.TabIndex = 0;
			panel1.Paint += panel1_Paint;
			// 
			// mapViewButton
			// 
			mapViewButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			mapViewButton.Image = (Image)resources.GetObject("mapViewButton.Image");
			mapViewButton.ImageAlign = ContentAlignment.MiddleRight;
			mapViewButton.Location = new Point(1084, 8);
			mapViewButton.Name = "mapViewButton";
			mapViewButton.Size = new Size(96, 34);
			mapViewButton.TabIndex = 1;
			mapViewButton.Text = "Map View";
			mapViewButton.TextAlign = ContentAlignment.MiddleLeft;
			mapViewButton.UseVisualStyleBackColor = true;
			mapViewButton.Click += mapViewButton_Click;
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
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.Location = new Point(0, 0);
			flowLayoutPanel1.Margin = new Padding(10);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Padding = new Padding(10);
			flowLayoutPanel1.Size = new Size(1192, 558);
			flowLayoutPanel1.TabIndex = 1;
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
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private FlowLayoutPanel flowLayoutPanel1;
		private Label label1;
		private Button mapViewButton;
	}
}
