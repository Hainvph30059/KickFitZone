using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace APP_Service.Helper
{
	public class PasswordHasher
	{
		public static string HashPassword(string password)
		{
			// Tạo muối ngẫu nhiên
			byte[] salt;
			new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

			// Tạo hàm băm với muối và mật khẩu
			var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
			byte[] hash = pbkdf2.GetBytes(20);

			// Kết hợp muối và hàm băm
			byte[] hashBytes = new byte[36];
			Array.Copy(salt, 0, hashBytes, 0, 16);
			Array.Copy(hash, 0, hashBytes, 16, 20);

			// Chuyển đổi thành chuỗi Base64
			string hashedPassword = Convert.ToBase64String(hashBytes);

			return hashedPassword;
		}

		public static bool VerifyPassword(string enteredPassword, string storedHash)
		{
			byte[] hashBytes = Convert.FromBase64String(storedHash);
			byte[] salt = new byte[16];
			Array.Copy(hashBytes, 0, salt, 0, 16);

			var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 10000);
			byte[] hash = pbkdf2.GetBytes(20);

			for (int i = 0; i < 20; i++)
				if (hashBytes[i + 16] != hash[i])
					return false;

			return true;
		}
	}
}
