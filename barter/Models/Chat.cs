namespace barter.Models
{
	public class Chat
	{
		public UserMessage Sender { get; set; }
		public UserMessage Receiver { get; set; }
		public List<Message> Messages { get; set; }
	}

	public class Message
	{
		public String Author { get; set; }
		public String Text { get; set; }
		public DateTime Timestamp { get; set; }
	}

    public class  UserMessage
    {
        public int Id { get; set; }
		public String Name { get; set; }
		public String Username { get; set; }
		public String Email { get; set; }
    }
}
