<%@ Page Title="Mượn Sách và Thiết Bị" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="Reserve.aspx.cs" Inherits="ThuQuanWebForm.Reserve" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
        <style>
            /* Basic styles */
            :root {
                --primary-color: #3498db;
                --secondary-color: #2ecc71;
                --dark-color: #333;
            }

            .page-header {
                position: relative;
                padding: 2.5rem 0;
                text-align: center;
                margin-bottom: 2rem;
                background-image: linear-gradient(to right, var(--primary-color), var(--secondary-color));
                border-radius: 10px;
                color: white;
            }

            .page-title {
                font-size: 2.2rem;
                margin-bottom: 0.5rem;
            }

            .search-container {
                max-width: 700px;
                margin: 2rem auto;
            }

            .search-box {
                display: flex;
                background: white;
                border-radius: 50px;
                box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
                overflow: hidden;
                transition: all 0.3s;
                border: 2px solid transparent;
            }

            .search-box:focus-within {
                box-shadow: 0 15px 40px rgba(0, 0, 0, 0.15);
                border-color: var(--primary-color);
            }

            .search-input {
                flex: 1;
                padding: 1rem 1.5rem;
                border: none;
                outline: none;
                font-size: 1rem;
                background: transparent;
            }

            .search-btn {
                background-image: linear-gradient(to right, var(--primary-color), var(--secondary-color));
                color: white;
                border: none;
                padding: 0.75rem 1.5rem;
                cursor: pointer;
                font-size: 1rem;
                display: flex;
                align-items: center;
                gap: 0.5rem;
                transition: all 0.3s;
            }

            .search-btn:hover {
                background-image: linear-gradient(to right, var(--secondary-color), var(--primary-color));
            }

            .filter-options {
                display: flex;
                justify-content: center;
                gap: 0.5rem;
                margin-bottom: 2.5rem;
                flex-wrap: wrap;
            }

            .filter-btn {
                padding: 0.6rem 1.2rem;
                border: none;
                background-color: #f5f5f5;
                border-radius: 30px;
                color: #555;
                font-weight: 500;
                cursor: pointer;
                transition: all 0.3s;
                font-size: 0.9rem;
                display: flex;
                align-items: center;
                gap: 0.5rem;
            }

            .filter-btn:hover,
            .filter-btn.active {
                background-color: var(--primary-color);
                color: white;
                box-shadow: 0 5px 15px rgba(52, 152, 219, 0.3);
            }

            .item-grid {
                display: grid;
                grid-template-columns: repeat(auto-fill, minmax(280px, 1fr));
                gap: 2rem;
                margin-bottom: 2rem;
            }

            .item-card {
                border-radius: 12px;
                overflow: hidden;
                box-shadow: 0 10px 30px rgba(0, 0, 0, 0.07);
                transition: transform 0.4s, box-shadow 0.4s;
                background: white;
                position: relative;
                animation: fadeIn 0.6s ease backwards;
            }

            .item-card:hover {
                transform: translateY(-15px);
                box-shadow: 0 20px 40px rgba(0, 0, 0, 0.15);
            }

            .item-img {
                height: 200px;
                overflow: hidden;
                position: relative;
            }

            .item-img::after {
                content: "";
                position: absolute;
                bottom: 0;
                left: 0;
                width: 100%;
                height: 30%;
                background-image: linear-gradient(to top, rgba(0, 0, 0, 0.6), transparent);
            }

            .item-img img {
                width: 100%;
                height: 100%;
                object-fit: cover;
                transition: transform 0.5s;
            }

            .item-card:hover .item-img img {
                transform: scale(1.1);
            }

            .item-info {
                padding: 1.5rem;
                position: relative;
            }

            .item-status {
                position: absolute;
                top: -15px;
                right: 15px;
                padding: 0.4rem 1rem;
                border-radius: 20px;
                font-size: 0.8rem;
                font-weight: bold;
                text-transform: uppercase;
                z-index: 2;
                box-shadow: 0 5px 15px rgba(0, 0, 0, 0.1);
            }

            .status-available {
                background-color: #d5f5e3;
                color: #27ae60;
            }

            .status-borrowed {
                background-color: #fadbd8;
                color: #c0392b;
            }

            .status-reserved {
                background-color: #fef9e7;
                color: #f39c12;
            }

            .item-name {
                font-size: 1.4rem;
                margin-bottom: 0.6rem;
                color: var(--dark-color);
            }

            .item-description {
                color: #555;
                margin-bottom: 1.5rem;
                font-size: 0.95rem;
                line-height: 1.5;
            }

            .reserve-btn {
                border: none;
                padding: 0.8rem 1.5rem;
                border-radius: 30px;
                font-weight: 600;
                cursor: pointer;
                transition: all 0.3s;
                text-transform: uppercase;
                font-size: 0.85rem;
                letter-spacing: 0.5px;
                display: flex;
                align-items: center;
                justify-content: center;
                gap: 0.5rem;
            }

            .reserve-btn:not(:disabled) {
                background-image: linear-gradient(to right, var(--primary-color), var(--secondary-color));
                color: white;
                box-shadow: 0 5px 15px rgba(52, 152, 219, 0.3);
            }

            .reserve-btn:not(:disabled):hover {
                box-shadow: 0 8px 20px rgba(52, 152, 219, 0.4);
                transform: translateY(-2px);
            }

            .reserve-btn:disabled {
                background-color: #f5f5f5;
                color: #999;
                cursor: not-allowed;
            }

            .item-meta {
                display: flex;
                align-items: center;
                margin-bottom: 1rem;
                font-size: 0.85rem;
                color: #777;
            }

            .meta-item {
                display: flex;
                align-items: center;
                margin-right: 1rem;
            }

            .meta-item i {
                margin-right: 0.4rem;
                color: var(--primary-color);
            }

            .pagination {
                display: flex;
                justify-content: center;
                gap: 0.5rem;
                margin-top: 2rem;
                margin-bottom: 2rem;
            }

            .pagination-btn {
                width: 40px;
                height: 40px;
                display: flex;
                align-items: center;
                justify-content: center;
                border-radius: 50%;
                background-color: white;
                color: #555;
                border: 1px solid #ddd;
                cursor: pointer;
                transition: all 0.3s;
            }

            .pagination-btn:hover,
            .pagination-btn.active {
                background-color: var(--primary-color);
                color: white;
                border-color: var(--primary-color);
                box-shadow: 0 5px 15px rgba(52, 152, 219, 0.3);
            }

            @keyframes fadeIn {
                from {
                    opacity: 0;
                    transform: translateY(20px);
                }

                to {
                    opacity: 1;
                    transform: translateY(0);
                }
            }

            /* Apply animation with delays */
            .item-card:nth-child(1) {
                animation-delay: 0.1s;
            }

            .item-card:nth-child(2) {
                animation-delay: 0.2s;
            }

            .item-card:nth-child(3) {
                animation-delay: 0.3s;
            }

            .item-card:nth-child(4) {
                animation-delay: 0.4s;
            }

            .item-card:nth-child(5) {
                animation-delay: 0.5s;
            }

            .item-card:nth-child(6) {
                animation-delay: 0.6s;
            }

            /* Modal Styles */
            .reservation-modal {
                display: none;
                position: fixed;
                top: 0;
                left: 0;
                width: 100%;
                height: 100%;
                background-color: rgba(0, 0, 0, 0.5);
                z-index: 1000;
                align-items: center;
                justify-content: center;
            }

            .reservation-modal.show {
                display: flex;
            }

            .modal-content {
                background-color: white;
                border-radius: 10px;
                padding: 30px;
                width: 450px;
                max-width: 90%;
                box-shadow: 0 15px 40px rgba(0, 0, 0, 0.2);
            }

            .modal-header {
                margin-bottom: 20px;
            }

            .modal-header h2 {
                color: var(--primary-color);
                margin: 0;
                font-size: 1.8rem;
            }

            .modal-body {
                margin-bottom: 20px;
            }

            .form-group {
                margin-bottom: 20px;
            }

            .form-group label {
                display: block;
                margin-bottom: 5px;
                font-weight: 500;
                color: var(--dark-color);
            }

            .time-display {
                padding: 10px 15px;
                background-color: #f9f9f9;
                border: 1px solid #e0e0e0;
                border-radius: 5px;
                font-weight: 500;
            }

            .modal-footer {
                display: flex;
                justify-content: flex-end;
                gap: 10px;
            }

            .btn-cancel {
                background-color: #e0e0e0;
                color: #555;
                border: none;
                padding: 10px 20px;
                border-radius: 5px;
                cursor: pointer;
                font-weight: 500;
                transition: all 0.3s;
            }

            .btn-cancel:hover {
                background-color: #d0d0d0;
            }

            .btn-confirm {
                background-image: linear-gradient(to right, var(--primary-color), var(--secondary-color));
                color: white;
                border: none;
                padding: 10px 20px;
                border-radius: 5px;
                cursor: pointer;
                font-weight: 500;
                transition: all 0.3s;
            }

            .btn-confirm:hover {
                box-shadow: 0 5px 15px rgba(52, 152, 219, 0.3);
            }
        </style>
    </asp:Content>

    <asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <div class="page-header">
            <h1 class="page-title">Mượn Sách và Thiết Bị</h1>
            <p>Khám phá và mượn sách và các thiết bị công nghệ cho việc học tập và nghiên cứu của bạn</p>
        </div>

        <div class="search-container container my-4">
            <div class="row justify-content-center">
                <div class="col-md-8">
                    <div class="input-group">
                        <asp:TextBox ID="itemSearchTextBox" runat="server" CssClass="form-control"
                            placeholder="Nhập tên sách, thiết bị hoặc từ khóa..." />
                        <asp:Button ID="SearchButton" runat="server" Text="Tìm kiếm" CssClass="btn btn-primary"
                            OnClick="SearchButton_Click" />
                    </div>
                </div>
            </div>
        </div>

        <div class="filter-options">
            <asp:LinkButton ID="FilterAllButton" runat="server" CssClass="filter-btn active"
                OnClick="FilterButton_Click" CommandArgument="all"
                OnClientClick="filterItemsClient('all', event); return true;">
                <i class="fas fa-list"></i> Tất cả
            </asp:LinkButton>
            <asp:LinkButton ID="FilterAvailableButton" runat="server" CssClass="filter-btn" OnClick="FilterButton_Click"
                CommandArgument="available" OnClientClick="filterItemsClient('available', event); return true;">
                <i class="fas fa-check-circle"></i> Có sẵn
            </asp:LinkButton>
            <asp:LinkButton ID="FilterBooksButton" runat="server" CssClass="filter-btn" OnClick="FilterButton_Click"
                CommandArgument="books" OnClientClick="filterItemsClient('books', event); return true;">
                <i class="fas fa-book"></i> Sách
            </asp:LinkButton>
            <asp:LinkButton ID="FilterDevicesButton" runat="server" CssClass="filter-btn" OnClick="FilterButton_Click"
                CommandArgument="devices" OnClientClick="filterItemsClient('devices', event); return true;">
                <i class="fas fa-laptop"></i> Thiết bị
            </asp:LinkButton>
        </div>

        <!-- Repeater control -->
        <div class="item-grid">
            <asp:Repeater ID="ItemRepeater" runat="server" OnItemCommand="ItemRepeater_ItemCommand">
                <ItemTemplate>
                    <div class="item-card" data-type='<%# Eval("ItemType") %>'>
                        <div class="item-img">
                            <img src='<%# Eval("ImageUrl") %>' alt='<%# Eval("ItemName") %>'>
                        </div>
                        <div class="item-info">
                            <span class='item-status <%# Eval("StatusCssClass") %>'>
                                <%# Eval("StatusText") %>
                            </span>
                            <h3 class="item-name">
                                <%# Eval("ItemName") %>
                            </h3>
                            <div class="item-meta">
                                <%# (string)Eval("ItemType")=="book"
                                    ? "<span class='meta-item'><i class='fas fa-user-edit'></i> " + Eval("Author")
                                    + "</span>" : "" %>
                                    <%# (string)Eval("ItemType")=="book"
                                        ? "<span class='meta-item'><i class='fas fa-calendar'></i> " + Eval("Year")
                                        + "</span>" : "" %>
                                        <%# (string)Eval("ItemType")=="device"
                                            ? "<span class='meta-item'><i class='fas fa-microchip'></i> " +
                                            Eval("Spec1") + "</span>" : "" %>
                                            <%# (string)Eval("ItemType")=="device"
                                                ? "<span class='meta-item'><i class='fas fa-memory'></i> " +
                                                Eval("Spec2") + "</span>" : "" %>
                            </div>
                            <p class="item-description">
                                <%# Eval("Description") %>
                            </p>
                            <asp:Button runat="server" CssClass="reserve-btn"
                                Text='<%# (bool)Eval("IsAvailable") ? ((string)Eval("ItemType") == "book" ? "Mượn sách" : "Mượn thiết bị") : "Đang mượn" %>'
                                CommandName="Borrow" CommandArgument='<%# Eval("ItemType") + ":" + Eval("ItemID") %>'
                                Enabled='<%# (bool)Eval("IsAvailable") %>' OnClientClick='<%# "showReservationModal(" + 
                                    "\"" + Eval("ItemType") + "\", " + 
                                    "\"" + Eval("ItemID") + "\", " + 
                                    "\"" + Eval("ItemName") + "\"); return false;" %>' />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

        <!-- Updated Pagination Controls with Server-side Paging -->
        <div class="pagination">
            <asp:LinkButton ID="PrevPageButton" runat="server" CssClass="pagination-btn"
                OnClick="PaginationButton_Click" CommandArgument="prev" ToolTip="Trang trước">
                <i class="fas fa-chevron-left"></i>
            </asp:LinkButton>

            <asp:Repeater ID="PaginationRepeater" runat="server" OnItemCommand="PaginationRepeater_ItemCommand">
                <ItemTemplate>
                    <asp:LinkButton ID="PageNumberButton" runat="server"
                        CssClass='<%# ((int)Container.DataItem == CurrentPage) ? "pagination-btn active" : "pagination-btn" %>'
                        CommandName="GoToPage" CommandArgument='<%# Container.DataItem %>'
                        Text='<%# Container.DataItem %>' />
                </ItemTemplate>
            </asp:Repeater>

            <asp:LinkButton ID="NextPageButton" runat="server" CssClass="pagination-btn"
                OnClick="PaginationButton_Click" CommandArgument="next" ToolTip="Trang kế">
                <i class="fas fa-chevron-right"></i>
            </asp:LinkButton>
        </div>

        <!-- Add the reservation modal dialog -->
        <div id="reservationModal" class="reservation-modal">
            <div class="modal-content">
                <div class="modal-header">
                    <h2 id="modalTitle">Đặt lịch mượn</h2>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <label for="<%= startDateTimeControl.ClientID %>">Thời gian bắt đầu mượn (để trống sẽ dùng thời
                            gian hiện tại):</label>
                        <asp:TextBox ID="startDateTimeControl" runat="server" CssClass="form-control"
                            TextMode="DateTimeLocal" min=""></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="<%= endDateTimeControl.ClientID %>">Thời gian trả (có thể gia hạn sau):</label>
                        <asp:TextBox ID="endDateTimeControl" runat="server" CssClass="form-control"
                            TextMode="DateTimeLocal"></asp:TextBox>
                    </div>
                    <asp:HiddenField ID="itemTypeHidden" runat="server" />
                    <asp:HiddenField ID="itemIDHidden" runat="server" />
                </div>
                <div class="modal-footer">
                    <button type="button" id="cancelReservation" class="btn-cancel">Hủy</button>
                    <asp:Button ID="confirmReservation" runat="server" Text="Xác nhận" CssClass="btn-confirm"
                        OnClick="ConfirmReservation_Click" />
                </div>
            </div>
        </div>

        <script type="text/javascript">
            function filterItemsClient(filter, event) {
                if (event && event.currentTarget) {
                    const filterButtons = document.querySelectorAll('.filter-options .filter-btn');
                    filterButtons.forEach(btn => btn.classList.remove('active'));
                    event.currentTarget.classList.add('active');
                }
            }

            // Add functionality for reservation modal
            document.addEventListener('DOMContentLoaded', function () {
                const modal = document.getElementById('reservationModal');
                const cancelBtn = document.getElementById('cancelReservation');
                const startDateTimeControl = document.getElementById('<%= startDateTimeControl.ClientID %>');
                const endDateTimeControl = document.getElementById('<%= endDateTimeControl.ClientID %>');

                // Close modal when cancel button is clicked
                cancelBtn.addEventListener('click', function () {
                    modal.classList.remove('show');
                });

                // Set default end time when start time changes
                startDateTimeControl.addEventListener('change', function () {
                    if (this.value) {
                        const startDate = new Date(this.value);
                        const suggestedEndDate = new Date(startDate.getTime() + (2 * 60 * 60 * 1000)); // Add 2 hours as suggestion

                        // Format for datetime-local input (YYYY-MM-DDThh:mm)
                        endDateTimeControl.value = suggestedEndDate.toISOString().slice(0, 16);

                        // Set min attribute on end date to be the start date
                        endDateTimeControl.setAttribute('min', this.value);
                    }
                });

                // Also validate end date when it changes
                endDateTimeControl.addEventListener('change', function () {
                    const startValue = startDateTimeControl.value;
                    if (startValue && this.value) {
                        const startDate = new Date(startValue);
                        const endDate = new Date(this.value);

                        // If end date is before start date, reset to start date + 2 hours
                        if (endDate < startDate) {
                            const suggestedEndDate = new Date(startDate.getTime() + (2 * 60 * 60 * 1000));
                            this.value = suggestedEndDate.toISOString().slice(0, 16);
                            alert("Thời gian trả không thể sớm hơn thời gian mượn.");
                        }
                    }
                });

                // Set initial date time to current time
                function setInitialDateTime() {
                    const now = new Date();

                    // Format datetime-local input value (YYYY-MM-DDThh:mm)
                    const year = now.getFullYear();
                    const month = String(now.getMonth() + 1).padStart(2, '0');
                    const day = String(now.getDate()).padStart(2, '0');
                    const hours = String(now.getHours()).padStart(2, '0');
                    const minutes = String(now.getMinutes()).padStart(2, '0');

                    // Set today as the minimum selectable date
                    const todayMin = `${year}-${month}-${day}T00:00`;
                    startDateTimeControl.setAttribute('min', todayMin);

                    const formattedDateTime = `${year}-${month}-${day}T${hours}:${minutes}`;
                    startDateTimeControl.value = formattedDateTime;

                    // Set suggested end time (2 hours from now)
                    const suggestedEnd = new Date(now.getTime() + (2 * 60 * 60 * 1000));
                    const endYear = suggestedEnd.getFullYear();
                    const endMonth = String(suggestedEnd.getMonth() + 1).padStart(2, '0');
                    const endDay = String(suggestedEnd.getDate()).padStart(2, '0');
                    const endHours = String(suggestedEnd.getHours()).padStart(2, '0');
                    const endMinutes = String(suggestedEnd.getMinutes()).padStart(2, '0');

                    endDateTimeControl.value = `${endYear}-${endMonth}-${endDay}T${endHours}:${endMinutes}`;
                }

                // Function to show modal with item information
                window.showReservationModal = function (itemType, itemId, itemName) {
                    // Set hidden fields
                    document.getElementById('<%= itemTypeHidden.ClientID %>').value = itemType;
                    document.getElementById('<%= itemIDHidden.ClientID %>').value = itemId;

                    // Set modal title based on item type
                    const modalTitle = document.getElementById('modalTitle');
                    modalTitle.textContent = itemType === 'book' ? 'Đặt lịch mượn sách' : 'Đặt lịch mượn thiết bị';

                    // Set initial datetime
                    setInitialDateTime();

                    // Show the modal
                    modal.classList.add('show');
                }
            });
        </script>
    </asp:Content>