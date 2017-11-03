using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JTASystem.Common
{
    static class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int HashSize = 20;


        public static bool IsCorrect(string enteredPassword, string hashedPassword)
        {
            //extract bytes
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);

            //get the salt
            byte[] salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            //compute the hash on the password the user entered
            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            //compare the results
            for (int i = 0; i < HashSize; i++)
                if (hashBytes[i + SaltSize] != hash[i])
                    return false;
            return true;

        }

        public static string Hash(string password)
        {
            //create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            //combine salt and hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            return Convert.ToBase64String(hashBytes);

        }
    }
}
