namespace barter.Components
{
	partial class ObjectDetailView
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
			splitContainer1 = new SplitContainer();
			panel1 = new Panel();
			description = new RichTextBox();
			objectName = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			nextButton = new Button();
			picture = new PictureBox();
			prevButton = new Button();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			panel1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picture).BeginInit();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(panel1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
			splitContainer1.Size = new Size(875, 166);
			splitContainer1.SplitterDistance = 620;
			splitContainer1.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(description);
			panel1.Controls.Add(objectName);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(620, 166);
			panel1.TabIndex = 0;
			// 
			// description
			// 
			description.BorderStyle = BorderStyle.None;
			description.Location = new Point(17, 47);
			description.Name = "description";
			description.Size = new Size(596, 105);
			description.TabIndex = 1;
			description.Text = "";
			description.TextChanged += richTextBox1_TextChanged;
			// 
			// objectName
			// 
			objectName.AutoSize = true;
			objectName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			objectName.Location = new Point(17, 17);
			objectName.Name = "objectName";
			objectName.Size = new Size(45, 17);
			objectName.TabIndex = 0;
			objectName.Text = "label1";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.BackColor = Color.White;
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.63492F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.36508F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
			tableLayoutPanel1.Controls.Add(nextButton, 2, 0);
			tableLayoutPanel1.Controls.Add(picture, 1, 0);
			tableLayoutPanel1.Controls.Add(prevButton, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(251, 166);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// nextButton
			// 
			nextButton.FlatAppearance.BorderSize = 0;
			nextButton.FlatStyle = FlatStyle.Flat;
			nextButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			nextButton.ForeColor = Color.FromArgb(39, 194, 64);
			nextButton.Location = new Point(211, 3);
			nextButton.Name = "nextButton";
			nextButton.Size = new Size(33, 160);
			nextButton.TabIndex = 2;
			nextButton.Text = ">";
			nextButton.UseVisualStyleBackColor = true;
			nextButton.Click += nextButton_Click;
			// 
			// picture
			// 
			picture.Dock = DockStyle.Fill;
			picture.InitialImage = Properties.Resources.Group_15;
			picture.Location = new Point(46, 3);
			picture.Name = "picture";
			picture.Size = new Size(159, 160);
			picture.TabIndex = 0;
			picture.TabStop = false;
			picture.WaitOnLoad = true;
			// 
			// prevButton
			// 
			prevButton.FlatAppearance.BorderSize = 0;
			prevButton.FlatStyle = FlatStyle.Flat;
			prevButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			prevButton.ForeColor = Color.FromArgb(39, 194, 64);
			prevButton.Location = new Point(3, 3);
			prevButton.Name = "prevButton";
			prevButton.Size = new Size(33, 160);
			prevButton.TabIndex = 1;
			prevButton.Text = "<";
			prevButton.UseVisualStyleBackColor = true;
			prevButton.Click += prevButton_Click;
			// 
			// ObjectDetailView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BorderStyle = BorderStyle.FixedSingle;
			Controls.Add(splitContainer1);
			Name = "ObjectDetailView";
			Size = new Size(875, 166);
			Load += ObjectDetailView_Load;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)picture).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private TableLayoutPanel tableLayoutPanel1;
		private PictureBox picture;
		private Panel panel1;
		private Button prevButton;
		private Button nextButton;
		private Label objectName;
		private RichTextBox description;
	}
}
