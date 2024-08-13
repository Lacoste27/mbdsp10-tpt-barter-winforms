namespace barter.Windows
{
	partial class SuggestionDetail
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuggestionDetail));
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			label4 = new Label();
			description = new RichTextBox();
			username = new Label();
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			declinedButton = new Button();
			acceptButton = new Button();
			panel3 = new Panel();
			splitContainer1 = new SplitContainer();
			postObject = new CheckedListBox();
			suggestedObjet = new CheckedListBox();
			createdAt = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(createdAt);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(description);
			panel1.Controls.Add(username);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(618, 159);
			panel1.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			label2.Location = new Point(378, 122);
			label2.Name = "label2";
			label2.Size = new Size(166, 25);
			label2.TabIndex = 9;
			label2.Text = "Suggested object";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			label1.Location = new Point(68, 122);
			label1.Name = "label1";
			label1.Size = new Size(158, 25);
			label1.TabIndex = 8;
			label1.Text = "Your object post";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(167, 7);
			label4.Name = "label4";
			label4.Size = new Size(67, 15);
			label4.TabIndex = 7;
			label4.Text = "Description";
			// 
			// description
			// 
			description.BorderStyle = BorderStyle.None;
			description.Enabled = false;
			description.Location = new Point(167, 37);
			description.Name = "description";
			description.Size = new Size(428, 68);
			description.TabIndex = 6;
			description.Text = "";
			// 
			// username
			// 
			username.AutoSize = true;
			username.Location = new Point(68, 26);
			username.Name = "username";
			username.Size = new Size(38, 15);
			username.TabIndex = 5;
			username.Text = "label3";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.user;
			pictureBox1.Location = new Point(18, 11);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(44, 42);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			panel2.BackColor = Color.White;
			panel2.Controls.Add(declinedButton);
			panel2.Controls.Add(acceptButton);
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 450);
			panel2.Name = "panel2";
			panel2.Size = new Size(618, 38);
			panel2.TabIndex = 1;
			// 
			// declinedButton
			// 
			declinedButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			declinedButton.BackColor = Color.Red;
			declinedButton.FlatStyle = FlatStyle.Flat;
			declinedButton.ForeColor = Color.White;
			declinedButton.Image = Properties.Resources.decline;
			declinedButton.ImageAlign = ContentAlignment.MiddleLeft;
			declinedButton.Location = new Point(10, 6);
			declinedButton.Name = "declinedButton";
			declinedButton.Size = new Size(72, 28);
			declinedButton.TabIndex = 6;
			declinedButton.Text = "Decline";
			declinedButton.TextAlign = ContentAlignment.MiddleRight;
			declinedButton.UseVisualStyleBackColor = false;
			declinedButton.Click += declinedButton_Click;
			// 
			// acceptButton
			// 
			acceptButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			acceptButton.BackColor = Color.Green;
			acceptButton.FlatStyle = FlatStyle.Flat;
			acceptButton.ForeColor = Color.White;
			acceptButton.Image = Properties.Resources.accept;
			acceptButton.ImageAlign = ContentAlignment.MiddleLeft;
			acceptButton.Location = new Point(534, 6);
			acceptButton.Name = "acceptButton";
			acceptButton.Size = new Size(72, 28);
			acceptButton.TabIndex = 5;
			acceptButton.Text = "Accept";
			acceptButton.TextAlign = ContentAlignment.MiddleRight;
			acceptButton.UseVisualStyleBackColor = false;
			acceptButton.Click += acceptButton_Click;
			// 
			// panel3
			// 
			panel3.BackColor = Color.White;
			panel3.Controls.Add(splitContainer1);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(0, 159);
			panel3.Name = "panel3";
			panel3.Size = new Size(618, 291);
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
			splitContainer1.Panel1.Controls.Add(postObject);
			splitContainer1.Panel1.Padding = new Padding(10);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(suggestedObjet);
			splitContainer1.Panel2.Padding = new Padding(10);
			splitContainer1.Size = new Size(618, 291);
			splitContainer1.SplitterDistance = 298;
			splitContainer1.TabIndex = 0;
			// 
			// postObject
			// 
			postObject.Dock = DockStyle.Fill;
			postObject.FormattingEnabled = true;
			postObject.Location = new Point(10, 10);
			postObject.Name = "postObject";
			postObject.Size = new Size(278, 271);
			postObject.TabIndex = 0;
			// 
			// suggestedObjet
			// 
			suggestedObjet.Dock = DockStyle.Fill;
			suggestedObjet.FormattingEnabled = true;
			suggestedObjet.Location = new Point(10, 10);
			suggestedObjet.Name = "suggestedObjet";
			suggestedObjet.Size = new Size(296, 271);
			suggestedObjet.TabIndex = 0;
			// 
			// createdAt
			// 
			createdAt.AutoSize = true;
			createdAt.Location = new Point(18, 86);
			createdAt.Name = "createdAt";
			createdAt.Size = new Size(38, 15);
			createdAt.TabIndex = 10;
			createdAt.Text = "label3";
			// 
			// SuggestionDetail
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(618, 488);
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "SuggestionDetail";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Suggest detail";
			Load += SuggestionDetail_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		private SplitContainer splitContainer1;
		private CheckedListBox postObject;
		private CheckedListBox suggestedObjet;
		private Label label4;
		private RichTextBox description;
		private Label username;
		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private Button acceptButton;
		private Button declinedButton;
		private Label createdAt;
	}
}