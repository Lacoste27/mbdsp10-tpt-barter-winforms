namespace barter.Models
{
	public class Post
	{
		public int Id { get; set; }
		public int AuthorId { get; set; }
		public String description { get; set; }
		public double? Latitude { get; set; }
		public double? Longitude { get; set; }
		public String Address { get; set; }
		public DateTime? deletedAt { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }

		public User Author { get; set; }
		public List<ObjectPost> Objects { get; set; }
	}
}
