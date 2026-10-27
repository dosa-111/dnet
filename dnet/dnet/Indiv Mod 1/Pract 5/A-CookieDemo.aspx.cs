using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookieDemo
{
    public partial class CookieDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // Session Cookie - Browser band hone par delete ho jayega 
            HttpCookie sessionCookie = new HttpCookie("SessionUser");
            sessionCookie.Value = txtName.Text;
            Response.Cookies.Add(sessionCookie);

            // Persistent Cookie - 7 din tak rahega 
            HttpCookie persistentCookie = new HttpCookie("PersistentUser");
            persistentCookie.Value = txtName.Text;
            persistentCookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(persistentCookie);

            lblOutput.Text = "Cookies Saved Successfully";
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            string sessionData = Request.Cookies["SessionUser"].Value;
            string persistentData = Request.Cookies["PersistentUser"].Value;

            lblOutput.Text = "Session Cookie: " + sessionData +
                             "<br/>Persistent Cookie: " + persistentData;
        }
    }
}