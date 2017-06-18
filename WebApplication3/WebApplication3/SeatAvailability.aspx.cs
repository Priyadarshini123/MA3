using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication3
{
    public partial class SeatAvailability : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int seatnum = 0;

            string connetionString = null;
            SqlConnection cnn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = null;
            connetionString = "Data Source = IE3BDT1QK99F2; Initial Catalog = TicketBookingDb; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework";

            cnn = new SqlConnection(connetionString);
            sql = "insert into Seat_Availability_Table values(11,'Available',0)";

            try
            {
                cnn.Open();
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
               
            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string Seat_Num = seatno.Value;

            // declare the SqlDataReader, which is used in
            // both the try block and the finally block
            SqlDataReader rdr = null;

            // create a connection object
            SqlConnection conn = new SqlConnection("Data Source = IE3BDT1QK99F2; Initial Catalog = TicketBookingDb; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework");
            // create a command object
            SqlCommand cmd = new SqlCommand(
                "select * from Seat_Availability_Table where SeatId ="+Seat_Num, conn);
            try
            {
               
                conn.Open();

          
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {        
                    string status = (string)rdr["Status"];
                    int demand = (int)rdr["Demand"];
                    Console.Write(status);
                    Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" + demand + " .');</script>");
                }
            }
            finally
            {
                // 3. close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        










    }
    }
}