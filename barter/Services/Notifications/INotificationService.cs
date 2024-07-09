using barter.Models;
using barter.Requests;
using barter.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Services.Notifications
{
	public interface INotificationService
	{
		public Task<Response<List<Notification>>> GetUserNotification();
		public Task<Response<List<Notification>>> GetUserNotification(int UserId);
		public Task<Response<Notification>> AddNotification(NotificationRequest request);
		public Task<Response<Notification>> MarkNotificationAsRead(Notification request);
	}
}
