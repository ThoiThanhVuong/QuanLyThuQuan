<%@ Page Title="Đăng Nhập" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="ThuQuanWebForm.Login" %>

    <asp:Content ID="HeadLoginContent" ContentPlaceHolderID="HeadContent" runat="server">
        <style>
            .login-container {
                max-width: 450px;
                margin: 2rem auto;
                border-radius: 10px;
                overflow: hidden;
                box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
                background: white;
                animation: slideUp 0.8s ease;
            }

            .login-header {
                background-image: linear-gradient(to right, var(--primary-color), var(--secondary-color));
                color: white;
                padding: 2rem;
                text-align: center;
            }

            .login-header h2 {
                margin: 0;
                font-size: 1.8rem;
                color: white;
            }

            .login-icon {
                font-size: 3rem;
                margin-bottom: 1rem;
            }

            .login-body {
                padding: 2rem;
            }

            /* Form field styles - completely redesigned */
            .form-group {
                margin-bottom: 1.5rem;
                position: relative;
            }

            .form-label {
                display: block;
                margin-bottom: 0.5rem;
                font-weight: 500;
                color: #333;
            }

            /* Position the icon within the boundary of the input */
            .form-input {
                width: 100%;
                padding: 0.75rem 1rem;
                padding-right: 40px;
                /* Make room for the icon */
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

            /* Direct sibling positioning for icons */
            .form-input+.form-icon,
            .form-input+.password-toggle {
                position: absolute;
                top: 50%;
                transform: translateY(-25%);
                right: 12px;
                color: #777;
                z-index: 1;
            }

            .password-toggle {
                cursor: pointer;
            }

            .password-toggle:hover {
                color: var(--primary-color);
            }

            .checkbox-container {
                display: flex;
                justify-content: space-between;
                align-items: center;
                margin-bottom: 1.5rem;
            }

            .checkbox-wrapper {
                display: flex;
                align-items: center;
            }

            .checkbox-wrapper input {
                margin-right: 8px;
            }

            .forgot-link {
                color: var(--primary-color);
                text-decoration: none;
                transition: color 0.3s;
            }

            .forgot-link:hover {
                color: var(--secondary-color);
                text-decoration: underline;
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

            .error-container {
                margin-bottom: 1.5rem;
                padding: 0.75rem;
                border: 1px solid #f44336;
                border-radius: 5px;
                background-color: #ffebee;
                color: #d32f2f;
                display: block;
                margin: 1rem auto;
                max-width: 450px;
            }

            .error-message {
                margin: 0;
                font-size: 0.875rem;
            }
        </style>
    </asp:Content>

    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="login-container">
            <div class="login-header">
                <div class="login-icon"><i class="fas fa-user-circle"></i></div>
                <h2>Đăng Nhập</h2>
            </div>
            <div class="login-body">
                <div class="form-group">
                    <asp:Label ID="lblUsername" runat="server" CssClass="form-label" Text="Tên người dùng"
                        AssociatedControlID="txtUsername"></asp:Label>
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-input" required></asp:TextBox>
                    <i class="fas fa-user form-icon"></i>
                </div>

                <div class="form-group">
                    <asp:Label ID="lblPassword" runat="server" CssClass="form-label" Text="Mật khẩu"
                        AssociatedControlID="txtPassword"></asp:Label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-input" required>
                    </asp:TextBox>
                    <i class="fas fa-eye password-toggle" onclick="togglePassword('<%=txtPassword.ClientID%>')"></i>
                </div>

                <div class="checkbox-container">
                    <div class="checkbox-wrapper">
                        <asp:CheckBox ID="chkRemember" runat="server" />
                        <asp:Label ID="lblRemember" runat="server" Text="Ghi nhớ đăng nhập"
                            AssociatedControlID="chkRemember"></asp:Label>
                    </div>
                </div>

                <asp:Button ID="btnLogin" runat="server" Text="Đăng Nhập" CssClass="btn btn-gradient btn-block"
                    OnClick="btnLogin_Click" />

                <div class="form-footer">
                    <p>Chưa có tài khoản? <a href="Register.aspx">Đăng ký ngay</a></p>
                </div>
            </div>
        </div>

        <div class="error-container">
            <asp:Label ID="lblError" runat="server" CssClass="error-message" Visible="false" ForeColor="Red">
            </asp:Label>
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