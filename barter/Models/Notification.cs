using System.Globalization;

namespace barter.Models
{
	public class Notification
	{
		public required string _Id { get; set; }
		public int UserId { get; set; }
		public required string Subject { get; set; }
		public required string Message { get; set; }
		public bool IsRead { get; set; }
		public DateTime CreatedAt { get; set; }

		public Notification()
		{

		}

		public string FormatDateString()
		{
			DateTime now = DateTime.Now;
			TimeSpan timeDifference = now - CreatedAt;

			if (timeDifference.TotalHours < 24)
			{
				int hours = (int)timeDifference.TotalHours;
				return $"Il y a {hours} heure{(hours > 1 ? "s" : "")}";
			}
			else
			{
				return CreatedAt.ToString("dddd, dd MMMM yyyy", new CultureInfo("fr-FR"));
			}
		}
	}
}
