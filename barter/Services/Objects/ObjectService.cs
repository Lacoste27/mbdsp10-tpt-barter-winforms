﻿using barter.Requests;
using barter.Responses;
using barter.Services.Api;
using System.Net.Http.Headers;
using System.Net.Http.Json;


namespace barter.Services.Objects
{
	public class ObjectService : IObjectService
	{
		private IApiService ApiService { get; set; }
		private string endpoint = "api/objects";

		public ObjectService()
		{
			ApiService = Service.GetService<IApiService>();
		}

		public async Task<Response<List<Models.Object>>> GetAllObjects()
		{
			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(endpoint);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<List<Models.Object>>();
					return new Response<List<Models.Object>>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<List<Models.Object>>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<List<Models.Object>>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<ListResponse<Models.Object>>> GetUserObjects(int userId, int page = 1, int limit = 10)
		{
			// string path = string.Format("{0}/owner/{1}", endpoint, userId);
			string path = $"{endpoint}/owner/{userId}?page={page}&limit={limit}";

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(path);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<ListResponse<Models.Object>>();
					return new Response<ListResponse<Models.Object>>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<ListResponse<Models.Object>>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<ListResponse<Models.Object>>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Models.Object>> GetObjectByid(int Id)
		{
			string path = string.Format("{0}/{1}", endpoint, Id);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().GetAsync(path);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Models.Object>();
					return new Response<Models.Object>(Status.Success, data);
				}
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Models.Object>(Status.Error, null, errorMessage);
				}

			}
			catch (Exception Exception)
			{
				return new Response<Models.Object>(Status.Error, null, Exception.Message);
			}
		}

		public async Task<Response<Models.Object>> AddObject(ObjectRequest request)
		{
			try
			{
				using var form = new MultipartFormDataContent();

				foreach (string image in request.Image)
				{
					var fileContent = new ByteArrayContent(await File.ReadAllBytesAsync(image));
					fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");

					form.Add(fileContent, "files", Path.GetFileName(image));
				}

				form.Add(new StringContent(request.Name), "name");
				form.Add(new StringContent(request.CategoryId.ToString()), "categoryId");
				form.Add(new StringContent(request.Description), "description");
				form.Add(new StringContent(request.OwnerId.ToString()), "ownerId");

				HttpResponseMessage response = await this.ApiService.GetClient().PostAsync(
				endpoint, form);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Models.Object>();
					return new Response<Models.Object>(Status.Success, data);
				}
				/*else if (response.StatusCode == HttpStatusCode.BadRequest)
				{
					var errorContent = await response.Content.ReadAsStringAsync();
					var badRequestResponse = JsonConvert.DeserializeObject<BadRequest>(errorContent);
					var errorMessage = string.Join(";\n ", badRequestResponse.Errors.Select(e => e.Msg));
					return new Response<Models.Object>(Status.Error, null, errorMessage);
				}*/
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Models.Object>(Status.Error, null, errorMessage);
				}
			}
			catch (Exception Exception)
			{
				return new Response<Models.Object>(Status.Error, null, Exception.Message, Exception);
			}
		}

		public async Task<Response<Models.Object>> UpdateObject(UpdateObjectRequest request, int objectId)
		{
			string path = string.Format("{0}/{1}", endpoint, objectId);

			try
			{
				HttpResponseMessage response = await this.ApiService.GetClient().PutAsJsonAsync(path, request);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadFromJsonAsync<Models.Object>();
					return new Response<Models.Object>(Status.Success, data);
				}
				/*else if (response.StatusCode == HttpStatusCode.BadRequest)
				{
					var errorContent = await response.Content.ReadAsStringAsync();
					var badRequestResponse = JsonConvert.DeserializeObject<BadRequest>(errorContent);
					var errorMessage = string.Join(";\n ", badRequestResponse.Errors.Select(e => e.Msg));
					return new Response<Models.Object>(Status.Error, null, errorMessage);
				}*/
				else
				{
					var errorMessage = await response.Content.ReadAsStringAsync();
					return new Response<Models.Object>(Status.Error, null, errorMessage);
				}
			}
			catch (Exception Exception)
			{
				return new Response<Models.Object>(Status.Error, null, Exception.Message, Exception);
			}
		}
	}
}
