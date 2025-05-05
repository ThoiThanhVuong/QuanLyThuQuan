using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThuQuanWebForm
{
    public partial class SiteMaster : MasterPage
    {
        // Property to check if user is logged in
        public bool IsUserLoggedIn
        {
            get { return Session["UserID"] != null; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Update UI based on login status
                UpdateNavigationBasedOnLoginStatus();
            }
        }

        private void UpdateNavigationBasedOnLoginStatus()
        {
            // Navigation links are controlled in the markup with visibility controls
        }

        protected void LogoutLink_Click(object sender, EventArgs e)
        {
            // Clear the session
            Session.Clear();
            Session.Abandon();

            // Redirect to home page
            Response.Redirect("~/Default.aspx");
        }
    }
}