devicesCREATE DATABASE IF NOT EXISTS `QuanLyThuQuan` 
  /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `QuanLyThuQuan`;

-- Bảng Member
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
-- Bảng Books
CREATE TABLE IF NOT EXISTS `Books` (
  `BookID` INT AUTO_INCREMENT NOT NULL ,
  `BookTitle` VARCHAR(255) NOT NULL,
  `Author` VARCHAR(255) NOT NULL,
  `BookImage` VARCHAR(255) NOT NULL,
  `Category` VARCHAR(100) NOT NULL,
  `PublishYear` INT NOT NULL,
  `Quantity` INT NOT NULL CHECK (`Quantity` >= 0) ,
  `Status` ENUM('Available', 'OutOf') NOT NULL DEFAULT 'Available',
  PRIMARY KEY (`BookID`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=UTF8MB4_GENERAL_CI;

-- Value Books
INSERT INTO `Books` (`BookTitle`,`Author`,`BookImage`,`Category`,`PublishYear`,`Quantity`)
	VALUES('Bí Quyết Thành Công Của Steve Jobs','Kim Thác Đao','BiQuyetThanhCongCuaSteveJobs.jpg','Kinh Tế - Quản Lý',2011,10),
			('Ai Lấy Miếng Pho Mát Của Tôi?','Spencer Johnson','AiLayMiengPhoMatCuaToi.jpg','Tâm Lý - Kỹ Năng Sống',2021,10),
			('Ba Người Lính Ngự Lâm','Alexander Dumas','BaNguoiLinhNguLam.jpg','Tiểu Thuyết - Văn Học',2019,10),
			('Các Thế Giới Song Song','Michio Kaku','CacTheGioiSongSong.jpg','Khoa Học - Viễn Tưởng',2024,10),
			('Bí Quyết Thành Công Của Napoleon Hill','Napoleon Hill','BiQuyetThanhCongCuaNapoleonHill.jpg','Kinh Tế - Quản Lý',2021,10),
			('Bí Quyết Thành Công của Henry Ford','Douglas Brinkley ','BiQuyetThanhCongcuaHenryFord.jpg','Kinh Tế - Quản Lý',2011,10),
			('7 Nguyên Tắc Bất Biến Để Xây Dựng Doanh Nghiệp Nhỏ','Steven S. Little','7NguyenTacBatBienDeXayDungDoanhNghiepNho.jpg','Kinh Tế - Quản Lý',2023,10),
			('Thiên Long Bát Bộ','Kim Dung','ThienLongBatBo.jpg','Tiểu Thuyết - Văn Học',1963,10),
			('Chú Chó Kazan','James Oliver Curwood','ChuChoKazan.jpg','Tiểu Thuyết - Văn Học',2022,10),
			('Truyền Thuyết Về Mộc Lan','Laurent Divers','TruyenThuyetVeMocLan.jpg','Tiểu Thuyết - Văn Học',1939,10),
			('Bản Chất Của Dối Trá','Dan Ariely','BanChatCuaDoiTra.jpg','Tâm Lý - Kỹ Năng Sống',2014,10),
			('Từ Hy Thái Hậu','Buck, Pearl S','TuHyThaiHau.jpg','Văn Hóa - Lịch Sử',1911,10),
			('Từ Tơ Lụa Đến Silicon','Jeffrey E. Garten','TuToLuaDenSilicon.jpg','Kinh Tế - Quản Lý',2017,10),
			('Vĩ Đại Do Lựa Chọn','Jim Collins - Morten T. Hansen','ViDaiDoLuaChon.jpg','Kinh Tế - Quản Lý',2011,10),
			('Xây Dựng Để Trường Tồn','Jim Collins - Jerry I. Porras','XayDungDeTruongTon.jpg','Kinh Tế - Quản Lý',1994,10),
			('Giáo Trình Tiền Tệ Ngân Hàng','Ts. Nguyễn Minh Kiều','GiaoTrinhTienTeNganHang.jpg','Kinh Tế - Quản Lý',2017,10),
			('Chỉ Cần Mẩu Khăn Giấy','Dan Roam','ChiCanMauKhanGiay.jpg','Kinh Tế - Quản Lý',2013,10),
			('Cho Khế Nhận Vàng','Adam Grant','ChoKheNhanVang.jpg','Kinh Tế - Quản Lý',2021,10),
			('Tiền Không Mua Được Gì?','Michael Sandel','TienKhongMuaDuocGi.jpg','Kinh Tế - Quản Lý',2019,10),
			('Đông Chu Liệt Quốc','Phùng Mộng Long','DongChuLietQuoc.jpg','Tiểu Thuyết - Văn Học',1998,10),
			('Kinh Thánh Của Một Người','Cao Hành Kiện','KinhThanhCuaMotNguoi.jpg','Tiểu Thuyết - Văn Học',2006,10),
			('Tầng Đầu Địa Ngục','Aleksandr Solzhenitsyn','TangDauDiaNguc.jpg','Tiểu Thuyết - Văn Học',1968,10),
			('Tình Yêu Định Mệnh','Alexandre Dumas','TinhYeuDinhMenh.jpg','Tiểu Thuyết - Văn Học',2019,10),
			('Cuộc Ngã Giá Của Nhà Tỷ Phú','Barbara Dunlop','CuocNgaGiaCuaNhaTyPhu.jpg','Tiểu Thuyết - Văn Học',2023,10),
			('Tổ Ấm Nơi Tận Cùng Thế Giới','Michael Cunningham','ToAmNoiTanCungTheGioi.jpg','Tiểu Thuyết - Văn Học',2010,10),
			('Tử huyệt cảm xúc','Roy Garn','TuHuyetCamXuc.jpg','Tâm Lý - Kỹ Năng Sống',2022,10),
			('Ngày xưa có một con bò','Camilo Cruz','NgayXuaCoMotConBo.jpg','Tâm Lý - Kỹ Năng Sống',2013,10),
			('Bí quyết tay trắng thành triệu phú','Adam Khoo','BiQuyetTayTrangThanhTrieuPhu.jpg','Tâm Lý - Kỹ Năng Sống',2009,10),
			('Năng Đoạn Kim Cương','Michael Roach','NangDoanKimCuong.jpg','Tâm Lý - Kỹ Năng Sống',2022,10),
			('7 Thói Quen Để Thành Đạt',' Stephen R.Covey','7ThoiQuenDeThanhDat.jpg','Tâm Lý - Kỹ Năng Sống',1998,10),
			('Sinh Ra Để Chạy','Christopher McDougall','SinhRaDeChay.jpg','Tâm Lý - Kỹ Năng Sống',2023,10),
			('Bí Mật Hành Trình Tình Yêu','David Niven','BiMatHanhTrinhTinhYeu.jpg','Tâm Lý - Kỹ Năng Sống',2017,10),
			('Đời Ngắn Đừng Ngủ Dài','Robin Sharma','DoiNganDungNguDai.jpg','Tâm Lý - Kỹ Năng Sống',2014,10),
			('Đánh Thức Năng Lực Vô Hạn','Anthony Robbins','DanhThucNangLucVoHan.jpg','Tâm Lý - Kỹ Năng Sống',2015,10),
			('Tam Thể','Lưu Từ Hân','TamThe.jpg','Khoa Học - Viễn Tưởng',2006,10),
			('Hai Vạn Dặm Dưới Đáy Biển','Jules Verne','HaiVanDamDuoiDayBien.jpg','Khoa Học - Viễn Tưởng',1870,10),
			('Hành trình vào tâm Trái Đất','Jules Verne','HanhTrinhVaoTamTraiDat.jpg','Khoa Học - Viễn Tưởng',1864,10),
			('Bí kíp quá giang vào Ngân Hà','Douglas Adams','BiKipQuaGiangVaoNganHa.jpg','Khoa Học - Viễn Tưởng',1979,10),
			('Cỗ máy thời gian','H. G. Wells','CoMayThoiGian .jpg','Khoa Học - Viễn Tưởng',1895,10),
			('451 Độ F','Ray Bradbury','451DoF.jpg','Khoa Học - Viễn Tưởng',2021,10);
			
-- Bảng Devices
CREATE TABLE IF NOT EXISTS `Devices` (
  `DeviceID` INT AUTO_INCREMENT NOT NULL ,
  `DeviceName` VARCHAR(255) NOT NULL,
  `DeviceImage` VARCHAR(255) NOT NULL,
  `DeviceType` VARCHAR(100) NOT NULL,
  `Quantity` INT NOT NULL CHECK (`Quantity` >= 0),
  `Status` ENUM('Available', 'OutOf') NOT NULL DEFAULT 'Available',
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

-- Bảng Transactions
CREATE TABLE IF NOT EXISTS `Transactions` (
  `TransactionID` INT AUTO_INCREMENT NOT NULL ,
  `MemberID` INT NOT NULL,
   `TransactionType` ENUM('Borrow', 'Return', 'Reserve') NOT NULL,
  `TransactionDate` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `DueDate` DATETIME NULL,
  `ReturnDate` DATETIME NULL CHECK(`ReturnDate`>= `TransactionDate`),
  `Status` ENUM('Active', 'Completed', 'Overdue') NOT NULL DEFAULT 'Active',
  PRIMARY KEY (`TransactionID`),
	INDEX (`MemberID`),
  FOREIGN KEY (`MemberID`) REFERENCES `Member`(`MemberID`) 
    ON DELETE CASCADE ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=UTF8MB4_GENERAL_CI;
-- Values Transactions 
INSERT INTO `Transactions`(`MemberID`,`TransactionType`,`TransactionDate`,`DueDate`,`ReturnDate`,`Status`)
		VALUES(3,'Borrow', '2025-02-03 11:00:00', '2025-02-13 11:00:00', '2025-02-12 11:00:00', 'Completed'),
				(4,'Borrow', '2025-02-04 08:30:00', '2025-02-14 08:30:00', '2025-02-14 08:00:00', 'Completed'),
				(4,'Borrow', '2025-02-06 08:00:00', '2025-02-18 08:30:00', '2025-02-16 08:00:00', 'Completed'),
				(3,'Borrow', '2025-02-20 07:00:00', '2025-02-27 15:00:00', '2025-02-27 13:00:00', 'Completed'),
				(3,'Borrow', '2025-03-01 07:00:00', '2025-03-01 16:00:00', '2025-03-01 15:30:00', 'Completed'),
				(4,'Borrow', '2025-03-02 08:00:00', '2025-03-10 08:30:00', '2025-03-11 08:00:00', 'Completed');
-- Bảng TransactionItems
CREATE TABLE IF NOT EXISTS `TransactionItems`(
		`ItemID` INT AUTO_INCREMENT NOT NULL,
		`TransactionID` INT NOT NULL,
		`BookID` INT NULL,
		`DeviceID` INT NULL,
		`Amount` INT NOT NULL CHECK(`Amount` > 0),
		PRIMARY KEY(`ItemID`),
	FOREIGN KEY (`TransactionID`) REFERENCES `Transactions`(`TransactionID`)
    ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (`BookID`) REFERENCES `Books`(`BookID`) 
    ON DELETE SET NULL ON UPDATE CASCADE,
  FOREIGN KEY (`DeviceID`) REFERENCES `Devices`(`DeviceID`) 
    ON DELETE SET NULL ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=UTF8MB4_GENERAL_CI;

-- Values TransactionItems
INSERT INTO `TransactionItems`(`TransactionID`,`BookID`,`DeviceID`,`Amount`)
		VALUES (1,1,NULL,1),
				(1,3,NULL,1),
				(1,4,NULL,1),
				(2,10,NULL,1),
				(2,5,NULL,1),
				(3,7,NULL,1),
				(3,20,NULL,1),
				(3,25,NULL,1),
				(4,22,NULL,1),
				(4,23,NULL,1),
				(4,24,NULL,1),
				(5,NULL,4,1),
				(5,NULL,6,2),
				(5,NULL,7,1),
				(5,NULL,9,2),
				(5,NULL,11,1),
				(6,2,NULL,1),
				(6,40,NULL,1);
-- Bảng Rules
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

-- Bảng Violation
CREATE TABLE IF NOT EXISTS `Violation` (
  `ViolationID` INT AUTO_INCREMENT NOT NULL ,
  `MemberID` INT NOT NULL,
  `TransactionID` INT NOT NULL,
  `RuleID` INT NOT NULL,
  `FineAmount` DECIMAL(10, 0) NOT NULL CHECK (`FineAmount` >=0),
  `Reason` VARCHAR(255) NOT NULL,
  `ViolationDate` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `PaidStatus` ENUM('Unpaid', 'Paid') NOT NULL DEFAULT 'Unpaid',
  PRIMARY KEY (`ViolationID`),
  FOREIGN KEY (`MemberID`) REFERENCES `Member`(`MemberID`) 
    ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (`TransactionID`) REFERENCES `Transactions`(`TransactionID`) 
    ON DELETE CASCADE ON UPDATE CASCADE,
  FOREIGN KEY (`RuleID`) REFERENCES `Rules`(`RuleID`) 
    ON DELETE CASCADE ON UPDATE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=UTF8MB4_GENERAL_CI;
	
-- Values Violation
INSERT INTO `Violation`(`MemberID`, `TransactionID`,`RuleID`,`FineAmount`,`Reason`,`ViolationDate`,`PaidStatus`)
		VALUES (4,6,3,10000,'Trả sách quá hạn 1 ngày','2025-03-11 08:00:00','Unpaid'),
				(3, 4, 1, 0, 'Không giữ yên lặng trong thư viện', '2025-02-20 07:30:00', 'Paid'),
				(4, 6, 1, 0, 'Gây ồn ào trong thư viện', '2025-03-02 10:00:00', 'Paid'),
				(3, 5, 2, 0, 'Ăn uống trong khu vực thư viện', '2025-03-01 14:00:00', 'Paid'),
				(4, 2, 4, 200000, 'Làm hỏng sách mượn', '2025-02-04 09:00:00', 'Paid'),
				(3, 4, 5, 0, 'Sử dụng điện thoại trong khu vực yên tĩnh', '2025-02-20 07:30:00', 'Paid');
			

-- Bảng LoginHistory
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
-- Bảng Review
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
-- Bảng Categories
CREATE TABLE Categories (
    CategoryID INT AUTO_INCREMENT PRIMARY KEY,
    CategoryName VARCHAR(100) NOT NULL UNIQUE
);

-- Bảng Authors
CREATE TABLE Authors (
    AuthorID INT AUTO_INCREMENT PRIMARY KEY,
    AuthorName VARCHAR(255) NOT NULL UNIQUE
);

ALTER TABLE Books 
ADD COLUMN CategoryID INT,
ADD COLUMN AuthorID INT;

INSERT INTO Categories (CategoryName)
SELECT DISTINCT Category FROM Books;

INSERT INTO Authors (AuthorName)
SELECT DISTINCT Author FROM Books;

UPDATE Books b
JOIN Categories c ON b.Category = c.CategoryName
SET b.CategoryID = c.CategoryID;

UPDATE Books b
JOIN Authors a ON b.Author = a.AuthorName
SET b.AuthorID = a.AuthorID;

ALTER TABLE Books
DROP COLUMN Category,
DROP COLUMN Author;

ALTER TABLE Books
ADD FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
ADD FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID);

ALTER TABLE Books ADD COLUMN fee_per_day INT DEFAULT 10000;
ALTER TABLE Devices ADD COLUMN fee_per_hour INT DEFAULT 5000;




