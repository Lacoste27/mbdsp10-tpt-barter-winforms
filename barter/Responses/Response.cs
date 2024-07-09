using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Responses
{
	public class Response<T>
	{
		public Status Status { get; set; }
		public T Data { get; set; }
		public string Message { get; set; }

		public Response(Status status, T data, string message = null)
		{
			Status = status;
			Data = data;
			Message = message;
		}
	}
}
