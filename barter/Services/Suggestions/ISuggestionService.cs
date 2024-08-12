using barter.Models;
using barter.Requests;
using barter.Responses;

namespace barter.Services.Suggestions
{
	public interface ISuggestionService
	{
		public Task<Response<ListResponse<Suggestion>>> GetUserSuggestion(string statys = "PENDING", int page = 1, int limit = 10);
		public Task<Response<Suggestion>> SendSuggestion(SuggestionRequest request);

	}
}
