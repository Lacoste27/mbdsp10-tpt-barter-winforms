﻿namespace barter.Models
{
	public class ObjectPost
	{
		public int Id { get; set; }
		public int ObjectId { get; set; }
		public int PostId { get; set; }
		public DateTime? DeletedAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

		public Object Object { get; set; }
	}
}
