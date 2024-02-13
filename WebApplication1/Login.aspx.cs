using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
  
            if (!string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                HttpCookie usernameCookie = new HttpCookie("Username", txtUsername.Text.Trim());
                usernameCookie.Expires = DateTime.Now.AddHours(1); 
                Response.Cookies.Add(usernameCookie);

                Response.Redirect("Welcome.aspx");
            }
            else
            {
                lblError.Text = "Per favore, inserisci una username valida.";

            }
        }
    }
}