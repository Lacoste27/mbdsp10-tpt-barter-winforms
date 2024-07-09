using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Models
{
	public class Notification
	{
		public required string _Id { get; set; }
		public int UserId { get; set; }
		public required string Subject { get; set; }
		public required string Message { get; set; }
		public bool IsRead { get; set; }
		public DateTime CreatedAt { get; set; }

		public Notification()
		{

		}
	}
}
