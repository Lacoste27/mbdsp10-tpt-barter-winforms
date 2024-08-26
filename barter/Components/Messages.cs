using barter.Models;
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
					/*for (int i = 0; i < 10; i++)
					{
						Chat chat = new Chat();
						chat.Receiver = new();
						chat.Receiver.Username = "User" + i;
						chat.Receiver.Name = "Another User " + i;

						var messageView = new MessageView(chat);
						messageView.BackColor = Color.White;
						messageView.Click += message_Click;

						messageFlowLayout.Controls.Add(messageView);
						messageFlowLayout.Refresh();
					}*/

					foreach (var chat in chats)
					{
						var messageView = new MessageView(chat);
						messageView.BackColor = Color.White;
						messageView.Click += message_Click;

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

		private void message_Click(object sender, EventArgs e)
		{
			MessageView message = (MessageView)sender;

			MessageListView listView = new MessageListView(message.Message);

			listView.BackColor = Color.White;
			listView.Dock = DockStyle.Fill;
			listView.Location = new Point(0, 0);
			listView.TabIndex = 0;
			listView.Visible = true;

			splitContainer1.Panel2.Controls.Clear();
			splitContainer1.Panel2.Controls.Add(listView);
		}
	} 
}
