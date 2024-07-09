using barter.Models;
using barter.Requests;
using barter.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.Services.Reports
{
	public interface IReportService
	{
		public Task<Response<List<Report>>> GetAllReport();
		public Task<Response<List<Report>>> GetUserReport(int userId);
		public Task<Response<Report>> AddUserReport(Report request);
		public Task<Response<Report>> AddPostReport(Report request);
		public Task<Response<Report>> UpdateReport(ReportRequest request);
		public Task<Response<Report>> GetById(string Id);
	}
}
