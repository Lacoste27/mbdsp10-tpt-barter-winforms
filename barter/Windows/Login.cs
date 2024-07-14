using barter.ModelsView;
using barter.Requests;
using barter.Services.Auth;
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
