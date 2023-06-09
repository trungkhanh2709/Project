CREATE DATABASE QuanLyNhaHang
GO
--use QLSV
--drop database QuanLyNhaHang
USE QuanLyNhaHang
GO

-- BanAn 

-- DanhSachMonAn 

-- MonAn  

-- PhieuTamTinhHoaDon 

-- ChiTietHoaDon 

-- NhanVien

-- TaiKhoan

-- Job

Create Table BanAn 
(
	id int Identity Primary Key, -- identity: tự tăng

	Ten nvarchar(100) Not Null Default N'Bàn chưa có tên', 

	TinhTrang nvarchar(100) Not Null Default N'Trống'	-- Trống || Có người
) 
GO
--thêm bàn
DECLARE @i INT = 1

WHILE @i <= 15
BEGIN
	INSERT BanAn (Ten) VALUES (N'Bàn ' + CAST (@i AS nvarchar(100))) -- dùng để insert into nhanh hơn insert into từng bàn
	SET @i = @i +1 
END
GO 
Select * from BanAn

Create Table DanhSachMonAn 
( 
	id int Identity Primary Key, 

	ten nvarchar(100) NOT NULL Default N'Chưa đặt tên' 
) 
GO 
-- Danh sách món ăn
Insert into DanhSachMonAn(ten) Values
	(N'SPECIALTIES'),--1
	(N'DIMSUM'), --2
	(N'PHỤC VỤ CẢ NGÀY'), --3
	(N'KHAI VỊ'), --4
	(N'MÌ & CHÁO'), --5
	(N'LẨU'), --6
	(N'THỊT'), --7
	(N'HẢI SẢN'), --8
	(N'VIÊN, CHẢ'), --9
	(N'NẤM'), --10
	(N'RAU CỦ'), --11
	(N'MÌ'), --12
	(N'TRÁNG MIỆNG'), --13
	(N'TRÀ'), --14
	(N'CÀ PHÊ'), --15
	(N'TRÀ DƯỠNG NHAN'), --16
	(N'TRÀ THẢO MỘC'), --17
	(N'NƯỚC ÉP'), --18
	(N'BIA & THỨC UỐNG KHÁC'), --19
	(N'RƯỢU MẠNH'), --20
	(N'RƯỢU VANG'), --21
	(N'VANG CAO CẤP') --22
select * from DanhSachMonAn

Create Table MonAn 
( 
	id int Identity Primary Key,

	ten nvarchar(100) Not Null Default N'Chưa đặt tên', 

	idDSMonAn int Not Null, 

	gia float Not Null Default 0 

	Foreign Key (idDSMonAn) References dbo.DanhSachMonAn(id)
) 
GO
--Tên món ăn
-- SPECIALTIES
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES 
	(N'Canh Sụn Cá Mập Hầm Bong Bóng Cá Sò Điệp Khô', 1, 399000),
	(N'Vi Cá Trung, Càng Cua, Sò Điệp Khô Hầm Với Sốt Đặc Biệt', 1, 1290000),
	(N'Bào Ngư, Hải Sâm, Nấm Hương Hầm Sốt Đặc Biệt', 1, 1490000),
	(N'Canh Sụn Cá Mập Bóng Cá Hầm Vi Cá Trung', 1, 1590000)
