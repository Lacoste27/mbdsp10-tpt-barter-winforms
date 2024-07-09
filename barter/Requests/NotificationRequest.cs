using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Requests
{
	public class NotificationRequest
	{
		public int UserId { get; set; }	
		public required string Subject { get; set; }
		public required string Message { get; set; }
	}
}
