using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Requests
{
	public class ObjectRequest
	{
		public required string Name { get; set; }
		public required int CategoryId { get; set; }
		public required string Description { get; set; }
		public required string Image { get; set; }
		public int OwnerId { get; set; }
	}
}