--DIMSUM
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES 
	(N'Há Cảo Tôm Bó Xôi (3 viên)', 2, 79000),
	(N'Há Cảo Sò Điệp (3 viên)', 2, 129000),
	(N'Sủi Cảo Bắc Kinh (3 viên)', 2, 79000),
	(N'Bánh Trứng Nướng (3 cái)', 2, 79000),
	(N'Hoành Thánh Sốt Cay Kiểu Tứ Xuyên (3 viên)', 2, 99000),
	(N'Sủi Cảo Vi Cá Hầm Thượng Canh (1 viên)', 2, 229000),
	(N'Bánh Xếp Tam Tơ Chay (3 cái)', 2, 79000),
	(N'Bánh Bao Thượng Hải (3 cái)', 2, 79000),
	(N'Bánh Khoai Môn Chiên Xù (3 cái)', 2, 79000),
	(N'Bánh Cuốn Xá Xíu Chiên', 2, 99000),
	(N'Bánh Cuốn Xào Tương X.O', 2, 79000),
	(N'Bánh Cuốn Tôm Tươi Chiên', 2, 119000),
	(N'Bánh Cuốn Chiên Xì Dầu Thượng Hạng', 2, 79000),
	(N'Bánh Cuốn Tôm Tươi Hấp', 2, 119000),
	(N'Bánh Cuốn Xá Xíu Hấp', 2, 79000),
	(N'Đậu Hũ Ki Cuộn Tôm Với Sốt Bào Ngư (3 cuộn)', 2, 89000)
--PHỤC VỤ CẢ NGÀY
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Chân Gà Hấp Tàu Xì', 3, 79000),
	(N'Há Cảo Tôm Tươi (3 viên)', 3, 79000),
	(N'Sườn Hấp Tàu Xì', 3, 79000),
	(N'Bánh Bao Xá Xíu (3 cái)', 3, 79000),
	(N'Bánh Bao Trứng Sữa (3 cái)', 3, 79000),
	(N'Sủi Cảo Tôm Chiên Sốt Mayonnaise (3 viên)', 3, 119000),
	(N'Xíu Mại Đuôi Phụng Trứng Cá (3 viên)', 3, 99000),
	(N'Đậu Hũ Ki Cuộn Tôm Rong Biển Chiên (3 cuộn)', 3, 119000),
	(N'Cảo Hải Sản Măng Tây', 3, 99000),
	(N'Há Cảo Tôm Tươi Và Rong Nho Biển (3 viên)', 3, 119000)
--KHAI VỊ
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Dưa Leo Trộn Tỏi Kiểu "Tứ Xuyên"', 4, 39000),
	(N'Đậu Phộng Hầm Ngũ Vị', 4, 39000),
	(N'Rong Biển Trộn Cay Kiểu Tứ Xuyên', 4, 39000),
	(N'Gỏi Sứa Trộn Mè Cay', 4, 129000),
	(N'Viên Sò Điệp Trộn Xuyên Tiêu', 4, 129000)
--MÌ & CHÁO
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Sủi Cảo Tôm Tươi Canh Thượng Hạng', 5, 129000),
	(N'Cháo Thịt Heo Và Trứng Bắc Thảo', 5, 79000),
	(N'Cháo Hải Sản Sò Điệp Khô', 5, 299000),
	(N'Mì Sủi Cảo Tôm (Khô/ Nước)', 5, 109000),
	(N'Hoành Thánh Tôm Tươi Với Canh Thượng Hạng', 5, 119000),
	(N'Hoành Thánh Tôm Chiên Giòn', 5, 119000)
--LẨU
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Lẩu Mala', 6, 109000),
	(N'Lẩu Nấm Hoàng Gia', 6, 109000),
	(N'Lẩu Satay', 6, 109000),
	(N'Lẩu Gà Thảo Mộc', 6, 109000),
	(N'Lẩu Xương Hầm Thượng Hạng', 6, 199000),
	(N'Lẩu Cá Nhám Chua Cay', 6, 299000)
--THỊT
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Gầu Bò', 7, 169000),
	(N'Gù Bò', 7, 169000),
	(N'Ba Chỉ Bò Mỹ', 7, 99000),
	(N'Lõi Vai Bò Mỹ', 7, 169000),
	(N'Thăn Ngoại Bò Mỹ', 7, 219000),
	(N'Combo Bò', 7, 259000),
	(N'Đầu Thăn Ngoại Wagyu', 7, 369000),
	(N'Ba Rọi Heo', 7, 89000),
	(N'Xương Heo - Xí Quách', 7, 99000),
	(N'Da Heo', 7, 89000),
	(N'Bao Tử Heo', 7, 129000),
	(N'Chân Gà Rút Xương', 7, 89000),
	(N'Trứng Gà Non', 7, 99000),
	(N'Ngọc Kê', 7, 159000)
