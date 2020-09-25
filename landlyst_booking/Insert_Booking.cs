using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace landlyst_booking
{
    class Insert_Booking
    {
        public static void InsertDataString(string insertString)
        {

                //opratter forbinese til databasen
                SqlConnection conn = new SqlConnection("Data source = (local); initial Catalog=AutoLot; integrated Security=SSPI");
                //
                conn.Open();

                // 1. Instantiate a new command with a query and conn. 
                SqlCommand cmd = new SqlCommand(insertString, conn);
                // 2. Call ExecuteNonQuery to send command 
                cmd.ExecuteNonQuery();
                conn.Close();



        }
    }
}
