using barter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barter.Components
{
	public partial class NotificationView : UserControl
	{
		private Notification _notification { get; set; }

		public NotificationView()
		{
			InitializeComponent();
		}


		private void NotificationView_Load(object sender, EventArgs e)
		{
			/*this.notificationTitle.Text = this._notification.Subject;
			this.notificationMessage.Text = this._notification.Message;*/
		}
	}
}
