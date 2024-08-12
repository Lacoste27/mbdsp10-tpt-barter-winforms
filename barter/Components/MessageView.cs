using barter.Models;

namespace barter.Components
{
	public partial class MessageView : UserControl
	{
		private Chat Message { get; set; }


		public MessageView()
		{
			InitializeComponent();
		}

		public MessageView(Chat Chat)
		{
			this.Message = Message;
		}

		private void MessageView_Load(object sender, EventArgs e)
		{
			this.username.Text = this.Message.Receiver.Username;
		}
	}
}
