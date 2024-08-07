using barter.Models;
using barter.Requests;
using barter.Responses;
using barter.Services.Categories;
using barter.Services.Objects;
using barter.Services.Posts;
using barter.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.ModelsView
{
	public class AddPostModelView
	{
		private IPostService PostService { get; set; }
		private IObjectService ObjectService { get; set; }

		public List<Models.Object> UserObjects { get; set; }


		public AddPostModelView()
		{
			PostService = Service.GetService<IPostService>();
			ObjectService = Service.GetService<IObjectService>();
		}

		public async Task<Post> AddPost(int authorId,String Description, List<int> objectIds)
		{
			PostRequest request = new (){ AuthorId = authorId,Description= Description, ObjectIds = objectIds };

			var response = await PostService.AddPost(request);

			if (response.Status == Status.Success)
			{
				return response.Data;
			}
			else
			{
				MessageBox.Show(response.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		public async Task<List<Models.Object>> GetUserObjects(int page = 1, int limit = 100)
		{
			int userId = TokenStorage.GetUserId();
			var response = await ObjectService.GetUserObjects(userId, page, limit);

			if (response.Status == Status.Success)
			{
				UserObjects = [.. response.Data.Data];
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
