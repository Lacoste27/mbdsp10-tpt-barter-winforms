namespace barter.Windows
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			Spliter = new SplitContainer();
			PanelImage = new Panel();
			panel1 = new Panel();
			label1 = new Label();
			LoginPanel = new Panel();
			loginButton = new Button();
			textBox1 = new TextBox();
			usernameTextBox = new TextBox();
			getStartedLabel = new Label();
			((System.ComponentModel.ISupportInitialize)Spliter).BeginInit();
			Spliter.Panel1.SuspendLayout();
			Spliter.Panel2.SuspendLayout();
			Spliter.SuspendLayout();
			PanelImage.SuspendLayout();
			panel1.SuspendLayout();
			LoginPanel.SuspendLayout();
			SuspendLayout();
			// 
			// Spliter
			// 
			Spliter.Dock = DockStyle.Fill;
			Spliter.Location = new Point(0, 0);
			Spliter.Margin = new Padding(0);
			Spliter.Name = "Spliter";
			// 
			// Spliter.Panel1
			// 
			Spliter.Panel1.Controls.Add(PanelImage);
			// 
			// Spliter.Panel2
			// 
			Spliter.Panel2.Controls.Add(LoginPanel);
			Spliter.Size = new Size(800, 526);
			Spliter.SplitterDistance = 380;
			Spliter.SplitterWidth = 1;
			Spliter.TabIndex = 0;
			// 
			// PanelImage
			// 
			PanelImage.Controls.Add(panel1);
			PanelImage.Dock = DockStyle.Fill;
			PanelImage.Location = new Point(0, 0);
			PanelImage.Name = "PanelImage";
			PanelImage.Size = new Size(380, 526);
			PanelImage.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.BackgroundImage = Properties.Resources.login;
			panel1.BackgroundImageLayout = ImageLayout.Stretch;
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(380, 526);
			panel1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Monotype Corsiva", 45F);
			label1.ForeColor = Color.FromArgb(39, 194, 64);
			label1.Location = new Point(73, 9);
			label1.Name = "label1";
			label1.Size = new Size(231, 144);
			label1.TabIndex = 0;
			label1.Text = "Welcome \r\nto barter";
			// 
			// LoginPanel
			// 
			LoginPanel.BackColor = Color.White;
			LoginPanel.Controls.Add(loginButton);
			LoginPanel.Controls.Add(textBox1);
			LoginPanel.Controls.Add(usernameTextBox);
			LoginPanel.Controls.Add(getStartedLabel);
			LoginPanel.Dock = DockStyle.Fill;
			LoginPanel.Location = new Point(0, 0);
			LoginPanel.Name = "LoginPanel";
			LoginPanel.Size = new Size(419, 526);
			LoginPanel.TabIndex = 0;
			// 
			// loginButton
			// 
			loginButton.BackColor = Color.FromArgb(39, 194, 64);
			loginButton.FlatStyle = FlatStyle.Flat;
			loginButton.Font = new Font("Segoe UI", 20F);
			loginButton.ForeColor = Color.White;
			loginButton.Location = new Point(100, 330);
			loginButton.Name = "loginButton";
			loginButton.Size = new Size(241, 55);
			loginButton.TabIndex = 3;
			loginButton.Text = "Login";
			loginButton.UseVisualStyleBackColor = false;
			loginButton.Click += loginButton_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(52, 252);
			textBox1.Name = "textBox1";
			textBox1.PasswordChar = '*';
			textBox1.Size = new Size(315, 23);
			textBox1.TabIndex = 2;
			textBox1.UseSystemPasswordChar = true;
			// 
			// usernameTextBox
			// 
			usernameTextBox.Location = new Point(49, 174);
			usernameTextBox.Name = "usernameTextBox";
			usernameTextBox.Size = new Size(315, 23);
			usernameTextBox.TabIndex = 1;
			// 
			// getStartedLabel
			// 
			getStartedLabel.AutoSize = true;
			getStartedLabel.Font = new Font("Verdana", 30F);
			getStartedLabel.Location = new Point(93, 63);
			getStartedLabel.Name = "getStartedLabel";
			getStartedLabel.Size = new Size(248, 48);
			getStartedLabel.TabIndex = 0;
			getStartedLabel.Text = "Get started";
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 526);
			Controls.Add(Spliter);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(800, 526);
			MinimumSize = new Size(800, 526);
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			Load += Login_Load;
			Spliter.Panel1.ResumeLayout(false);
			Spliter.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)Spliter).EndInit();
			Spliter.ResumeLayout(false);
			PanelImage.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			LoginPanel.ResumeLayout(false);
			LoginPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer Spliter;
		private Panel LoginPanel;
		private Panel PanelImage;
		private Panel panel1;
		private Label label1;
		private Label getStartedLabel;
		private TextBox usernameTextBox;
		private TextBox textBox1;
		private Button loginButton;
	}
}