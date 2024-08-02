namespace barter.Windows
{
	partial class DetailObject
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailObject));
			splitContainer1 = new SplitContainer();
			panel1 = new Panel();
			saveButton = new Button();
			desctiptionText = new RichTextBox();
			label3 = new Label();
			categoryComboBox = new ComboBox();
			label2 = new Label();
			nameText = new TextBox();
			label1 = new Label();
			imageLayout = new FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.BackColor = Color.White;
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(panel1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(imageLayout);
			splitContainer1.Size = new Size(501, 503);
			splitContainer1.SplitterDistance = 297;
			splitContainer1.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.Controls.Add(saveButton);
			panel1.Controls.Add(desctiptionText);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(categoryComboBox);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(nameText);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(501, 297);
			panel1.TabIndex = 0;
			// 
			// saveButton
			// 
			saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			saveButton.Image = Properties.Resources.save;
			saveButton.ImageAlign = ContentAlignment.MiddleLeft;
			saveButton.Location = new Point(368, 257);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(65, 28);
			saveButton.TabIndex = 6;
			saveButton.Text = "Save";
			saveButton.TextAlign = ContentAlignment.MiddleRight;
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += saveButton_Click;
			// 
			// desctiptionText
			// 
			desctiptionText.Location = new Point(114, 143);
			desctiptionText.Name = "desctiptionText";
			desctiptionText.Size = new Size(319, 96);
			desctiptionText.TabIndex = 5;
			desctiptionText.Text = "";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(35, 137);
			label3.Name = "label3";
			label3.Size = new Size(73, 15);
			label3.TabIndex = 4;
			label3.Text = "Description :";
			// 
			// categoryComboBox
			// 
			categoryComboBox.FormattingEnabled = true;
			categoryComboBox.Location = new Point(114, 80);
			categoryComboBox.Name = "categoryComboBox";
			categoryComboBox.Size = new Size(319, 23);
			categoryComboBox.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(35, 83);
			label2.Name = "label2";
			label2.Size = new Size(61, 15);
			label2.TabIndex = 2;
			label2.Text = "Category :";
			// 
			// nameText
			// 
			nameText.Location = new Point(114, 31);
			nameText.Name = "nameText";
			nameText.Size = new Size(319, 23);
			nameText.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(35, 34);
			label1.Name = "label1";
			label1.Size = new Size(45, 15);
			label1.TabIndex = 0;
			label1.Text = "Name :";
			// 
			// imageLayout
			// 
			imageLayout.Dock = DockStyle.Fill;
			imageLayout.Location = new Point(0, 0);
			imageLayout.Name = "imageLayout";
			imageLayout.Padding = new Padding(10);
			imageLayout.Size = new Size(501, 202);
			imageLayout.TabIndex = 0;
			// 
			// DetailObject
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(501, 503);
			Controls.Add(splitContainer1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(517, 542);
			MinimumSize = new Size(517, 542);
			Name = "DetailObject";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Object detail";
			Load += DetailObject_Load;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private Panel panel1;
		private FlowLayoutPanel imageLayout;
		private Label label1;
		private TextBox nameText;
		private Label label2;
		private ComboBox categoryComboBox;
		private RichTextBox desctiptionText;
		private Label label3;
		private Button saveButton;
	}
}