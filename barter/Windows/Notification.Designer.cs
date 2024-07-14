﻿namespace barter.Windows
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
			notificationLayout = new FlowLayoutPanel();
			notificationView1 = new Components.NotificationView();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			notificationLayout.SuspendLayout();
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
			panel2.Controls.Add(notificationLayout);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 41);
			panel2.Name = "panel2";
			panel2.Size = new Size(441, 331);
			panel2.TabIndex = 1;
			// 
			// notificationLayout
			// 
			notificationLayout.AutoScroll = true;
			notificationLayout.Controls.Add(notificationView1);
			notificationLayout.Dock = DockStyle.Fill;
			notificationLayout.Location = new Point(0, 0);
			notificationLayout.Name = "notificationLayout";
			notificationLayout.Size = new Size(441, 331);
			notificationLayout.TabIndex = 0;
			// 
			// notificationView1
			// 
			notificationView1.BackColor = Color.WhiteSmoke;
			notificationView1.BorderStyle = BorderStyle.FixedSingle;
			notificationView1.Location = new Point(3, 3);
			notificationView1.Name = "notificationView1";
			notificationView1.Size = new Size(434, 72);
			notificationView1.TabIndex = 0;
			// 
			// Notification
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(441, 372);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MinimumSize = new Size(457, 403);
			Name = "Notification";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Notification";
			Load += Notification_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			notificationLayout.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private FlowLayoutPanel notificationLayout;
		private Label label1;
		private Components.NotificationView notificationView1;
	}
}