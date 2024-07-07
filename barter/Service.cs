using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using barter.Services.Categories;
using barter.Services.Messages;
using barter.Services.Notifications;
using barter.Services.Objects;
using barter.Services.Posts;
using barter.Services.Reports;
using barter.Services.Users;

namespace barter
{
	public static class Service
	{
		public static IServiceProvider serviceProvider { get; set; }

		public static void ConfigureService()
		{
			var services = new ServiceCollection();

			services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<IMessageService, MessageService>();
			services.AddScoped<INotificationService, NotificationService>();
			services.AddScoped<IObjectService, ObjectService>();
			services.AddScoped<IPostService, PostService>();
			services.AddScoped<IReportService, ReportService>();
			services.AddScoped<IUsersService, UsersService>();
		}

		public static T? GetService<T>() where T : class
		{
			return (T?)serviceProvider.GetService(typeof(T));
		}
	}
}
