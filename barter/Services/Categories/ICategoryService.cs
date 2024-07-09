using barter.Models;
using barter.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Services.Categories
{
	public interface ICategoryService
	{
		public Task<Response<List<Category>>> GetAllCategory();
		public Task<Response<Category>> GetCategoryById(int id);
	}
}
