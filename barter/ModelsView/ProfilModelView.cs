using barter.Models;
using barter.Responses;
using barter.Services.Objects;
using barter.Services.Posts;
using barter.Utils;

namespace barter.ModelsView
{
	public class ProfilModelView
	{
		private IObjectService ObjectService { get; set; }
		private IPostService PostService { get; set; }

		public List<Models.Object> UserObjects { get; private set; }
		public List<Post> UserPosts { get; private set; }

		public ListResponse<Models.Object> Objects { get; private set; }
		public ListResponse<Post> Posts { get; private set; }
		public Boolean userObjectChanged { get; set; } = false;
		public Boolean userPostChanged { get; set; } = false;

		public ProfilModelView()
		{
			ObjectService = Service.GetService<IObjectService>();
			PostService = Service.GetService<IPostService>();
		}

		public async Task<List<Models.Object>> GetUserObjects(int page = 1, int limit = 10)
		{
			int userId = TokenStorage.GetUserId();
			var response = await ObjectService.GetUserObjects(userId, page, limit);

			if (response.Status == Status.Success)
			{
				Objects = response.Data;
				UserObjects = [.. response.Data.Data];
				return [.. response.Data.Data];
			}
			else
			{
				MessageBox.Show(response.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		public async Task<List<Post>> GetUserPosts(int page = 1, int limit = 10)
		{
			int userId = TokenStorage.GetUserId();
			var response = await PostService.GetUserPost(userId, page, limit);

			if (response.Status == Status.Success)
			{
				Posts = response.Data;
				UserPosts = [.. response.Data.Data];
				return [.. response.Data.Data];
			}
			else
			{
				MessageBox.Show(response.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

	}
}
