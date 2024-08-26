using barter.Models;
using barter.ModelsView;
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
	public partial class SuggestionDetail : Form
	{
		private Suggestion Suggestion { get; set; }
		private SuggestionDetailsModelView SuggestionDetailsModelView { get; set; } = new SuggestionDetailsModelView(); 

		public SuggestionDetail()
		{
			InitializeComponent();
		}

		public SuggestionDetail(Suggestion suggestion)
		{
			InitializeComponent();

			this.Suggestion = suggestion;
		}

		private async void acceptButton_Click(object sender, EventArgs e)
		{
			acceptButton.Enabled = false;
			acceptButton.Text = "Loading...";

			try
			{
				string status = "ACCEPTED";

				var update = await this.SuggestionDetailsModelView.UpdateSuggestion(this.Suggestion.Id, status);

				if (update is not null)
				{
					MessageBox.Show("Suggestion updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
			}
			catch(Exception Exception)
			{
				acceptButton.Text = "Accept";
				acceptButton.Enabled = true;
			}
			finally
			{
				acceptButton.Text = "Accept";
				acceptButton.Enabled = true;
			}
		}

		private async void declinedButton_Click(object sender, EventArgs e)
		{
			declinedButton.Enabled = false;
			declinedButton.Text = "Loading...";

			try
			{
				string status = "DECLINED";

				var update = await this.SuggestionDetailsModelView.UpdateSuggestion(this.Suggestion.Id, status);

				if (update is not null)
				{
					MessageBox.Show("Suggestion updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
			}
			catch (Exception Exception)
			{
				declinedButton.Text = "Accept";
				declinedButton.Enabled = true;
			}
			finally
			{
				acceptButton.Text = "Accept";
				declinedButton.Enabled = true;
			}

			
		}

		private void SuggestionDetail_Load(object sender, EventArgs e)
		{
			this.username.Text = this.Suggestion.SuggestedBy.Name;
			this.description.Text = this.Suggestion.Post.description;
			this.createdAt.Text = this.Suggestion.CreatedAt.ToShortDateString();

			Load_Post_Objet();
			Load_Suggested_Object();

			if(this.Suggestion.Status == "ACCEPTED")
			{
				acceptButton.Enabled = false;
				declinedButton.Enabled = false;
				declinedButton.Visible = false;
			}
			else if(this.Suggestion.Status == "DECLINED")
			{
				acceptButton.Enabled = false;
				acceptButton.Visible = false;
				declinedButton.Enabled = false;
			}
		}

		private async void Load_Suggested_Object()
		{
			if (this.Suggestion.SuggestedObject is not null)
			{
				suggestedObjet.Items.Clear();

				foreach (var item in this.Suggestion.SuggestedObject)
				{
					suggestedObjet.DisplayMember = "Text";
					suggestedObjet.ValueMember = "Value";
					suggestedObjet.Items.Add(new { Text = item.Object.Name, Value = item.Object.Id, Checked = true });
					suggestedObjet.Tag = item.Id;
				}

				int maxWidth = 0;
				using (Graphics g = suggestedObjet.CreateGraphics())
				{
					foreach (var item in postObject.Items)
					{
						int itemWidth = (int)g.MeasureString(item.ToString(), suggestedObjet.Font).Width;
						if (itemWidth > maxWidth)
						{
							maxWidth = itemWidth;
						}
					}
				}
				suggestedObjet.ColumnWidth = maxWidth + SystemInformation.VerticalScrollBarWidth;
			}
		}

		private async void Load_Post_Objet()
		{
			if (this.Suggestion.Post is not null)
			{
				postObject.Items.Clear();

				foreach (var item in this.Suggestion.Post.Objects)
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
