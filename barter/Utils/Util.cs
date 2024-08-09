namespace barter.Utils
{
	public static class Util
	{
		public static string TimeAgo(DateTime date)
		{
			TimeSpan timeSpan = DateTime.Now - date;

			if (timeSpan.TotalDays > 7)
			{
				return date.ToString("MMMM dd, yyyy");
			}
			else if (timeSpan.TotalDays >= 1)
			{
				int days = (int)timeSpan.TotalDays;
				return $"{days} day{(days > 1 ? "s" : "")} ago";
			}
			else if (timeSpan.TotalHours >= 1)
			{
				int hours = (int)timeSpan.TotalHours;
				return $"{hours} hour{(hours > 1 ? "s" : "")} ago";
			}
			else
			{
				return date.ToString("MMMM dd, yyyy");
			}
		}
	}
}
