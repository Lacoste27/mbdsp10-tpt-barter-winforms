using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Services.Api
{
	public interface IApiService
	{
		public HttpClient GetClient();
	}
}
