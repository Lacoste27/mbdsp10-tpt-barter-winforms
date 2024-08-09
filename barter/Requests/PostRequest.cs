namespace barter.Requests
{
	public class PostRequest
	{
		public int AuthorId { get; set; }
		public String Description { get; set; }
		public List<int> ObjectIds { get; set; }
	}
}
