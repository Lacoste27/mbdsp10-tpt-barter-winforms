using barter.ModelsView;

namespace barter.Components
{
	public partial class Messages : UserControl
	{
		private readonly ChatModelView ChatModelView = new();


		public Messages()
		{
			InitializeComponent();
		}

		private void Messages_Load(object sender, EventArgs e)
		{
			try
			{
				
			}catch(Exception Exception)
			{
				MessageBox.Show("Une erreur s'est produite !", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public async void LoadMessages()
		{
			try
			{
				var chats = await ChatModelView.GetUserChat();

				if (chats != null)
				{
					foreach (var chat in chats)
					{
						var messageView = new MessageView(chat);
						messageView.BackColor = Color.White;

						messageFlowLayout.Controls.Add(messageView);
						messageFlowLayout.Refresh();
					}
				}
			}
			catch (Exception Exception)
			{
				MessageBox.Show("Une erreur s'est produite !", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
