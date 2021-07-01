using System;
using System.io;
using system.text;


static void Main(string[] args);


namespace NewRepo
{
   class read
    {
        public static string read(string files, string)
        {
            using (streamreader sr = files.openText(@"C:\Users\HP\Desktop\materials\products.tsv"))
            {
                string S;
                while ((s = sr.ReadLine()) != null)

                {   
                    Console.WriteLine(S);

                }

            }
        }
    }

    
        
}
        
    



       // static void Main(string[] args)
        //{
            //var cs = @"Server=localhost\SQLEXPRESS;Database=etl;Trusted_Connection=True;";

            //using var con = new SqlConnection(cs);
            //con.Open();
       // }
       // {
           // Console.WriteLine("Hello World!");
       // }
   //}
//}
