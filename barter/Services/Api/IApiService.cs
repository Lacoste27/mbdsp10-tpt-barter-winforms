namespace barter.Services.Api
{
	public interface IApiService
	{
		public HttpClient GetClient(bool needToken = true);
	}
}
