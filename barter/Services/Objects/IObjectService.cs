using barter.Models;
using barter.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Services.Objects
{
	public interface IObjectService
	{
		public Task<Response<List<Models.Object>>> GetAllObjects();
		public Task<Response<Models.Object>> GetUserObjects(int userId);
		public Task<Response<Models.Object>> GetObjectByid(int id);
	}
}
