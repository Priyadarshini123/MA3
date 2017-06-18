using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class seat1_availability : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
         

            string r = "red.png";
            string g = "green.jpg";
            int count = 0;
            int num = 1;

            // declare the SqlDataReader, which is used in
            // both the try block and the finally block
            SqlDataReader rdr = null;

            // create a connection object
            SqlConnection conn = new SqlConnection("Data Source = IE3BDT1QK99F2; Initial Catalog = TicketBookingDb; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework");
            // create a command object
            SqlCommand cmd = new SqlCommand(
                "select status from Seat_Availability_Table ", conn);

            holder.Controls.Add(new LiteralControl("&nbsp;&nbsp;&nbsp;"));

            try
            {

                conn.Open();


                holder.Controls.Add(new LiteralControl("SilverSeat:<br>"));

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    
                
                    string status = (string)rdr["Status"];

                    if (num == 1)
                    {
                        holder.Controls.Add(new LiteralControl("&nbsp;&nbsp;&nbsp;&nbsp;"));
                    }

                    if (status == "Available")
                    {

                       
                        holder.Controls.Add(new LiteralControl(num.ToString()));
                        ImageButton imgBtn10 = new ImageButton();
                        imgBtn10.ImageUrl = g;
                        holder.Controls.Add(imgBtn10);
                        count++; num++;
                        holder.Controls.Add(new LiteralControl("&nbsp;&nbsp;"));




                    }
                   else if (status == "Booked")
                    {
                       
                        holder.Controls.Add(new LiteralControl(num.ToString()));
                        ImageButton imgBtn10 = new ImageButton();
                        imgBtn10.ImageUrl = r;
                        holder.Controls.Add(imgBtn10);
                        count++; num++;
                        holder.Controls.Add(new LiteralControl("&nbsp;&nbsp;"));




                    }

                   if(count == 3)
                    {   
                        count = 0;
                        holder.Controls.Add(new LiteralControl("<br>"));
                        holder.Controls.Add(new LiteralControl("&nbsp;"));

                    }
                   if(num == 4 || num == 7)
                    {
                        holder.Controls.Add(new LiteralControl("&nbsp;&nbsp;&nbsp;"));
                    }

                   if(num == 10)
                    {
                        holder.Controls.Add(new LiteralControl("GoldenSeat:<br>"));
                        holder.Controls.Add(new LiteralControl("&nbsp;"));
                    }
                    if (num == 19)
                    {
                        holder.Controls.Add(new LiteralControl("PlatinumSeat:<br>"));
                        holder.Controls.Add(new LiteralControl("&nbsp;"));
                    }


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




         /*   int i;
            for (i = 0; i < 5; i++) // will generate 10 LinkButton
            {

                ImageButton imgBtn10 = new ImageButton();
                imgBtn10.ImageUrl = "green.jpg";
                holder.Controls.Add(imgBtn10);

                holder.Controls.Add(new LiteralControl("&nbsp;&nbsp;"));
            }

            holder.Controls.Add(new LiteralControl("<br>"));


           
            for (i = 0; i < 5; i++) // will generate 10 LinkButton
            {

                ImageButton imgBtn10 = new ImageButton();
  
                imgBtn10.ImageUrl = r;
                holder.Controls.Add(imgBtn10);

                holder.Controls.Add(new LiteralControl("&nbsp;&nbsp;"));
            }*/


        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string seatnum = seatno.Value;
            string connetionString = null;
            SqlConnection cnn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = null;
            string sql1 = null;
            connetionString = "Data Source = IE3BDT1QK99F2; Initial Catalog = TicketBookingDb; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework";

            cnn = new SqlConnection(connetionString);
            sql = "update Seat_Availability_Table set Demand = -1  where SeatId =" + seatnum;
            sql1 = "update Seat_Availability_Table set Status = 'Booked'  where SeatId =" + seatnum;

          

            try
            {
                cnn.Open();
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                adapter.InsertCommand = new SqlCommand(sql1, cnn);
                adapter.InsertCommand.ExecuteNonQuery();

                


                Response.Redirect("feedback.aspx");

            }
            catch (Exception ex)
            {

            }



            Response.Redirect("feedback.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string r = "red.png";
            string g = "green.jpg";
            int count = 0;
            int num = 1;

            // declare the SqlDataReader, which is used in
            // both the try block and the finally block
            SqlDataReader rdr = null;

            // create a connection object
            SqlConnection conn = new SqlConnection("Data Source = IE3BDT1QK99F2; Initial Catalog = TicketBookingDb; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework");
            // create a command object
            SqlCommand cmd = new SqlCommand(
                "select status from Seat_Availability_Table where Seatid <18", conn);
            try
            {

                conn.Open();


                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string status = (string)rdr["Status"];

                    if (status == "Available")
                    {


                        holder.Controls.Add(new LiteralControl(num.ToString()));
                        ImageButton imgBtn10 = new ImageButton();
                        imgBtn10.ImageUrl = g;
                        holder.Controls.Add(imgBtn10);
                        count++; num++;
                        holder.Controls.Add(new LiteralControl("&nbsp;"));




                    }
                    else if (status == "Booked")
                    {

                        holder.Controls.Add(new LiteralControl(num.ToString()));
                        ImageButton imgBtn10 = new ImageButton();
                        imgBtn10.ImageUrl = r;
                        holder.Controls.Add(imgBtn10);
                        count++; num++;
                        holder.Controls.Add(new LiteralControl("&nbsp;"));




                    }

                    if (count == 3)
                    {
                        count = 0;
                        holder.Controls.Add(new LiteralControl("<br>"));

                    }


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

        protected void Button3_Click(object sender, EventArgs e)
        {

            int flag = 0;
            
            string Seat_Num = seatno.Value;

            // declare the SqlDataReader, which is used in
            // both the try block and the finally block
            SqlDataReader rdr = null;

            // create a connection object
            SqlConnection conn = new SqlConnection("Data Source = IE3BDT1QK99F2; Initial Catalog = TicketBookingDb; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework");
            // create a command object
            SqlCommand cmd = new SqlCommand(
                "select * from Seat_Availability_Table where SeatId =" + Seat_Num, conn);
       

            try
            {

                conn.Open();


                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string status = (string)rdr["Status"];
                    int demand = (int)rdr["Demand"];

                    if (status == "Booked")
                    {
                        Response.Write(@"<script language='javascript'>alert('Oops!!!!!!Already Someone booked this seat.... \n');</script>");
                    }
                    if (demand > 0 )
                    {
                        flag = 1;
                        Response.Write(@"<script language='javascript'>alert('Demand of this seat is high.... \n\nYou need to pay Extra money...\n');</script>");

                    }

                    if (status == "Available")
                    {
                        flag = 1;
                        
                    }
                }

                   

             
                if (flag == 1)
                {
                    string seatnum = seatno.Value;
                    string connetionString = null;
                    SqlConnection cnn;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string sql = null;
                    connetionString = "Data Source = IE3BDT1QK99F2; Initial Catalog = TicketBookingDb; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework";

                    cnn = new SqlConnection(connetionString);
                    sql = "update Seat_Availability_Table set Demand = Demand+1 where SeatId =" + seatnum;

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


           










            /*    string seatnum = seatno.Value;
                string connetionString = null;
                SqlConnection conn;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = null;
                connetionString = "Data Source = IE3BDT1QK99F2; Initial Catalog = TicketBookingDb; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework";

                conn = new SqlConnection(connetionString);

                SqlDataReader rdr = null;
                SqlCommand cmd = new SqlCommand(
                    "select * from Seat_Availability_Table where Seatid="+seatno, conn);
                try
                {
                    conn.Open();
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        string status = (string)rdr["Status"];
                        int demand = (int)rdr["Demand"];

                        if (status == "Booked")
                        {
                            Response.Write(@"<script language='javascript'>alert('Oops!!!!!!Already Someone booked this seat.... \n');</script>");
                        }
                        else if (demand > 0)
                        {
                            Response.Write(@"<script language='javascript'>alert('Demand of this seat is high.... \n\n' You need to pay Extra money...\n);</script>");
                        }

                    }
                }
                catch (Exception ex)
                {

                }





                     sql = "update Seat_Availability_Table set Demand = Demand+1 where SeatId =" + seatnum + "and Status = 'Available' ";

               try
               {
                   cnn.Open();
                   adapter.InsertCommand = new SqlCommand(sql, cnn);
                   adapter.InsertCommand.ExecuteNonQuery();

               }*/






        }
    }
}