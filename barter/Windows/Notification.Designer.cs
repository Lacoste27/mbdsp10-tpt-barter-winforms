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
			panel2 = new Panel();
			flowLayoutPanel1 = new FlowLayoutPanel();
			notificationView1 = new Components.NotificationView();
			notificationView2 = new Components.NotificationView();
			notificationView3 = new Components.NotificationView();
			notificationView4 = new Components.NotificationView();
			notificationView5 = new Components.NotificationView();
			label1 = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
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
			// panel2
			// 
			panel2.Controls.Add(flowLayoutPanel1);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 41);
			panel2.Name = "panel2";
			panel2.Size = new Size(441, 331);
			panel2.TabIndex = 1;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoScroll = true;
			flowLayoutPanel1.Controls.Add(notificationView1);
			flowLayoutPanel1.Controls.Add(notificationView2);
			flowLayoutPanel1.Controls.Add(notificationView3);
			flowLayoutPanel1.Controls.Add(notificationView4);
			flowLayoutPanel1.Controls.Add(notificationView5);
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.Location = new Point(0, 0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(441, 331);
			flowLayoutPanel1.TabIndex = 0;
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
			// notificationView2
			// 
			notificationView2.BackColor = Color.White;
			notificationView2.BorderStyle = BorderStyle.FixedSingle;
			notificationView2.Location = new Point(3, 81);
			notificationView2.Name = "notificationView2";
			notificationView2.Size = new Size(434, 72);
			notificationView2.TabIndex = 1;
			// 
			// notificationView3
			// 
			notificationView3.BackColor = Color.White;
			notificationView3.BorderStyle = BorderStyle.FixedSingle;
			notificationView3.Location = new Point(3, 159);
			notificationView3.Name = "notificationView3";
			notificationView3.Size = new Size(434, 72);
			notificationView3.TabIndex = 2;
			// 
			// notificationView4
			// 
			notificationView4.BackColor = Color.White;
			notificationView4.BorderStyle = BorderStyle.FixedSingle;
			notificationView4.Location = new Point(3, 237);
			notificationView4.Name = "notificationView4";
			notificationView4.Size = new Size(434, 72);
			notificationView4.TabIndex = 3;
			// 
			// notificationView5
			// 
			notificationView5.BackColor = Color.WhiteSmoke;
			notificationView5.BorderStyle = BorderStyle.FixedSingle;
			notificationView5.Location = new Point(3, 315);
			notificationView5.Name = "notificationView5";
			notificationView5.Size = new Size(434, 72);
			notificationView5.TabIndex = 4;
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
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			flowLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private FlowLayoutPanel flowLayoutPanel1;
		private Components.NotificationView notificationView1;
		private Components.NotificationView notificationView2;
		private Components.NotificationView notificationView3;
		private Components.NotificationView notificationView4;
		private Components.NotificationView notificationView5;
		private Label label1;
	}
}