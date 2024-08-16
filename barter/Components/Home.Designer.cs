namespace barter.Components
{
	partial class Home
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			panel1 = new Panel();
			mapViewButton = new Button();
			label1 = new Label();
			panel2 = new Panel();
			progression = new ProgressBar();
			nextButton = new Button();
			pageNumber = new TextBox();
			previousButton = new Button();
			panel3 = new Panel();
			layout = new FlowLayoutPanel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(mapViewButton);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1176, 53);
			panel1.TabIndex = 0;
			// 
			// mapViewButton
			// 
			mapViewButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			mapViewButton.Image = (Image)resources.GetObject("mapViewButton.Image");
			mapViewButton.ImageAlign = ContentAlignment.MiddleRight;
			mapViewButton.Location = new Point(1050, 10);
			mapViewButton.Name = "mapViewButton";
			mapViewButton.Size = new Size(96, 34);
			mapViewButton.TabIndex = 2;
			mapViewButton.Text = "Map View";
			mapViewButton.TextAlign = ContentAlignment.MiddleLeft;
			mapViewButton.UseVisualStyleBackColor = true;
			mapViewButton.Click += mapViewButton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(51, 20);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 1;
			label1.Text = "Mes posts";
			// 
			// panel2
			// 
			panel2.Controls.Add(progression);
			panel2.Controls.Add(nextButton);
			panel2.Controls.Add(pageNumber);
			panel2.Controls.Add(previousButton);
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 583);
			panel2.Name = "panel2";
			panel2.Size = new Size(1176, 35);
			panel2.TabIndex = 1;
			// 
			// progression
			// 
			progression.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			progression.Location = new Point(753, 6);
			progression.MarqueeAnimationSpeed = 40;
			progression.Name = "progression";
			progression.Size = new Size(393, 23);
			progression.Style = ProgressBarStyle.Marquee;
			progression.TabIndex = 6;
			progression.Visible = false;
			// 
			// nextButton
			// 
			nextButton.Location = new Point(80, 6);
			nextButton.Name = "nextButton";
			nextButton.Size = new Size(22, 23);
			nextButton.TabIndex = 5;
			nextButton.Text = ">";
			nextButton.UseVisualStyleBackColor = true;
			nextButton.Click += nextButton_Click;
			// 
			// pageNumber
			// 
			pageNumber.Location = new Point(41, 6);
			pageNumber.Name = "pageNumber";
			pageNumber.Size = new Size(33, 23);
			pageNumber.TabIndex = 4;
			// 
			// previousButton
			// 
			previousButton.Location = new Point(13, 6);
			previousButton.Name = "previousButton";
			previousButton.Size = new Size(22, 23);
			previousButton.TabIndex = 3;
			previousButton.Text = "<";
			previousButton.UseVisualStyleBackColor = true;
			previousButton.Click += previousButton_Click;
			// 
			// panel3
			// 
			panel3.Controls.Add(layout);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 53);
			panel3.Name = "panel3";
			panel3.Size = new Size(1176, 530);
			panel3.TabIndex = 2;
			// 
			// layout
			// 
			layout.AutoScroll = true;
			layout.Dock = DockStyle.Fill;
			layout.Location = new Point(0, 0);
			layout.Name = "layout";
			layout.Padding = new Padding(10);
			layout.Size = new Size(1176, 530);
			layout.TabIndex = 2;
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "Home";
			Size = new Size(1176, 618);
			Load += Home_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Button mapViewButton;
		private Panel panel2;
		private Panel panel3;
		private FlowLayoutPanel layout;
		private Button nextButton;
		private TextBox pageNumber;
		private Button previousButton;
		private ProgressBar progression;
	}
}
