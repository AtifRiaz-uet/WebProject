using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTables_Assignment
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("WebForm1.aspx");
            }
            

        }
        protected void SignIn_Click(object sender, EventArgs e)
        {
            Session["user"] = "admin";
            Response.Redirect("WebForm1.aspx");
        }
    }
}