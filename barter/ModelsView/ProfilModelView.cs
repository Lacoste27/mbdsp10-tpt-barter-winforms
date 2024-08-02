using barter.Models;
using barter.Responses;
using barter.Services.Notifications;
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
	public class ProfilModelView
	{
		private IObjectService ObjectService { get; set; }
		private IPostService PostService { get; set; }

		public List<Models.Object> UserObjects { get; private set; }
		public Boolean userObjectChanged { get; set; } = false;	
		public Boolean userPostChanged { get; set; } = false;	

		public ProfilModelView()
		{
			ObjectService = Service.GetService<IObjectService>();
			PostService = Service.GetService<IPostService>();
		}

		public async Task<List<Models.Object>> GetUserObjects()
		{
			int userId = TokenStorage.GetUserId();
			var response = await ObjectService.GetAllObjects();

			if (response.Status == Status.Success)
			{
				UserObjects = [.. response.Data];
				return [.. response.Data];
			}
			else
			{
				MessageBox.Show(response.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		public async Task<List<Post>> GetUserPosts()
		{
			int userId = TokenStorage.GetUserId();

			var response = await PostService.GetUserPost(userId);

			if (response.Status == Status.Success)
			{
				return [.. response.Data];
			}
			else
			{
				MessageBox.Show(response.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

	}
}
