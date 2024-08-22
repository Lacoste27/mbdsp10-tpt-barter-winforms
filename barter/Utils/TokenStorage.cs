using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;

namespace barter.Utils
{
	public class TokenStorage
	{
		private static readonly byte[] entropy = Encoding.UTF8.GetBytes("fqlglq9_Flqlfkqlaortaùbn9slfl_");

		public static void SaveToken(string token)
		{
			using (var rng = new RNGCryptoServiceProvider())
			{
				byte[] tokenData = Encoding.UTF8.GetBytes(token);
				byte[] encryptedData = ProtectedData.Protect(tokenData, entropy, DataProtectionScope.CurrentUser);
				string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				string filePath = Path.Combine(appDataPath, "Barter", "token.dat");

				Directory.CreateDirectory(Path.GetDirectoryName(filePath));
				File.WriteAllBytes(filePath, encryptedData);
			}
		}

		public static string LoadToken()
		{
			string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string filePath = Path.Combine(appDataPath, "Barter", "token.dat");

			if (!File.Exists(filePath))
				return null;

			byte[] encryptedData = File.ReadAllBytes(filePath);
			byte[] tokenData = ProtectedData.Unprotect(encryptedData, entropy, DataProtectionScope.CurrentUser);
			return Encoding.UTF8.GetString(tokenData);
		}

		public static void DeleteToken()
		{
			string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string filePath = Path.Combine(appDataPath, "Barter", "token.dat");

			if (File.Exists(filePath))
				File.Delete(filePath);
		}

		public static bool IsTokenExpired()
		{
			var jwtHandler = new JwtSecurityTokenHandler();
			string token = LoadToken();

			if (!jwtHandler.CanReadToken(token))
				return true;

			var jwtToken = jwtHandler.ReadJwtToken(token);

			var expClaim = jwtToken.Claims.FirstOrDefault(claim => claim.Type == JwtRegisteredClaimNames.Exp);
			if (expClaim == null)
				return true;

			var expDateTime = DateTimeOffset.FromUnixTimeSeconds(long.Parse(expClaim.Value));

			return expDateTime < DateTimeOffset.UtcNow;
		}

		public static int GetUserId()
		{
			string token = LoadToken();
			var jwtHandler = new JwtSecurityTokenHandler();

			if (!jwtHandler.CanReadToken(token))
				return 0;

			var jwtToken = jwtHandler.ReadJwtToken(token);

			int.TryParse(jwtToken.Claims.FirstOrDefault(claim => claim.Type == "userId").Value, out int userId);

			return userId;
		}

		public static string GetUserUsername()
		{
			string token = LoadToken();
			var jwtHandler = new JwtSecurityTokenHandler();

			if (!jwtHandler.CanReadToken(token))
				return string.Empty;

			var jwtToken = jwtHandler.ReadJwtToken(token);

			return jwtToken.Claims.FirstOrDefault(claim => claim.Type == "username")?.Value ?? "";
		}

		public static string GetUserEmail()
		{
			string token = LoadToken();
			var jwtHandler = new JwtSecurityTokenHandler();

			if (!jwtHandler.CanReadToken(token))
				return string.Empty;

			var jwtToken = jwtHandler.ReadJwtToken(token);

			return jwtToken.Claims.FirstOrDefault(claim => claim.Type == "email")?.Value ?? "";
		}
	}
}
