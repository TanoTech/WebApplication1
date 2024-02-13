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

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblError.Text = "Per favore, inserisci un username.";
                return;
            }

            if (txtPassword.Text != txtPassword2.Text)
            {
                lblError.Text = "Le password non coincidono.";
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblError.Text = "Per favore, inserisci una password.";
                return;
            }

            Session["Username"] = txtUsername.Text.Trim();
        


            Response.Redirect("Welcome.aspx");
        }
    }
}