using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(@"<script language='javascript'>alert('Successful \n');</script>");
        }

        protected void doSubmit(object sender, EventArgs e)
        {
            Response.Redirect("login1.aspx");
        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            Response.Redirect("feedback.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("login1.aspx");
        }
    }
}