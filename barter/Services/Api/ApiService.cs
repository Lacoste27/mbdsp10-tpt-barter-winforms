using barter.Exceptions;
using barter.Utils;
using System.Net.Http.Headers;

namespace barter.Services.Api
{
	public class ApiService : IApiService
	{

		private HttpClient Client { get; set; }

		public ApiService()
		{
			Client = new();
			Client.BaseAddress = new Uri(Properties.Resources.remoteurl);
			Client.DefaultRequestHeaders.Accept.Clear();
			Client.DefaultRequestHeaders.Accept.Add(
				new MediaTypeWithQualityHeaderValue("application/json"));
		}

		public HttpClient GetClient(bool needToken = true)
		{
			if (needToken)
			{
				string token = TokenStorage.LoadToken() ?? throw new UnauhtorizedException("Token is not specified");

				KeyValuePair<string, IEnumerable<string>> _token = Client.DefaultRequestHeaders.Where(x => x.Key == "x-auth-token").FirstOrDefault();

				if (_token.Key is null)
				{
					Client.DefaultRequestHeaders.Add("x-auth-token", token);
				}
			}

			return Client;
		}
	}
}
