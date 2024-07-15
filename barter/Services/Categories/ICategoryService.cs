using barter.Models;
using barter.Requests;
using barter.Responses;

namespace barter.Services.Categories
{
	public interface ICategoryService
	{
		public Task<Response<List<Category>>> GetAllCategory();
		public Task<Response<Category>> GetCategoryById(int id);
		public Task<Response<Category>> AddCategory(CategoryRequest request);
	}
}
