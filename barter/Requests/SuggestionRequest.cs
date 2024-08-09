using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Requests
{
	public class SuggestionRequest
	{
		public int Id { get; set; }
		public String Status { get; set; }
		public int PostId { get; set; }
	}
}
