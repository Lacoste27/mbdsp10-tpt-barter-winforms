namespace barter.Components
{
	partial class Profil
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
			panel1 = new Panel();
			panel4 = new Panel();
			layout = new FlowLayoutPanel();
			panel3 = new Panel();
			progression = new ProgressBar();
			nextButton = new Button();
			pageNumber = new TextBox();
			previousButton = new Button();
			panel2 = new Panel();
			notificationState = new CheckBox();
			logoutButton = new Button();
			postButton = new Button();
			objectButton = new Button();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			addObjectButton = new Button();
			addPostButton = new Button();
			panel1.SuspendLayout();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(panel4);
			panel1.Controls.Add(panel3);
			panel1.Controls.Add(panel2);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1192, 672);
			panel1.TabIndex = 0;
			// 
			// panel4
			// 
			panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel4.Controls.Add(layout);
			panel4.Location = new Point(0, 219);
			panel4.Name = "panel4";
			panel4.Padding = new Padding(30);
			panel4.Size = new Size(1192, 418);
			panel4.TabIndex = 2;
			// 
			// layout
			// 
			layout.AutoScroll = true;
			layout.Dock = DockStyle.Fill;
			layout.Location = new Point(30, 30);
			layout.Name = "layout";
			layout.Size = new Size(1132, 358);
			layout.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.Controls.Add(progression);
			panel3.Controls.Add(nextButton);
			panel3.Controls.Add(pageNumber);
			panel3.Controls.Add(previousButton);
			panel3.Dock = DockStyle.Bottom;
			panel3.Location = new Point(0, 637);
			panel3.Name = "panel3";
			panel3.Size = new Size(1192, 35);
			panel3.TabIndex = 1;
			// 
			// progression
			// 
			progression.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			progression.Location = new Point(769, 6);
			progression.MarqueeAnimationSpeed = 40;
			progression.Name = "progression";
			progression.Size = new Size(393, 23);
			progression.Style = ProgressBarStyle.Marquee;
			progression.TabIndex = 3;
			progression.Visible = false;
			// 
			// nextButton
			// 
			nextButton.Location = new Point(79, 6);
			nextButton.Name = "nextButton";
			nextButton.Size = new Size(22, 23);
			nextButton.TabIndex = 2;
			nextButton.Text = ">";
			nextButton.UseVisualStyleBackColor = true;
			nextButton.Click += nextButton_Click;
			// 
			// pageNumber
			// 
			pageNumber.Location = new Point(40, 6);
			pageNumber.Name = "pageNumber";
			pageNumber.Size = new Size(33, 23);
			pageNumber.TabIndex = 1;
			pageNumber.TextChanged += pageNumber_TextChanged;
			// 
			// previousButton
			// 
			previousButton.Location = new Point(12, 6);
			previousButton.Name = "previousButton";
			previousButton.Size = new Size(22, 23);
			previousButton.TabIndex = 0;
			previousButton.Text = "<";
			previousButton.UseVisualStyleBackColor = true;
			previousButton.Click += previousButton_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(notificationState);
			panel2.Controls.Add(logoutButton);
			panel2.Controls.Add(postButton);
			panel2.Controls.Add(objectButton);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(pictureBox1);
			panel2.Controls.Add(addObjectButton);
			panel2.Controls.Add(addPostButton);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(1192, 219);
			panel2.TabIndex = 0;
			panel2.Paint += panel2_Paint;
			// 
			// notificationState
			// 
			notificationState.Appearance = Appearance.Button;
			notificationState.AutoSize = true;
			notificationState.FlatStyle = FlatStyle.Popup;
			notificationState.Location = new Point(294, 101);
			notificationState.Name = "notificationState";
			notificationState.Size = new Size(111, 25);
			notificationState.TabIndex = 7;
			notificationState.Text = "Allow notification";
			notificationState.UseVisualStyleBackColor = true;
			// 
			// logoutButton
			// 
			logoutButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			logoutButton.Location = new Point(1087, 20);
			logoutButton.Name = "logoutButton";
			logoutButton.Size = new Size(91, 29);
			logoutButton.TabIndex = 6;
			logoutButton.Text = "Logout";
			logoutButton.UseVisualStyleBackColor = true;
			logoutButton.Click += logoutButton_Click;
			// 
			// postButton
			// 
			postButton.Location = new Point(188, 174);
			postButton.Name = "postButton";
			postButton.Size = new Size(83, 30);
			postButton.TabIndex = 3;
			postButton.Text = "Posts";
			postButton.UseVisualStyleBackColor = true;
			postButton.Click += postButton_Click;
			// 
			// objectButton
			// 
			objectButton.FlatStyle = FlatStyle.System;
			objectButton.Location = new Point(99, 174);
			objectButton.Name = "objectButton";
			objectButton.Size = new Size(83, 30);
			objectButton.TabIndex = 2;
			objectButton.Text = "Objects";
			objectButton.UseVisualStyleBackColor = true;
			objectButton.Click += objectButton_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(294, 37);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 1;
			label1.Text = "Username";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(99, 20);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(137, 126);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// addObjectButton
			// 
			addObjectButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			addObjectButton.Image = (Image)resources.GetObject("addObjectButton.Image");
			addObjectButton.ImageAlign = ContentAlignment.MiddleLeft;
			addObjectButton.Location = new Point(1087, 178);
			addObjectButton.Name = "addObjectButton";
			addObjectButton.Size = new Size(91, 23);
			addObjectButton.TabIndex = 5;
			addObjectButton.Text = "Add object";
			addObjectButton.TextAlign = ContentAlignment.MiddleRight;
			addObjectButton.UseVisualStyleBackColor = true;
			addObjectButton.Visible = false;
			addObjectButton.Click += addObjectButton_Click;
			// 
			// addPostButton
			// 
			addPostButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			addPostButton.Image = (Image)resources.GetObject("addPostButton.Image");
			addPostButton.ImageAlign = ContentAlignment.MiddleLeft;
			addPostButton.Location = new Point(1087, 178);
			addPostButton.Name = "addPostButton";
			addPostButton.Size = new Size(91, 23);
			addPostButton.TabIndex = 4;
			addPostButton.Text = "Add post";
			addPostButton.TextAlign = ContentAlignment.MiddleRight;
			addPostButton.UseVisualStyleBackColor = true;
			addPostButton.Visible = false;
			addPostButton.Click += addPostButton_Click;
			// 
			// Profil
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			Controls.Add(panel1);
			Name = "Profil";
			Size = new Size(1192, 672);
			Load += Profil_Load;
			panel1.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private PictureBox pictureBox1;
		private Label label1;
		private Button postButton;
		private Button objectButton;
		private Panel panel4;
		private FlowLayoutPanel layout;
		private Panel panel3;
		private Button previousButton;
		private TextBox pageNumber;
		private Button nextButton;
		private ProgressBar progression;
		private Button addPostButton;
		private Button addObjectButton;
		private Button logoutButton;
		private CheckBox notificationState;
	}
}
