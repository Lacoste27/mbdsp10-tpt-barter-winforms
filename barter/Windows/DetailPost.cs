using barter.Components;
using barter.Models;

namespace barter.Windows
{
	public partial class DetailPost : Form
	{
		public Post post { get; set; }

		public DetailPost()
		{
			InitializeComponent();
		}

		public DetailPost(Post post)
		{
			InitializeComponent();
			this.post = post;
		}

		private void DetailPost_Load(object sender, EventArgs e)
		{
			this.username.Text = this.post.Author.Name;
			this.publishDate.Text = Utils.Util.TimeAgo(this.post.createdAt);
			this.description.Text = this.post.description;

			if (post.Objects is not null)
			{
				foreach (var item in post.Objects)
				{
					ObjectDetailView view = new ObjectDetailView(item.Object);
					view.Margin = new Padding(0, 0, 0, 20);
					this.objectListLayout.Controls.Add(view);
				}

				var categories = post.Objects.Select(x => x.Object.Category).ToList();
				categories.Select(category => category.Title).Distinct().ToList().ForEach(category =>
				{
					Button button = new();
					button.Text = category;
					button.Enabled = false;

					categoryLayout.Controls.Add(button);
				});
			}
		}

		private void sendMessageButton_Click(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void suggestButton_Click(object sender, EventArgs e)
		{
			AddSuggestion addSuggestion = new(this.post);
			addSuggestion.ShowDialog();
		}

		private void reportButton_Click(object sender, EventArgs e)
		{
			Report report = new Report(this.post);

			report.ShowDialog();
		}
	}
}
