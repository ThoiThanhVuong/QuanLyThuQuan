using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ThuQuanWebForm.AppConfig;
using MySql.Data.MySqlClient; // Add MySql.Data namespace

namespace ThuQuanWebForm
{
    public partial class Profile : System.Web.UI.Page
    {
        private ConnectDB db = new ConnectDB(); // Class-level instance

        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if user is logged in, redirect to login page if not
            if (Session["UserID"] == null)
            {
                Response.Redirect("~/Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                // Load user data
                LoadUserData();

                // Load borrowed devices
                LoadCurrentBorrowed();

                // Load borrowed books
                LoadCurrentBorrowedBooks();

                // Load reservations
                LoadReservations();

                // Load book reservations
                LoadBookReservations();

                // Load borrow history
                LoadBorrowHistory();

                // Load violations
                LoadViolations();

                // Fill settings form
                FillSettingsForm();
            }
        }

        private void LoadUserData()
        {
            int memberId = Convert.ToInt32(Session["UserID"]);
            DataTable dtUser = new DataTable();

            try
            {
                string query = @"SELECT 
                                FullName, 
                                UserName, 
                                Email, 
                                PhoneNumber, 
                                Status, 
                                RegistrationDate,
                                UserType,
                                (SELECT COUNT(*) FROM TransactionItems ti 
                                 JOIN Transactions t ON t.TransactionID = ti.TransactionID 
                                 WHERE t.MemberID = @MemberId) as BorrowedCount
                            FROM Member 
                            WHERE MemberID = @MemberId";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@MemberId", memberId }
                };

                dtUser = this.db.ExecuteSelectQuery(query, parameters); // Use class-level db

