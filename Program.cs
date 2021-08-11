using System;
using System.IO;
using System.Text;
using System.Data.SqlClient;
//using Dapper;


namespace NewRepo
{
    class ParseData
    {
        // static void main(string[] args)
        // {
        //     var allTEXT= parsedata.ReferenceEquals
        //     TextReader.parsedata
        //     GetParsedata.tsv
        //     console.writeline(parsedata);
        //
        //    
        //
        // }
    }
    
    
    class Program
    {
        // 1. Read the files from drive
        // 2. Decrypt files data
        // 3. Read/Parse data from .tsv to rows and columns
        // 4. Upload this data to database
        
        static void Main(string[] args)
        {
            // Path to the file in your file system.
            var filePath = @"C/Users/peter/Desktop/materials/products.tsv";
            
            var allText = ReadFile(filePath);
            var decryptedText = DecryptFiles(allText);
            var parsed = 

            // Read file by lines of code using StreamReader.
            var fileStream = File.OpenText(filePath);
            var line = fileStream.ReadLine();
            
            Console.WriteLine(line);
            
            // IMPORTANT! to close the Stream.
            fileStream.Close();
            fileStream.Dispose();
            //decryptfiles
            
            Convert.FromBase64String(allText);

            //Console.WriteLine(File);
            
            
            

            //upload data to the database.
           
            Console.WriteLine(allText);
            
                var cs = @"Server=localhost\SQLEXPRESS;Database=etl;Trusted_Connection=True;";

                using var con = new SqlConnection(cs);
                con.Open()

            // read myClass = new read();
            // myClass.rea("some string");
            // StreamReader reader = new StreamReader(fileName);
            // //streamreader => StreamReader
            // // your code
        }

        public static string ReadFile(string filePath)
        {
            // Read all file data to the memory using File class.
            var allText = File.ReadAllText(filePath);
            Console.WriteLine(allText);

            return allText;
        }
        
        public static string DecryptFiles(string encryptedText)
        {
            //Decrypt files.
            byte[] data = Convert.FromBase64String(encryptedText);
            return Encoding.Unicode.GetString(data);
        }

        public static string parse (string parsefile)
        {

            var allText = ParseData.ReferenceEquals
             TextReader.parsedata
             GetParsedata.tsv
             Console.WriteLine(ParseData);
             return ParseData;


        }

        
 }   }
        
        
        
        
       



             
        
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