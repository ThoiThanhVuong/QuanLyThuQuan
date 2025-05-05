<%@ Page Title="Trang Chủ" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ThuQuanWebForm._Default" %>

    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <main>
            <!-- Hero Section -->
            <div class="hero-section">
                <div class="hero-content">
                    <h1 class="hero-title">Chào mừng đến với Thư Quán SV</h1>
                    <p class="hero-description">Hệ thống quản lý thư quán hiện đại giúp sinh viên dễ dàng mượn và trả
                        thiết bị</p>
                    <div class="hero-buttons">
                        <a href="Reserve.aspx" class="btn btn-gradient">
                            <i class="fas fa-search"></i> Tìm Thiết Bị
                        </a>
                        <a href="Register.aspx" class="btn btn-success">
                            <i class="fas fa-user-plus"></i> Đăng Ký Ngay
                        </a>
                    </div>
                </div>
            </div>

            <!-- Features Section -->
            <h2 class="section-title">Dịch Vụ Của Chúng Tôi</h2>
            <div class="row">
                <div class="col-md-4">
                    <div class="feature-card">
                        <div class="feature-icon">
                            <i class="fas fa-user-plus"></i>
                        </div>
                        <h3 class="feature-title">Đăng Ký Tài Khoản</h3>
                        <p class="feature-description">Dễ dàng đăng ký tài khoản thành viên online với mã số sinh viên.
                        </p>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="feature-card">
                        <div class="feature-icon">
                            <i class="fas fa-search"></i>
                        </div>
                        <h3 class="feature-title">Tìm Thiết Bị</h3>
                        <p class="feature-description">Tìm kiếm các thiết bị có sẵn và đặt chỗ mượn thiết bị nhanh
                            chóng.</p>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="feature-card">
                        <div class="feature-icon">
                            <i class="fas fa-history"></i>
                        </div>
                        <h3 class="feature-title">Quản Lý Hồ Sơ</h3>
                        <p class="feature-description">Xem lịch sử mượn trả, thông tin cá nhân và theo dõi các thiết bị
                            đã đặt chỗ.</p>
                    </div>
                </div>
            </div>

            <!-- Process Section -->
            <div class="process-section">
                <h2 class="section-title">Quy Trình Mượn Thiết Bị</h2>
                <div class="process-timeline">
                    <div class="process-step">
                        <div class="process-number">1</div>
                        <div class="spacer"></div>
                        <div class="process-content">
                            <h3 class="process-title">Đăng Ký / Đăng Nhập</h3>
                            <p class="process-description">Đăng ký tài khoản thành viên với mã số sinh viên hoặc đăng
                                nhập nếu đã có tài khoản.</p>
                        </div>
                    </div>

                    <div class="process-step">
                        <div class="process-number">2</div>
                        <div class="spacer"></div>
                        <div class="process-content">
                            <h3 class="process-title">Tìm Thiết Bị</h3>
                            <p class="process-description">Tìm kiếm thiết bị mong muốn bằng cách sử dụng công cụ tìm
                                kiếm.</p>
                        </div>
                    </div>

                    <div class="process-step">
                        <div class="process-number">3</div>
                        <div class="spacer"></div>
                        <div class="process-content">
                            <h3 class="process-title">Đặt Chỗ Thiết Bị</h3>
                            <p class="process-description">Đặt chỗ thiết bị nếu thiết bị đó đang có sẵn và chưa được
                                mượn hoặc đặt chỗ bởi người khác.</p>
                        </div>
                    </div>

                    <div class="process-step">
                        <div class="process-number">4</div>
                        <div class="spacer"></div>
                        <div class="process-content">
                            <h3 class="process-title">Đến Mượn Thiết Bị</h3>
                            <p class="process-description">Đến thư quán với thẻ sinh viên để mượn thiết bị đã đặt chỗ.
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </main>

    </asp:Content>