using System;
using System.Data.SqlClient;

namespace landlyst_booking
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDataReader rdr = null;

            Console.WriteLine("welcome her is a list or items");
            Console.WriteLine();
            Console.WriteLine("Read Data");
            Read_Booking.Read_Data(rdr);

            //warealbulles for the inset sql statment
            Console.WriteLine("inter last id + 1");
            string Tabel_id = Console.ReadLine();

            Console.WriteLine("inter you frest name");
            string Frist_name = Console.ReadLine();

            Console.WriteLine("inter you last name");
            string Last_name = Console.ReadLine();

 
            //this is sql-------------------------- 
            // prepare command string to insert data into the database
            string insertString = @"INSERT into Customers(CastID, FirstName, LastName)
                               values ("+ Tabel_id + ", '"+ Frist_name + "', '"+ Last_name + "')";
            Console.WriteLine(insertString);
            Insert_Booking.InsertDataString(insertString);
        }
    }
}