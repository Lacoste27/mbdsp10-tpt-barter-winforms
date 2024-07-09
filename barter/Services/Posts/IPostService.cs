using barter.Models;
using barter.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Services.Posts
{
	public interface IPostService
	{
		public Task<Response<List<Post>>> GetAllPosts();
		public Task<Response<List<Post>>> GetUserPost(int userId);
		public Task<Response<Post>> GetPostById(int id);
	}
}
