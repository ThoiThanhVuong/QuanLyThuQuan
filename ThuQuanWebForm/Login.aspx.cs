using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThuQuanWebForm.BUS;
using ThuQuanWebForm.Model;

namespace ThuQuanWebForm
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly MemberBUS _memberBUS = new MemberBUS();
        private readonly LoginHistoryBUS _loginHistoryBUS = new LoginHistoryBUS();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Redirect to Profile page if user is already logged in
            if (Session["UserID"] != null)
            {
                Response.Redirect("~/Profile.aspx");
            }

            // Check if there's a remember-me cookie and auto-login
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["UserLogin"];
                if (cookie != null && !string.IsNullOrEmpty(cookie.Values["Username"]))
                {
                    txtUsername.Text = cookie.Values["Username"];
                    chkRemember.Checked = true;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ShowErrorMessage("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");
                return;
            }

            // Authenticate user with database
            MemberModel member = _memberBUS.AuthenticateUser(username, password);

            if (member == null)
            {
                ShowErrorMessage("Sai tên đăng nhập hoặc mật khẩu!");
                return;
            }

            // Store user session data
            Session["UserID"] = member.MemberID;
            Session["Username"] = member.Username;
            Session["FullName"] = member.FullName;
            Session["Email"] = member.Email;
            Session["UserType"] = member.UserType;

            // Record user login in LoginHistory table
            bool loginRecorded = _loginHistoryBUS.RecordLogin(member.MemberID);
            if (!loginRecorded)
            {
                // Just log the failure but continue with login
                System.Diagnostics.Debug.WriteLine($"Failed to record login for user {member.Username}");
            }

            // Set remember me cookie if checked
            if (chkRemember.Checked)
            {
                HttpCookie cookie = new HttpCookie("UserLogin");
                cookie.Values["Username"] = username;
                // Note: We don't store password in cookies for security reasons
                cookie.Expires = DateTime.Now.AddDays(10);
                Response.Cookies.Add(cookie);
            }
            else
            {
                // Remove any existing cookie if not checked
                if (Request.Cookies["UserLogin"] != null)
                {
                    HttpCookie cookie = Request.Cookies["UserLogin"];
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(cookie);
                }
            }

            // Redirect to profile page after successful login
            Response.Redirect("~/Profile.aspx");
        }

        private void ShowErrorMessage(string message)
        {
            // Use a label or literal control to display the error
            if (lblError != null)
            {
                lblError.Text = message;
                lblError.Visible = true;
            }
            else
            {
                // Fallback to a JavaScript alert if the error label doesn't exist
                Page.ClientScript.RegisterStartupScript(this.GetType(), "LoginError",
                    $"alert('{message}');", true);
            }
        }

        protected void lnkForgotPassword_Click(object sender, EventArgs e)
        {
            // Redirect to forgot password page or show a modal
            Response.Redirect("~/ForgotPassword.aspx");
        }
    }
}