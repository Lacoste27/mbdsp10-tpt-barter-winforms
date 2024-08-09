namespace barter.Models
{
	public class Object
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int OwnerId { get; set; }
		public List<string> Photos { get; set; }

		public DateTime? DeletedAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }


		public Category Category { get; set; }
	}
}
