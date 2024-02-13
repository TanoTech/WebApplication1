using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
    public class Global : HttpApplication
    {
        protected void Application_PostAcquireRequestState(object sender, EventArgs e)
        {
            var requestedPath = Request.Path.ToLowerInvariant();

            if (!requestedPath.EndsWith("/login.aspx") && Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");



            }
        }
    }
}