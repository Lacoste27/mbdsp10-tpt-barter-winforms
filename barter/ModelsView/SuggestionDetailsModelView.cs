using barter.Models;
using barter.Requests;
using barter.Services.Notifications;
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
		private INotificationService NotificationService { get; set; }
		public SuggestionDetailsModelView()
		{
			SuggestionService = Service.GetService<ISuggestionService>();
			NotificationService = Service.GetService<INotificationService>();
		}

		public async Task<Suggestion> UpdateSuggestion(int idSuggestion, String status)
		{
			var suggestion = await SuggestionService.UpdateSuggestion(idSuggestion, status);

			if (suggestion.Status == Responses.Status.Success)
			{
				if(suggestion.Data.Status == "DECLINED")
				{
					NotificationRequest notificationRequest = new NotificationRequest()
					{
						Message = "Your suggestion is declined",
						Subject = "Suggestion declined",
						UserId = suggestion.Data.SuggestedById
					};

					await NotificationService.AddNotification(notificationRequest);
				}else if(suggestion.Data.Status == "ACCEPTED")
				{
					NotificationRequest notificationRequest = new NotificationRequest()
					{
						Message = "Your suggestion is accpeted",
						Subject = "Suggestion accepted",
						UserId = suggestion.Data.SuggestedById
					};

					await NotificationService.AddNotification(notificationRequest);
				}
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
