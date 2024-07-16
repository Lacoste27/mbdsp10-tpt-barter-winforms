namespace barter.Windows
{
	partial class AddObject
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddObject));
			splitContainer1 = new SplitContainer();
			newCategoryButton = new Button();
			descriptionTextBox = new RichTextBox();
			label3 = new Label();
			categoryComboBox = new ComboBox();
			label2 = new Label();
			nameTextBox = new TextBox();
			label1 = new Label();
			panel2 = new Panel();
			imagePanel = new FlowLayoutPanel();
			addImageButton = new Components.ImageView();
			panel1 = new Panel();
			saveButton = new Button();
			openFileDialog = new OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			panel2.SuspendLayout();
			imagePanel.SuspendLayout();
			panel1.SuspendLayout();
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
			splitContainer1.Panel1.Controls.Add(newCategoryButton);
			splitContainer1.Panel1.Controls.Add(descriptionTextBox);
			splitContainer1.Panel1.Controls.Add(label3);
			splitContainer1.Panel1.Controls.Add(categoryComboBox);
			splitContainer1.Panel1.Controls.Add(label2);
			splitContainer1.Panel1.Controls.Add(nameTextBox);
			splitContainer1.Panel1.Controls.Add(label1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(panel2);
			splitContainer1.Panel2.Controls.Add(panel1);
			splitContainer1.Size = new Size(421, 508);
			splitContainer1.SplitterDistance = 337;
			splitContainer1.SplitterWidth = 1;
			splitContainer1.TabIndex = 0;
			// 
			// newCategoryButton
			// 
			newCategoryButton.Image = (Image)resources.GetObject("newCategoryButton.Image");
			newCategoryButton.Location = new Point(232, 111);
			newCategoryButton.Name = "newCategoryButton";
			newCategoryButton.Size = new Size(31, 23);
			newCategoryButton.TabIndex = 6;
			newCategoryButton.UseVisualStyleBackColor = true;
			newCategoryButton.Click += newCategoryButton_Click;
			// 
			// descriptionTextBox
			// 
			descriptionTextBox.Location = new Point(45, 193);
			descriptionTextBox.Name = "descriptionTextBox";
			descriptionTextBox.Size = new Size(345, 118);
			descriptionTextBox.TabIndex = 5;
			descriptionTextBox.Text = "";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(45, 160);
			label3.Name = "label3";
			label3.Size = new Size(67, 15);
			label3.TabIndex = 4;
			label3.Text = "Description";
			// 
			// categoryComboBox
			// 
			categoryComboBox.FormattingEnabled = true;
			categoryComboBox.Location = new Point(45, 112);
			categoryComboBox.Name = "categoryComboBox";
			categoryComboBox.Size = new Size(181, 23);
			categoryComboBox.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(44, 85);
			label2.Name = "label2";
			label2.Size = new Size(55, 15);
			label2.TabIndex = 2;
			label2.Text = "Category";
			// 
			// nameTextBox
			// 
			nameTextBox.Location = new Point(44, 41);
			nameTextBox.Name = "nameTextBox";
			nameTextBox.Size = new Size(346, 23);
			nameTextBox.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(44, 23);
			label1.Name = "label1";
			label1.Size = new Size(39, 15);
			label1.TabIndex = 0;
			label1.Text = "Name";
			// 
			// panel2
			// 
			panel2.BorderStyle = BorderStyle.Fixed3D;
			panel2.Controls.Add(imagePanel);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(421, 129);
			panel2.TabIndex = 1;
			// 
			// imagePanel
			// 
			imagePanel.AutoScroll = true;
			imagePanel.Controls.Add(addImageButton);
			imagePanel.Dock = DockStyle.Fill;
			imagePanel.Location = new Point(0, 0);
			imagePanel.Name = "imagePanel";
			imagePanel.Padding = new Padding(10);
			imagePanel.Size = new Size(417, 125);
			imagePanel.TabIndex = 0;
			// 
			// addImageButton
			// 
			addImageButton.BackColor = Color.White;
			addImageButton.Location = new Point(13, 13);
			addImageButton.Name = "addImageButton";
			addImageButton.Size = new Size(100, 100);
			addImageButton.TabIndex = 0;
			addImageButton.Load += addImageButton_Load;
			addImageButton.Click += addImageButton_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(saveButton);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 129);
			panel1.Name = "panel1";
			panel1.Size = new Size(421, 41);
			panel1.TabIndex = 0;
			// 
			// saveButton
			// 
			saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			saveButton.Image = Properties.Resources.save;
			saveButton.ImageAlign = ContentAlignment.MiddleLeft;
			saveButton.Location = new Point(344, 6);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(65, 28);
			saveButton.TabIndex = 3;
			saveButton.Text = "Save";
			saveButton.TextAlign = ContentAlignment.MiddleRight;
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += saveButton_Click;
			// 
			// openFileDialog
			// 
			openFileDialog.FileName = "openFileDialog1";
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
			openFileDialog.Multiselect = true;
			// 
			// AddObject
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(421, 508);
			Controls.Add(splitContainer1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(437, 547);
			MinimumSize = new Size(437, 547);
			Name = "AddObject";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add new objet";
			Load += AddObject_Load;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			imagePanel.ResumeLayout(false);
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private Label label1;
		private TextBox nameTextBox;
		private ComboBox categoryComboBox;
		private Label label2;
		private Panel panel2;
		private Panel panel1;
		private RichTextBox descriptionTextBox;
		private Label label3;
		private Button saveButton;
		private Button newCategoryButton;
		private FlowLayoutPanel imagePanel;
		private Components.ImageView addImageButton;
		private OpenFileDialog openFileDialog;
	}
}