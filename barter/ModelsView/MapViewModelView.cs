using barter.Components;
using barter.Models;
using barter.Services.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.ModelsView
{
	public class MapViewModelView
	{
		private IPostService PostService { get; set; }

		public MapViewModelView()
		{
			PostService = Service.GetService<IPostService>();
		}

		public async Task<List<Post>> GetAllPost(int page = 1, int limit = 1000)
		{
			var response = await PostService.GetAllPosts(page, limit);

			if (response.Status == Responses.Status.Success)
			{
				return response.Data.Data;
			}
			else
			{
				MessageBox.Show(response.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
	}
}
