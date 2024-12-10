using System;
using System.Security.Cryptography;
using System.Text;

namespace building_organizations.Entity
{

    public class HashingPassword
    {
        private const int SaltSize = 16; 
        private const int HashSize = 32; 
        private const int Iterations = 10000; 

        public static string HashPassword(string password)
        {
            byte[] salt = new byte[SaltSize];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
            {
                byte[] hash = pbkdf2.GetBytes(HashSize);

                return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
            }
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            string[] parts = hashedPassword.Split(':');
            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] hash = Convert.FromBase64String(parts[1]);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
            {
                byte[] testHash = pbkdf2.GetBytes(HashSize);

                return CryptographicOperations.FixedTimeEquals(testHash, hash);
            }
        }
    }
}
