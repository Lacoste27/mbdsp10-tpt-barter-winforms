namespace barter.Windows
{
	partial class DetailPost
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailPost));
			splitContainer1 = new SplitContainer();
			panel1 = new Panel();
			splitContainer2 = new SplitContainer();
			panel3 = new Panel();
			splitContainer3 = new SplitContainer();
			panel5 = new Panel();
			button1 = new Button();
			suggestButton = new Button();
			sendMessageButton = new Button();
			publishDate = new Label();
			username = new Label();
			pictureBox1 = new PictureBox();
			categoryLayout = new FlowLayoutPanel();
			panel4 = new Panel();
			label1 = new Label();
			description = new RichTextBox();
			panel2 = new Panel();
			objectListLayout = new FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
			splitContainer3.Panel1.SuspendLayout();
			splitContainer3.Panel2.SuspendLayout();
			splitContainer3.SuspendLayout();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel4.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.IsSplitterFixed = true;
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
			splitContainer1.Panel2.Controls.Add(panel2);
			splitContainer1.Size = new Size(954, 599);
			splitContainer1.SplitterDistance = 203;
			splitContainer1.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.Controls.Add(splitContainer2);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(954, 203);
			panel1.TabIndex = 0;
			// 
			// splitContainer2
			// 
			splitContainer2.Dock = DockStyle.Fill;
			splitContainer2.Location = new Point(0, 0);
			splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			splitContainer2.Panel1.Controls.Add(panel3);
			// 
			// splitContainer2.Panel2
			// 
			splitContainer2.Panel2.Controls.Add(panel4);
			splitContainer2.Size = new Size(954, 203);
			splitContainer2.SplitterDistance = 395;
			splitContainer2.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.AutoScroll = true;
			panel3.Controls.Add(splitContainer3);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(395, 203);
			panel3.TabIndex = 0;
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
			splitContainer3.Panel1.Controls.Add(panel5);
			// 
			// splitContainer3.Panel2
			// 
			splitContainer3.Panel2.Controls.Add(categoryLayout);
			splitContainer3.Size = new Size(395, 203);
			splitContainer3.SplitterDistance = 169;
			splitContainer3.TabIndex = 0;
			// 
			// panel5
			// 
			panel5.Controls.Add(button1);
			panel5.Controls.Add(suggestButton);
			panel5.Controls.Add(sendMessageButton);
			panel5.Controls.Add(publishDate);
			panel5.Controls.Add(username);
			panel5.Controls.Add(pictureBox1);
			panel5.Dock = DockStyle.Fill;
			panel5.Location = new Point(0, 0);
			panel5.Name = "panel5";
			panel5.Size = new Size(395, 169);
			panel5.TabIndex = 0;
			// 
			// button1
			// 
			button1.FlatStyle = FlatStyle.Flat;
			button1.ForeColor = Color.Red;
			button1.Location = new Point(286, 111);
			button1.Name = "button1";
			button1.Size = new Size(106, 33);
			button1.TabIndex = 7;
			button1.Text = "Report";
			button1.UseVisualStyleBackColor = true;
			// 
			// suggestButton
			// 
			suggestButton.BackColor = Color.FromArgb(39, 194, 64);
			suggestButton.FlatAppearance.BorderColor = Color.FromArgb(39, 194, 64);
			suggestButton.FlatStyle = FlatStyle.Flat;
			suggestButton.ForeColor = Color.White;
			suggestButton.Location = new Point(129, 111);
			suggestButton.Name = "suggestButton";
			suggestButton.Size = new Size(106, 33);
			suggestButton.TabIndex = 6;
			suggestButton.Text = "Suggest";
			suggestButton.UseVisualStyleBackColor = false;
			suggestButton.Click += suggestButton_Click;
			// 
			// sendMessageButton
			// 
			sendMessageButton.FlatStyle = FlatStyle.Flat;
			sendMessageButton.ForeColor = Color.FromArgb(39, 194, 64);
			sendMessageButton.Location = new Point(21, 111);
			sendMessageButton.Name = "sendMessageButton";
			sendMessageButton.Size = new Size(106, 33);
			sendMessageButton.TabIndex = 5;
			sendMessageButton.Text = "Send Message";
			sendMessageButton.UseVisualStyleBackColor = true;
			sendMessageButton.Click += sendMessageButton_Click;
			// 
			// publishDate
			// 
			publishDate.AutoSize = true;
			publishDate.Location = new Point(279, 35);
			publishDate.Name = "publishDate";
			publishDate.Size = new Size(38, 15);
			publishDate.TabIndex = 4;
			publishDate.Text = "label1";
			// 
			// username
			// 
			username.AutoSize = true;
			username.Location = new Point(79, 35);
			username.Name = "username";
			username.Size = new Size(38, 15);
			username.TabIndex = 3;
			username.Text = "label1";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.user;
			pictureBox1.Location = new Point(23, 16);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(50, 50);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// categoryLayout
			// 
			categoryLayout.AutoScroll = true;
			categoryLayout.Dock = DockStyle.Fill;
			categoryLayout.Location = new Point(0, 0);
			categoryLayout.Name = "categoryLayout";
			categoryLayout.Size = new Size(395, 30);
			categoryLayout.TabIndex = 0;
			// 
			// panel4
			// 
			panel4.Controls.Add(label1);
			panel4.Controls.Add(description);
			panel4.Dock = DockStyle.Fill;
			panel4.Location = new Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(555, 203);
			panel4.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(15, 23);
			label1.Name = "label1";
			label1.Size = new Size(67, 15);
			label1.TabIndex = 1;
			label1.Text = "Description";
			// 
			// description
			// 
			description.BackColor = Color.White;
			description.Location = new Point(15, 61);
			description.Name = "description";
			description.ReadOnly = true;
			description.Size = new Size(517, 128);
			description.TabIndex = 0;
			description.Text = "";
			description.TextChanged += richTextBox1_TextChanged;
			// 
			// panel2
			// 
			panel2.Controls.Add(objectListLayout);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(954, 392);
			panel2.TabIndex = 0;
			// 
			// objectListLayout
			// 
			objectListLayout.AutoScroll = true;
			objectListLayout.Dock = DockStyle.Fill;
			objectListLayout.Location = new Point(0, 0);
			objectListLayout.Name = "objectListLayout";
			objectListLayout.Padding = new Padding(20);
			objectListLayout.Size = new Size(954, 392);
			objectListLayout.TabIndex = 0;
			// 
			// DetailPost
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(954, 599);
			Controls.Add(splitContainer1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(970, 638);
			MinimumSize = new Size(970, 638);
			Name = "DetailPost";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Post detail";
			Load += DetailPost_Load;
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			panel1.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			splitContainer3.Panel1.ResumeLayout(false);
			splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
			splitContainer3.ResumeLayout(false);
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private Panel panel1;
		private Panel panel2;
		private FlowLayoutPanel objectListLayout;
		private SplitContainer splitContainer2;
		private Panel panel3;
		private Panel panel4;
		private SplitContainer splitContainer3;
		private Panel panel5;
		private Label username;
		private PictureBox pictureBox1;
		private Label publishDate;
		private FlowLayoutPanel categoryLayout;
		private Button suggestButton;
		private Button sendMessageButton;
		private RichTextBox description;
		private Label label1;
		private Button button1;
	}
}