namespace barter.Models
{
	public class Post
	{
		public int Id { get; set; }
		public int AuthorId { get; set; }
		public List<int> ObjectIds { get; set; }
		public List<int> SuggestionIds { get; set; }
		public DateTime deletedAt { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }
	}
}