--HẢI SẢN
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Mực Ống', 8, 169000),
	(N'Mực Lá Fillet', 8, 169000),
	(N'Cá Lăng Fillet', 8, 169000),
	(N'Cá Tầm', 8, 390000),
	(N'Cá Chình Sông', 8, 590000),
	(N'Ốc Tỏi', 8, 390000),
	(N'Vẹm Xanh New Zealand', 8, 290000),
	(N'Sò Dương', 8, 690000),
	(N'Cá Mú Trân Châu', 8, 590000),
	(N'Bong Bóng Cá', 8, 599000),
	(N'Combo Hoàng Kim (Ốc Tỏi, Vẹm Xanh, Sò Dương)', 8, 790000),
	(N'Combo Thượng Phẩm (Bào Ngư, Hải Sâm, Bong Bóng Cá', 8, 890000),
	(N'Tôm Hùm Bông', 8, 890000),
	(N'Bào Ngư (6 con)', 8, 799000),
	(N'Sứa', 8, 129000),
	(N'Bạch Tuộc', 8, 169000),
	(N'Tôm Sú', 8, 199000),
	(N'Sò Điệp Nhật', 8, 390000),
	(N'Combo Hải Sản', 8, 379000),
	(N'Mực Ngâm Tro', 8, 99000)
-- VIÊN CHẢ
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Trứng Cút', 9, 59000),
	(N'Heo Viên', 9, 89000),
	(N'Đậu Hủ Dồn', 9, 89000),
	(N'Bò Viên', 9, 119000),
	(N'Cá Viên', 9, 119000),
	(N'Mực Viên', 9, 119000),
	(N'Viên Phô Mai', 9, 139000),
	(N'Chạo Cá', 9, 139000),
	(N'Chạo Mực', 9, 169000),
	(N'Chạo Tôm', 9, 179000),
	(N'Rong Biển Cuộn Mực', 9, 139000),
	(N'Que Sò Điệp Nhật', 9, 179000),
	(N'Combo Viên Tứ Bửu(Cá, Bò, Mực, Heo)', 9, 159000)
--NẤM
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Nấm Kim Châm', 10, 69000),
	(N'Nấm Đông Cô Tươi', 10, 69000),
	(N'Nấm Bào Ngư', 10, 69000),
	(N'Nấm Linh Chi Trắng', 10, 69000),
	(N'Nấm Linh Chi Đen', 10, 69000),
	(N'Nấm Đùi Gà', 10, 69000),
	(N'Nấm Đông Trùng Hạ Thảo', 10, 169000),
	(N'Combo Nấm', 10, 139000)
--RAU CỦ
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Củ Sen', 11, 49000),
	(N'Bắp', 11, 49000),
	(N'Rong Biển', 11, 49000),
	(N'Bắp Non', 11, 49000),
	(N'Khoai Môn', 11, 49000),
	(N'Rau Cải Mầm', 11, 49000),
	(N'Rau Muống', 11, 49000),
	(N'Cải Thìa', 11, 49000),
	(N'Cải Cúc (Tần Ô)', 11, 49000),
	(N'Combo Rau', 11, 99000),
	(N'Bó Xôi', 11, 49000),
	(N'Rau Mồng Tơi', 11, 49000),
	(N'Xà Lách Xoong', 11, 49000),
	(N'Cải Thảo', 11, 49000)
--MÌ
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Đậu Hủ Ki', 12, 39000),
	(N'Đậu Hủ Non', 12, 39000),
	(N'Đậu Hủ Ki Cuộn Chiên', 12, 69000),
	(N'Đậu Hủ Ki Tươi', 12, 69000),
	(N'Đậu Hủ Xốp Đài Loan', 12, 59000),
	(N'Mì Đậu Hủ', 12, 69000),
	(N'Mì Tươi (Homemade)', 12, 39000),
	(N'Mì Udon', 12, 39000),
	(N'Miến', 12, 39000),
	(N'Mì Gói', 12, 39000),
	(N'Bún Tơ Cuộn', 12, 39000),
	(N'Miến Dẹt', 12, 59000)
