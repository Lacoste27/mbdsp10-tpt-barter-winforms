namespace barter.Windows
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			panel1 = new Panel();
			suggestionButton = new Button();
			notificationButton = new Button();
			profileButton = new PictureBox();
			messageButton = new Button();
			postButton = new Button();
			accueilButton = new PictureBox();
			panel2 = new Panel();
			posts1 = new Components.Posts();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)profileButton).BeginInit();
			((System.ComponentModel.ISupportInitialize)accueilButton).BeginInit();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.WhiteSmoke;
			panel1.Controls.Add(suggestionButton);
			panel1.Controls.Add(notificationButton);
			panel1.Controls.Add(profileButton);
			panel1.Controls.Add(messageButton);
			panel1.Controls.Add(postButton);
			panel1.Controls.Add(accueilButton);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.MinimumSize = new Size(131, 667);
			panel1.Name = "panel1";
			panel1.Size = new Size(131, 765);
			panel1.TabIndex = 0;
			// 
			// suggestionButton
			// 
			suggestionButton.FlatAppearance.BorderSize = 0;
			suggestionButton.FlatStyle = FlatStyle.Flat;
			suggestionButton.Font = new Font("Tahoma", 14F);
			suggestionButton.Image = Properties.Resources.recommander;
			suggestionButton.ImageAlign = ContentAlignment.TopCenter;
			suggestionButton.Location = new Point(3, 462);
			suggestionButton.Name = "suggestionButton";
			suggestionButton.Size = new Size(122, 71);
			suggestionButton.TabIndex = 6;
			suggestionButton.Text = "Suggestion";
			suggestionButton.TextAlign = ContentAlignment.BottomCenter;
			suggestionButton.UseVisualStyleBackColor = true;
			suggestionButton.Click += suggestionButton_Click;
			// 
			// notificationButton
			// 
			notificationButton.FlatAppearance.BorderSize = 0;
			notificationButton.FlatStyle = FlatStyle.Flat;
			notificationButton.Font = new Font("Tahoma", 14F);
			notificationButton.Image = Properties.Resources.notification;
			notificationButton.ImageAlign = ContentAlignment.TopCenter;
			notificationButton.Location = new Point(3, 367);
			notificationButton.Name = "notificationButton";
			notificationButton.Size = new Size(122, 71);
			notificationButton.TabIndex = 5;
			notificationButton.Text = "Notification";
			notificationButton.TextAlign = ContentAlignment.BottomCenter;
			notificationButton.UseVisualStyleBackColor = true;
			notificationButton.Click += notificationButton_Click;
			// 
			// profileButton
			// 
			profileButton.Anchor = AnchorStyles.Bottom;
			profileButton.Image = Properties.Resources.user;
			profileButton.Location = new Point(42, 705);
			profileButton.Name = "profileButton";
			profileButton.Size = new Size(48, 48);
			profileButton.SizeMode = PictureBoxSizeMode.CenterImage;
			profileButton.TabIndex = 4;
			profileButton.TabStop = false;
			profileButton.WaitOnLoad = true;
			profileButton.Click += profileButton_Click;
			// 
			// messageButton
			// 
			messageButton.FlatAppearance.BorderSize = 0;
			messageButton.FlatStyle = FlatStyle.Flat;
			messageButton.Font = new Font("Tahoma", 14F);
			messageButton.Image = Properties.Resources.email;
			messageButton.ImageAlign = ContentAlignment.TopCenter;
			messageButton.Location = new Point(16, 277);
			messageButton.Name = "messageButton";
			messageButton.Size = new Size(96, 61);
			messageButton.TabIndex = 3;
			messageButton.Text = "Message";
			messageButton.TextAlign = ContentAlignment.BottomCenter;
			messageButton.UseVisualStyleBackColor = true;
			messageButton.Click += messageButton_Click;
			// 
			// postButton
			// 
			postButton.FlatAppearance.BorderSize = 0;
			postButton.FlatStyle = FlatStyle.Flat;
			postButton.Font = new Font("Tahoma", 14F);
			postButton.Image = (Image)resources.GetObject("postButton.Image");
			postButton.ImageAlign = ContentAlignment.TopCenter;
			postButton.Location = new Point(16, 191);
			postButton.Name = "postButton";
			postButton.Size = new Size(96, 61);
			postButton.TabIndex = 2;
			postButton.Text = "Post";
			postButton.TextAlign = ContentAlignment.BottomCenter;
			postButton.UseVisualStyleBackColor = true;
			postButton.Visible = false;
			postButton.Click += postButton_Click;
			// 
			// accueilButton
			// 
			accueilButton.Image = Properties.Resources.Group_15;
			accueilButton.Location = new Point(12, 29);
			accueilButton.Name = "accueilButton";
			accueilButton.Size = new Size(100, 83);
			accueilButton.SizeMode = PictureBoxSizeMode.CenterImage;
			accueilButton.TabIndex = 0;
			accueilButton.TabStop = false;
			accueilButton.WaitOnLoad = true;
			accueilButton.Click += accueilButton_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(posts1);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(131, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1090, 765);
			panel2.TabIndex = 1;
			// 
			// posts1
			// 
			posts1.BackColor = Color.White;
			posts1.Dock = DockStyle.Fill;
			posts1.Location = new Point(0, 0);
			posts1.Name = "posts1";
			posts1.Size = new Size(1090, 765);
			posts1.TabIndex = 3;
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1221, 765);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MinimumSize = new Size(1180, 706);
			Name = "Main";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Barter";
			Load += Main_Load;
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)profileButton).EndInit();
			((System.ComponentModel.ISupportInitialize)accueilButton).EndInit();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private PictureBox accueilButton;
		private Button postButton;
		private Button messageButton;
		private PictureBox profileButton;
		private Components.Profil profil1;
		private Components.Home home1;
		private Components.Messages messages1;
		private Components.Posts posts1;
		private Button notificationButton;
		private StatusStrip statusStrip1;
		private ToolStripProgressBar toolStripProgressBar1;
		private Button suggestionButton;
	}
}