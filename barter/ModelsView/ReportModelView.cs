using barter.Models;
using barter.Services.Notifications;
using barter.Services.Objects;
using barter.Services.Posts;
using barter.Services.Reports;
using barter.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.ModelsView
{
	public class ReportModelView
	{
		private IReportService ReportService { get; set; }


		public ReportModelView()
		{
			ReportService = Service.GetService<IReportService>();
		}

		public async Task<Report> AddUserReport(Report userReport)
		{
			int userId = TokenStorage.GetUserId();
			var response = await ReportService.AddUserReport(userReport);

			if (response.Status == Responses.Status.Success)
			{
				return response.Data;
			}
			else
			{
				MessageBox.Show(response.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		public async Task<Report> AddPostReport(Report userReport)
		{
			int userId = TokenStorage.GetUserId();
			var response = await ReportService.AddPostReport(userReport);

			if (response.Status == Responses.Status.Success)
			{
				return response.Data;
			}
			else
			{
				MessageBox.Show(response.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
	}
}
