using barter.Models;

namespace barter.Components
{
	public partial class MessageListView : UserControl
	{
		private Chat Chat = new();

		public MessageListView()
		{
			InitializeComponent();
		}

		private MessageListView(Chat Message)
		{
			this.Chat = Message;
		}
	}
}
