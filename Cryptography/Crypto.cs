using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; //Kriptofrafijai skirta klase

namespace Cryptography
{
    class Crypto //Kriptografinems funkcijoms skirta klase
    {
        public static string MD5EncodeString(string data)
        {
            //Koduojame baitus. Reikia konvertuoti teksta
            byte[] bytes = Encoding.ASCII.GetBytes(data);

            var md5Provider = new MD5CryptoServiceProvider(); //Crypto servisas

            byte[] encodedResult = md5Provider.ComputeHash(bytes);

            StringBuilder builder = new StringBuilder();
            foreach (var item in encodedResult)
            {
                builder.Append(item.ToString("X2")); // suformatuos i 16aine sistema
            }
            return builder.ToString();
        }

        public static string MD5EncodeFile(byte[] inputBytes)
        {
            var md5Provider = new MD5CryptoServiceProvider(); //Crypto servisas

            byte[] encodedResult = md5Provider.ComputeHash(inputBytes);

            StringBuilder builder = new StringBuilder();
            foreach (var item in encodedResult)
            {
                builder.Append(item.ToString("X2")); // suformatuos i 16aine sistema
            }
            return builder.ToString();
        }

        public static string TDESEncodeString(string data, string password)
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(data);

            var tdesProvider = new TripleDESCryptoServiceProvider();

            //TDES algoritmo parametrai
            byte[] salt = { 12, 54, 75, 12, 222, 65, 78, 99 };

            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, salt, 100);

            tdesProvider.Key = rfc.GetBytes(16); //max 16
            tdesProvider.IV = rfc.GetBytes(8);
            tdesProvider.Mode = CipherMode.CBC;
            tdesProvider.Padding = PaddingMode.PKCS7;

            //Kodavimas
            ICryptoTransform transform = tdesProvider.CreateEncryptor();

            //Uzkoduojam visa teksta
            byte[] outputBytes = transform.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

            return Convert.ToBase64String(outputBytes);
        }

        public static string TDESDecodeString(string inputText, string password)
        {
            byte[] inputBytes = Convert.FromBase64String(inputText);

            var tdesProvider = new TripleDESCryptoServiceProvider();

            //TDES algoritmo parametrai
            byte[] salt = { 12, 54, 75, 12, 222, 65, 78, 44 };

            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, salt, 100);

            tdesProvider.Key = rfc.GetBytes(16); //max 16
            tdesProvider.IV = rfc.GetBytes(8);
            tdesProvider.Mode = CipherMode.CBC;
            tdesProvider.Padding = PaddingMode.PKCS7;

            //atkoduojam
            ICryptoTransform transform = tdesProvider.CreateDecryptor();

            byte[] outputBytes = transform.TransformFinalBlock(inputBytes, 0, inputBytes.Length); //atkoduoti duomenys

            return Encoding.ASCII.GetString(outputBytes);

        }
    }
}
