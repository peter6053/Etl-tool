using System;
using System.Security.Cryptography;

namespace NewRepo
{
    class decrypt

        class decrypt
    {
        public static string EncryptString(string files, string plainText)
        {

            {
                string path = @"C:\Users\HP\Desktop\materials\products.tsv;

                 Console.WriteLine("Please enter a  path encryption");  
                var str = Console.ReadLine();
                var encryptedString = AesOperation.EncryptString(key, str);
                Console.WriteLine($"encrypted string = {encryptedString}");

                var decryptedString = AesOperation.DecryptString(key, encryptedString);
                Console.WriteLine($"decrypted string = {decryptedString}"); 
                
                Console.ReadKey();

            }
        }
    {
        static void Main(string[] args)
        {
            var cs = @"Server=localhost\SQLEXPRESS;Database=etl;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();
        }
        {
            Console.WriteLine("Hello World!");
        }
    }
}
