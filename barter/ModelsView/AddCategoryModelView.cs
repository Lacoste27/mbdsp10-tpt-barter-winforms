using barter.Models;
using barter.Requests;
using barter.Responses;
using barter.Services.Categories;

namespace barter.ModelsView
{
	public class AddCategoryModelView
	{
		private ICategoryService CategoryService { get; set; }

		public AddCategoryModelView()
		{
			CategoryService = Service.GetService<ICategoryService>();
		}

		public async Task<Category> AddCategory(CategoryRequest request)
		{
			var response = await CategoryService.AddCategory(request);

			if (response.Status == Status.Success)
			{
				return response.Data;
			}
			else
			{
				MessageBox.Show(response.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
	}
}
