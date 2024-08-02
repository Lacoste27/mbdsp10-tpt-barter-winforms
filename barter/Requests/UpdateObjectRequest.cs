using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Requests
{
	public class UpdateObjectRequest
	{
		[Required(ErrorMessage = "Name is required.", AllowEmptyStrings = false)]
		[StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
		public required string Name { get; set; }
		[Required(ErrorMessage = "Category is required")]
		[Range(1, int.MaxValue, ErrorMessage = "Category is required")]
		public required int CategoryId { get; set; }
		[Required(ErrorMessage = "Description is required.", AllowEmptyStrings = false)]
		public required string Description { get; set; }
		public int OwnerId { get; set; }
	}
}
