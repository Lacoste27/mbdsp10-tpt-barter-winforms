using barter.Responses;

namespace barter.Services.Objects
{
	public interface IObjectService
	{
		public Task<Response<List<Models.Object>>> GetAllObjects();
		public Task<Response<Models.Object>> GetUserObjects(int userId);
		public Task<Response<Models.Object>> GetObjectByid(int id);
	}
}
