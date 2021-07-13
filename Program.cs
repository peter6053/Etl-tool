using System;
using System.IO;
using System.Text;


namespace NewRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the file in your file system.
            var filePath = "C:\Users\HP\Desktop\materials";
            
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


             {
                 public static void RemoveEncryption(string Filepath)
                 var filePath = "C:\Users\HP\Desktop\materials";
                 File.Decrypt( string  filepath);
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