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
			tabPage2 = new TabPage();
			panel2 = new Panel();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			listView1 = new ListView();
			listView2 = new ListView();
			listView3 = new ListView();
			listView4 = new ListView();
			panel1.SuspendLayout();
			panel3.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tableLayoutPanel1.SuspendLayout();
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
			tabPage1.Controls.Add(tableLayoutPanel1);
			tabPage1.Location = new Point(4, 44);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(1124, 399);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Objects";
			// 
			// tabPage2
			// 
			tabPage2.BackColor = Color.White;
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
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.AutoScroll = true;
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(listView4, 0, 3);
			tableLayoutPanel1.Controls.Add(listView3, 0, 2);
			tableLayoutPanel1.Controls.Add(listView2, 0, 1);
			tableLayoutPanel1.Controls.Add(listView1, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 3);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.Padding = new Padding(15);
			tableLayoutPanel1.RowCount = 4;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel1.Size = new Size(1118, 393);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// listView1
			// 
			listView1.BackColor = Color.WhiteSmoke;
			listView1.BorderStyle = BorderStyle.Fixed3D;
			listView1.Dock = DockStyle.Fill;
			listView1.Location = new Point(18, 18);
			listView1.Name = "listView1";
			listView1.Size = new Size(1082, 84);
			listView1.TabIndex = 0;
			// 
			// listView2
			// 
			listView2.BackColor = Color.WhiteSmoke;
			listView2.BorderStyle = BorderStyle.Fixed3D;
			listView2.Dock = DockStyle.Fill;
			listView2.Location = new Point(18, 108);
			listView2.Name = "listView2";
			listView2.Size = new Size(1082, 84);
			listView2.TabIndex = 1;
			// 
			// listView3
			// 
			listView3.BackColor = Color.WhiteSmoke;
			listView3.BorderStyle = BorderStyle.Fixed3D;
			listView3.Dock = DockStyle.Fill;
			listView3.Location = new Point(18, 198);
			listView3.Name = "listView3";
			listView3.Size = new Size(1082, 84);
			listView3.TabIndex = 2;
			// 
			// listView4
			// 
			listView4.BackColor = Color.WhiteSmoke;
			listView4.BorderStyle = BorderStyle.Fixed3D;
			listView4.Dock = DockStyle.Fill;
			listView4.Location = new Point(18, 288);
			listView4.Name = "listView4";
			listView4.Size = new Size(1082, 87);
			listView4.TabIndex = 3;
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
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
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
		private TableLayoutPanel tableLayoutPanel1;
		private ListView listView1;
		private ListView listView3;
		private ListView listView2;
		private ListView listView4;
	}
}
