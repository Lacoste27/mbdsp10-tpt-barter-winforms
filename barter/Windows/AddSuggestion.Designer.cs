namespace barter.Windows
{
	partial class AddSuggestion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSuggestion));
			panel1 = new Panel();
			label4 = new Label();
			description = new RichTextBox();
			username = new Label();
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			saveButton = new Button();
			panel3 = new Panel();
			splitContainer1 = new SplitContainer();
			splitContainer2 = new SplitContainer();
			label1 = new Label();
			postObject = new CheckedListBox();
			splitContainer3 = new SplitContainer();
			label2 = new Label();
			userObject = new CheckedListBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
			splitContainer3.Panel1.SuspendLayout();
			splitContainer3.Panel2.SuspendLayout();
			splitContainer3.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(label4);
			panel1.Controls.Add(description);
			panel1.Controls.Add(username);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(559, 127);
			panel1.TabIndex = 0;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(161, 9);
			label4.Name = "label4";
			label4.Size = new Size(67, 15);
			label4.TabIndex = 3;
			label4.Text = "Description";
			// 
			// description
			// 
			description.BorderStyle = BorderStyle.None;
			description.Enabled = false;
			description.Location = new Point(161, 39);
			description.Name = "description";
			description.Size = new Size(386, 82);
			description.TabIndex = 2;
			description.Text = "";
			// 
			// username
			// 
			username.AutoSize = true;
			username.Location = new Point(62, 54);
			username.Name = "username";
			username.Size = new Size(38, 15);
			username.TabIndex = 1;
			username.Text = "label3";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.user;
			pictureBox1.Location = new Point(12, 39);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(44, 42);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			panel2.BackColor = Color.White;
			panel2.Controls.Add(saveButton);
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 408);
			panel2.Name = "panel2";
			panel2.Size = new Size(559, 38);
			panel2.TabIndex = 1;
			// 
			// saveButton
			// 
			saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			saveButton.Image = Properties.Resources.save;
			saveButton.ImageAlign = ContentAlignment.MiddleLeft;
			saveButton.Location = new Point(482, 6);
			saveButton.Name = "saveButton";
			saveButton.Size = new Size(65, 28);
			saveButton.TabIndex = 4;
			saveButton.Text = "Save";
			saveButton.TextAlign = ContentAlignment.MiddleRight;
			saveButton.UseVisualStyleBackColor = true;
			saveButton.Click += saveButton_Click;
			// 
			// panel3
			// 
			panel3.Controls.Add(splitContainer1);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 127);
			panel3.Name = "panel3";
			panel3.Size = new Size(559, 281);
			panel3.TabIndex = 2;
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(splitContainer3);
			splitContainer1.Size = new Size(559, 281);
			splitContainer1.SplitterDistance = 275;
			splitContainer1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			splitContainer2.Dock = DockStyle.Fill;
			splitContainer2.Location = new Point(0, 0);
			splitContainer2.Name = "splitContainer2";
			splitContainer2.Orientation = Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			splitContainer2.Panel1.BackColor = Color.White;
			splitContainer2.Panel1.Controls.Add(label1);
			// 
			// splitContainer2.Panel2
			// 
			splitContainer2.Panel2.Controls.Add(postObject);
			splitContainer2.Size = new Size(275, 281);
			splitContainer2.SplitterDistance = 34;
			splitContainer2.TabIndex = 0;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(95, 3);
			label1.Name = "label1";
			label1.Size = new Size(110, 25);
			label1.TabIndex = 0;
			label1.Text = "Post object";
			label1.Click += label1_Click;
			// 
			// postObject
			// 
			postObject.Dock = DockStyle.Fill;
			postObject.FormattingEnabled = true;
			postObject.HorizontalScrollbar = true;
			postObject.Location = new Point(0, 0);
			postObject.Name = "postObject";
			postObject.Size = new Size(275, 243);
			postObject.TabIndex = 0;
			// 
			// splitContainer3
			// 
			splitContainer3.Dock = DockStyle.Fill;
			splitContainer3.Location = new Point(0, 0);
			splitContainer3.Name = "splitContainer3";
			splitContainer3.Orientation = Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			splitContainer3.Panel1.BackColor = Color.White;
			splitContainer3.Panel1.Controls.Add(label2);
			// 
			// splitContainer3.Panel2
			// 
			splitContainer3.Panel2.Controls.Add(userObject);
			splitContainer3.Size = new Size(280, 281);
			splitContainer3.SplitterDistance = 35;
			splitContainer3.TabIndex = 0;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(94, 3);
			label2.Name = "label2";
			label2.Size = new Size(114, 25);
			label2.TabIndex = 1;
			label2.Text = "Your object";
			// 
			// userObject
			// 
			userObject.Dock = DockStyle.Fill;
			userObject.FormattingEnabled = true;
			userObject.HorizontalScrollbar = true;
			userObject.Location = new Point(0, 0);
			userObject.Name = "userObject";
			userObject.Size = new Size(280, 242);
			userObject.TabIndex = 0;
			// 
			// AddSuggestion
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(559, 446);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(575, 485);
			MinimumSize = new Size(575, 485);
			Name = "AddSuggestion";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Suggestion";
			Load += AddSuggestion_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel1.PerformLayout();
			splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			splitContainer3.Panel1.ResumeLayout(false);
			splitContainer3.Panel1.PerformLayout();
			splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
			splitContainer3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		private SplitContainer splitContainer1;
		private SplitContainer splitContainer2;
		private SplitContainer splitContainer3;
		private CheckedListBox postObject;
		private CheckedListBox userObject;
		private Label label1;
		private Label label2;
		private Button saveButton;
		private PictureBox pictureBox1;
		private RichTextBox description;
		private Label username;
		private Label label4;
	}
}