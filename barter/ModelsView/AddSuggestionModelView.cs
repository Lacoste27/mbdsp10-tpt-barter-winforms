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
	public class AddSuggestionModelView
	{
		private IObjectService ObjectService { get; set; }

		public List<Models.Object> UserObjects { get; set; }


		public AddSuggestionModelView()
		{
			ObjectService = Service.GetService<IObjectService>();
		}

		public async Task<List<Models.Object>> GetUserObjects(int page = 1, int limit = 100)
		{
			int userId = TokenStorage.GetUserId();
			var response = await ObjectService.GetUserObjects(userId, page, limit);

			if (response.Status == Responses.Status.Success)
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
