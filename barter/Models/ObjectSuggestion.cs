namespace barter.Models
{
	public class ObjectSuggestion
	{
		public int Id { get; set; }
		public int ObjectId { get; set; }
		public int SuggestionId { get; set; }
		public DateTime? DeletedAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

		public Models.Object Object { get; set; }
		public Suggestion Suggestion { get; set; }
	}
}
