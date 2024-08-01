using barter.Models;
using barter.Requests;
using barter.Responses;

namespace barter.Services.Objects
{
	public interface IObjectService
	{
		public Task<Response<List<Models.Object>>> GetAllObjects();
		public Task<Response<List<Models.Object>>> GetUserObjects(int userId);
		public Task<Response<Models.Object>> GetObjectByid(int id);
		public Task<Response<Models.Object>> AddObject(ObjectRequest request);
	}
}
