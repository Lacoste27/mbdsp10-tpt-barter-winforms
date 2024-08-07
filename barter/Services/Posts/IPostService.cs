using barter.Models;
using barter.Requests;
using barter.Responses;

namespace barter.Services.Posts
{
	public interface IPostService
	{
		public Task<Response<ListResponse<Post>>> GetAllPosts(int page = 1, int limit = 10);
		public Task<Response<ListResponse<Post>>> GetUserPost(int userId, int page= 1, int limit = 10);
		public Task<Response<Post>> GetPostById(int id);
		public Task<Response<Post>> AddPost(PostRequest request);
	}
}
