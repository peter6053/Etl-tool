using System;
using System.io;


namespace NewRepo
{
    class read

        
    {
        public static string read (string files,)
        {
            using (StreamReader sr = File.OpenText(@"C:\Users\HP\Desktop\materials\products.tsv))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }

               

            }
        }
    
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
