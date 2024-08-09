using barter.Models;
using barter.Requests;
using barter.Services.Categories;
using barter.Services.Objects;
using System.ComponentModel.DataAnnotations;

namespace barter.ModelsView
{
	public class DetailsObjectModelView
	{
		private IObjectService ObjectService { get; set; }
		private ICategoryService CategoryService { get; set; }


		public DetailsObjectModelView()
		{
			ObjectService = Service.GetService<IObjectService>();
			CategoryService = Service.GetService<ICategoryService>();
		}

		public async Task<Models.Object> UpdateObject(UpdateObjectRequest request, int objectId)
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

			var response = await ObjectService.UpdateObject(request, objectId);

			if (response.Status == Responses.Status.Success)
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

			if (response.Status == Responses.Status.Success)
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
