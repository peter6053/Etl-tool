using System.IO;
using System.Text;


namespace NewRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            read myClass = new read();
            myClass.rea("some string");
            StreamReader reader = new StreamReader(fileName);
            //streamreader => StreamReader
            // your code
}
}
   class read
    {
        public static string rea(string files)
        {
            
            using (streamreader sr = files.openText(@"C:\Users\HP\Desktop\materials\products.tsv"))
            {
                string s;
                while ((s = sr.ReadLine()) != null)

                {   
                    Console.WriteLine(s);

                }
                sr.Close();

            }
        }
      
    
        
        }
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
