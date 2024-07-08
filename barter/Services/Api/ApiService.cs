using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace barter.Services.Api {
	public class ApiService : IApiService {

		private HttpClient Client { get; set; }

		public ApiService() {
			Client = new();
			Client.BaseAddress = new Uri(Properties.Resources.baseurl);
			Client.DefaultRequestHeaders.Accept.Clear();
			Client.DefaultRequestHeaders.Accept.Add(
				new MediaTypeWithQualityHeaderValue("application/json"));
		}

		public HttpClient GetClient()
		{
			return Client;
		}
	}
}
