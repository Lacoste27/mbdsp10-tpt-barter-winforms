using barter.Requests;
using barter.Responses;

namespace barter.Services.Objects
{
	public interface IObjectService
	{
		public Task<Response<List<Models.Object>>> GetAllObjects();
		public Task<Response<ListResponse<Models.Object>>> GetUserObjects(int userId, int page = 1, int limit = 10);
		public Task<Response<Models.Object>> GetObjectByid(int id);
		public Task<Response<Models.Object>> AddObject(ObjectRequest request);
		public Task<Response<Models.Object>> UpdateObject(UpdateObjectRequest request, int objectId);
	}
}
