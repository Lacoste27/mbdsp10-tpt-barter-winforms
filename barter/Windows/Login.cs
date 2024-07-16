using barter.ModelsView;
using barter.Requests;

namespace barter.Windows
{
	public partial class Login : Form
	{
		private LoginModelView LoginModelView { get; set; }

		public Login()
		{
			LoginModelView = new LoginModelView();
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private async void loginButton_Click(object sender, EventArgs e)
		{
			loginButton.Enabled = false;
			loginButton.Text = "Loading...";

			try
			{
				AuthRequest request = new()
				{
					Email = usernameTextBox.Text,
					Password = passwordTextBox.Text
				};

				var response = await LoginModelView.Login(request.Email, request.Password);

				if (response)
				{
					DialogResult = DialogResult.OK;
					Close();
				}
			}
			finally
			{
				loginButton.Enabled = true;
			}

		}

		private void getStartedLabel_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void passwordTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private async void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				AuthRequest request = new()
				{
					Email = usernameTextBox.Text,
					Password = passwordTextBox.Text
				};

				var response = await LoginModelView.Login(request.Email, request.Password);

				if (response)
				{
					DialogResult = DialogResult.OK;
					Close();
				}
			}
		}
	}
}
