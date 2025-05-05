using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThuQuanWebForm.DAO;
using ThuQuanWebForm.Model;
using ThuQuanWebForm.BUS;

namespace ThuQuanWebForm
{
    public partial class Reserve : System.Web.UI.Page
    {
        // Instantiate DAOs and BUS for database access
        private BookDAO bookDAO = new BookDAO();
        private DeviceDAO deviceDAO = new DeviceDAO();
        private AuthorBUS authorBUS = new AuthorBUS();
        private ResevationBUS reservationBUS = new ResevationBUS();

        // Paging properties
        private const int ItemsPerPage = 8; // Show items per page
        private int _totalPages = 1;
        private string _currentFilter = "all";
        private string _currentSearchTerm = "";

        // Property to get/set the current page from ViewState
        protected int CurrentPage
        {
            get
            {
                object obj = ViewState["CurrentPage"];
                return obj == null ? 1 : (int)obj;
            }
            set
            {
                ViewState["CurrentPage"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize ViewState properties
                CurrentPage = 1;
                ViewState["CurrentFilter"] = "all";
                ViewState["CurrentSearchTerm"] = "";

                // Load initial data when the page first loads
                BindItemData();
            }
        }

        // Event handler for the Confirm Reservation button
        protected void ConfirmReservation_Click(object sender, EventArgs e)
        {
            // Check if user is authenticated by looking for the Session variables
            // instead of using User.Identity.IsAuthenticated
            if (Session["UserID"] == null || Session["Username"] == null)
            {
                // Redirect to login page if not authenticated
                ClientScript.RegisterStartupScript(this.GetType(), "authError",
                    "alert('Bạn cần đăng nhập để mượn sách hoặc thiết bị!'); window.location = 'Login.aspx?returnUrl=" +
                    Server.UrlEncode(Request.Url.AbsoluteUri) + "';", true);
                return;
            }

            string debugInfo = ""; // For collecting debug information

            try
            {
                // Get user ID directly from the session
                int memberID = Convert.ToInt32(Session["UserID"]);
                debugInfo += "MemberID: " + memberID + "<br/>";

                if (memberID <= 0)
                {
                    // Instead of silently returning, show a more detailed error message
                    ShowErrorMessage("Không thể xác định người dùng (ID = " + memberID + "). Vui lòng đăng nhập lại.");
                    return;
                }

                // Get form values
                string itemType = itemTypeHidden.Value;
                int itemID = Convert.ToInt32(itemIDHidden.Value);

                // Handle start time - use current time if field is empty
                DateTime startTime;
                if (string.IsNullOrEmpty(startDateTimeControl.Text))
                {
                    startTime = DateTime.Now;
                    debugInfo += "StartTime: Generated current time - " + startTime.ToString() + "<br/>";
                }
                else
                {
                    startTime = Convert.ToDateTime(startDateTimeControl.Text);
                    debugInfo += "StartTime: From form - " + startTime.ToString() + "<br/>";
                }

                // Get end time from the form
                DateTime endTime = Convert.ToDateTime(endDateTimeControl.Text);
                debugInfo += "EndTime: " + endTime.ToString() + "<br/>";

                // Create reservation model
                var reservation = new ReservationModel
                {
                    MemberID = memberID,
                    StartTime = startTime,
                    EndTime = endTime,
                    Status = ReservationStatus.Pending,
                    Items = new List<ReservationItemModel>()
                };

                // Add item to reservation based on type (book or device)
                var reservationItem = new ReservationItemModel
                {
                    Amount = 1 // Default to borrowing 1 item
                };

                if (itemType == "book")
                {
                    reservationItem.BookID = itemID;
                    reservationItem.DeviceID = null;
                    debugInfo += "Adding book with ID: " + itemID + "<br/>";
                }
                else if (itemType == "device")
                {
                    reservationItem.DeviceID = itemID;
                    reservationItem.BookID = null;
                    debugInfo += "Adding device with ID: " + itemID + "<br/>";
                }

                reservation.Items.Add(reservationItem);

                // Save reservation to database
                bool success = reservationBUS.AddReservationWithItems(reservation);
                debugInfo += "Database operation result: " + (success ? "Success" : "Failed") + "<br/>";

                if (success)
                {
                    // Show success message
                    string itemTypeName = itemType == "book" ? "sách" : "thiết bị";
                    ClientScript.RegisterStartupScript(this.GetType(), "reservationSuccess",
                        $"alert('Đặt mượn {itemTypeName} thành công! Bạn có thể xem thông tin đặt mượn trong trang cá nhân.');", true);

                    // Refresh item data to show updated status
                    BindItemData();
                }
                else
                {
                    // Add debug info to the error message
                    ShowErrorMessage("Đã xảy ra lỗi khi đặt mượn. Vui lòng thử lại sau.<br/><br/>Chi tiết:<br/>" + debugInfo);
                }
            }
            catch (Exception ex)
            {
                // Show detailed error message including the debug info
                ShowErrorMessage("Lỗi: " + ex.Message + "<br/><br/>Chi tiết lỗi: " + ex.StackTrace + "<br/><br/>Debug Info:<br/>" + debugInfo);
            }
        }

        // Helper method to get current user ID
        private int GetCurrentUserID()
        {
            // Get user ID from session - this is where the Login page stores it
            if (Session["UserID"] != null)
            {
                try
                {
                    return Convert.ToInt32(Session["UserID"]);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error converting UserID from session: " + ex.Message);
                    // Continue to other methods if this fails
                }
            }

            // For debugging - show what's actually in the session
            string sessionDebug = "Available Session Keys: ";
            foreach (string key in Session.Keys)
            {
                sessionDebug += key + "=" + Session[key] + "; ";
            }
            System.Diagnostics.Debug.WriteLine(sessionDebug);

            // Default to a hard-coded value for testing if needed
            // Uncomment and set a valid member ID from your database for testing
            // return 1; // Use a valid MemberID that exists in your database

            return -1; // Invalid user ID
        }

        // Helper method to show error message
        private void ShowErrorMessage(string message)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "errorAlert",
                $"alert('{message}');", true);
        }

