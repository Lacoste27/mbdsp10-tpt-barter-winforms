using barter.Models;
using barter.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barter.Components
{
	public partial class SuggestionView : UserControl
	{
		public SuggestionDetail Detail { get; set; }
		private Suggestion Suggestion { get; set; }


		public SuggestionView()
		{
			InitializeComponent();
		}

		public SuggestionView(Suggestion Suggestion)
		{
			this.Suggestion = Suggestion;
			this.Detail = new SuggestionDetail(Suggestion);
			InitializeComponent();
		}

		private void detailButton_Click(object sender, EventArgs e)
		{
			this.Detail.ShowDialog();
		}

		private void SuggestionView_Load(object sender, EventArgs e)
		{
			this.username.Text = this.Suggestion.SuggestedBy.Name;

			if(Suggestion.Status == "ACCEPTED")
			{
				this.suggestStatus.Text = "Accepted";
				this.suggestStatus.BackColor = Color.Green;
				this.suggestStatus.FlatAppearance.BorderColor = Color.Green;

			}
			else if(Suggestion.Status == "DECLINED")
			{
				this.suggestStatus.Text = "Declined";
				this.suggestStatus.BackColor = Color.Red;
				this.suggestStatus.FlatAppearance.BorderColor = Color.Red;
			}
		}
	}
}
