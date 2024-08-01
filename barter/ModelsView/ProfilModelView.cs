using barter.Responses;
using barter.Services.Notifications;
using barter.Services.Objects;
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

		public ProfilModelView()
		{
			ObjectService = Service.GetService<IObjectService>();
		}

		public async Task<List<Models.Object>> GetUserObjects()
		{
			int userId = TokenStorage.GetUserId();
			var response = await ObjectService.GetAllObjects();

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
