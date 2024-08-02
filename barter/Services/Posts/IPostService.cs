using barter.Models;
using barter.Requests;
using barter.Responses;

namespace barter.Services.Posts
{
	public interface IPostService
	{
		public Task<Response<List<Post>>> GetAllPosts();
		public Task<Response<List<Post>>> GetUserPost(int userId);
		public Task<Response<Post>> GetPostById(int id);
		public Task<Response<Post>> AddPost(PostRequest request);
	}
}
