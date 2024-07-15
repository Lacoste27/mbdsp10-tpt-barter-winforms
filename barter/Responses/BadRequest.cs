namespace barter.Responses
{
	public class Error
	{
		public string? Type { get; set; }
		public string? Msg { get; set; }
		public string? Path { get; set; }
		public string? Location { get; set; }
	}

	public class BadRequest
	{
		public List<Error> Errors { get; set; }
	}
}
