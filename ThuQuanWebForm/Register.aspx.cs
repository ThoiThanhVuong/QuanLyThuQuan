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
    public partial class Register : System.Web.UI.Page
    {
        private MemberBUS memberBUS;

        protected void Page_Load(object sender, EventArgs e)
        {
            // If user is already logged in, redirect to profile page
            if (Session["UserID"] != null)
            {
                Response.Redirect("~/Profile.aspx");
            }

            memberBUS = new MemberBUS();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                return;
            }

            // Get form values
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string studentId = txtStudentId.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phoneNumber = txtPhone.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Full name combining first and last name
            string fullName = $"{firstName} {lastName}";

            // Validate input
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                ShowErrorMessage("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            if (password != confirmPassword)
            {
                ShowErrorMessage("Mật khẩu và xác nhận mật khẩu không khớp.");
                return;
            }

            // Check if username, email or phone already exists
            if (memberBUS.GetMemberByEmailOrPhone(email) != null)
            {
                ShowErrorMessage("Email đã được sử dụng.");
                return;
            }

            // Check if phone number already exists
            if (memberBUS.GetMemberByEmailOrPhone(phoneNumber) != null)
            {
                ShowErrorMessage("Số điện thoại đã được sử dụng.");
                return;
            }

            try
            {
                // Create new member
                MemberModel newMember = new MemberModel
                {
                    FullName = fullName,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    Username = studentId, // Using student ID as username
                    Password = password,
                    RegistrationDate = DateTime.Now,
                    UserType = UserType.User, // Default user type for new registrations
                    MemberStatus = ActivityStatus.Active
                };

                // Register the user
                bool registrationSuccess = memberBUS.AddMember(newMember);

                if (registrationSuccess)
                {
                    // Get the registered user for session
                    MemberModel registeredUser = memberBUS.Login(studentId, password);

                    if (registeredUser != null)
                    {
                        // Set session variables
                        Session["UserID"] = registeredUser.MemberID;
                        Session["Username"] = registeredUser.Username;
                        Session["FullName"] = registeredUser.FullName;
                        Session["Email"] = registeredUser.Email;
                        Session["PhoneNumber"] = registeredUser.PhoneNumber;
                        Session["UserType"] = registeredUser.UserType.ToString();

                        // Redirect to profile page after successful registration
                        Response.Redirect("~/Profile.aspx");
                    }
                    else
                    {
                        ShowErrorMessage("Đã đăng ký thành công nhưng không thể đăng nhập tự động. Vui lòng đăng nhập thủ công.");
                        Response.Redirect("~/Login.aspx");
                    }
                }
                else
                {
                    ShowErrorMessage("Đăng ký thất bại. Vui lòng thử lại sau.");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Đã xảy ra lỗi trong quá trình đăng ký: {ex.Message}");
            }
        }

        private void ShowErrorMessage(string message)
        {
            // Show error message
            Page.ClientScript.RegisterStartupScript(this.GetType(), "RegisterError",
                "alert('" + message + "');", true);
        }
    }
}