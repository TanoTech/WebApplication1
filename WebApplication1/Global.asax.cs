using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            var requestedPath = HttpContext.Current.Request.Path.ToLowerInvariant();

            if (!requestedPath.EndsWith("login.aspx"))
            {
                HttpCookie usernameCookie = HttpContext.Current.Request.Cookies["Username"];

                if (usernameCookie == null)
                {
                    HttpContext.Current.Response.Redirect("Login.aspx");
                }
            }
            else if (requestedPath.EndsWith("login.aspx") && HttpContext.Current.Request.Cookies["Username"] != null)
            {
                HttpContext.Current.Response.Redirect("Welcome.aspx");
            }
        }
    }
}