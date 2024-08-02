namespace barter.Components
{
	partial class ObjectView
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
			categoryText = new Label();
			label2 = new Label();
			label1 = new Label();
			nameText = new Label();
			imageLayout = new FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(categoryText);
			splitContainer1.Panel1.Controls.Add(label2);
			splitContainer1.Panel1.Controls.Add(label1);
			splitContainer1.Panel1.Controls.Add(nameText);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(imageLayout);
			splitContainer1.Size = new Size(279, 257);
			splitContainer1.SplitterDistance = 81;
			splitContainer1.TabIndex = 0;
			// 
			// categoryText
			// 
			categoryText.AutoSize = true;
			categoryText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			categoryText.Location = new Point(87, 49);
			categoryText.Name = "categoryText";
			categoryText.Size = new Size(47, 15);
			categoryText.TabIndex = 3;
			categoryText.Text = "Vehicle";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(18, 49);
			label2.Name = "label2";
			label2.Size = new Size(61, 15);
			label2.TabIndex = 2;
			label2.Text = "Category :";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(18, 15);
			label1.Name = "label1";
			label1.Size = new Size(45, 15);
			label1.TabIndex = 1;
			label1.Text = "Name :";
			// 
			// nameText
			// 
			nameText.AutoSize = true;
			nameText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			nameText.Location = new Point(69, 15);
			nameText.Name = "nameText";
			nameText.Size = new Size(56, 15);
			nameText.TabIndex = 0;
			nameText.Text = "BMW X2";
			// 
			// imageLayout
			// 
			imageLayout.AutoScroll = true;
			imageLayout.Dock = DockStyle.Fill;
			imageLayout.Location = new Point(0, 0);
			imageLayout.Name = "imageLayout";
			imageLayout.Padding = new Padding(10);
			imageLayout.Size = new Size(279, 172);
			imageLayout.TabIndex = 0;
			imageLayout.DoubleClick += imageLayout_DoubleClick;
			// 
			// ObjectView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BorderStyle = BorderStyle.Fixed3D;
			Controls.Add(splitContainer1);
			Name = "ObjectView";
			Size = new Size(279, 257);
			Load += ObjectView_Load;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private Label nameText;
		private Label label1;
		private Label categoryText;
		private Label label2;
		public FlowLayoutPanel imageLayout;
	}
}
