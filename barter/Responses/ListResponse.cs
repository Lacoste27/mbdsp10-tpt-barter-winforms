using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Responses
{
	public class ListResponse<T>
	{
		[JsonProperty("data")]
		public List<T> Data { get; set; }

		[JsonProperty("totalDocs")]
		public int TotalDocs { get; set; }

		[JsonProperty("totalPages")]
		public int TotalPages { get; set; }

		[JsonProperty("nextPage")]
		public int? NextPage { get; set; }

		[JsonProperty("prevPage")]
		public int? PrevPage { get; set; }

		[JsonProperty("hasNextPage")]
		public bool HasNextPage { get; set; }

		[JsonProperty("hasPrevPage")]
		public bool HasPrevPage { get; set; }
	}
}
