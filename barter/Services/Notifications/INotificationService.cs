using barter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Services.Notifications
{
	public interface INotificationService
	{
		public Task<List<Notification>> GetUserNotification();
		public Task<List<Notification>> GetUserNotification(int UserId);
	}
}