--TRÁNG MIỆNG
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Chè Mè Đen (Nóng)', 13, 69000),
	(N'Quy Linh Cao', 13, 69000),
	(N'Dương Kim Chi Lộ', 13, 89000),
	(N'Đậu Hủ Hạnh Nhân Vải', 13, 69000)
--TRÀ
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Trà Lài Đác Thơm Hạt Chia', 14, 79000),
	(N'Trà Lài Đác Cam Nha Đam', 14, 79000),
	(N'Trà Thơm Chanh Dây Nha Đam', 14, 79000),
	(N'Trà Lài', 14, 79000),
	(N'Trà Hoa Cúc', 14, 79000),
	(N'Trà Bửu Lỉ', 14, 79000)
--CÀ PHÊ 
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Cà Phê Đá/ Nóng', 15, 49000),
	(N'Cà Phê Sữa Đá/ Nóng', 15, 49000)
--TRÀ DƯỠNG NHAN
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Olong Táo Đỏ Kỷ Tử (Ly)', 16, 79000),
	(N'Olong Táo Đỏ Kỷ Tử (Bình)', 16, 99000),
	(N'Olong Thơm Cam Ngân Nhĩ (Ly)', 16, 79000),
	(N'Olong Thơm Cam Ngân Nhĩ (Bình)', 16, 99000)
-- TRÀ THẢO MỘC 
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Nước Xí Muội', 17, 59000),
	(N'Nước Mát Thảo Mộc Dynasty (Ly)', 17, 59000),
	(N'Nước Mát Thảo Mộc Dynasty (Bình)', 17, 69000)
--NƯỚC ÉP
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Ép Chanh', 18, 49000),
	(N'Dừa Tươi', 18, 59000),
	(N'Ép Cam', 18, 69000),
	(N'Chanh Dây', 18, 69000),
	(N'Ép Dưa Hấu', 18, 69000),
	(N'Ép Thơm', 18, 69000),
	(N'Ép Bưởi', 18, 69000)
--BIA & THỨC UỐNG KHÁC
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Pepsi', 19, 49000),
	(N'Pepsi Black', 19, 49000),
	(N'7 Up', 19, 49000),
	(N'Aquafina', 19, 49000),
	(N'Aqua Soda', 19, 49000),
	(N'Evian', 19, 79000),
	(N'Perrier', 19, 79000),
	(N'Tiger Lon', 19, 59000),
	(N'Heneken Lon', 19, 59000)
--RƯỢU MẠNH
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'Chivas Blue 18 Năm', 20, 2900000),
	(N'Glenlivet 15 Năm', 20, 3290000),
	(N'Glenlivet 18 Năm', 20, 4900000),
	(N'Henessy Xo', 20, 7690000),
	(N'Martel Xo', 20, 7890000),
	(N'Macalan 12 Năm', 20, 4290000)
--RƯỢU VANG
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'DB SELECTION, Semillon - Chardonnay, Australia (Ly)' , 21, 160000),
	(N'DB SELECTION, Semillon - Chardonnay, Australia (Chai)' , 21, 790000),
	(N'LINDEMAN CAWARR, Chardonnay, South Eastern Austral (Chai)' , 21, 890000),
	(N'TRIBU, Viognier, Mendoza - Argentina (Chai)' , 21, 890000),
	(N'MAISON CASTEL (Chai)' , 21, 990000),
	(N'NEDERBURG (Chai)' , 21, 990000),
	(N'BANFI (Chai)' , 21, 1290000),
	(N'MATUA (Chai)' , 21, 1490000),
	(N'TRIMBACH (Chai)' , 21, 1490000),
	(N'RIMAPERE (Chai)' , 21, 2090000),
	(N'VILLA MARIA (Chai)' , 21, 2990000)
