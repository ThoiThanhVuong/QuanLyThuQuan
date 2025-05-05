<%@ Page Title="Đăng Ký" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Register.aspx.cs" Inherits="ThuQuanWebForm.Register" %>

    <asp:Content ID="HeadRegisterContent" ContentPlaceHolderID="HeadContent" runat="server">
        <style>
            .register-container {
                max-width: 550px;
                margin: 2rem auto;
                border-radius: 10px;
                overflow: hidden;
                box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
                background: white;
                animation: slideUp 0.8s ease;
            }

            .register-header {
                background-image: linear-gradient(to right, var(--primary-color), var(--secondary-color));
                color: white;
                padding: 2rem;
                text-align: center;
            }

            .register-header h2 {
                margin: 0;
                font-size: 1.8rem;
                color: white;
            }

            .register-icon {
                font-size: 3rem;
                margin-bottom: 1rem;
            }

            .register-body {
                padding: 2rem;
            }

            .form-group {
                margin-bottom: 1.5rem;
            }

            .form-label {
                display: block;
                margin-bottom: 0.5rem;
                font-weight: 500;
                color: #333;
            }

            .form-input {
                width: 100%;
                padding: 0.75rem 1rem;
                border: 1px solid #ddd;
                border-radius: 5px;
                font-size: 1rem;
                transition: border-color 0.3s;
                box-sizing: border-box;
            }

            .form-input:focus {
                border-color: var(--primary-color);
                outline: none;
                box-shadow: 0 0 0 3px rgba(52, 152, 219, 0.2);
            }

            .password-input-container {
                display: flex;
                align-items: center;
            }

            .password-toggle {
                margin: 0 10px;
                cursor: pointer;
                color: #777;
                transition: color 0.3s;
            }

            .password-toggle:hover {
                color: var(--primary-color);
            }

            .form-row {
                display: flex;
                gap: 15px;
            }

            .form-row .form-group {
                flex: 1;
            }

            .checkbox-wrapper {
                display: flex;
                align-items: flex-start;
                margin-bottom: 1.5rem;
            }

            .checkbox-wrapper input {
                margin-right: 10px;
                margin-top: 5px;
            }

            .form-footer {
                text-align: center;
                margin-top: 1.5rem;
            }

            .btn-block {
                display: block;
                margin: 0 auto;
                width: 100%;
            }

            @keyframes slideUp {
                from {
                    opacity: 0;
                    transform: translateY(50px);
                }

                to {
                    opacity: 1;
                    transform: translateY(0);
                }
            }
        </style>
    </asp:Content>

    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="register-container">
            <div class="register-header">
                <div class="register-icon"><i class="fas fa-user-plus"></i></div>
                <h2>Đăng Ký Tài Khoản</h2>
            </div>
            <div class="register-body">
                <div class="form-row">
                    <div class="form-group">
                        <asp:Label ID="lblFirstName" runat="server" CssClass="form-label" Text="Họ"
                            AssociatedControlID="txtFirstName"></asp:Label>
                        <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-input" required></asp:TextBox>
                        <i class="fas fa-user form-icon"></i>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblLastName" runat="server" CssClass="form-label" Text="Tên"
                            AssociatedControlID="txtLastName"></asp:Label>
                        <asp:TextBox ID="txtLastName" runat="server" CssClass="form-input" required></asp:TextBox>
                        <i class="fas fa-user form-icon"></i>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblStudentId" runat="server" CssClass="form-label" Text="Tên đăng nhập"
                        AssociatedControlID="txtStudentId"></asp:Label>
                    <asp:TextBox ID="txtStudentId" runat="server" CssClass="form-input" required></asp:TextBox>
                    <i class="fas fa-id-card form-icon"></i>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblEmail" runat="server" CssClass="form-label" Text="Email"
                        AssociatedControlID="txtEmail"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="form-input" required>
                    </asp:TextBox>
                    <i class="fas fa-envelope form-icon"></i>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblPhone" runat="server" CssClass="form-label" Text="Số điện thoại"
                        AssociatedControlID="txtPhone"></asp:Label>
                    <asp:TextBox ID="txtPhone" runat="server" CssClass="form-input" required></asp:TextBox>
                    <i class="fas fa-phone form-icon"></i>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblPassword" runat="server" CssClass="form-label" Text="Mật khẩu"
                        AssociatedControlID="txtPassword"></asp:Label>
                    <div class="password-input-container">
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-input" required>
                        </asp:TextBox>
                        <i class="fas fa-eye password-toggle" onclick="togglePassword('<%=txtPassword.ClientID%>')"></i>
                    </div>
                    <div class="password-requirements">
                        Mật khẩu cần có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblConfirmPassword" runat="server" CssClass="form-label" Text="Xác nhận mật khẩu"
                        AssociatedControlID="txtConfirmPassword"></asp:Label>
                    <div class="password-input-container">
                        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" CssClass="form-input"
                            required></asp:TextBox>
                        <i class="fas fa-eye password-toggle"
                            onclick="togglePassword('<%=txtConfirmPassword.ClientID%>')"></i>
                    </div>
                </div>

                <asp:Button ID="btnRegister" runat="server" Text="Đăng Ký" CssClass="btn btn-gradient btn-block"
                    OnClick="btnRegister_Click" />

                <div class="form-footer">
                    <p>Đã có tài khoản? <a href="Login.aspx">Đăng nhập</a></p>
                </div>
            </div>
        </div>

        <script type="text/javascript">
            function togglePassword(passwordId) {
                var passwordInput = document.getElementById(passwordId);
                if (passwordInput.type === "password") {
                    passwordInput.type = "text";
                } else {
                    passwordInput.type = "password";
                }
            }
        </script>
    </asp:Content>