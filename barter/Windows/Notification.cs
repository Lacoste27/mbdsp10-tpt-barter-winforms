﻿using barter.Components;
using barter.ModelsView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barter.Windows
{
	public partial class Notification : Form
	{
		private Color READ_COLOR = Color.WhiteSmoke;
		private Color UNREAD_COLOR = Color.White;

		private NotificationModelView NotificationModelView { get; set; } = new NotificationModelView();

		public Notification()
		{
			InitializeComponent();
		}

		public Notification(int UserId)
		{
			InitializeComponent();
		}

		private async void Notification_Load(object sender, EventArgs e)
		{
			var notifications = await NotificationModelView.GetNotifications();

			if(notifications is not null)
			{
				int id = 1;
                foreach (var notification in notifications)
                {
					NotificationView view = new NotificationView();
					view.Dock = DockStyle.Fill;

					notificationLayout.Controls.Add(view);

					view.BackColor = notification.IsRead ? READ_COLOR : UNREAD_COLOR;
					view.BorderStyle = BorderStyle.FixedSingle;
					view.Location = new Point(3, 3);
					view.Name = string.Format("notification_{0}", id);
					view.Size = new Size(434, 72);
					view.TabIndex = 0;

					id++;
				}
			}
		}
	}
}
