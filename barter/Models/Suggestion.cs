using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Models
{
	public class Suggestion
	{
		public int Id { get; set; }
		public int PostId { get; set; }
		public String Status { get; set; }
		public DateTime? DeletedAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

		public Post Post { get; set; }
	}
}
