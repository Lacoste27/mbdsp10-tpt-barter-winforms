global using Microsoft.Extensions.Logging;
using barter.Utils;
using barter.Windows;

namespace barter
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			Service.ConfigureService();

			bool isTokenExpired = TokenStorage.IsTokenExpired();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			
			if (isTokenExpired)
			{
				var loginForm = new Login();
				if (loginForm.ShowDialog() == DialogResult.OK)
				{
					Application.Run(new Main());
				}
			}
			else
			{
				Application.Run(new Main());
			}
		}
	}
}