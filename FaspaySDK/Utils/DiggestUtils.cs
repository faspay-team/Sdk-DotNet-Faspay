using System;
using System.Security.Cryptography;
using System.Text;

namespace FaspayApi.Utils
{
    public class DiggestUtils
    {
        public DiggestUtils()
        {
        }
        public static String sha1(String plainData)
        {


            // Create SHA1Managed  
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(plainData));

                // Merge all bytes into a string of bytes  
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                Console.WriteLine(builder.ToString());

                // BitConverter can also be used to put all bytes into one string  
                string bitString = BitConverter.ToString(bytes);

                return bitString.Replace("-", "").ToLower();

            }

        }
        public static string md5(string input)
        {
            // step 1, calculate MD5 hash from input

            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }
    }
}
