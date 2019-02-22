using System;
using System.Security.Cryptography;
using System.Text;

namespace BestellErfassung.FileHelpers
{
    class CryptionHelpers
    {
        /// <summary>the crypto key for the DES encryption and decryption routines</summary>
        /// <example>private const string cryptoKey = "cryptoKey";</example>
        private const string cryptoKey = "4D453AE9-AE5F-4f61-B6D6-88C1BA2F7DE0-43B5674C-C118-42d7-8925-E74F91AF45CE-020DE267-930F-4f12-8F5F-A06B0F96CFD5";

        /// <summary>the initialization vector for the DES encryption and decryption routines</summary>
        private static readonly byte[] initialVector = new byte[8] { 240, 3, 45, 29, 0, 76, 173, 59 };

        /// <summary>encrypt a string</summary>
        /// <param name="originalString">the original string</param>
        /// <returns>the encrypted string</returns>
        internal static string Encrypt(string originalString)
        {
            string result = string.Empty;
            if (originalString == null || originalString.Length == 0) return result;

            byte[] buffer = Encoding.ASCII.GetBytes(originalString);
            using (TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider())
                {
                    des.Key = MD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(cryptoKey));
                }
                des.IV = initialVector;
                result = Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length));
                return result;
            }
        }

        /// <summary>decrypt an encrypted string</summary>
        /// <param name="cryptedString">The encrypted string.</param>
        /// <returns>the decrypted string.</returns>
        internal static string Decrypt(string cryptedString)
        {
            string result = string.Empty;
            if (cryptedString == null || cryptedString.Length == 0) return result;

            byte[] buffer = Convert.FromBase64String(cryptedString);
            using (TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider())
                {
                    des.Key = MD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(cryptoKey));
                }
                des.IV = initialVector;
                result = Encoding.ASCII.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length));
                return result;
            }
        }
    }
}