--VANG CAO CẤP 
INSERT INTO MonAn(ten, idDSMonAn, gia) VALUES
	(N'DB SELECTION RED (Ly)' , 22, 160000),
	(N'DB SELECTION RED (Chai)' , 22, 790000),
	(N'TRIBU (Chai)' , 22, 890000),
	(N'THE STRUM JUMP (Chai)' , 22, 990000),
	(N'CAP ROYAL (Chai)' , 22, 1290000),
	(N'BANFI (Chai)' , 22, 1290000),
	(N'LINDEMAN BIN 50 (Chai)' , 22, 1290000),
	(N'CASILLERO DEL DIABLO DEVIL COLLECTION (Chai)' , 22, 1690000)
select * from MonAn

Create table KhachHang
(
	id int Identity Primary Key,
	
	tenkhachhang nvarchar(100),
	
	gioitinh nvarchar(100),

	sdt nvarchar(100),

)
insert into KhachHang values
	(N'Hoàng Thái Vũ', N'Nam','0947659105'),
	(N'Nguyễn Đức Cường', N'Nam','0947937295'),
	(N'Bùi Trường Linh', N'Nam','0947857377')
Create Table PhieuTamTinhHoaDon
( 
	id int Identity Primary Key,

	giovao date Not Null Default GETDATE(), 

	giora date, 
	
	idKhach int not null,

	idBanAn int Not Null, 

	status int Not Null Default 0 -- 1: đã thanh toán && 0: chưa thanh toán 

	Foreign Key (idBanAn) References dbo.BanAn(id), 
	Foreign Key (idKhach) References dbo.KhachHang(id) 
)
GO
--Thêm bill
INSERT INTO PhieuTamTinhHoaDon(idBanAn,idkhach, giovao, giora, status) VALUES
	(1,1,'06-Jan-2022 11:30:00AM','06-Jan-2022 13:45:00PM',1),
	(2,2,'01-Jun-2022 14:30:00PM','01-Jun-2022 17:05:00PM',1),
	(3,3,'01-Jun-2022 14:30:00PM','01-Jun-2022 17:05:00PM',1)
select * from PhieuTamTinhHoaDon

Create Table ChiTietHoaDon 
( 
	id int Identity Primary Key,

	idBill int NOT NULL, 

	idMonAn int Not Null, 

	soluong int Not Null Default 0 

	Foreign Key (idBill) References dbo.PhieuTamTinhHoaDon(id), 

	Foreign Key (idMonAn) References dbo.MonAn(id) 
) 
GO 
select * from PhieuTamTinhHoaDon
insert into ChiTietHoaDon(idBill,idMonAn, soluong) values
	(2,5,2),
	(2,8,2),
	(2,3,1),
	(2,9,1),
	(3,10,2),
	(3,28,3),
	(3,39,2),
	(3,45,1)
select * from ChiTietHoaDon

Create Table NhanVien
(
	id int Identity Primary Key,

	tennhanvien varchar(100) Default N'Hỏng biết nữa',
	
	gioitinh nvarchar(5) CHECK (GioiTinh in (N'Nam', N'Nữ')),

	sodienthoai nvarchar(20),

	ngaysinh date,
	
	diachi nvarchar(500),

	CMND nvarchar(100),

	ngaybatdaulam date,
) 
GO
-- Thêm nhân viên
INSERT INTO NhanVien VALUES 
	(N'Khánh', 'Nam', '012345678','27-Sep-2003', N'Quận Gò Vấp', '123456789101', '01-Jan-2019'),
	(N'Như', N'Nữ','0987654321','23-Sep-2000', N'Quận Gò Vấp', '123456789106', '07-Mar-2018'),
	(N'Thư', N'Nữ', '012345678','06-Jan-2003', N'Quận Gò Vấp', '027913784296', '05-May-2022'),
	(N'Toàn', N'Nam','036361786', '15-Jan-2003', N'Huyện Hóc Môn', '582018492108', '18-Jun-2021'),
	(N'Vu Vy', N'Nữ','063274620','25-Apr-2003', N'Quận 4', '739710485924', '29-Nov-2022')
