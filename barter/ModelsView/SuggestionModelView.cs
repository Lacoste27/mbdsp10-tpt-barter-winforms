using barter.Components;
using barter.Models;
using barter.Responses;
using barter.Services.Categories;
using barter.Services.Posts;
using barter.Services.Suggestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.ModelsView
{
	public class SuggestionModelView
	{
		private ISuggestionService SuggestionService { get; set; }

		public SuggestionModelView()
		{
			SuggestionService = Service.GetService<ISuggestionService>();
		}

		public async Task<List<Suggestion>> GetUserSuggestion(string status = "PENDING")
		{
			var response = await SuggestionService.GetUserSuggestion(status, 1, 10);

			if (response.Status == Status.Success)
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
