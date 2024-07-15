namespace barter.Windows
{
	partial class AddCategory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
			label1 = new Label();
			titleTextBox = new TextBox();
			saveButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(43, 27);
			label1.Name = "label1";
			label1.Size = new Size(29, 15);
			label1.TabIndex = 0;
			label1.Text = "Title";
			// 
			// titleTextBox
			// 
			titleTextBox.Location = new Point(43, 55);
			titleTextBox.Name = "titleTextBox";
			titleTextBox.Size = new Size(223, 23);
			titleTextBox.TabIndex = 1;
			// 
			// saveButton
			// 
			saveButton.Image = Properties.Resources.save;
			saveButton.ImageAlign = ContentAlignment.MiddleLeft;
			saveButton.Location = new Point(201, 101);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(65, 28);
			saveButton.TabIndex = 2;
			saveButton.Text = "Save";
			saveButton.TextAlign = ContentAlignment.MiddleRight;
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += saveButton_Click;
			// 
			// AddCategory
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(310, 155);
			Controls.Add(saveButton);
			Controls.Add(titleTextBox);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(326, 194);
			MinimumSize = new Size(326, 194);
			Name = "AddCategory";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add new category";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox titleTextBox;
		private Button saveButton;
	}
}