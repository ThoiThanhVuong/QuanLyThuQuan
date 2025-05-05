CREATE DATABASE IF NOT EXISTS `QuanLyThuQuan` 
  /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `QuanLyThuQuan`;

-- ========================= Bảng Member =========================
CREATE TABLE IF NOT EXISTS `Member` (
  `MemberID` INT AUTO_INCREMENT NOT NULL ,
  `FullName` VARCHAR(255) NOT NULL,
  `Email` VARCHAR(255) NOT NULL UNIQUE,
  `PhoneNumber` VARCHAR(20) NOT NULL,
  `UserName` VARCHAR(255) NOT NULL UNIQUE,
  `Password` VARCHAR(255) NOT NULL,
  `RegistrationDate` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `UserType` ENUM('Admin','User','Librarian') NOT NULL,
  `Status` ENUM('Active','Inactive') NOT NULL DEFAULT 'Active',
  PRIMARY KEY (`MemberID`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=UTF8MB4_GENERAL_CI;

-- Value Member
INSERT INTO `Member` (`FullName`,`Email`,`PhoneNumber`,`UserName`,`Password`,`RegistrationDate`,`UserType`)
		VALUES('Admin','Admin@gmai.com','0123456789','Admin','Admin','2025-01-01 06:00:00','Admin'),
				('Librarian','Librarian@gmail.com','0987654321','Librarian','Librarian','2025-01-01 06:00:00','Librarian'),
				('User1','User1@gmail.com','0334455112','User2','abc12345',DEFAULT,'User'),
				('Thanh Vương','ThanhVuong@gmail.com','0334456212','ThanhVuong','abc12345',DEFAULT,'User');

-- ===================================== Bảng Categories ===========================================
CREATE TABLE IF NOT EXISTS `Categories` (
    `CategoryID` INT AUTO_INCREMENT PRIMARY KEY,
    `CategoryName` VARCHAR(100) NOT NULL,
    `CategoryStatus` ENUM('Active', 'Inactive') NOT NULL DEFAULT 'Active'
);
-- value Categories
INSERT INTO `Categories` (`CategoryName`)
VALUES 
('Kinh Tế - Quản Lý'),
('Tâm Lý - Kỹ Năng Sống'),
('Tiểu Thuyết - Văn Học'),
('Khoa Học - Viễn Tưởng'),
('Văn Hóa - Lịch Sử');

-- ===================================== Bảng Authors ===========================================
CREATE TABLE `Authors` (
    `AuthorID` INT AUTO_INCREMENT PRIMARY KEY,
    `AuthorName` VARCHAR(255) NOT NULL UNIQUE,
    `AuthorStatus` ENUM('Active','Inactive') NOT NULL DEFAULT 'Active'
);
INSERT INTO `Authors` (`AuthorName`)
VALUES 
('Adam Grant'),
('Adam Khoo'),
('Aleksandr Solzhenitsyn'),
('Alexander Dumas'),
('Anthony Robbins'),
('Barbara Dunlop'),
('Buck, Pearl S'),
('Camilo Cruz'),
('Christopher McDougall'),
('Cao Hành Kiện'),
('Dan Ariely'),
('Dan Roam'),
('David Niven'),
('Douglas Adams'),
('Douglas Brinkley'),
('H. G. Wells'),
('James Oliver Curwood'),
('Jeffrey E. Garten'),
('Jim Collins - Jerry I. Porras'),
('Jim Collins - Morten T. Hansen'),
('Jules Verne'),
('Kim Dung'),
('Kim Thác Đao'),
('Laurent Divers'),
('Lưu Từ Hân'),
('Michael Cunningham'),
('Michael Roach'),
('Michael Sandel'),
('Michio Kaku'),
('Napoleon Hill'),
('Ray Bradbury'),
('Robin Sharma'),
('Roy Garn'),
('Spencer Johnson'),
('Stephen R.Covey'),
('Steven S. Little'),
('Ts. Nguyễn Minh Kiều'),
('Alexandre Dumas'),
('Phùng Mộng Long');

-- ========================= Bảng Books =========================
CREATE TABLE IF NOT EXISTS `Books` (
  `BookID` INT AUTO_INCREMENT NOT NULL ,
  `BookTitle` VARCHAR(255) NOT NULL,
  `AuthorID` INT NOT NULL,
  `BookImage` VARCHAR(255) NOT NULL,
  `CategoryID` INT NOT NULL,
  `PublishYear` INT NOT NULL,
  `Quantity` INT NOT NULL CHECK (`Quantity` >= 0) ,
	`fee_per_day` INT DEFAULT 10000,
  `Status` ENUM('Available', 'OutOf','Unavailable') NOT NULL DEFAULT 'Available',
  PRIMARY KEY (`BookID`),
  FOREIGN KEY (`CategoryID`) REFERENCES `Categories`(`CategoryID`)
        ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (`AuthorID`) REFERENCES `Authors`(`AuthorID`)
        ON DELETE CASCADE ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=UTF8MB4_GENERAL_CI;

-- Value Books
INSERT INTO `Books` (`BookTitle`,`AuthorID`,`BookImage`,`CategoryID`,`PublishYear`,`Quantity`)
	VALUES('Bí Quyết Thành Công Của Steve Jobs',23,'BiQuyetThanhCongCuaSteveJobs.jpg',1,2011,10),
			('Ai Lấy Miếng Pho Mát Của Tôi?',34,'AiLayMiengPhoMatCuaToi.jpg',2,2021,10),
			('Ba Người Lính Ngự Lâm',4,'BaNguoiLinhNguLam.jpg',3,2019,10),
			('Các Thế Giới Song Song',29,'CacTheGioiSongSong.jpg',4,2024,10),
			('Bí Quyết Thành Công Của Napoleon Hill',30,'BiQuyetThanhCongCuaNapoleonHill.jpg',1,2021,10),
			('Bí Quyết Thành Công của Henry Ford',15,'BiQuyetThanhCongcuaHenryFord.jpg',1,2011,10),
			('7 Nguyên Tắc Bất Biến Để Xây Dựng Doanh Nghiệp Nhỏ',36,'7NguyenTacBatBienDeXayDungDoanhNghiepNho.jpg',1,2023,10),
			('Thiên Long Bát Bộ',22,'ThienLongBatBo.jpg',3,1963,10),
			('Chú Chó Kazan',17,'ChuChoKazan.jpg',3,2022,10),
			('Truyền Thuyết Về Mộc Lan',24,'TruyenThuyetVeMocLan.jpg',3,1939,10),
			('Bản Chất Của Dối Trá',11,'BanChatCuaDoiTra.jpg',2,2014,10),
			('Từ Hy Thái Hậu',7,'TuHyThaiHau.jpg',5,1911,10),
			('Từ Tơ Lụa Đến Silicon',18,'TuToLuaDenSilicon.jpg',1,2017,10),
			('Vĩ Đại Do Lựa Chọn',20,'ViDaiDoLuaChon.jpg',1,2011,10),
			('Xây Dựng Để Trường Tồn',19,'XayDungDeTruongTon.jpg',1,1994,10),
			('Giáo Trình Tiền Tệ Ngân Hàng',37,'GiaoTrinhTienTeNganHang.jpg',1,2017,10),
			('Chỉ Cần Mẩu Khăn Giấy',12,'ChiCanMauKhanGiay.jpg',1,2013,10),
			('Cho Khế Nhận Vàng',1,'ChoKheNhanVang.jpg',1,2021,10),
			('Tiền Không Mua Được Gì?',28,'TienKhongMuaDuocGi.jpg',1,2019,10),
			('Đông Chu Liệt Quốc',39,'DongChuLietQuoc.jpg',3,1998,10),
			('Kinh Thánh Của Một Người',10,'KinhThanhCuaMotNguoi.jpg',3,2006,10),
			('Tầng Đầu Địa Ngục',3,'TangDauDiaNguc.jpg',3,1968,10),
			('Tình Yêu Định Mệnh',38,'TinhYeuDinhMenh.jpg',3,2019,10),
			('Cuộc Ngã Giá Của Nhà Tỷ Phú',6,'CuocNgaGiaCuaNhaTyPhu.jpg',3,2023,10),
			('Tổ Ấm Nơi Tận Cùng Thế Giới',26,'ToAmNoiTanCungTheGioi.jpg',3,2010,10),
			('Tử huyệt cảm xúc',33,'TuHuyetCamXuc.jpg',2,2022,10),
			('Ngày xưa có một con bò',8,'NgayXuaCoMotConBo.jpg',2,2013,10),
			('Bí quyết tay trắng thành triệu phú',2,'BiQuyetTayTrangThanhTrieuPhu.jpg',2,2009,10),
			('Năng Đoạn Kim Cương',27,'NangDoanKimCuong.jpg',2,2022,10),
			('7 Thói Quen Để Thành Đạt',35,'7ThoiQuenDeThanhDat.jpg',2,1998,10),
			('Sinh Ra Để Chạy',9,'SinhRaDeChay.jpg',2,2023,10),
			('Bí Mật Hành Trình Tình Yêu',13,'BiMatHanhTrinhTinhYeu.jpg',2,2017,10),
			('Đời Ngắn Đừng Ngủ Dài',32,'DoiNganDungNguDai.jpg',2,2014,10),
			('Đánh Thức Năng Lực Vô Hạn',5,'DanhThucNangLucVoHan.jpg',2,2015,10),
			('Tam Thể',25,'TamThe.jpg',4,2006,10),
			('Hai Vạn Dặm Dưới Đáy Biển',21,'HaiVanDamDuoiDayBien.jpg',4,1870,10),
			('Hành trình vào tâm Trái Đất',21,'HanhTrinhVaoTamTraiDat.jpg',4,1864,10),
			('Bí kíp quá giang vào Ngân Hà',13,'BiKipQuaGiangVaoNganHa.jpg',4,1979,10),
			('Cỗ máy thời gian',16,'CoMayThoiGian.jpg',4,1895,10),
			('451 Độ F',31,'451DoF.jpg',4,2021,10);
-- ========================= Bảng Devices ===========================
CREATE TABLE IF NOT EXISTS `Devices` (
  `DeviceID` INT AUTO_INCREMENT NOT NULL ,
  `DeviceName` VARCHAR(255) NOT NULL,
  `DeviceImage` VARCHAR(255) NOT NULL,
  `DeviceType` VARCHAR(100) NOT NULL,
  `Quantity` INT NOT NULL CHECK (`Quantity` >= 0),
  `fee_per_hour` INT DEFAULT 5000,
  `Status` ENUM('Available', 'OutOf','Unavailable') NOT NULL DEFAULT 'Available',
  PRIMARY KEY (`DeviceID`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=UTF8MB4_GENERAL_CI;

-- Values Devices
INSERT INTO `Devices` (`DeviceName`,`DeviceImage`,`DeviceType`,`Quantity`)
		VALUES ('Laptop Dell Latitude','LaptopDell.jpg','Laptop',10),
				 ('Máy in Cannon LBP','MayInCannon.jpg','Printer',5),
				 ('Máy in laser màu Cannon','MayInMauLaser.jpg','Printer',5),
				 ('Máy chiếu Panasonic','MayChieuPanasonic.jpg','Projector',8),
				 ('Máy chiếu ACER','MayChieuACER.jpg','Projector',6),
				 ('Bút thuyết trình','ButThuyetTrinh.jpg','Projector',10),
				 ('Màn hình trình chiếu','ManHinhChieu.jpg','Projector',10),
				 ('Máy Scan Plustek','MayScan.jpg','Scanner',4),
				 ('Ổ cắm điện','OCamDien.jpg','Power Outlet',14),
				 ('Bàn đọc sách','BanDocSach.jpg','Furniture',7),
				 ('Bàn ghế xếp gọn','BanGheXepGon.jpg','Furniture',5);
				 
-- ========================= Bảng Transactions =========================
-- dùng để mượn trả thiết bị ,có ngày mượn, hạn trả, ngày trả thực tế

CREATE TABLE IF NOT EXISTS `Transactions` (
  `TransactionID` INT AUTO_INCREMENT NOT NULL ,
  `MemberID` INT NOT NULL,
   `TransactionType` ENUM('Borrow', 'Return') NOT NULL,
  `TransactionDate` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `DueDate` DATETIME NULL CHECK (`DueDate` IS NULL OR `DueDate` >= `TransactionDate`),
  `ReturnDate` DATETIME NULL CHECK(`ReturnDate`>= `TransactionDate`)  ,
  `Status` ENUM('Active', 'Completed', 'Overdue') NOT NULL DEFAULT 'Active',
  PRIMARY KEY (`TransactionID`),
	INDEX (`MemberID`),
  FOREIGN KEY (`MemberID`) REFERENCES `Member`(`MemberID`) 
    ON DELETE CASCADE ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=UTF8MB4_GENERAL_CI;
-- Values Transactions 
INSERT INTO `Transactions`(`MemberID`,`TransactionType`,`TransactionDate`,`DueDate`,`ReturnDate`,`Status`)
		VALUES(3,'Borrow', '2025-02-03 11:00:00', '2025-02-13 11:00:00', '2025-02-12 11:00:00', 'Completed'),
				(4,'Borrow', '2025-02-04 08:30:00', '2025-02-14 08:30:00', '2025-02-15 08:00:00', 'Completed'),
				(4,'Borrow', '2025-02-06 08:00:00', '2025-02-18 08:30:00', '2025-02-16 08:00:00', 'Completed'),
				(3,'Borrow', '2025-02-20 07:00:00', '2025-02-27 15:00:00', '2025-02-27 13:00:00', 'Completed'),
				(3,'Borrow', '2025-03-01 07:00:00', '2025-03-01 16:00:00', '2025-03-01 15:30:00', 'Completed'),
				(4,'Borrow', '2025-03-02 08:00:00', '2025-03-10 08:30:00', '2025-03-11 08:00:00', 'Completed'),
				(3,'Borrow','2025-04-25 08:00:00','2025-04-29 08:00:00',NULL,'Active');
				
-- ===================================== Bảng TransactionItems ================================================================
CREATE TABLE IF NOT EXISTS `TransactionItems`(
		`ItemID` INT AUTO_INCREMENT NOT NULL,
		`TransactionID` INT NOT NULL,
		`BookID` INT NULL,
		`DeviceID` INT NULL,
		`Amount` INT NOT NULL CHECK(`Amount` > 0),
		`Status` ENUM('Borrowed', 'Returned') NOT NULL DEFAULT 'Borrowed',
		PRIMARY KEY(`ItemID`),
	FOREIGN KEY (`TransactionID`) REFERENCES `Transactions`(`TransactionID`)
    ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (`BookID`) REFERENCES `Books`(`BookID`) 
    ON DELETE SET NULL ON UPDATE CASCADE,
  FOREIGN KEY (`DeviceID`) REFERENCES `Devices`(`DeviceID`) 
    ON DELETE SET NULL ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=UTF8MB4_GENERAL_CI;

-- Values TransactionItems
INSERT INTO `TransactionItems`(`TransactionID`,`BookID`,`DeviceID`,`Amount`,`Status`)
		VALUES (1,1,NULL,1,'Returned'),
				(1,3,NULL,1,'Returned'),
				(1,4,NULL,1,'Returned'),
				(2,10,NULL,1,'Returned'),
				(2,5,NULL,1,'Returned'),
				(3,7,NULL,1,'Returned'),
				(3,20,NULL,1,'Returned'),
				(3,25,NULL,1,'Returned'),
				(4,22,NULL,1,'Returned'),
				(4,23,NULL,1,'Returned'),
				(4,24,NULL,1,'Returned'),
				(5,NULL,4,1,'Returned'),
				(5,NULL,6,2,'Returned'),
				(5,NULL,7,1,'Returned'),
				(5,NULL,9,2,'Returned'),
				(5,NULL,11,1,'Returned'),
				(6,2,NULL,1,'Returned'),
				(6,40,NULL,1,'Returned'),
				(7,2,NULL,1,'Borrowed'),
				(7,3,NULL,1,'Borrowed'),
				(7,4,NULL,1,'Borrowed');
-- ==================================== Bảng Reservation =======================================================
-- được lưu những đăng ký đặt chỗ thiết bị trước,ghi thời gian bắt đầu - kết thúc và trạng thái (Pending, Confirmed, Cancelled)
CREATE TABLE IF NOT EXISTS `Reservation` (
  `ReservationID` INT AUTO_INCREMENT PRIMARY KEY,
  `MemberID` INT NOT NULL,
  `StartTime` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `EndTime` DATETIME NOT NULL,
  `Status` ENUM('Pending', 'Confirmed', 'Cancelled') DEFAULT 'Pending',
  FOREIGN KEY (`MemberID`) REFERENCES `Member`(`MemberID`) 
    ON DELETE CASCADE ON UPDATE CASCADE
);
INSERT INTO `Reservation` (`MemberID`, `StartTime`, `EndTime`, `Status`)
VALUES 
(3, '2025-04-10 09:00:00', '2025-04-10 11:00:00', 'Confirmed'),
(4, '2025-04-11 14:00:00', '2025-04-11 16:00:00', 'Pending'),
(3, '2025-04-12 08:00:00', '2025-04-12 10:00:00', 'Cancelled');

-- ==================================== Bảng ReservationItems =======================================================
CREATE TABLE IF NOT EXISTS `ReservationItems` (
  `ItemID` INT AUTO_INCREMENT PRIMARY KEY,
  `ReservationID` INT NOT NULL,
  `BookID` INT NULL,
  `DeviceID` INT NULL,
  `Amount` INT NOT NULL CHECK (`Amount` > 0),
  FOREIGN KEY (`ReservationID`) REFERENCES `Reservation`(`ReservationID`)
    ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (`BookID`) REFERENCES `Books`(`BookID`)
    ON DELETE SET NULL ON UPDATE CASCADE,
  FOREIGN KEY (`DeviceID`) REFERENCES `Devices`(`DeviceID`)
    ON DELETE SET NULL ON UPDATE CASCADE
);
INSERT INTO `ReservationItems` (`ReservationID`, `DeviceID`, `Amount`)
VALUES 
(1, 4, 1),  -- Máy chiếu Panasonic
(1,6, 1),  -- Bút thuyết trình
(2, 2, 1),  -- Máy in Cannon
(2, 9, 2),  -- Ổ cắm điện
(3, 10, 1); -- Bàn đọc sách (bị hủy)


-- ================================= Bảng Rules ===============================================
CREATE TABLE IF NOT EXISTS `Rules` (
  `RuleID` INT AUTO_INCREMENT NOT NULL ,
  `RuleTitle` VARCHAR(255) NOT NULL,
  `RuleDescription` TEXT NOT NULL,
  `Penalty` VARCHAR(255) NOT NULL,
  `EffectiveDate` DATETIME NOT NULL,
   `Status` ENUM('Active', 'Inactive') NOT NULL DEFAULT 'Active',
  PRIMARY KEY (`RuleID`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=UTF8MB4_GENERAL_CI;

-- Values Rules
INSERT INTO `Rules` (`RuleTitle`, `RuleDescription`, `Penalty`, `EffectiveDate`) VALUES
('Giữ yên lặng', 'Người dùng phải giữ yên lặng trong khu vực đọc sách.', 'Cảnh cáo lần đầu, cấm vào thư viện 1 tuần nếu tái phạm.', '2025-01-01 08:00:00'),
('Không ăn uống', 'Cấm ăn uống trong khu vực thư viện để bảo vệ sách và tài sản.', 'Cảnh cáo, phạt tiền nếu tái phạm.', '2025-02-01 08:00:00'),
('Trả sách đúng hạn', 'Người dùng phải trả sách đúng thời hạn đã quy định.', 'Phạt tiền 10.000 VND/ngày quá hạn.', '2025-03-01 08:00:00'),
('Không làm hỏng sách', 'Cấm gấp trang, viết hoặc làm rách sách.', 'Bồi thường sách mới.', '2025-01-01 08:00:00'),
('Không sử dụng điện thoại', 'Cấm sử dụng điện thoại ở khu vực yên tĩnh.', 'Cảnh cáo, yêu cầu rời khỏi khu vực.', '2025-01-01 08:00:00'),
('Giữ gìn vệ sinh', 'Người dùng phải giữ vệ sinh chung trong thư viện.', 'Cảnh cáo và yêu cầu làm sạch khu vực.', '2025-03-01 08:00:00'),
('Không chiếm dụng chỗ ngồi', 'Cấm chiếm dụng chỗ ngồi bằng đồ đạc cá nhân.', 'Yêu cầu dọn đồ, cảnh cáo nếu tái phạm.', '2025-03-01 08:00:00'),
('Không gây mất trật tự', 'Cấm gây ồn ào hoặc quấy rối người khác.', 'Yêu cầu rời khỏi thư viện.', '2023-08-01 08:00:00'),
('Sử dụng máy tính đúng mục đích', 'Chỉ sử dụng máy tính cho việc học tập và nghiên cứu.', 'Cấm sử dụng máy tính 1 tuần nếu vi phạm.', '2025-01-01 08:00:00'),
('Không mang vật nuôi vào', 'Cấm mang vật nuôi vào thư viện.', 'Yêu cầu rời khỏi thư viện.', '2025-01-01 08:00:00'),
('Không hút thuốc', 'Cấm hút thuốc trong khuôn viên thư viện.', 'Phạt tiền 200.000 VND.', '2025-02-01 08:00:00'),
('Đăng ký mượn sách đúng quy trình', 'Người dùng phải đăng ký trước khi mượn sách.', 'Không cho mượn sách nếu không đăng ký.', '2025-01-01 08:00:00'),
('Không sao chép tài liệu', 'Cấm sao chép tài liệu có bản quyền.', 'Cấm sử dụng tài liệu 1 tháng.', '2025-01-01 08:00:00'),
('Không sử dụng thiết bị trái phép', 'Cấm sử dụng thiết bị thư viện mà không được phép.', 'Cảnh cáo và yêu cầu rời khỏi khu vực.', '2025-02-01 08:00:00'),
('Tôn trọng nhân viên thư viện', 'Người dùng phải cư xử lịch sự với nhân viên.', 'Cấm vào thư viện 1 tháng nếu xúc phạm.', '2025-03-01 08:00:00');

-- ===================================== Bảng Violation =========================================
-- dùng để lưu trữ những xử lý vi phạm đối với thành viên
CREATE TABLE IF NOT EXISTS `Violation` (
  `ViolationID` INT AUTO_INCREMENT NOT NULL ,
  `MemberID` INT NOT NULL,
  `TransactionID` INT NULL,
  `RuleID` INT NOT NULL,
  `FineAmount` DECIMAL(10, 0) NOT NULL CHECK (`FineAmount` >=0),
  `Reason` VARCHAR(255) NOT NULL,
  `ViolationDate` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `IsCompensationRequired` BOOLEAN DEFAULT FALSE, -- xác định có bồi thường thiết bị/sách không?
  PRIMARY KEY (`ViolationID`),
  FOREIGN KEY (`MemberID`) REFERENCES `Member`(`MemberID`) 
    ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (`TransactionID`) REFERENCES `Transactions`(`TransactionID`) 
    ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (`RuleID`) REFERENCES `Rules`(`RuleID`) 
    ON DELETE CASCADE ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=UTF8MB4_GENERAL_CI;
	
-- Values Violation
INSERT INTO `Violation`(`MemberID`, `TransactionID`, `RuleID`, `FineAmount`, `Reason`, `ViolationDate`)
VALUES (4, 2, 3, 10000, 'Trả sách quá hạn', '2025-02-15 08:00:00');
            

-- ===================================== Bảng Payment ===========================================
-- dùng để ghi nhận số tiền phải thu từ thành viên (liên quan đến vi phạm / mượn phí)
CREATE TABLE `Payment` (
  `PaymentID` INT AUTO_INCREMENT PRIMARY KEY,
  `MemberID` INT NOT NULL,
  `ViolationID` INT NULL, 
  `TransactionID` INT NULL,
  `Amount` DECIMAL(10,0) NOT NULL,
  `Description` VARCHAR(255) NULL,
  `PaymentDate` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Status` ENUM('Paid', 'Unpaid') DEFAULT 'Unpaid',
  FOREIGN KEY (`MemberID`) REFERENCES `Member`(`MemberID`) 
    ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (`ViolationID`) REFERENCES `Violation`(`ViolationID`) 
    ON DELETE SET NULL ON UPDATE CASCADE,
   FOREIGN KEY (`TransactionID`) REFERENCES `Transactions`(`TransactionID`)
    ON DELETE CASCADE ON UPDATE CASCADE
);
INSERT INTO `Payment` (`MemberID`, `ViolationID`, `TransactionID`, `Amount`, `Description`, `Status`)
			VALUES(3,NULL,1,270000,'Phí mượn sách(3 cuốn,9 ngày)','Paid'),
					(4,1,2,210000,'Trả sách quá hạn' ,'Paid'),
					(4, NULL, 3, 300000, 'Phí mượn sách (3 cuốn, 10 ngày)', 'Paid'),
					(3, NULL, 4, 210000, 'Phí mượn sách (3 cuốn, 7 ngày)', 'Paid'),
					(3, NULL, 5, 280000, 'Phí mượn thiết bị (7 thiết bị, 8 giờ)', 'Paid'),
					(4, NULL, 6, 180000, 'Phí mượn sách (2 cuốn, 9 ngày)', 'Paid');


-- ================================ Bảng LoginHistory ================================================================
-- dùng để lưu trữ lịch sử đăng nhập của tài khoản
CREATE TABLE IF NOT EXISTS `LoginHistory` (
  `LoginID` INT AUTO_INCREMENT NOT NULL ,
  `MemberID` INT NOT NULL,
  `LoginTime` DATETIME NOT NULL,
  `LogoutTime` DATETIME NULL,
   `Status` ENUM('Success', 'Failed') NOT NULL,
  PRIMARY KEY (`LoginID`),
  FOREIGN KEY (`MemberID`) REFERENCES `Member`(`MemberID`) 
    ON DELETE CASCADE ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=UTF8MB4_GENERAL_CI;
-- Values LoginHistory
INSERT INTO `LoginHistory`(`MemberID`,`LoginTime`,`LogoutTime`,`Status`)
			VALUES(1,'2025-02-01 08:00:00','2025-02-01 09:00:00','Success'),
					(2,'2025-02-01 09:15:00','2025-02-01 10:15:00','Success');
					
-- ===================================== Bảng StudySession ===========================================
-- Dùng để lưu trữ thời gian thành viên ra vào thư quán
CREATE TABLE `StudySession` (
  `SessionID` INT AUTO_INCREMENT PRIMARY KEY,
  `MemberID` INT NOT NULL,
  `CheckInTime` DATETIME NOT NULL,
  FOREIGN KEY (`MemberID`) REFERENCES `Member`(`MemberID`)
);

INSERT INTO `StudySession` (`MemberID`, `CheckInTime`)
VALUES
(3, '2025-03-05 08:00:00'),
(4, '2025-03-06 13:30:00'),
(3, '2025-03-08 09:00:00');

-- ===================================== Bảng Review ===========================================
CREATE TABLE IF NOT EXISTS `Review` (
  `ReviewID` INT AUTO_INCREMENT NOT NULL ,
  `MemberID` INT NOT NULL,
  `BookID` INT NULL,
  `DeviceID` INT NULL,
  `Rating` INT NOT NULL CHECK(`Rating` BETWEEN 1 AND 5),
  `ReviewText` TEXT NULL,
  `ReviewDate` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ReviewID`),
  INDEX(`BookID`),
  INDEX(`DeviceID`),
  INDEX(`MemberID`),
  FOREIGN KEY (`MemberID`) REFERENCES `Member`(`MemberID`) 
    ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (`BookID`) REFERENCES `Books`(`BookID`) 
    ON DELETE SET NULL ON UPDATE CASCADE,
  FOREIGN KEY (`DeviceID`) REFERENCES `Devices`(`DeviceID`) 
    ON DELETE SET NULL ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `Review` (`MemberID`,`BookID`, `DeviceID`,`Rating`,`ReviewText`,`ReviewDate`)
			VALUES (3, 1,NULL, 5, 'Sách rất hay, nội dung cuốn hút từ đầu đến cuối!', '2025-02-20'),
					(4, 10,NULL,4, 'Nội dung khá thú vị nhưng một số phần hơi khó hiểu.', '2025-02-21'),
					(4, 5,NULL, 3, 'Sách ổn nhưng không như mong đợi.', '2025-02-22'),
					(4, 2,NULL,5, 'Tuyệt vời! Mình học được rất nhiều kiến thức bổ ích.', '2025-02-23'),
					(3, 4,NULL,4, 'Nội dung dễ hiểu và hữu ích cho công việc.', '2025-02-24');

-- ======================================== procedure =================================================================
-- thủ tục chuyển đổi dữ liệu từ bảng Reservations sang bảng transaction
DELIMITER $$

CREATE PROCEDURE TransferConfirmedReservations(
    IN p_ReservationID INT,
    OUT p_TransactionID INT
)
BEGIN
    DECLARE v_MemberID INT;

    -- Lấy MemberID
    SELECT MemberID INTO v_MemberID
    FROM Reservation
    WHERE ReservationID = p_ReservationID;

    -- Tạo Transaction
    INSERT INTO Transactions (MemberID, TransactionType, TransactionDate, Status)
    VALUES (v_MemberID, 'Borrow', NOW(), 'Active');

    SET p_TransactionID = LAST_INSERT_ID();

    -- Chuyển các item
    INSERT INTO TransactionItems (TransactionID, BookID, DeviceID, Amount, Status)
    SELECT p_TransactionID, BookID, DeviceID, Amount, 'Borrowed'
    FROM ReservationItems
    WHERE ReservationID = p_ReservationID;

    -- Cập nhật trạng thái reservation
    UPDATE Reservation
    SET Status = 'Confirmed'
    WHERE ReservationID = p_ReservationID;
END $$

DELIMITER ;


DELIMITER $$
CREATE PROCEDURE ConfirmReturnAndCalculatePayment(IN p_TransactionID INT)
BEGIN
    DECLARE v_MemberID INT;
    DECLARE v_TransactionDate DATETIME;
    DECLARE v_ReturnDate DATETIME;
    DECLARE v_Days INT;
    DECLARE v_Hours INT;
    DECLARE v_FineAmount DECIMAL(10, 0) DEFAULT 0;
    
    -- Lấy thông tin giao dịch
    SELECT MemberID, TransactionDate, COALESCE(ReturnDate, NOW()) 
    INTO v_MemberID, v_TransactionDate, v_ReturnDate
    FROM Transactions
    WHERE TransactionID = p_TransactionID;
    
    -- Tính số ngày và số giờ mượn
    SET v_Days = DATEDIFF(v_ReturnDate, v_TransactionDate);
    SET v_Hours = TIMESTAMPDIFF(HOUR, v_TransactionDate, v_ReturnDate);
    
    -- Cập nhật ReturnDate và Status thành 'Completed'
    UPDATE Transactions
    SET ReturnDate = v_ReturnDate, Status = 'Completed'
    WHERE TransactionID = p_TransactionID;
    
    -- Tính tiền thanh toán từ sách
    INSERT INTO Payment (MemberID, TransactionID, Amount, Description, Status)
    SELECT v_MemberID, p_TransactionID, 
           b.fee_per_day * ti.Amount * v_Days, 
           CONCAT('Thuê sách "', b.BookTitle, '" ', v_Days, ' ngày'), 'Unpaid'
    FROM TransactionItems ti
    JOIN Books b ON b.BookID = ti.BookID
    WHERE ti.TransactionID = p_TransactionID AND
	 		ti.Status = 'Borrowed';
    
    -- Tính tiền thanh toán từ thiết bị
    INSERT INTO Payment (MemberID, TransactionID, Amount, Description, Status)
    SELECT v_MemberID, p_TransactionID, 
           d.fee_per_hour * ti.Amount * v_Hours, 
           CONCAT('Thuê thiết bị "', d.DeviceName, '" ', v_Hours, ' giờ'), 'Unpaid'
    FROM TransactionItems ti
    JOIN Devices d ON d.DeviceID = ti.DeviceID
    WHERE ti.TransactionID = p_TransactionID AND ti.Status = 'Borrowed';

    -- Tính tiền phạt từ Violation nếu có
    INSERT INTO Payment (MemberID, ViolationID, TransactionID, Amount, Description, Status)
    SELECT v.MemberID, v.ViolationID, v.TransactionID, v.FineAmount, 
           CONCAT('Phạt: ', v.Reason), 'Unpaid'
    FROM Violation v
    WHERE v.TransactionID = p_TransactionID AND v.FineAmount > 0;
    
    UPDATE TransactionItems
	SET Status = 'Returned'
	WHERE TransactionID = p_TransactionID AND Status = 'Borrowed';
END$$
DELIMITER ;


-- Trả trước từng món
DELIMITER $$
CREATE PROCEDURE ReturnSingleItem(
    IN p_ItemID INT
)
BEGIN
    DECLARE v_MemberID INT;
    DECLARE v_TransactionID INT;
    DECLARE v_TransactionDate DATETIME;
    DECLARE v_ReturnDate DATETIME DEFAULT NOW();
    DECLARE v_Days INT;
    DECLARE v_Hours INT;
    DECLARE v_Amount INT;
    DECLARE v_fee_per_day INT;
    DECLARE v_fee_per_hour INT;
    DECLARE v_BookTitle VARCHAR(255);
    DECLARE v_DeviceName VARCHAR(255);
    
    -- Lấy thông tin item
    SELECT ti.TransactionID, ti.Amount, t.MemberID, t.TransactionDate
    INTO v_TransactionID, v_Amount, v_MemberID, v_TransactionDate
    FROM TransactionItems ti
    JOIN Transactions t ON t.TransactionID = ti.TransactionID
    WHERE ti.ItemID = p_ItemID;
    
    -- Nếu là sách
    IF EXISTS (SELECT 1 FROM TransactionItems WHERE ItemID = p_ItemID AND BookID IS NOT NULL) THEN
        SELECT BookTitle, fee_per_day INTO v_BookTitle, v_fee_per_day
        FROM Books b
        JOIN TransactionItems ti ON ti.BookID = b.BookID
        WHERE ti.ItemID = p_ItemID;
        
        SET v_Days = DATEDIFF(v_ReturnDate, v_TransactionDate);
        
        INSERT INTO Payment (MemberID, TransactionID, Amount, Description, Status)
        VALUES (v_MemberID, v_TransactionID, v_fee_per_day * v_Days * v_Amount, 
                CONCAT('Trả trước sách "', v_BookTitle, '" ', v_Days, ' ngày'), 'Unpaid');
    END IF;
    
    -- Nếu là thiết bị
    IF EXISTS (SELECT 1 FROM TransactionItems WHERE ItemID = p_ItemID AND DeviceID IS NOT NULL) THEN
        SELECT DeviceName, fee_per_hour INTO v_DeviceName, v_fee_per_hour
        FROM Devices d
        JOIN TransactionItems ti ON ti.DeviceID = d.DeviceID
        WHERE ti.ItemID = p_ItemID;
        
        SET v_Hours = TIMESTAMPDIFF(HOUR, v_TransactionDate, v_ReturnDate);
        
        INSERT INTO Payment (MemberID, TransactionID, Amount, Description, Status)
        VALUES (v_MemberID, v_TransactionID, v_fee_per_hour * v_Hours * v_Amount, 
                CONCAT('Trả trước thiết bị "', v_DeviceName, '" ', v_Hours, ' giờ'), 'Unpaid');
    END IF;
    
    -- Update trạng thái Item đã trả
    UPDATE TransactionItems
    SET Status = 'Returned'
    WHERE ItemID = p_ItemID;
END$$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE UpdateBookQuantityOnBorrow(IN p_BookID INT, IN p_Amount INT)
BEGIN
    DECLARE v_NewQuantity INT;
    DECLARE v_Status VARCHAR(20);

    -- Giảm số lượng
    UPDATE Books
    SET Quantity = Quantity - p_Amount
    WHERE BookID = p_BookID;

    -- Lấy số lượng mới và trạng thái hiện tại
    SELECT Quantity, Status INTO v_NewQuantity, v_Status
    FROM Books
    WHERE BookID = p_BookID;

    -- Nếu số lượng = 0 thì đặt thành OutOf
    IF v_NewQuantity = 0 THEN
        UPDATE Books
        SET Status = 'OutOf'
        WHERE BookID = p_BookID;
    END IF;

    -- Nếu số lượng > 0 và trạng thái là OutOf → chuyển về Available
    IF v_NewQuantity > 0 AND v_Status = 'OutOf' THEN
        UPDATE Books
        SET Status = 'Available'
        WHERE BookID = p_BookID;
    END IF;

END$$
DELIMITER ;



DELIMITER $$
CREATE PROCEDURE UpDateDeviceQuantityOnBorrow(IN p_DeviceID INT, IN p_Amount INT)
BEGIN
    DECLARE v_NewQuantity INT;
	 DECLARE v_Status VARCHAR(20);
    -- Giảm số lượng
    UPDATE Devices
    SET Quantity = Quantity - p_Amount
    WHERE DeviceID = p_DeviceID;

    -- Lấy lại số lượng mới
    SELECT Quantity ,Status INTO v_NewQuantity,v_Status
	 FROM Devices WHERE DeviceID = p_DeviceID;

    -- Cập nhật trạng thái nếu cần
    IF v_NewQuantity = 0 THEN
        UPDATE Devices SET Status = 'OutOf' WHERE DeviceID = p_DeviceID;
    END IF;
    
    IF v_NewQuantity > 0 AND v_Status = 'OutOf' THEN
    	UPDATE Devices
    	SET STATUS ='Available'
    	WHERE DeviceID = p_DeviceID;
   END IF;
  
END$$
DELIMITER ;

-- ==================================================TRIGGER===============================================
-- Giảm Quantity sách khi mượn thành công
DELIMITER $$ 
	CREATE TRIGGER `trg_Update_BookQuantity_On_Borrow`
	AFTER INSERT ON `TransactionItems`
	FOR EACH ROW
	BEGIN
	  IF NEW.`BookID` IS NOT NULL THEN
	    CALL UpdateBookQuantityOnBorrow(NEW.`BookID`, NEW.`Amount`);
	  END IF;
	END$$ 
DELIMITER ;
-- Tăng lại Quantity nếu Status = 'Completed' (khi trả)
DELIMITER $$
	CREATE TRIGGER `trg_Update_BookQuantity_On_Return`
	AFTER UPDATE ON `Transactions`
	FOR EACH ROW
	BEGIN
	  IF OLD.`Status` != 'Completed' AND NEW.`Status` = 'Completed' THEN
	    -- Tăng lại số lượng sách đã mượn
	    UPDATE `Books` b
	    JOIN `TransactionItems` ti ON ti.`BookID` = b.`BookID`
	    SET b.`Quantity` = b.`Quantity` + ti.`Amount`
	    WHERE ti.`TransactionID` = NEW.`TransactionID`;
	    
	    -- Cập nhật lại trạng thái nếu số lượng > 0 mà đang là 'OutOf'
	    UPDATE `Books`
	    SET `Status` = 'Available'
	    WHERE `Quantity` > 0 AND `Status` = 'OutOf';
	  END IF;
	END$$
DELIMITER;

DELIMITER $$
-- Ngăn xóa Book đang được mượn
CREATE TRIGGER trg_Prevent_Delete_Book_When_Active
BEFORE DELETE ON Books
FOR EACH ROW
BEGIN
  IF EXISTS (
    SELECT 1
    FROM TransactionItems ti
    JOIN Transactions t ON t.TransactionID = ti.TransactionID
    WHERE ti.BookID = OLD.BookID AND t.Status IN ('Active', 'Overdue')
  ) THEN
    SIGNAL SQLSTATE '45000'
    SET MESSAGE_TEXT = 'Không thể xóa sách đang được mượn!';
  END IF;
END$$

-- Ngăn cập nhật trạng thái Book thành 'Unavailable' khi đang được mượn
CREATE TRIGGER trg_Prevent_Unavailable_Book_When_Active
BEFORE UPDATE ON Books
FOR EACH ROW
BEGIN
  IF NEW.Status = 'Unavailable' AND EXISTS (
    SELECT 1
    FROM TransactionItems ti
    JOIN Transactions t ON t.TransactionID = ti.TransactionID
    WHERE ti.BookID = OLD.BookID AND t.Status IN ('Active', 'Overdue')
  ) THEN
    SIGNAL SQLSTATE '45000'
    SET MESSAGE_TEXT = 'Không thể cập nhật sách sang Unavailable khi đang được mượn!';
  END IF;
END$$
DELIMITER ;

-- Giảm Quantity thiết bị khi mượn thành công
DELIMITER $$
	CREATE TRIGGER `trg_Update_DeviceQuantity_On_Borrow`
	AFTER INSERT ON `TransactionItems`
	FOR EACH ROW
	BEGIN
	  IF NEW.`DeviceID` IS NOT NULL THEN
	   	CALL UpDateDeviceQuantityOnBorrow(NEW.`DeviceID`,NEW.`Amount`);
	   END IF;
	END$$
DELIMITER;

-- Tăng lại Quantity nếu Status = 'Completed' (khi trả)
DELIMITER $$
	CREATE TRIGGER `trg_Update_DeviceQuantity_On_Return`
	AFTER UPDATE ON `Transactions`
	FOR EACH ROW
	BEGIN
	  IF OLD.`Status` != 'Completed' AND NEW.`Status` = 'Completed' THEN
	    UPDATE `Devices` d
	    JOIN `TransactionItems` ti ON ti.`DeviceID` = d.`DeviceID`
	    SET d.`Quantity` = d.`Quantity` + ti.`Amount`
	    WHERE ti.`TransactionID` = NEW.`TransactionID`;
	    
	   -- Nếu Quantity > 0 và Status là OutOf → chuyển về Available
	    UPDATE `Devices` d
	    SET d.`Status` = 'Available'
	    WHERE d.`Quantity` > 0 AND d.`Status` = 'OutOf';
	  END IF;
	END$$
DELIMITER ;



DELIMITER $$
-- Ngăn xóa Device đang được mượn
CREATE TRIGGER trg_Prevent_Delete_Device_When_Active
BEFORE DELETE ON Devices
FOR EACH ROW
BEGIN
  IF EXISTS (
    SELECT 1
    FROM TransactionItems ti
    JOIN Transactions t ON t.TransactionID = ti.TransactionID
    WHERE ti.DeviceID = OLD.DeviceID AND t.Status IN ('Active', 'Overdue')
  ) THEN
    SIGNAL SQLSTATE '45000'
    SET MESSAGE_TEXT = 'Không thể xóa thiết bị đang được mượn!';
  END IF;
END$$

-- Ngăn cập nhật trạng thái Device thành 'Unavailable' khi đang được mượn
CREATE TRIGGER trg_Prevent_Unavailable_Device_When_Active
BEFORE UPDATE ON Devices
FOR EACH ROW
BEGIN
  IF NEW.Status = 'Unavailable' AND EXISTS (
    SELECT 1
    FROM TransactionItems ti
    JOIN Transactions t ON t.TransactionID = ti.TransactionID
    WHERE ti.DeviceID = OLD.DeviceID AND t.Status IN ('Active', 'Overdue')
  ) THEN
    SIGNAL SQLSTATE '45000'
    SET MESSAGE_TEXT = 'Không thể cập nhật thiết bị sang Unavailable khi đang được mượn!';
  END IF;
END$$
DELIMITER ;

-- tự động chuyển Status sang 'Overdue' nếu quá hạn
DELIMITER $$
	CREATE TRIGGER `trg_Auto_Overdue`
	BEFORE UPDATE ON `Transactions`
	FOR EACH ROW
	BEGIN
	  -- Nếu trạng thái chưa là 'Completed' và đã quá hạn mà chưa trả
	  IF NEW.`Status` != 'Completed' AND NEW.`ReturnDate` IS NULL AND NEW.`DueDate` < NOW() THEN
	    SET NEW.`Status` = 'Overdue';
	  END IF;
	END$$
DELIMITER;

-- trừ trước số lượng khi trạng thái là Pending (đặt chỗ mà coi như đã giữ hàng)
DELIMITER $$
	CREATE TRIGGER `trg_Decrease_Stock_On_Reservation_Pending`
	AFTER INSERT ON `ReservationItems`
	FOR EACH ROW
	BEGIN
	  -- Trừ số lượng sách
	  IF NEW.`BookID` IS NOT NULL THEN
	    UPDATE `Books`
	    SET `Quantity` = `Quantity` - NEW.`Amount`
	    WHERE `BookID` = NEW.`BookID`;
	  END IF;
	
	  -- Trừ số lượng thiết bị
	  IF NEW.`DeviceID` IS NOT NULL THEN
	    UPDATE `Devices`
	    SET `Quantity` = `Quantity` - NEW.`Amount`
	    WHERE `DeviceID` = NEW.`DeviceID`;
	  END IF;
	END$$
DELIMITER;

-- Khi hủy reservation (Status = 'Cancelled'), nên phục hồi Quantity lại cho Books/Devices
DELIMITER $$
	CREATE TRIGGER `trg_Restore_Stock_On_Reservation_Cancel`
	AFTER UPDATE ON `Reservation`
	FOR EACH ROW
	BEGIN
	  IF OLD.`Status` != 'Cancelled' AND NEW.`Status` = 'Cancelled' THEN
	    -- Tăng lại số lượng sách
	    UPDATE `Books` b
	    JOIN `ReservationItems` ri ON ri.`BookID` = b.`BookID`
	    SET b.`Quantity` = b.`Quantity` + ri.`Amount`
	    WHERE ri.`ReservationID` = NEW.`ReservationID`;
	
	    -- Tăng lại số lượng thiết bị
	    UPDATE `Devices` d
	    JOIN `ReservationItems` ri ON ri.`DeviceID` = d.`DeviceID`
	    SET d.`Quantity` = d.`Quantity` + ri.`Amount`
	    WHERE ri.`ReservationID` = NEW.`ReservationID`;
	  END IF;
	END
DELIMITER $$;


