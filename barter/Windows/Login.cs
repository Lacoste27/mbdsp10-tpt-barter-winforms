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

			if(response)
			{
				Main main = new Main();
				main.Show();
			}
		}
	}
}
