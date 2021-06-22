using System;

namespace NewRepo
{
    class Program
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
