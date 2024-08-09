namespace barter.Utils
{
	public class ImageCache
	{
		private readonly Dictionary<string, Image> _cache = new Dictionary<string, Image>();
		private readonly HttpClient _httpClient = new HttpClient();

		public async Task<Image> GetImageAsync(string url)
		{
			if (_cache.ContainsKey(url))
			{
				return _cache[url];
			}

			var image = await LoadImageFromUrlAsync(url);
			if (image != null)
			{
				_cache[url] = image;
			}

			return image;
		}

		private async Task<Image> LoadImageFromUrlAsync(string url)
		{
			try
			{
				var response = await _httpClient.GetAsync(url);
				response.EnsureSuccessStatusCode();
				var stream = await response.Content.ReadAsStreamAsync();
				return Image.FromStream(stream);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Erreur lors du chargement de l'image: {ex.Message}");
				return null;
			}
		}
	}
}
