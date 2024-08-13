using barter.Models;
using barter.Requests;
using barter.Services.Suggestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.ModelsView
{
	public class SuggestionDetailsModelView
	{
		private ISuggestionService SuggestionService { get; set; }

		public SuggestionDetailsModelView()
		{
			SuggestionService = Service.GetService<ISuggestionService>();
		}

		public async Task<Suggestion> UpdateSuggestion(int idSuggestion, String status)
		{
			var suggestion = await SuggestionService.UpdateSuggestion(idSuggestion, status);

			if (suggestion.Status == Responses.Status.Success)
			{
				return suggestion.Data;
			}
			else
			{
				MessageBox.Show(suggestion.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
	}
}
