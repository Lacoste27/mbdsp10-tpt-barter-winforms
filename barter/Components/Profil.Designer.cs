namespace barter.Components
{
	partial class Profil
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
			panel1 = new Panel();
			panel3 = new Panel();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			panel5 = new Panel();
			panel4 = new Panel();
			addButton = new Button();
			tabPage2 = new TabPage();
			panel2 = new Panel();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			panel6 = new Panel();
			button1 = new Button();
			panel7 = new Panel();
			addPostButton = new Button();
			panel1.SuspendLayout();
			panel3.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			panel4.SuspendLayout();
			tabPage2.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel6.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(panel3);
			panel1.Controls.Add(panel2);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1192, 672);
			panel1.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.Controls.Add(tabControl1);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 165);
			panel3.Name = "panel3";
			panel3.Padding = new Padding(30);
			panel3.Size = new Size(1192, 507);
			panel3.TabIndex = 1;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.ItemSize = new Size(80, 40);
			tabControl1.Location = new Point(30, 30);
			tabControl1.Margin = new Padding(10);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(1132, 447);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.BackColor = Color.White;
			tabPage1.Controls.Add(panel5);
			tabPage1.Controls.Add(panel4);
			tabPage1.Location = new Point(4, 44);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1124, 399);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Objects";
			// 
			// panel5
			// 
			panel5.Dock = DockStyle.Fill;
			panel5.Location = new Point(3, 57);
			panel5.Name = "panel5";
			panel5.Size = new Size(1118, 339);
			panel5.TabIndex = 1;
			// 
			// panel4
			// 
			panel4.Controls.Add(addButton);
			panel4.Dock = DockStyle.Top;
			panel4.Location = new Point(3, 3);
			panel4.Name = "panel4";
			panel4.Size = new Size(1118, 54);
			panel4.TabIndex = 0;
			// 
			// addButton
			// 
			addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			addButton.Image = (Image)resources.GetObject("addButton.Image");
			addButton.ImageAlign = ContentAlignment.MiddleLeft;
			addButton.Location = new Point(1040, 15);
			addButton.Name = "addButton";
			addButton.Size = new Size(60, 23);
			addButton.TabIndex = 0;
			addButton.Text = "New";
			addButton.TextAlign = ContentAlignment.MiddleRight;
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += addButton_Click;
			// 
			// tabPage2
			// 
			tabPage2.BackColor = Color.White;
			tabPage2.Controls.Add(panel7);
			tabPage2.Controls.Add(panel6);
			tabPage2.Location = new Point(4, 44);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(1124, 399);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Posts";
			// 
			// panel2
			// 
			panel2.Controls.Add(label1);
			panel2.Controls.Add(pictureBox1);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1192, 165);
			panel2.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(294, 75);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 1;
			label1.Text = "Username";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(99, 20);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(137, 126);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// panel6
			// 
			panel6.Controls.Add(addPostButton);
			panel6.Controls.Add(button1);
			panel6.Dock = DockStyle.Top;
			panel6.Location = new Point(3, 3);
			panel6.Name = "panel6";
			panel6.Size = new Size(1118, 54);
			panel6.TabIndex = 1;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button1.Image = (Image)resources.GetObject("button1.Image");
			button1.ImageAlign = ContentAlignment.MiddleLeft;
			button1.Location = new Point(1958, 15);
			button1.Name = "button1";
			button1.Size = new Size(60, 23);
			button1.TabIndex = 0;
			button1.Text = "New";
			button1.TextAlign = ContentAlignment.MiddleRight;
			button1.UseVisualStyleBackColor = true;
			// 
			// panel7
			// 
			panel7.Dock = DockStyle.Fill;
			panel7.Location = new Point(3, 57);
			panel7.Name = "panel7";
			panel7.Size = new Size(1118, 339);
			panel7.TabIndex = 2;
			// 
			// addPostButton
			// 
			addPostButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			addPostButton.Image = (Image)resources.GetObject("addPostButton.Image");
			addPostButton.ImageAlign = ContentAlignment.MiddleLeft;
			addPostButton.Location = new Point(1040, 15);
			addPostButton.Name = "addPostButton";
			addPostButton.Size = new Size(60, 23);
			addPostButton.TabIndex = 1;
			addPostButton.Text = "New";
			addPostButton.TextAlign = ContentAlignment.MiddleRight;
			addPostButton.UseVisualStyleBackColor = true;
			addPostButton.Click += addPostButton_Click;
			// 
			// Profil
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel1);
			Name = "Profil";
			Size = new Size(1192, 672);
			panel1.ResumeLayout(false);
			panel3.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			panel4.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel6.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel3;
		private Panel panel2;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private PictureBox pictureBox1;
		private Label label1;
		private Panel panel4;
		private Panel panel5;
		private Button addButton;
		private Panel panel6;
		private Button button1;
		private Panel panel7;
		private Button addPostButton;
	}
}
