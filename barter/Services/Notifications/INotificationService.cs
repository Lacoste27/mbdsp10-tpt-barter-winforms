using barter.Models;
using barter.Requests;
using barter.Responses;

namespace barter.Services.Notifications
{
	public interface INotificationService
	{
		public Task<Response<List<Notification>>> GetAllNotification();
		public Task<Response<List<Notification>>> GetUserNotification(int UserId);
		public Task<Response<Notification>> AddNotification(NotificationRequest request);
		public Task<Response<Notification>> MarkNotificationAsRead(Notification request);
	}
}
