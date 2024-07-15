namespace barter.Responses
{
	public class Response<T>
	{
		public Status Status { get; set; }
		public T Data { get; set; }
		public string Message { get; set; }
		public Exception Exception { get; set; }

		public Response(Status status, T data, string message = null, Exception exception = null)
		{
			Status = status;
			Data = data;
			Message = message;
			Exception = exception;
		}
	}
}
