﻿using barter.Models;
using barter.Requests;
using barter.Responses;
using barter.Services.Auth;
using barter.Services.Notifications;
using barter.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barter.ModelsView
{
	public class LoginModelView
	{
		private IAuthService AuthService { get; set; }

		public LoginModelView()
		{
			AuthService = Service.GetService<IAuthService>();
		}

		public async Task<bool> Login(string email, string password)
		{
			
			AuthRequest request = new AuthRequest()
			{
				Email = email,
				Password = password
			};

			var response = await AuthService.Login(request);

			if(response.Status == Status.Success)
			{
				TokenStorage.SaveToken(response.Data.Token);

				return true;
			}
			else
			{
				MessageBox.Show(response.Message,"Message d'erreur",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
	}
}
