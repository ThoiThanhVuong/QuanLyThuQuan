<%@ Page Title="Hồ Sơ Thành Viên" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Profile.aspx.cs" Inherits="ThuQuanWebForm.Profile" %>

    <asp:Content ID="HeadProfileContent" ContentPlaceHolderID="HeadContent" runat="server">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css">
        <style>
            /* Tab styles */
            .tabs {
                display: flex;
                border-bottom: 1px solid #ddd;
                margin-bottom: 1.5rem;
            }

            .tab-link {
                padding: 0.75rem 1.5rem;
                cursor: pointer;
                margin-right: 5px;
                background-color: #f8f8f8;
                border: 1px solid #ddd;
                border-bottom: none;
                border-radius: 4px 4px 0 0;
            }

            .tab-link.active {
                background-color: var(--primary-color);
                color: white;
                border-color: var(--primary-color);
            }

            .tab-content {
                display: none;
                padding: 1rem;
                border: 1px solid #ddd;
                border-top: none;
                margin-top: -5px;
            }

            .tab-content.active {
                display: block;
            }

            .user-info {
                display: flex;
                align-items: center;
                gap: 2rem;
                margin-bottom: 2rem;
            }

            .user-avatar {
                width: 120px;
                height: 120px;
                border-radius: 50%;
                overflow: hidden;
                border: 3px solid var(--primary-color);
            }

            .user-avatar img {
                width: 100%;
                height: 100%;
                object-fit: cover;
            }

            .user-details {
                flex: 1;
            }

            .violation-tag {
                display: inline-block;
                padding: 0.25rem 0.5rem;
                border-radius: 4px;
                font-size: 0.85rem;
                margin-right: 0.5rem;
                background-color: var(--danger-color);
                color: white;
            }

            .badge {
                padding: 0.25rem 0.5rem;
                border-radius: 4px;
                font-size: 0.85rem;
            }

            .badge-success {
                background-color: var(--success-color);
                color: white;
            }

            .badge-warning {
                background-color: var(--warning-color);
                color: white;
            }

            .badge-danger {
                background-color: red;
                color: white;
            }

            .table {
                width: 100%;
                border-collapse: collapse;
                margin-bottom: 1rem;
            }

            .table th,
            .table td {
                padding: 0.75rem;
                border-top: 1px solid #dee2e6;
                text-align: left;
            }

            .table th {
                background-color: #f8f9fa;
                border-bottom: 2px solid #dee2e6;
            }

            .table tr:hover {
                background-color: rgba(0, 0, 0, 0.03);
            }

            .card {
                background: white;
                border-radius: 0.25rem;
                box-shadow: 0 1px 3px rgba(0, 0, 0, 0.12);
                padding: 1.25rem;
                margin-bottom: 1.5rem;
            }

            .card-title {
                margin-top: 0;
                margin-bottom: 1rem;
                border-bottom: 1px solid #dee2e6;
                padding-bottom: 0.5rem;
            }

            .form-group {
                margin-bottom: 1rem;
            }

            .form-label {
                display: block;
                margin-bottom: 0.5rem;
                font-weight: 500;
            }

            .form-input {
                width: 100%;
                padding: 0.5rem;
                border: 1px solid #ddd;
                border-radius: 4px;
                margin-bottom: 0.5rem;
            }

            .password-input-container {
                position: relative;
            }

            .password-toggle {
                position: absolute;
                right: 10px;
                top: 50%;
                transform: translateY(-50%);
                cursor: pointer;
                color: #777;
            }

            .btn {
                padding: 0.5rem 1rem;
                border-radius: 0.25rem;
                border: 1px solid transparent;
                cursor: pointer;
                font-weight: 500;
                text-align: center;
                display: inline-block;
            }

            .btn-danger {
                background-color: red;
                color: white;
            }

            .btn-gradient {
                background-image: linear-gradient(to right, var(--primary-color), var(--secondary-color));
                color: white;
            }
        </style>
    </asp:Content>

    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container">
            <h1>Hồ Sơ Thành Viên</h1>

            <div class="user-info">
                <div class="user-avatar">
                    <img src="https://randomuser.me/api/portraits/men/32.jpg" alt="User Avatar">
                </div>
                <div class="user-details">
                    <h2>
                        <asp:Literal ID="litFullName" runat="server"></asp:Literal>
                    </h2>
                    <p>Tên Người Dùng: <asp:Literal ID="litStudentId" runat="server"></asp:Literal>
                    </p>
                    <p>Email: <asp:Literal ID="litEmail" runat="server"></asp:Literal>
                    </p>
                    <p>Số điện thoại: <asp:Literal ID="litPhone" runat="server"></asp:Literal>
                    </p>
                    <p>Tình trạng: <span class="badge badge-success">
                            <asp:Literal ID="litStatus" runat="server"></asp:Literal>
                        </span></p>
                </div>
            </div>

            <div class="tabs">
                <button type="button" class="tab-link" id="tab-info-btn" onclick="openTab('tab-info')">Thông Tin Cá
                    Nhân</button>
                <button type="button" class="tab-link" id="tab-borrowed-btn" onclick="openTab('tab-borrowed')">Thiết Bị
                    Đang Mượn</button>
                <button type="button" class="tab-link" id="tab-reserved-btn" onclick="openTab('tab-reserved')">Đặt
                    Chỗ</button>
                <button type="button" class="tab-link" id="tab-history-btn" onclick="openTab('tab-history')">Lịch Sử
                    Mượn Trả</button>
                <button type="button" class="tab-link" id="tab-violations-btn" onclick="openTab('tab-violations')">Vi
                    Phạm</button>
                <button type="button" class="tab-link" id="tab-settings-btn" onclick="openTab('tab-settings')">Cài
                    Đặt</button>
            </div>

            <!-- Tab Thông Tin Cá Nhân -->
            <div id="tab-info" class="tab-content" style="display: block;">
                <div class="card">
                    <h3 class="card-title">Thông Tin Thành Viên</h3>
                    <p><strong>Họ và tên:</strong>
                        <asp:Literal ID="litFullNameDetail" runat="server"></asp:Literal>
                    </p>
                    <p><strong>Tên người dùng:</strong>
                        <asp:Literal ID="litStudentIdDetail" runat="server"></asp:Literal>
                    </p>
                    <p><strong>Usertype:</strong>
                        <asp:Literal ID="litFaculty" runat="server"></asp:Literal>
                    </p>
                    <p><strong>Email:</strong>
                        <asp:Literal ID="litEmailDetail" runat="server"></asp:Literal>
                    </p>
                    <p><strong>Số điện thoại:</strong>
                        <asp:Literal ID="litPhoneDetail" runat="server"></asp:Literal>
                    </p>
                    <p><strong>Ngày tham gia:</strong>
                        <asp:Literal ID="litRegistrationDate" runat="server"></asp:Literal>
                    </p>
                    <p><strong>Số thiết bị đã mượn:</strong>
                        <asp:Literal ID="litBorrowedCount" runat="server">0</asp:Literal>
                    </p>
                </div>
            </div>

            <!-- Tab Thiết Bị Đang Mượn -->
            <div id="tab-borrowed" class="tab-content">
                <div class="card">
                    <h3 class="card-title">Thiết Bị Đang Mượn</h3>
                    <asp:GridView ID="gvCurrentBorrowed" runat="server" CssClass="table" AutoGenerateColumns="false"
                        EmptyDataText="Bạn không có thiết bị đang mượn">
                        <Columns>
                            <asp:BoundField DataField="DeviceID" HeaderText="Mã thiết bị" />
                            <asp:BoundField DataField="DeviceName" HeaderText="Tên thiết bị" />
                            <asp:BoundField DataField="BorrowDate" HeaderText="Ngày mượn"
                                DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField DataField="DueDate" HeaderText="Hạn trả"
                                DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:TemplateField HeaderText="Trạng thái">
                                <ItemTemplate>
                                    <span class='badge <%# GetStatusClass(Eval("Status").ToString()) %>'>
                                        <%# Eval("Status") %>
                                    </span>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>

                <div class="card">
                    <h3 class="card-title">Sách Đang Mượn</h3>
                    <asp:GridView ID="gvCurrentBorrowedBooks" runat="server" CssClass="table"
                        AutoGenerateColumns="false" EmptyDataText="Bạn không có sách đang mượn">
                        <Columns>
                            <asp:BoundField DataField="BookID" HeaderText="Mã sách" />
                            <asp:BoundField DataField="BookTitle" HeaderText="Tên sách" />
                            <asp:BoundField DataField="BorrowDate" HeaderText="Ngày mượn"
                                DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField DataField="DueDate" HeaderText="Hạn trả"
                                DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:TemplateField HeaderText="Trạng thái">
                                <ItemTemplate>
                                    <span class='badge <%# GetStatusClass(Eval("Status").ToString()) %>'>
                                        <%# Eval("Status") %>
                                    </span>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>

            <!-- Tab Đặt Chỗ Thiết Bị -->
            <div id="tab-reserved" class="tab-content">
                <div class="card">
                    <h3 class="card-title">Đặt Chỗ Thiết Bị</h3>
                    <asp:GridView ID="gvReservations" runat="server" CssClass="table" AutoGenerateColumns="false"
                        EmptyDataText="Bạn không có thiết bị đặt chỗ" OnRowCommand="gvReservations_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="DeviceID" HeaderText="Mã thiết bị" />
                            <asp:BoundField DataField="DeviceName" HeaderText="Tên thiết bị" />
                            <asp:BoundField DataField="ReservationDate" HeaderText="Ngày đặt chỗ"
                                DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField DataField="DeadlineDate" HeaderText="Hạn đến lấy"
                                DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:TemplateField HeaderText="Thao tác">
                                <ItemTemplate>
                                    <asp:Button ID="btnCancel" runat="server" Text="Hủy đặt chỗ"
                                        CommandName="CancelReservation" CommandArgument='<%# Eval("ReservationID") %>'
                                        CssClass="btn btn-danger"
                                        OnClientClick="return confirm('Bạn có chắc chắn muốn hủy đặt chỗ thiết bị này?');" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>

                <div class="card">
                    <h3 class="card-title">Đặt Chỗ Sách</h3>
                    <asp:GridView ID="gvBookReservations" runat="server" CssClass="table" AutoGenerateColumns="false"
                        EmptyDataText="Bạn không có sách đặt chỗ" OnRowCommand="gvBookReservations_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="BookID" HeaderText="Mã sách" />
                            <asp:BoundField DataField="BookTitle" HeaderText="Tên sách" />
                            <asp:BoundField DataField="ReservationDate" HeaderText="Ngày đặt chỗ"
                                DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField DataField="DeadlineDate" HeaderText="Hạn đến lấy"
                                DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:TemplateField HeaderText="Thao tác">
                                <ItemTemplate>
                                    <asp:Button ID="btnCancelBook" runat="server" Text="Hủy đặt chỗ"
                                        CommandName="CancelBookReservation"
                                        CommandArgument='<%# Eval("ReservationID") %>' CssClass="btn btn-danger"
                                        OnClientClick="return confirm('Bạn có chắc chắn muốn hủy đặt chỗ sách này?');" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>

            <!-- Tab Lịch Sử Mượn Trả -->
            <div id="tab-history" class="tab-content">
                <div class="card">
                    <h3 class="card-title">Lịch Sử Mượn Trả Thiết Bị</h3>
                    <asp:GridView ID="gvBorrowHistory" runat="server" CssClass="table" AutoGenerateColumns="false"
                        EmptyDataText="Chưa có lịch sử mượn trả thiết bị">
                        <Columns>
                            <asp:BoundField DataField="DeviceID" HeaderText="Mã thiết bị" />
                            <asp:BoundField DataField="DeviceName" HeaderText="Tên thiết bị" />
                            <asp:BoundField DataField="BorrowDate" HeaderText="Ngày mượn"
                                DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField DataField="ReturnDate" HeaderText="Ngày trả"
                                DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:TemplateField HeaderText="Trạng thái">
                                <ItemTemplate>
                                    <span class='badge <%# GetStatusClass(Eval("Status").ToString()) %>'>
                                        <%# Eval("Status") %>
                                    </span>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>

                <div class="card">
                    <h3 class="card-title">Lịch Sử Mượn Trả Sách</h3>
                    <asp:GridView ID="gvBookBorrowHistory" runat="server" CssClass="table" AutoGenerateColumns="false"
                        EmptyDataText="Chưa có lịch sử mượn trả sách">
                        <Columns>
                            <asp:BoundField DataField="BookID" HeaderText="Mã sách" />
                            <asp:BoundField DataField="BookTitle" HeaderText="Tên sách" />
                            <asp:BoundField DataField="BorrowDate" HeaderText="Ngày mượn"
                                DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField DataField="ReturnDate" HeaderText="Ngày trả"
                                DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:TemplateField HeaderText="Trạng thái">
                                <ItemTemplate>
                                    <span class='badge <%# GetStatusClass(Eval("Status").ToString()) %>'>
                                        <%# Eval("Status") %>
                                    </span>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>

            <!-- Tab Vi Phạm -->
            <div id="tab-violations" class="tab-content">
                <div class="card">
                    <h3 class="card-title">Trạng Thái Vi Phạm</h3>
                    <div class="violation-summary" style="margin-bottom: 1.5rem;">
                        <p><strong>Tổng số vi phạm:</strong>
                            <asp:Literal ID="litViolationCount" runat="server">0</asp:Literal>
                        </p>
                        <p>
                            <strong>Loại vi phạm:</strong>
                            <asp:Repeater ID="rptViolationTags" runat="server">
                                <ItemTemplate>
                                    <span class="violation-tag">
                                        <%# Eval("ViolationType") %>
                                    </span>
                                </ItemTemplate>
                            </asp:Repeater>
                        </p>
                        <p><strong>Hạn chế:</strong>
                            <asp:Literal ID="litRestriction" runat="server">Không có hạn chế</asp:Literal>
                        </p>
                    </div>

                    <h4>Chi tiết vi phạm</h4>
                    <asp:GridView ID="gvViolations" runat="server" CssClass="table" AutoGenerateColumns="false"
                        EmptyDataText="Không có vi phạm">
                        <Columns>
                            <asp:BoundField DataField="ViolationID" HeaderText="Mã vi phạm" />
                            <asp:BoundField DataField="DeviceName" HeaderText="Thiết bị" />
                            <asp:BoundField DataField="ViolationDate" HeaderText="Ngày vi phạm"
                                DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField DataField="ViolationType" HeaderText="Loại vi phạm" />
                            <asp:BoundField DataField="Reason" HeaderText="Mô tả" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>

            <!-- Tab Cài Đặt -->
            <div id="tab-settings" class="tab-content">
                <div class="card">
                    <h3 class="card-title">Đổi Mật Khẩu</h3>
                    <div class="form-group">
                        <label for="currentPassword" class="form-label">Mật khẩu hiện tại</label>
                        <div class="password-input-container">
                            <asp:TextBox ID="txtCurrentPassword" runat="server" CssClass="form-input"
                                TextMode="Password"></asp:TextBox>
                            <i class="fas fa-eye password-toggle"
                                onclick="togglePassword('<%=txtCurrentPassword.ClientID%>')"></i>
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="newPassword" class="form-label">Mật khẩu mới</label>
                        <div class="password-input-container">
                            <asp:TextBox ID="txtNewPassword" runat="server" CssClass="form-input" TextMode="Password">
                            </asp:TextBox>
                            <i class="fas fa-eye password-toggle"
                                onclick="togglePassword('<%=txtNewPassword.ClientID%>')"></i>
                        </div>
                        <div class="password-strength-meter">
                            <div class="strength-bar"></div>
                        </div>
                        <small class="password-hint">Mật khẩu cần có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và
                            ký tự đặc biệt</small>
                    </div>

                    <div class="form-group">
                        <label for="confirmNewPassword" class="form-label">Xác nhận mật khẩu mới</label>
                        <div class="password-input-container">
                            <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="form-input"
                                TextMode="Password"></asp:TextBox>
                            <i class="fas fa-eye password-toggle"
                                onclick="togglePassword('<%=txtConfirmPassword.ClientID%>')"></i>
                        </div>
                        <asp:CompareValidator ID="cvPasswordMatch" runat="server" ControlToValidate="txtConfirmPassword"
                            ControlToCompare="txtNewPassword" ErrorMessage="Mật khẩu không khớp" Display="Dynamic"
                            CssClass="text-danger">
                        </asp:CompareValidator>
                    </div>

                    <asp:Button ID="btnChangePassword" runat="server" CssClass="btn btn-gradient" Text="Đổi Mật Khẩu"
                        OnClick="btnChangePassword_Click" />
                    <asp:Literal ID="litPasswordMessage" runat="server"></asp:Literal>
                </div>

                <div class="card settings-card">
                    <h3 class="card-title">Cài Đặt Tài Khoản</h3>
                    <div class="form-group">
                        <label for="email" class="form-label">Email</label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-input" TextMode="Email"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="phone" class="form-label">Số điện thoại</label>
                        <asp:TextBox ID="txtPhone" runat="server" CssClass="form-input"></asp:TextBox>
                    </div>

                    <asp:Button ID="btnSaveChanges" runat="server" CssClass="btn btn-gradient" Text="Lưu Thay Đổi"
                        OnClick="btnSaveChanges_Click" />
                    <asp:Literal ID="litSettingsMessage" runat="server"></asp:Literal>
                </div>
            </div>
        </div>

        <script type="text/javascript">
            // Save current active tab to sessionStorage
            function saveActiveTab(tabId) {
                sessionStorage.setItem("activeTab", tabId);
            }

            // Open tab and save its state
            function openTab(tabId) {
                // Hide all tab content
                var tabcontent = document.getElementsByClassName("tab-content");
                for (var i = 0; i < tabcontent.length; i++) {
                    tabcontent[i].style.display = "none";
                }

                // Remove "active" class from all tab links
                var tablinks = document.getElementsByClassName("tab-link");
                for (var i = 0; i < tablinks.length; i++) {
                    tablinks[i].className = tablinks[i].className.replace(" active", "");
                }

                // Show the current tab and add "active" class to its button
                document.getElementById(tabId).style.display = "block";
                document.getElementById(tabId + "-btn").className += " active";

                // Save the active tab
                saveActiveTab(tabId);
            }

            // Toggle password visibility
            function togglePassword(elementId) {
                var passwordInput = document.getElementById(elementId);
                var icon = event.currentTarget;

                if (passwordInput.type === "password") {
                    passwordInput.type = "text";
                    icon.classList.remove("fa-eye");
                    icon.classList.add("fa-eye-slash");
                } else {
                    passwordInput.type = "password";
                    icon.classList.remove("fa-eye-slash");
                    icon.classList.add("fa-eye");
                }
            }

            // Initialize tabs on page load
            window.onload = function () {
                // Get saved tab from sessionStorage or default to "tab-info"
                var activeTab = sessionStorage.getItem("activeTab") || "tab-info";
                openTab(activeTab);
            };
        </script>
    </asp:Content>