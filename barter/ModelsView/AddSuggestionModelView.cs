using barter.Models;
using barter.Requests;
using barter.Services.Notifications;
using barter.Services.Objects;
using barter.Services.Posts;
using barter.Services.Suggestions;
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
		private INotificationService NotificationService { get; set; }
		private ISuggestionService SuggestionService { get; set; }

		public List<Models.Object> UserObjects { get; set; }


		public AddSuggestionModelView()
		{
			ObjectService = Service.GetService<IObjectService>();
			SuggestionService = Service.GetService<ISuggestionService>();
			NotificationService = Service.GetService<INotificationService>();
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

		public async Task<Suggestion> SendSuggestion(Post post, int suggestedById, List<int> SuggestedObjectIds)
		{
			SuggestionRequest request = new SuggestionRequest
			{
				PostId = post.Id,
				SuggestedById = suggestedById,
				SuggestedObjectIds = SuggestedObjectIds
			};

			var suggestion = await SuggestionService.SendSuggestion(request);

			if (suggestion.Status == Responses.Status.Success)
			{
				NotificationRequest notificationRequest = new NotificationRequest()
				{
					Message = "You have a new suggestion",
					Subject = "New",
					UserId = post.Author.Id
				};

				var notification = await NotificationService.AddNotification(notificationRequest);
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
