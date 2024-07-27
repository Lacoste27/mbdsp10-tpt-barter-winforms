namespace barter.Windows
{
	partial class Notification
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
			panel1 = new Panel();
			label1 = new Label();
			panel2 = new Panel();
			notificationPanel = new FlowLayoutPanel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(441, 41);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(98, 15);
			label1.TabIndex = 0;
			label1.Text = "Mes notifications";
			// 
			// panel2
			// 
			panel2.Controls.Add(notificationPanel);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 41);
			panel2.Name = "panel2";
			panel2.Size = new Size(441, 323);
			panel2.TabIndex = 1;
			// 
			// notificationPanel
			// 
			notificationPanel.AutoScroll = true;
			notificationPanel.Dock = DockStyle.Fill;
			notificationPanel.Location = new Point(0, 0);
			notificationPanel.Name = "notificationPanel";
			notificationPanel.Size = new Size(441, 323);
			notificationPanel.TabIndex = 0;
			// 
			// Notification
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(441, 364);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(461, 403);
			MinimumSize = new Size(457, 403);
			Name = "Notification";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Notification";
			Load += Notification_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Label label1;
		private FlowLayoutPanel notificationPanel;
	}
}