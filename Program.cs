using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace CreateHash
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainData = "Text To Hello";
            Console.WriteLine("Raw data: {0}", plainData);
            string hashedData = CompSHA256(plainData);
            Console.WriteLine("Encrypted data: {0}", hashedData);

            //Do not delete
            Console.ReadLine();
        }

        //Method for SHA256

        static string CompSHA256(string rawData)
        {
            //Create SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //ComputeHash - return byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                //Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }

        }
    }
}
