using barter.Models;
using barter.Requests;
using barter.Responses;
using barter.Services.Categories;
using barter.Services.Objects;
using System.ComponentModel.DataAnnotations;

namespace barter.ModelsView
{
	public class AddObjectModelView
	{
		private IObjectService ObjectService { get; set; }
		private ICategoryService CategoryService { get; set; }


		public AddObjectModelView()
		{
			ObjectService = Service.GetService<IObjectService>();
			CategoryService = Service.GetService<ICategoryService>();
		}

		public async Task<Models.Object> AddObject(ObjectRequest request)
		{
			var validationResults = new List<ValidationResult>();
			var validationContext = new ValidationContext(request);

			if (!Validator.TryValidateObject(request, validationContext, validationResults, true))
			{
				string errorMessage = "Error message :" + Environment.NewLine +
									  string.Join(Environment.NewLine, validationResults.Select(vr => $"- {vr.ErrorMessage}"));
				MessageBox.Show(errorMessage, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

			var response = await ObjectService.AddObject(request);

			if (response.Status == Status.Success)
			{
				return response.Data;
			}
			else
			{
				MessageBox.Show(response.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

		}

		public async Task<Dictionary<int, string>> GetCategoryData()
		{
			var response = await CategoryService.GetAllCategory();
			Dictionary<int, string> data = new Dictionary<int, string>();

			if (response.Status == Status.Success)
			{
				var categories = response.Data;

				foreach (Category category in categories)
				{
					int Id = category.Id;
					string Title = category.Title;

					data.Add(Id, Title);
				}

				return data;
			}
			else
			{
				MessageBox.Show(response.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}
	}
}
