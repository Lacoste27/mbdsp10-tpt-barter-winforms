namespace barter.Requests
{
	public class NotificationRequest
	{
		public int UserId { get; set; }
		public required string Subject { get; set; }
		public required string Message { get; set; }
	}
}
