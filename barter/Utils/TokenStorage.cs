using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace barter.Utils
{
	public class TokenStorage
	{
		private static byte[]? entropy;

		public static void SaveToken(string token)
		{
			using (var rng = new RNGCryptoServiceProvider())
			{
				byte[] entropyBytes = new byte[32];
				rng.GetBytes(entropyBytes);

				entropy = entropyBytes;

				byte[] tokenData = Encoding.UTF8.GetBytes(token);
				byte[] encryptedData = ProtectedData.Protect(tokenData, entropyBytes, DataProtectionScope.CurrentUser);
				File.WriteAllBytes("token.dat", encryptedData);
			}
		}

		public static string LoadToken()
		{
			if (!File.Exists("token.dat"))
				return null;

			byte[] encryptedData = File.ReadAllBytes("token.dat");
			byte[] tokenData = ProtectedData.Unprotect(encryptedData, entropy, DataProtectionScope.CurrentUser);
			return Encoding.UTF8.GetString(tokenData);
		}
		public static void DeleteToken()
		{
			if (File.Exists("token.dat"))
				File.Delete("token.dat");
		}
	}
}
