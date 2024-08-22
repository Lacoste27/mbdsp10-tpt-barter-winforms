using barter.Models;

namespace barter.Components
{
	public partial class MessageListView : UserControl
	{
		private Chat Message = new();

		public MessageListView()
		{
			InitializeComponent();
		}

		public MessageListView(Chat Message)
		{
			this.Message = Message;
			InitializeComponent();
		}

		private void MessageListView_Load(object sender, EventArgs e)
		{
			this.username.Text = this.Message.Receiver.Username;

			for (int i = 0; i < 40; i++)
			{
				Panel message = new Panel();

				message.AutoSize = true;
				message.AutoSizeMode = AutoSizeMode.GrowAndShrink;
				message.BorderStyle = BorderStyle.FixedSingle;
				message.Location = new Point(3, 3);
				message.Name = $"panel {i}";
				message.Size = new Size(120, 22);
				message.TabIndex = 1;

				if(i%2 == 0)
				{
					message.BackColor = Color.FromArgb(39, 194, 64);
				} else
				{
					message.BackColor = SystemColors.Control;
				}

				Label messageLabel = new();
				messageLabel.AutoSize = true;
				messageLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
				messageLabel.Location = new Point(4, 0);
				messageLabel.Name = "label1";
				messageLabel.Size = new Size(111, 20);
				messageLabel.TabIndex = 0;
				messageLabel.Text = "Mora be nge io";
				messageLabel.TextAlign = ContentAlignment.MiddleCenter;

				message.Controls.Add(messageLabel);

				flowLayoutPanel1.Controls.Add(message);
			}
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
