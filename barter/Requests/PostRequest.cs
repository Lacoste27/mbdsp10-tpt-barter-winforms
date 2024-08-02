using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Requests
{
	public class PostRequest
	{
		public int AuthorId { get; set; }
		public List<int> ObjectIds { get; set; }
	}
}
