﻿namespace barter.Models
{
	public class Suggestion
	{
		public int Id { get; set; }
		public String Status { get; set; }
		public int PostId { get; set; }
		public int SuggestedById { get; set; }
		public DateTime? DeletedAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

		public Post Post { get; set; }
		public User SuggestedBy { get; set; }
		public List<ObjectSuggestion> SuggestedObject { get; set; }
	}
}
