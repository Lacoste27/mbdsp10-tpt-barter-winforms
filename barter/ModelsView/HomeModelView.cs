﻿using barter.Models;
using barter.Responses;
using barter.Services.Posts;

namespace barter.ModelsView
{
	public class HomeModelView
	{
		private IPostService PostService { get; set; }

		public ListResponse<Post> Posts { get; private set; }

		public bool PostChanged { get; set; }


		public HomeModelView()
		{
			PostService = Service.GetService<IPostService>();
		}

		public async Task<List<Post>> GetPosts()
		{
			var response = await PostService.GetAllPosts(1, 10);

			if (response.Status == Status.Success)
			{
				Posts = response.Data;
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