        // Event handler for the Search button
        protected void SearchButton_Click(object sender, EventArgs e)
        {
            // Get the search term from the TextBox
            string searchTerm = itemSearchTextBox.Text;
            ViewState["CurrentSearchTerm"] = searchTerm;
            CurrentPage = 1; // Reset to first page when searching

            // Bind data with the search term
            BindItemData(searchTerm: searchTerm, filter: _currentFilter);
        }

        // Event handler for all Filter link buttons
        protected void FilterButton_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            string filterType = btn.CommandArgument; // Gets 'all', 'available', 'books', etc.

            ViewState["CurrentFilter"] = filterType;
            CurrentPage = 1; // Reset to first page when changing filters

            // Filter the data source based on filterType
            BindItemData(filter: filterType, searchTerm: _currentSearchTerm);

            // Update the 'active' class on filter buttons server-side
            UpdateFilterButtonStyles(filterType);
        }

        // Event handler for pagination buttons (prev, next)
        protected void PaginationButton_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            string action = btn.CommandArgument; // "prev" or "next"

            if (action == "prev" && CurrentPage > 1)
            {
                CurrentPage--;
            }
            else if (action == "next" && CurrentPage < _totalPages)
            {
                CurrentPage++;
            }

            // Get current filter and search term from ViewState
            string currentFilter = (string)ViewState["CurrentFilter"] ?? "all";
            string currentSearchTerm = (string)ViewState["CurrentSearchTerm"] ?? "";

            // Rebind data with current page, filter, and search term
            BindItemData(filter: currentFilter, searchTerm: currentSearchTerm);
        }

        // Event handler for pagination number buttons
        protected void PaginationRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "GoToPage")
            {
                CurrentPage = Convert.ToInt32(e.CommandArgument);

                // Get current filter and search term from ViewState
                string currentFilter = (string)ViewState["CurrentFilter"] ?? "all";
                string currentSearchTerm = (string)ViewState["CurrentSearchTerm"] ?? "";

                // Rebind data with current page, filter, and search term
                BindItemData(filter: currentFilter, searchTerm: currentSearchTerm);
            }
        }

        // Event handler for the Borrow buttons inside the Repeater
        protected void ItemRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Borrow")
            {
                // This is now handled by the client-side showReservationModal function
                // The client-side code will show the modal with date/time selection
                // After user confirms, the form will post back and handle it in ConfirmReservation_Click
            }
        }

        // Data binding method that loads data from the database with paging support
        private void BindItemData(string searchTerm = null, string filter = "all")
        {
            // Get current state from ViewState if not provided
            _currentFilter = string.IsNullOrEmpty(filter) ? (string)ViewState["CurrentFilter"] : filter;
            _currentSearchTerm = searchTerm ?? (string)ViewState["CurrentSearchTerm"];

            // Store current filter and search term in ViewState
            ViewState["CurrentFilter"] = _currentFilter;
            ViewState["CurrentSearchTerm"] = _currentSearchTerm;

            // Get all data from database
            var allItems = GetItemsFromDatabase();

            // Apply search filter if provided
            if (!string.IsNullOrWhiteSpace(_currentSearchTerm))
            {
                allItems = allItems.Where(item =>
                    (item.ItemName != null && item.ItemName.IndexOf(_currentSearchTerm, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (item.Description != null && item.Description.IndexOf(_currentSearchTerm, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (item.Author != null && item.Author.IndexOf(_currentSearchTerm, StringComparison.OrdinalIgnoreCase) >= 0) || // If book
                    (item.Spec1 != null && item.Spec1.IndexOf(_currentSearchTerm, StringComparison.OrdinalIgnoreCase) >= 0)      // If device
                ).ToList();
            }

            // Apply item type filter
            switch (_currentFilter)
            {
                case "available":
                    allItems = allItems.Where(item => item.IsAvailable).ToList();
                    break;
                case "borrowed":
                    allItems = allItems.Where(item => !item.IsAvailable).ToList();
                    break;
                case "books":
                    allItems = allItems.Where(item => item.ItemType == "book").ToList();
                    break;
                case "devices":
                    allItems = allItems.Where(item => item.ItemType == "device").ToList();
                    break;
                case "all":
                default:
                    // No additional filtering needed
                    break;
            }

            // Calculate total pages
            int totalItems = allItems.Count();
            _totalPages = (int)Math.Ceiling((double)totalItems / ItemsPerPage);

            // Ensure CurrentPage is within valid range
            if (CurrentPage < 1) CurrentPage = 1;
            if (CurrentPage > _totalPages && _totalPages > 0) CurrentPage = _totalPages;

            // Apply paging to get only the items for the current page
            var pagedItems = allItems
                .Skip((CurrentPage - 1) * ItemsPerPage)
                .Take(ItemsPerPage)
                .ToList();

            // Bind data to the ItemRepeater
            ItemRepeater.DataSource = pagedItems;
            ItemRepeater.DataBind();

            // Create page numbers for pagination
            BindPagination();

            // Update UI based on results
            UpdatePaginationUI(totalItems);
        }

        // Helper method to bind page numbers to pagination
        private void BindPagination()
        {
            List<int> pageNumbers = new List<int>();

            // Show up to 5 page numbers centered around current page
            int startPage = Math.Max(1, CurrentPage - 2);
            int endPage = Math.Min(_totalPages, startPage + 4);

            // Adjust startPage if we're near the end
            if (endPage - startPage < 4 && startPage > 1)
            {
                startPage = Math.Max(1, endPage - 4);
            }

            for (int i = startPage; i <= endPage; i++)
            {
                pageNumbers.Add(i);
            }

            PaginationRepeater.DataSource = pageNumbers;
            PaginationRepeater.DataBind();

            // Update navigation buttons
            PrevPageButton.Enabled = (CurrentPage > 1);
            PrevPageButton.CssClass = CurrentPage > 1 ? "pagination-btn" : "pagination-btn disabled";

            NextPageButton.Enabled = (CurrentPage < _totalPages);
            NextPageButton.CssClass = CurrentPage < _totalPages ? "pagination-btn" : "pagination-btn disabled";
        }

        // Helper method to update UI based on results count
        private void UpdatePaginationUI(int totalItems)
        {
            // Enable/disable pagination based on number of items
            PaginationRepeater.Visible = (_totalPages > 1);
            PrevPageButton.Visible = (_totalPages > 1);
            NextPageButton.Visible = (_totalPages > 1);
        }

        // Helper method to convert database data to display format
        private List<DisplayItem> GetItemsFromDatabase()
        {
            List<DisplayItem> displayItems = new List<DisplayItem>();

            // Get books from database
            var books = bookDAO.GetAllBooks();
            foreach (var book in books)
            {
                // For books, consider it available if quantity > 0 and status is Available
                bool isAvailable = book.BookQuantity > 0 && book.BookStatus == ProductStatus.Available;

                // Get author name using AuthorBUS
                string authorName = "Unknown Author";
                var author = authorBUS.GetAuthorByID(book.AuthorID);
                if (author != null)
                {
                    authorName = author.AuthorName;
                }

                // Build image path from local Img folder
                string imagePath;
                if (!string.IsNullOrEmpty(book.BookImage) && book.BookImage.StartsWith("http"))
                {
                    // Keep external URLs if they exist
                    imagePath = book.BookImage;
                }
                else
                {
                    // Use local path - format: ~/Img/Books/filename.jpg
                    // If BookImage has a filename, use it; otherwise use a default based on ID
                    string filename = !string.IsNullOrEmpty(book.BookImage)
                        ? System.IO.Path.GetFileName(book.BookImage)
                        : $"book_{book.BookID}.jpg";

                    imagePath = $"../Img/Books/{filename}";
                }

                displayItems.Add(new DisplayItem
                {
                    ItemType = "book",
                    ItemID = book.BookID,
                    ImageUrl = imagePath,
                    ItemName = book.BookTitle,
                    Description = $"Sách về {(book.Category != null ? book.Category.CategoryName : "chủ đề không xác định")}",
                    IsAvailable = isAvailable,
                    Author = authorName,
                    Year = book.PublisYear,
                    Spec1 = null,
                    Spec2 = null
                });
            }

            // Get devices from database
            var devices = deviceDAO.GetAllDevices();
            foreach (var device in devices)
            {
                // For devices, consider it available if quantity > 0 and status is Available
                bool isAvailable = device.DeviceQuantity > 0 && device.DeviceStatus == ProductStatus.Available;

                // Build image path from local Img folder
                string imagePath;
                if (!string.IsNullOrEmpty(device.DeviceImage) && device.DeviceImage.StartsWith("http"))
                {
                    // Keep external URLs if they exist
                    imagePath = device.DeviceImage;
                }
                else
                {
                    // Use local path - format: ~/Img/Devices/filename.jpg
                    // If DeviceImage has a filename, use it; otherwise use a default based on ID
                    string filename = !string.IsNullOrEmpty(device.DeviceImage)
                        ? System.IO.Path.GetFileName(device.DeviceImage)
                        : $"device_{device.DeviceID}.jpg";

                    imagePath = $"../Img/Devices/{filename}";
                }

                displayItems.Add(new DisplayItem
                {
                    ItemType = "device",
                    ItemID = device.DeviceID,
                    ImageUrl = imagePath,
                    ItemName = device.DeviceName,
                    Description = $"Thiết bị {device.DeviceType}, phí thuê {device.FeePerHour}đ/giờ",
                    IsAvailable = isAvailable,
                    Author = null,
                    Year = null,
                    Spec1 = device.DeviceType,
                    Spec2 = $"{device.FeePerHour}đ/giờ"
                });
            }

            return displayItems;
        }

        // Helper method to update filter button styles (optional)
        private void UpdateFilterButtonStyles(string activeFilter)
        {
            // Remove active class from all buttons
            FilterAllButton.CssClass = FilterAllButton.CssClass.Replace(" active", "");
            FilterAvailableButton.CssClass = FilterAvailableButton.CssClass.Replace(" active", "");
            FilterBooksButton.CssClass = FilterBooksButton.CssClass.Replace(" active", "");
            FilterDevicesButton.CssClass = FilterDevicesButton.CssClass.Replace(" active", "");

            // Add active class to the selected filter button
            switch (activeFilter)
            {
                case "available":
                    FilterAvailableButton.CssClass += " active";
                    break;
                case "borrowed":
                    FilterBorrowedButton.CssClass += " active";
                    break;
                case "books":
                    FilterBooksButton.CssClass += " active";
                    break;
                case "devices":
                    FilterDevicesButton.CssClass += " active";
                    break;
                case "all":
                default:
                    FilterAllButton.CssClass += " active";
                    break;
            }
        }

        // DisplayItem class used to store items for display in the Repeater
        public class DisplayItem
        {
            public string ItemType { get; set; } // "book" or "device"
            public int ItemID { get; set; }
            public string ImageUrl { get; set; }
            public string ItemName { get; set; }
            public string Description { get; set; }
            public bool IsAvailable { get; set; }
            public string StatusText => IsAvailable ? "Có sẵn" : "Đang mượn";
            public string StatusCssClass => IsAvailable ? "status-available" : "status-borrowed";
            // Book specific
            public string Author { get; set; }
            public int? Year { get; set; }
            // Device specific
            public string Spec1 { get; set; }
            public string Spec2 { get; set; }
        }
    }
}