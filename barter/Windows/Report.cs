using barter.Models;
using barter.ModelsView;
using barter.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barter.Windows
{
	public partial class Report : Form
	{
		private bool postReport { get; set; } = true;
		private bool userReport { get; set; } = false;

		private Post Post { get; set; }

		private ReportModelView ReportModelView { get; set; } = new ReportModelView();

		public Report()
		{
			InitializeComponent();
		}

		public Report(Post post)
		{
			this.Post = post;
			InitializeComponent();
		}

		private async void saveButton_Click(object sender, EventArgs e)
		{
			saveButton.Enabled = false;
			saveButton.Text = "Loading...";

			try
			{
				if (this.userReportRadio.Checked)
				{
					Models.Report report = new Models.Report();

					UserReport userMakeReport = new UserReport();
					UserReport userReport = new UserReport();

					userMakeReport.Id = TokenStorage.GetUserId();
					userMakeReport.Username = TokenStorage.GetUserUsername();
					userMakeReport.Email = TokenStorage.GetUserEmail();

					userReport.Id = this.Post.AuthorId;
					userReport.Username = this.Post.Author.Username;
					userReport.Email = this.Post.Author.Email;

					report.UserReport = userReport;
					report.UserMakeReport = userMakeReport;
					report.Motif = this.reasonText.Text;

					var response = await this.ReportModelView.AddUserReport(report);

					if (response is not null)
					{
						MessageBox.Show("User report added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Close();
					}
				}
				else if (this.postReportRadio.Checked)
				{
					Models.Report report = new Models.Report();

					UserReport userMakeReport = new UserReport();

					userMakeReport.Id = TokenStorage.GetUserId();
					userMakeReport.Username = TokenStorage.GetUserUsername();
					userMakeReport.Email = TokenStorage.GetUserEmail();

					ObjetReport objectReport = new ObjetReport();

					int objectReportId = TokenStorage.GetUserId();

					if(postObject.CheckedItems.Count == 0)
					{
						MessageBox.Show("Please choose one object to report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

					foreach (var item in postObject.CheckedItems)
					{
						dynamic data = item;

						if (data is not null)
						{
							objectReportId = data.Value;
						}
					}


					ObjectPost _object = this.Post.Objects.Where(o => o.ObjectId == objectReportId).FirstOrDefault();

					string objectName = _object.Object.Name;
					int ownerId = _object.Object.OwnerId;
					int categoryId = _object.Object.CategoryId;

					objectReport.CategorieId = categoryId;
					objectReport.ProprietaireId = ownerId;
					objectReport.Nom = objectName;
					objectReport.Id = objectReportId;
					
					report.ObjetReport = objectReport;
					report.UserMakeReport = userMakeReport;
					report.Motif = this.reasonText.Text;

					var response = await this.ReportModelView.AddPostReport(report);

					if (response is not null)
					{
						MessageBox.Show("Object report added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Close();
					}
				}
			}
			finally
			{
				saveButton.Text = "Save";
				saveButton.Enabled = true;
			}
		}

		private void TypeReportRadio_CheckedChanged(object sender, EventArgs e)
		{
			this.postObject.Visible = this.postReportRadio.Checked;
		}

		private void UserReportRadio_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void PostReportRadio_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void Report_Load(object sender, EventArgs e)
		{
			if(this.Post is not null)
			{
				foreach (var item in this.Post.Objects)
				{
					postObject.DisplayMember = "Text";
					postObject.ValueMember = "Value";
					postObject.Items.Add(new { Text = item.Object.Name, Value = item.Object.Id, Checked = true });
					postObject.Tag = item.Id;
				}

				int maxWidth = 0;
				using (Graphics g = postObject.CreateGraphics())
				{
					foreach (var item in postObject.Items)
					{
						int itemWidth = (int)g.MeasureString(item.ToString(), postObject.Font).Width;
						if (itemWidth > maxWidth)
						{
							maxWidth = itemWidth;
						}
					}
				}
				postObject.ColumnWidth = maxWidth + SystemInformation.VerticalScrollBarWidth;
			}
		}
	}
}
