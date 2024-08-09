using barter.Models;
using barter.Windows;

namespace barter.Components
{
	public partial class PostView : UserControl
	{
		public Post Post { get; set; }


		public PostView()
		{
			InitializeComponent();
		}

		public PostView(Post post)
		{
			InitializeComponent();
			this.Post = post;
		}

		private void PostView_Load(object sender, EventArgs e)
		{
			this.usernameText.Text = Post.Author.Username;
			this.publishDate.Text = Utils.Util.TimeAgo(Post.createdAt);

			if (this.Post.Objects is not null)
			{
				objectList.Invoke(new Action(() =>
				{
					objectList.Items.Clear();

					foreach (var item in this.Post.Objects)
					{
						objectList.DisplayMember = "Text";
						objectList.ValueMember = "Value";

						objectList.Items.Insert(0, new { Text = item.Object.Name, Value = item.Object.Id });
						objectList.Tag = item.Id;
					}

					int maxWidth = 0;
					using (Graphics g = objectList.CreateGraphics())
					{
						foreach (var item in objectList.Items)
						{
							int itemWidth = (int)g.MeasureString(item.ToString(), objectList.Font).Width;
							if (itemWidth > maxWidth)
							{
								maxWidth = itemWidth;
							}
						}
					}
					objectList.ColumnWidth = maxWidth + SystemInformation.VerticalScrollBarWidth;
				}));
			}
		}

		private void usernameText_Click(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DetailPost details = new DetailPost(this.Post);
			details.ShowDialog();
		}
	}
}
