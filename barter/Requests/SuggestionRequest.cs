using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Requests
{
	public class SuggestionRequest
	{
		public String Status { get; set; } = "PENDING"; // "PENDING", "ACCEPTED", "DECLINED"
		public int PostId { get; set; }
		public int SuggestedById { get; set; }
		public List<int> SuggestedObjectIds { get; set; }
	}
}
