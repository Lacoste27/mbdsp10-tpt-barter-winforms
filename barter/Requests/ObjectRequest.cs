using System.ComponentModel.DataAnnotations;

namespace barter.Requests
{
	public class ObjectRequest
	{
		[Required(ErrorMessage = "Name is required.", AllowEmptyStrings = false)]
		[StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
		public required string Name { get; set; }
		[Required(ErrorMessage = "Category is required")]
		[Range(1, int.MaxValue, ErrorMessage = "Category is required")]
		public required int CategoryId { get; set; }
		[Required(ErrorMessage = "Description is required.", AllowEmptyStrings = false)]
		public required string Description { get; set; }
		[MinLength(1, ErrorMessage = "Image is required")]
		public List<string> Image { get; set; } = new List<string>();
		public int OwnerId { get; set; }
	}
}
