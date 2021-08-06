using System;
using System.IO;
using System.Text;
using System.Data.SqlClient;
using Dapper;


namespace NewRepo
{
    class Program
    {
        // 1. Read the files from drive
        // 2. Decrypt files data
        // 3. Read/Parse data from .tsv to rows and columns
        // 4. Upload this data to database
        
        static void Main(string[] args)
        {
            // Path to the file in your file system.
            var filePath = @"C:\Users\peter\Desktop\materials\products.tsv";
            
            // Read all file data to the memory using File class.
            var allText = File.ReadAllText(filePath);
            Console.WriteLine(allText);

            // Read file by lines of code using StreamReader.
            var fileStream = File.OpenText(filePath);
            var line = fileStream.ReadLine();
            
            Console.WriteLine(line);
            
            // IMPORTANT! to close the Stream.
            fileStream.Close();
            fileStream.Dispose();
            //decryptfiles
            public static string void decryptfiles(string filepath, sting key)
                {
                    byte[] encrypted = File.ReadAllBytes(filepath);
                    var decryptor = aes.CreateDecryptor

               }
            Convert.FromBase64String(allText);

            Console.WriteLine(File)
            class parsedata
                static void main(string[] args)
                {
                    TextReader.parsedata
                    GetParsedata.tsv
                    console.writeline();

           

                }
            
            byte[] data = Convert.FromBase64String(allText);

            Console.WriteLine(allText);

            string decodedString = Encoding.UTF8.GetString(data);

            //upload data to the database.
           
            Console.WriteLine(allText);
            {
                var cs = @"Server=localhost\SQLEXPRESS;Database=etl;Trusted_Connection=True;";

                using var con = new SqlConnection(cs);
                con.Open();
             }


            






            // read myClass = new read();
            // myClass.rea("some string");
            // StreamReader reader = new StreamReader(fileName);
            // //streamreader => StreamReader
            // // your code
        }
    }

    // class read
    // {
    //     public static string rea(string files)
    //     {
    //         using (streamreader sr = files.openText(@"C:\Users\HP\Desktop\materials\products.tsv"))
    //         {
    //             string s;
    //             while ((s = sr.ReadLine()) != null)
    //
    //             {
    //                 Console.WriteLine(s);
    //             }
    //
    //             sr.Close();
    //         }
    //     }
    // }
}


// static void Main(string[] args)
//static void main (string[] args)
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