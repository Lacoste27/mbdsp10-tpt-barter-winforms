using barter.Models;
using barter.ModelsView;
using barter.Requests;
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
	public partial class AddSuggestion : Form
	{
		private AddSuggestionModelView AddSuggestionModelView { get; set; } = new AddSuggestionModelView();

		public Post Post { get; set; }

		public AddSuggestion()
		{
			InitializeComponent();
		}

		public AddSuggestion(Post post)
		{
			InitializeComponent();
			this.Post = post;
		}


		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void AddSuggestion_Load(object sender, EventArgs e)
		{
			this.description.Text = this.Post.description;
			this.username.Text = this.Post.Author.Username;

			Load_Post_Object();
			Load_User_Object();
		}

		private void Load_Post_Object()
		{
			if (this.Post is not null)
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

		private async void Load_User_Object()
		{
			var objects = await this.AddSuggestionModelView.GetUserObjects();

			if (objects is not null)
			{
				foreach (var item in objects)
				{
					userObject.DisplayMember = "Text";
					userObject.ValueMember = "Value";
					userObject.Items.Insert(0, new { Text = item.Name, Value = item.Id });
					userObject.Tag = item.Id;
				}

				int maxWidth = 0;
				using (Graphics g = userObject.CreateGraphics())
				{
					foreach (var item in userObject.Items)
					{
						int itemWidth = (int)g.MeasureString(item.ToString(), userObject.Font).Width;
						if (itemWidth > maxWidth)
						{
							maxWidth = itemWidth;
						}
					}
				}
				userObject.ColumnWidth = maxWidth + SystemInformation.VerticalScrollBarWidth;
			}
		}

		private async void saveButton_Click(object sender, EventArgs e)
		{
			List<int> suggestedObjectIds = new List<int>();
			int suggestedById = TokenStorage.GetUserId();

			foreach (var item in userObject.CheckedItems)
			{
				dynamic data = item;

				if (data is not null)
				{
					suggestedObjectIds.Add(data.Value);
				}
			}

			var suggestion = await this.AddSuggestionModelView.SendSuggestion(this.Post, suggestedById, suggestedObjectIds);

			if (suggestion is not null)
			{
				MessageBox.Show("Suggestion added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Close();
			}
		}
	}
}
