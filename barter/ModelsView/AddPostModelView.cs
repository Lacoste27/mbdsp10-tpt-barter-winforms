using barter.Models;
using barter.Requests;
using barter.Responses;
using barter.Services.Categories;
using barter.Services.Objects;
using barter.Services.Posts;
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

		public AddPostModelView()
		{
			PostService = Service.GetService<IPostService>();
		}

		public async Task<Post> AddPost(int authorId, List<int> objectIds)
		{
			PostRequest request = new (){ AuthorId = authorId, ObjectIds = objectIds };

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
	}
}
