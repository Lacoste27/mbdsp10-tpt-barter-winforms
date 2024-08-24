namespace barter.Requests
{
	public class PostRequest
	{
		public int AuthorId { get; set; }
		public String Description { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public String Adress { get; set; }
		public List<int> ObjectIds { get; set; }
	}
}