Select * from NhanVien

Create Table TaiKhoan 
( 
	id int Identity Primary Key,

	UserName nvarchar(100) Not Null, --Mã nhân viên làm username

	PassWord nvarchar(1000) Not Null Default 0, 

	idnhanvien int,

	LoaiTaiKhoan nvarchar(40) CHECK (loaiTaiKhoan in (N'Quản lí', N'Nhân viên'))

	Foreign Key (idnhanvien) References dbo.NhanVien(id)
) 
GO
select * from TaiKhoan

-- Thêm tài khoản
Insert into TaiKhoan Values
	('NV01', '1', 1, N'Quản lí'),
	('NV02', '1', 2, N'Nhân viên'),
	('NV03', '1', 3, N'Nhân viên'),
	('NV04', '1', 4, N'Nhân viên'),
	('NV05', '1', 5, N'Nhân viên')
select * from TaiKhoan
/*CREATE TABLE CaLam 
(
	id INT  IDENTITY PRIMARY KEY,

	calamviec varchar(10),
	
)	
GO
drop table CaLam
select * from CaLam

Create Table Job
(
	id int Identity Primary Key,
	
	idNhanVien nvarchar(100),
	
	idCaLamViec int,

	Foreign Key (idNhanVien) References NhanVien(id),

	luong float,

	socalam int,

	tinhtrang INT NOT NULL DEFAULT 0 -- 1: đã trả lương && 0: chưa trả lương
)
GO
-- Thêm Job
select * from Job */

select tm.idBanAn, ma.gia, ct.soluong, ct.soluong * ma.gia, tm.giovao, tm.giora
from PhieuTamTinhHoaDon tm, MonAn ma, ChiTietHoaDon ct
where 1 = 1
AND ct.idBill = tm.id 
AND ct.idMonAn = ma.id

select  Sum (m.gia * c.soluong) from PhieuTamTinhHoaDon p, MonAn m, ChiTietHoaDon c, BanAn
where c.idBill=p.id and p.idBanAn = BanAn.id and c.idMonAn = m.id and c.idBill = 2

select tm.idBanAn, ct.soluong * ma.gia, tm.giovao, tm.giora
from PhieuTamTinhHoaDon tm, MonAn ma, ChiTietHoaDon ct, BanAn ba
where ct.idBill = tm.id AND ct.idMonAn = ma.id And tm.giora between '2022-Jan-06' and '2022-Jan-06'

select distinct AAA from (
select tm.idBanAn as AAA, ma.gia * ct.soluong, tm.giovao, tm.giora
from PhieuTamTinhHoaDon tm, MonAn ma, ChiTietHoaDon ct, BanAn ba
where ct.idBill = tm.id AND ct.idMonAn = ma.id AND ba.id = tm.idBanAn)

select * from PhieuTamTinhHoaDon where giovao between '2022-01-19' and '2022-02-27'

select * from taikhoan
select * from KhachHang
select * from PhieuTamTinhHoaDon where idBanAn =1 and status = 0
select ba.Ten from BanAn ba, PhieuTamTinhHoaDon pt, KhachHang kh where 
select * from PhieuTamTinhHoaDon where idBanAn =5
select * from TaiKhoan

select ba.Ten, ct.soluong * ma.gia, tm.giovao, tm.giora
from PhieuTamTinhHoaDon tm, MonAn ma, ChiTietHoaDon ct, BanAn ba
where ct.idMonAn = ma.id AND ct.idBill = tm.id 

AND 



select * from PhieuTamTinhHoaDon where idBanAn= 2 and status = 0
select * from BanAn
update BanAn set TinhTrang = N'Trống' where TinhTrang = N'Đã Đặt'