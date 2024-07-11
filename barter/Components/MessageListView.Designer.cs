namespace barter.Components
{
	partial class MessageListView
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
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			tableLayoutPanel1 = new TableLayoutPanel();
			richTextBox1 = new RichTextBox();
			pictureBox2 = new PictureBox();
			panel3 = new Panel();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(label1);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.MinimumSize = new Size(917, 47);
			panel1.Name = "panel1";
			panel1.Size = new Size(934, 47);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(59, 14);
			label1.Name = "label1";
			label1.Size = new Size(79, 15);
			label1.TabIndex = 1;
			label1.Text = "Projet MBDS";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.user;
			pictureBox1.Location = new Point(13, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(40, 38);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			panel2.BackColor = Color.White;
			panel2.Controls.Add(tableLayoutPanel1);
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 568);
			panel2.Name = "panel2";
			panel2.Size = new Size(934, 42);
			panel2.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.70011F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.29988956F));
			tableLayoutPanel1.Controls.Add(richTextBox1, 0, 0);
			tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.Padding = new Padding(5);
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(934, 42);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// richTextBox1
			// 
			richTextBox1.BorderStyle = BorderStyle.FixedSingle;
			richTextBox1.Dock = DockStyle.Fill;
			richTextBox1.Location = new Point(8, 8);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.ScrollBars = RichTextBoxScrollBars.Horizontal;
			richTextBox1.Size = new Size(878, 26);
			richTextBox1.TabIndex = 0;
			richTextBox1.Text = "";
			// 
			// pictureBox2
			// 
			pictureBox2.Dock = DockStyle.Fill;
			pictureBox2.Image = Properties.Resources.send;
			pictureBox2.Location = new Point(892, 8);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(34, 26);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			// 
			// panel3
			// 
			panel3.BackColor = Color.White;
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 47);
			panel3.Name = "panel3";
			panel3.Padding = new Padding(5);
			panel3.Size = new Size(934, 521);
			panel3.TabIndex = 2;
			// 
			// MessageListView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "MessageListView";
			Size = new Size(934, 610);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		private Label label1;
		private PictureBox pictureBox1;
		private TableLayoutPanel tableLayoutPanel1;
		private RichTextBox richTextBox1;
		private PictureBox pictureBox2;
	}
}
