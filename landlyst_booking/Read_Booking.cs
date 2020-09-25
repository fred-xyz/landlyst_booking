using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace landlyst_booking
{
    class Read_Booking
    {

        public static SqlDataReader Read_Data(SqlDataReader rdr)
        {
            try
            {
                //opratter forbinese til databasen
                SqlConnection conn = new SqlConnection("Data source = (local); initial Catalog=AutoLot; integrated Security=SSPI");
                //
                conn.Open();

                //sql statment
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", conn);

                //ineseellise rdr as a sqldatareader datatype
                rdr = null;

                //puts the cmd value in to rdr so we can run it later
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " " + rdr["FirstName"] + "\t" + rdr[2]);
                }

                /*SqlConnection conn = new SqlConnection("Data source = DatabaseServerIP; Initial Catalog = databaseName; User ID = YourUserID; Password = yourPassword");*/
                conn.Close();
                return rdr;
            }
            catch (Exception)
            {

                throw;
            }

        }

    }

}