                if (dtUser.Rows.Count > 0)
                {
                    DataRow row = dtUser.Rows[0];
                    // ... (rest of the data extraction and assignment) ...
                    string fullName = row["FullName"].ToString();
                    string username = row["UserName"].ToString();
                    string email = row["Email"].ToString();
                    string phone = row["PhoneNumber"].ToString();
                    string status = row["Status"].ToString();
                    string userType = row["UserType"].ToString();
                    DateTime regDate = Convert.ToDateTime(row["RegistrationDate"]);
                    int borrowCount = Convert.ToInt32(row["BorrowedCount"]);

                    // Set main profile info
                    litFullName.Text = fullName;
                    litStudentId.Text = username;
                    litEmail.Text = email;
                    litPhone.Text = phone;
                    litStatus.Text = status;

                    // Set detailed profile info
                    litFullNameDetail.Text = fullName;
                    litStudentIdDetail.Text = username;
                    litEmailDetail.Text = email;
                    litPhoneDetail.Text = phone;
                    litFaculty.Text = userType; // Display UserType instead of static Faculty
                    litRegistrationDate.Text = regDate.ToString("dd/MM/yyyy");
                    litBorrowedCount.Text = borrowCount.ToString();
                }
            }
            catch (Exception ex)
            {
                // Log the error (in a real app)
                Response.Write("Error loading user data: " + ex.Message);
            }
        }

        private void LoadCurrentBorrowed()
        {
            int memberId = Convert.ToInt32(Session["UserID"]);
            DataTable dtBorrowed = new DataTable();

            try
            {
                string query = @"SELECT 
                                d.DeviceID,
                                d.DeviceName,
                                t.TransactionDate as BorrowDate,
                                t.DueDate,
                                CASE 
                                    WHEN t.DueDate < NOW() AND t.Status = 'Active' THEN 'Sắp hết hạn'
                                    WHEN t.Status = 'Active' THEN 'Đang mượn'
                                    WHEN t.Status = 'Overdue' THEN 'Trễ hạn'
                                    ELSE 'Đã trả'
                                END as Status
                            FROM TransactionItems ti
                            JOIN Devices d ON d.DeviceID = ti.DeviceID
                            JOIN Transactions t ON t.TransactionID = ti.TransactionID
                            WHERE t.MemberID = @MemberId
                            AND t.Status IN ('Active', 'Overdue')
                            AND ti.Status = 'Borrowed'";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@MemberId", memberId }
                };

                dtBorrowed = this.db.ExecuteSelectQuery(query, parameters); // Use class-level db

                gvCurrentBorrowed.DataSource = dtBorrowed;
                gvCurrentBorrowed.DataBind();
            }
            catch (Exception ex)
            {
                // Log the error (in a real app)
                Response.Write("Error loading borrowed items: " + ex.Message);
            }
        }

        private void LoadCurrentBorrowedBooks()
        {
            int memberId = Convert.ToInt32(Session["UserID"]);
            DataTable dtBorrowedBooks = new DataTable();

            try
            {
                string query = @"SELECT 
                                b.BookID,
                                b.BookTitle,
                                t.TransactionDate as BorrowDate,
                                t.DueDate,
                                CASE 
                                    WHEN t.DueDate < NOW() AND t.Status = 'Active' THEN 'Sắp hết hạn'
                                    WHEN t.Status = 'Active' THEN 'Đang mượn'
                                    WHEN t.Status = 'Overdue' THEN 'Trễ hạn'
                                    ELSE 'Đã trả'
                                END as Status
                            FROM TransactionItems ti
                            JOIN Books b ON b.BookID = ti.BookID
                            JOIN Transactions t ON t.TransactionID = ti.TransactionID
                            WHERE t.MemberID = @MemberId
                            AND t.Status IN ('Active', 'Overdue')
                            AND ti.Status = 'Borrowed'";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@MemberId", memberId }
                };

                dtBorrowedBooks = this.db.ExecuteSelectQuery(query, parameters); // Use class-level db

                gvCurrentBorrowedBooks.DataSource = dtBorrowedBooks;
                gvCurrentBorrowedBooks.DataBind();
            }
            catch (Exception ex)
            {
                // Log the error (in a real app)
                Response.Write("Error loading borrowed books: " + ex.Message);
            }
        }

        private void LoadReservations()
        {
            int memberId = Convert.ToInt32(Session["UserID"]);
            DataTable dtReservations = new DataTable();

            try
            {
                string query = @"SELECT 
                                r.ReservationID,
                                d.DeviceID,
                                d.DeviceName,
                                r.StartTime as ReservationDate,
                                r.EndTime as DeadlineDate
                            FROM ReservationItems ri
                            JOIN Devices d ON d.DeviceID = ri.DeviceID
                            JOIN Reservation r ON r.ReservationID = ri.ReservationID
                            WHERE r.MemberID = @MemberId
                            AND r.Status = 'Pending'";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@MemberId", memberId }
                };

                dtReservations = this.db.ExecuteSelectQuery(query, parameters); // Use class-level db

                gvReservations.DataSource = dtReservations;
                gvReservations.DataBind();
            }
            catch (Exception ex)
            {
                // Log the error (in a real app)
                Response.Write("Error loading reservations: " + ex.Message);
            }
        }

        private void LoadBookReservations()
        {
            int memberId = Convert.ToInt32(Session["UserID"]);
            DataTable dtBookReservations = new DataTable();

            try
            {
                string query = @"SELECT 
                                r.ReservationID,
                                b.BookID,
                                b.BookTitle,
                                r.StartTime as ReservationDate,
                                r.EndTime as DeadlineDate
                            FROM ReservationItems ri
                            JOIN Books b ON b.BookID = ri.BookID
                            JOIN Reservation r ON r.ReservationID = ri.ReservationID
                            WHERE r.MemberID = @MemberId
                            AND r.Status = 'Pending'";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@MemberId", memberId }
                };

                dtBookReservations = this.db.ExecuteSelectQuery(query, parameters); // Use class-level db

                gvBookReservations.DataSource = dtBookReservations;
                gvBookReservations.DataBind();
            }
            catch (Exception ex)
            {
                // Log the error (in a real app)
                Response.Write("Error loading book reservations: " + ex.Message);
            }
        }

        private void LoadBorrowHistory()
        {
            int memberId = Convert.ToInt32(Session["UserID"]);
            DataTable dtHistory = new DataTable();

            try
            {
                string query = @"SELECT 
                                d.DeviceID,
                                d.DeviceName,
                                t.TransactionDate as BorrowDate,
                                t.ReturnDate,
                                CASE 
                                    WHEN t.ReturnDate IS NULL AND t.Status = 'Active' THEN 'Đang mượn'
                                    WHEN t.Status = 'Completed' THEN 'Đã trả'
                                    WHEN t.Status = 'Overdue' THEN 'Trễ hạn'
                                    ELSE 'Đang mượn'
                                END as Status
                            FROM TransactionItems ti
                            JOIN Devices d ON d.DeviceID = ti.DeviceID
                            JOIN Transactions t ON t.TransactionID = ti.TransactionID
                            WHERE t.MemberID = @MemberId
                            AND t.Status = 'Completed'
                            ORDER BY t.TransactionDate DESC
                            LIMIT 10";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@MemberId", memberId }
                };

                dtHistory = this.db.ExecuteSelectQuery(query, parameters); // Use class-level db

                gvBorrowHistory.DataSource = dtHistory;
                gvBorrowHistory.DataBind();

                // Load book borrow history
                LoadBookBorrowHistory();
            }
            catch (Exception ex)
            {
                // Log the error (in a real app)
                Response.Write("Error loading borrow history: " + ex.Message);
            }
        }

        private void LoadBookBorrowHistory()
        {
            int memberId = Convert.ToInt32(Session["UserID"]);
            DataTable dtBookHistory = new DataTable();

            try
            {
                string query = @"SELECT 
                                b.BookID,
                                b.BookTitle,
                                t.TransactionDate as BorrowDate,
                                t.ReturnDate,
                                CASE 
                                    WHEN t.ReturnDate IS NULL AND t.Status = 'Active' THEN 'Đang mượn'
                                    WHEN t.Status = 'Completed' THEN 'Đã trả'
                                    WHEN t.Status = 'Overdue' THEN 'Trễ hạn'
                                    ELSE 'Đang mượn'
                                END as Status
                            FROM TransactionItems ti
                            JOIN Books b ON b.BookID = ti.BookID
                            JOIN Transactions t ON t.TransactionID = ti.TransactionID
                            WHERE t.MemberID = @MemberId
                            AND t.Status = 'Completed'
                            ORDER BY t.TransactionDate DESC
                            LIMIT 10";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@MemberId", memberId }
                };

                dtBookHistory = this.db.ExecuteSelectQuery(query, parameters); // Use class-level db

                gvBookBorrowHistory.DataSource = dtBookHistory;
                gvBookBorrowHistory.DataBind();
            }
            catch (Exception ex)
            {
                // Log the error (in a real app)
                Response.Write("Error loading book borrow history: " + ex.Message);
            }
        }

        private void LoadViolations()
        {
            int memberId = Convert.ToInt32(Session["UserID"]);
            DataTable dtViolationSummary = new DataTable();
            DataTable dtViolations = new DataTable();

            try
            {
                // Load violation count and types
                string violationQuery = @"SELECT 
                                        COUNT(*) AS ViolationCount,
                                        GROUP_CONCAT(DISTINCT r.RuleTitle SEPARATOR '||') as ViolationTypes
                                    FROM Violation v
                                    JOIN Rules r ON r.RuleID = v.RuleID
                                    WHERE v.MemberID = @MemberId";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@MemberId", memberId }
                };

                dtViolationSummary = this.db.ExecuteSelectQuery(violationQuery, parameters); // Use class-level db

                if (dtViolationSummary.Rows.Count > 0)
                {
                    DataRow row = dtViolationSummary.Rows[0];
                    // ... (rest of violation summary processing) ...
                    int violationCount = Convert.ToInt32(row["ViolationCount"]);
                    litViolationCount.Text = violationCount.ToString();

                    if (violationCount > 0)
                    {
                        string violationTypes = row["ViolationTypes"].ToString();
                        string[] types = violationTypes.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries);

                        // Set restriction based on violation count
                        if (violationCount >= 2)
                        {
                            litRestriction.Text = "Không được mượn quá 2 thiết bị cùng lúc";
                        }

                        // Create data table for violation tags
                        DataTable dtViolationTags = new DataTable();
                        dtViolationTags.Columns.Add("ViolationType", typeof(string));

                        foreach (string type in types)
                        {
                            dtViolationTags.Rows.Add(type);
                        }

                        rptViolationTags.DataSource = dtViolationTags;
                        rptViolationTags.DataBind();
                    }
                }

                // Load violation details
                string detailsQuery = @"SELECT 
                                     v.ViolationID,
                                     COALESCE(d.DeviceName, b.BookTitle, 'N/A') as DeviceName,
                                     v.ViolationDate,
                                     r.RuleTitle as ViolationType,
                                     v.Reason
                                  FROM Violation v
                                  JOIN Rules r ON r.RuleID = v.RuleID
                                  LEFT JOIN TransactionItems ti ON ti.TransactionID = v.TransactionID
                                  LEFT JOIN Devices d ON d.DeviceID = ti.DeviceID
                                  LEFT JOIN Books b ON b.BookID = ti.BookID
                                  WHERE v.MemberID = @MemberId
                                  ORDER BY v.ViolationDate DESC";

                // Reuse the parameters dictionary
                dtViolations = this.db.ExecuteSelectQuery(detailsQuery, parameters); // Use class-level db

                gvViolations.DataSource = dtViolations;
                gvViolations.DataBind();
            }
            catch (Exception ex)
            {
                // Log the error (in a real app)
                Response.Write("Error loading violations: " + ex.Message);
            }
        }

        private void FillSettingsForm()
        {
            txtEmail.Text = litEmail.Text;
            txtPhone.Text = litPhone.Text;
        }

        protected string GetStatusClass(string status)
        {
            switch (status)
            {
                case "Đang mượn":
                    return "badge-success";
                case "Sắp hết hạn":
                    return "badge-warning";
                case "Trễ hạn":
                    return "badge-danger";
                case "Đã trả":
                    return "badge-success";
                default:
                    return "badge-success";
            }
        }

        protected void gvReservations_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "CancelReservation")
            {
                int reservationId = Convert.ToInt32(e.CommandArgument);
                CancelReservation(reservationId);

                // Reload reservations grid
                LoadReservations();
            }
        }

        protected void gvBookReservations_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "CancelBookReservation")
            {
                int reservationId = Convert.ToInt32(e.CommandArgument);
                CancelReservation(reservationId);

                // Reload book reservations grid
                LoadBookReservations();
            }
        }

        private void CancelReservation(int reservationId)
        {
            try
            {
                string query = "UPDATE Reservation SET Status = 'Cancelled' WHERE ReservationID = @ReservationID";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@ReservationID", reservationId }
                };

                bool result = this.db.ExecuteUpdateQuery(query, parameters); // Use class-level db
                if (result)
                {
                    // Show success message
                    ScriptManager.RegisterStartupScript(this, this.GetType(),
                        "CancelSuccess", "alert('Đã hủy đặt chỗ thành công!');", true);
                }
                else
                {
                    Response.Write("Error cancelling reservation: Update failed.");
                }
            }
            catch (Exception ex)
            {
                // Log the error (in a real app)
                Response.Write("Error cancelling reservation: " + ex.Message);
            }
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            int memberId = Convert.ToInt32(Session["UserID"]);
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;

            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword))
            {
                litPasswordMessage.Text = "<div class='alert alert-danger'>Vui lòng nhập đầy đủ thông tin</div>";
                return;
            }

            try
            {
                // Use direct MySqlCommand to verify the password
                string storedPassword = null;

                // Open the database connection
                db.OpenConnection();

                // Create and execute command to get password
                string query = "SELECT Password FROM Member WHERE MemberID = @MemberId";
                using (MySqlCommand cmd = new MySqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@MemberId", memberId);

                    // Execute the query and get the result
                    object results = cmd.ExecuteScalar();
                    if (results != null)
                    {
                        storedPassword = results.ToString();
                    }
                }

                // Close the connection
                db.CloseConnection();

                // Check if password matches
                if (storedPassword == null || storedPassword != currentPassword)
                {
                    litPasswordMessage.Text = "<div class='alert alert-danger'>Mật khẩu hiện tại không đúng</div>";
                    return;
                }

                // Update password
                string updateQuery = "UPDATE Member SET Password = @NewPassword WHERE MemberID = @MemberId";
                Dictionary<string, object> updateParams = new Dictionary<string, object>
                {
                    { "@NewPassword", newPassword },
                    { "@MemberId", memberId }
                };

                bool result = this.db.ExecuteUpdateQuery(updateQuery, updateParams);
                if (result)
                {
                    litPasswordMessage.Text = "<div class='alert alert-success'>Đổi mật khẩu thành công</div>";
                    txtCurrentPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtConfirmPassword.Text = "";
                }
                else
                {
                    litPasswordMessage.Text = "<div class='alert alert-danger'>Đổi mật khẩu thất bại</div>";
                }
            }
            catch (Exception ex)
            {
                // Log the error and show detailed message to help with debugging
                litPasswordMessage.Text = $"<div class='alert alert-danger'>Đổi mật khẩu thất bại: {ex.Message}</div>";
                Console.WriteLine("Password change error: " + ex.ToString());
            }
        }

        protected void btnSaveChanges_Click(object sender, EventArgs e)
        {
            int memberId = Convert.ToInt32(Session["UserID"]);
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                litSettingsMessage.Text = "<div class='alert alert-danger'>Vui lòng nhập đầy đủ thông tin</div>";
                return;
            }

            try
            {
                string updateQuery = "UPDATE Member SET Email = @Email, PhoneNumber = @Phone WHERE MemberID = @MemberId";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@Email", email },
                    { "@Phone", phone },
                    { "@MemberId", memberId }
                };

                bool result = this.db.ExecuteUpdateQuery(updateQuery, parameters); // Use class-level db
                if (result)
                {
                    // Update displayed information
                    litEmail.Text = email;
                    litPhone.Text = phone;
                    litEmailDetail.Text = email;
                    litPhoneDetail.Text = phone;

                    litSettingsMessage.Text = "<div class='alert alert-success'>Lưu thay đổi thành công</div>";
                }
                else
                {
                    litSettingsMessage.Text = "<div class='alert alert-danger'>Lưu thay đổi thất bại</div>";
                }
            }
            catch (Exception ex)
            {
                // Log the error (in a real app)
                litSettingsMessage.Text = $"<div class='alert alert-danger'>Lưu thay đổi thất bại: {ex.Message}</div>";
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear session
            Session.Clear();
            Session.Abandon();

            // Remove cookies
            if (Request.Cookies["UserLogin"] != null)
            {
                HttpCookie cookie = new HttpCookie("UserLogin");
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }

            // Redirect to login page
            Response.Redirect("~/Login.aspx");
        }
    }
}