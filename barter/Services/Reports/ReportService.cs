using barter.Models;
using barter.Requests;
using barter.Responses;
using barter.Services.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;


namespace barter.Services.Reports
{
	public class ReportService : IReportService
	{
		private IApiService ApiService { get; set; }
		private ILogger logger { get; set; }
		private string endpoint = "api/reports";


		public ReportService()
		{
			ApiService = Service.GetService<IApiService>();

			ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
			logger = factory.CreateLogger("Program");
		}

		public ReportService(IApiService _ApiService)
		{
			ApiService = _ApiService;
		}

		public async Task<Response<Report>> AddPostReport(Report request)
		{
			string path = string.Format("{0}/post", endpoint);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().PostAsJsonAsync(
				path, request);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Report>();
					return new Response<Report>(Status.Success, data);
				}
				else if (response.StatusCode == HttpStatusCode.BadRequest)
				{
					var errorContent = await response.Content.ReadAsStringAsync();
					var badRequestResponse = JsonConvert.DeserializeObject<BadRequest>(errorContent);
					var errorMessage = string.Join(";\n ", badRequestResponse.Errors.Select(e => e.Msg));
					return new Response<Report>(Status.Error, null, errorMessage);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Report>(Status.Error, null, errorMessage);
				}
			}
			catch (Exception Exception)
			{
				logger.LogInformation(Exception.Message, "Message");
				return new Response<Report>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Report>> AddUserReport(Report request)
		{
			string path = string.Format("{0}/user", endpoint);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().PostAsJsonAsync(
				path, request);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Report>();
					return new Response<Report>(Status.Success, data);
				}
				else if (response.StatusCode == HttpStatusCode.BadRequest)
				{
					var errorContent = await response.Content.ReadAsStringAsync();
					var badRequestResponse = JsonConvert.DeserializeObject<BadRequest>(errorContent);
					var errorMessage = string.Join(";\n ", badRequestResponse.Errors.Select(e => e.Msg));
					return new Response<Report>(Status.Error, null, errorMessage);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Report>(Status.Error, null, errorMessage);
				}
			}
			catch (Exception Exception)
			{
				logger.LogInformation(Exception.Message, "Message");
				return new Response<Report>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<List<Report>>> GetAllReport()
		{
			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(endpoint);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<List<Report>>();
					return new Response<List<Report>>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<List<Report>>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				logger.LogInformation(Exception.Message, "Message");
				return new Response<List<Report>>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Report>> GetById(string Id)
		{
			string path = string.Format("{0}/{1}", endpoint, Id);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(path);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Report>();
					return new Response<Report>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Report>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				logger.LogInformation(Exception.Message, "Message");
				return new Response<Report>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<List<Report>>> GetUserReport(int userId)
		{
			string path = string.Format("{0}/{1}/user", endpoint, userId);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(path);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<List<Report>>();
					return new Response<List<Report>>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<List<Report>>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				logger.LogInformation(Exception.Message, "Message");
				return new Response<List<Report>>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Report>> UpdateReport(ReportRequest request)
		{
			string path = string.Format("{0}/{1}", endpoint, request.Id);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().PutAsJsonAsync(
					path, request);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Report>();
					return new Response<Report>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Report>(Status.Error, null, errorMessage);
				}
			}
			catch (Exception Exception)
			{
				logger.LogInformation(Exception.Message, "Message");
				return new Response<Report>(Status.Error, null, Exception.Message);
			}
		}
	}
}
