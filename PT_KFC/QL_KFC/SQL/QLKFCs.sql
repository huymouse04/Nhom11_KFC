CREATE DATABASE QLKFC

GO

USE QLKFC;

--drop database QLKFC

set dateformat dmy

GO

-- Bảng Quan Ly Nhan Vien  
CREATE TABLE NhanVien (  
    MaNhanVien VARCHAR(30) PRIMARY KEY NOT NULL,  
	AnhNhanVien  VARBINARY(MAX),
    TenNhanVien NVARCHAR(250) NOT NULL,  
    GioiTinh NVARCHAR(3),  
    NgaySinh DATETIME,  
    SoDienThoai VARCHAR(15),  
    Email VARCHAR(150),  
    DiaChi NVARCHAR(300),  
    ChucVu NVARCHAR(100),  
    SoGioLam int 
); 


-- Bảng Tinh Luong Nhan Vien  
CREATE TABLE Luong (  
    MaNhanVien VARCHAR(30) NOT NULL,  
    LuongCoBan FLOAT,  
    Thang Int,  
    SoNgayLam INT,  
    ThuongChuyenCan FLOAT,  
    ThuongHieuSuat FLOAT,  
    PRIMARY KEY (MaNhanVien, Thang),  
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)  
);  
ALTER TABLE Luong
ALTER COLUMN LuongCoBan DECIMAL(18, 2);
ALTER TABLE Luong
ALTER COLUMN ThuongChuyenCan DECIMAL(18, 2);
ALTER TABLE Luong
ALTER COLUMN ThuongHieuSuat DECIMAL(18, 2);


-- Bảng Loai Hang  
CREATE TABLE LoaiHang (  
    MaLoaiHang VARCHAR(20) PRIMARY KEY NOT NULL,  
    TenLoaiHang NVARCHAR(150) NOT NULL  
);  

-- bảng nhà cung cấp
CREATE TABLE NhaCungCap (  
    MaNhaCungCap VARCHAR(10) PRIMARY KEY,  
    TenNhaCungCap NVARCHAR(100) NOT NULL,  
	AnhNhaCungCap  VARBINARY(MAX),
    DiaChi NVARCHAR(200),  
    SoDienThoai VARCHAR(15),  
    GhiChu NVARCHAR(200)  
);  

-- Bảng Kho  
CREATE TABLE Kho (  
    MaSanPham VARCHAR(30) PRIMARY KEY NOT NULL,  
    TenSanPham NVARCHAR(250) NOT NULL,  
    SoLuong INT NOT NULL,  
	DonViTinh NVARCHAR(50),  
	DonGia FLOAT, 
    MaLoaiHang VARCHAR(20),  
    CONSTRAINT CK_SoLuong CHECK (SoLuong >= 0),  
    FOREIGN KEY (MaLoaiHang) REFERENCES LoaiHang(MaLoaiHang) 
); 
 
-- Bảng NhapHang  
CREATE TABLE NhapHang (  
    MaNhapHang INT IDENTITY(1,1) PRIMARY KEY,  
    MaSanPham VARCHAR(30) NOT NULL,  
    SoLuong INT NOT NULL,  
    DonViTinh NVARCHAR(50),  
    DonGia FLOAT,  
    NgayNhap DATETIME NOT NULL,  
    MaLoaiHang VARCHAR(20),  
	MaNhaCungCap VARCHAR(10),
    FOREIGN KEY (MaSanPham) REFERENCES Kho(MaSanPham),  
    FOREIGN KEY (MaLoaiHang) REFERENCES LoaiHang(MaLoaiHang),
	FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap)
);  

-- Bảng Quan Ly Combo  
CREATE TABLE Combo (  
    MaCombo VARCHAR(30) PRIMARY KEY NOT NULL,  
    TenCombo NVARCHAR(250) NOT NULL,  
    GiaCombo FLOAT,  
    ThoiGianHieuLuc DATETIME  
); 

-- Bảng Chi Tiet Combo  
CREATE TABLE ChiTietCombo (  
    MaChiTietCombo INT PRIMARY KEY IDENTITY(1,1),  
    MaCombo VARCHAR(30) NOT NULL,  
    MaSanPham VARCHAR(30) NOT NULL,  
    SoLuong INT NOT NULL,  
    FOREIGN KEY (MaCombo) REFERENCES Combo(MaCombo),  
    FOREIGN KEY (MaSanPham) REFERENCES Kho(MaSanPham)  
);

-- Bảng Quan Ly Thuc Don  
CREATE TABLE ThucDon (  
    MaSanPham VARCHAR(30) PRIMARY KEY NOT NULL,  
    TenSanPham NVARCHAR(250) NOT NULL,  
	HinhAnh VARBINARY(MAX),
    DonGia FLOAT,
	MaLoaiHang VARCHAR(20)
);  

-- Bảng Quan Ly Khuyen Mai  
CREATE TABLE KhuyenMai (  
    MaKhuyenMai VARCHAR(12) PRIMARY KEY,  
    NgayBatDau DATETIME NOT NULL,  
    NgayKetThuc DATETIME NOT NULL,  
    GiaTriGiam DECIMAL(10, 2),  
    SoLuong INT,  
    TrangThai BIT  
);  

-- Bảng Quan Ly Ban  
CREATE TABLE Ban (  
    MaBan VARCHAR(20) PRIMARY KEY NOT NULL,  
    TenBan NVARCHAR(50) NOT NULL,  
    TrangThaiBan BIT  
);  

-- Bảng Khach Hang Than Thiet  
CREATE TABLE KhachHangThanThiet (  
    MaKhachHang VARCHAR(30) PRIMARY KEY NOT NULL,  
    TenKhachHang NVARCHAR(250) NOT NULL,  
    SoDienThoai VARCHAR(15),   
    DiemTichLuy INT DEFAULT 0,  
);

-- bảng đơn đặt
CREATE TABLE DonDat (  
    MaDonDat INT IDENTITY(1,1) PRIMARY KEY,  
    MaBan VARCHAR(20) NOT NULL,  
	TongTien FLOAT,
    HinhThucThanhToan NVARCHAR(50),  
    SoTienNhan FLOAT NULL, 
    SoTienTra FLOAT NULL,  
	MaKhuyenMai VARCHAR(12) null,
	MaKhachHang VARCHAR(30) null,
    FOREIGN KEY (MaBan) REFERENCES Ban(MaBan)  ,
	FOREIGN KEY (MaKhuyenMai) REFERENCES KhuyenMai(MaKhuyenMai),
	FOREIGN KEY (MaKhachHang) REFERENCES KhachHangThanThiet(MaKhachHang)
);

-- Bảng chi tiết hóa đơn
CREATE TABLE ChiTietDonDat (  
	MaDonDat INT NOT NULL, 
    ID INT IDENTITY(1,1) PRIMARY KEY,  
    MaSanPham VARCHAR(30) NULL,  
    MaCombo VARCHAR(30) NULL,  
    SoLuong INT NOT NULL,   
	DonGia FLOAT NULL, 
	FOREIGN KEY (MaDonDat) REFERENCES DonDat(MaDonDat),
    FOREIGN KEY (MaSanPham) REFERENCES ThucDon(MaSanPham),  
    FOREIGN KEY (MaCombo) REFERENCES Combo(MaCombo)  
);


-- Bảng Hoa Don  
CREATE TABLE HoaDon (  
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY, 
	MaDonDat INT not NULL,   
    NgayThanhToan DATETIME,   
    FOREIGN KEY (MaDonDat) REFERENCES DonDat(MaDonDat)  
);   

-- Bảng Doanh Thu  
CREATE TABLE DoanhThu (  
	MaNhapHang INT,
    Thang INT NOT NULL,  
    Nam INT NOT NULL,  
    NgayGhiNhan DATE NOT NULL,  
    MaHoaDon INT,  -- Kết nối với bảng HoaDon (Hóa đơn)  
    TongChiTieu FLOAT,  -- Tổng chi tiêu  
    TongDoanhThu FLOAT,  -- Tổng doanh thu  
    PRIMARY KEY (Thang, Nam, NgayGhiNhan),  
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),  
	FOREIGN KEY (MaNhapHang) REFERENCES NhapHang(MaNhapHang)
);


INSERT INTO NhanVien (MaNhanVien, AnhNhanVien, TenNhanVien, GioiTinh, NgaySinh, SoDienThoai, Email, DiaChi, ChucVu, SoGioLam) VALUES  
('NV001', NULL, N'Trần Văn A', N'Nam', '01/03/1995', '0123456789', 'trana@example.com', N'123 Đường 1, Phường 1, Quận 1', N'Nhân viên', 160),  
('NV002', NULL, N'Nguyễn Thị B', N'Nữ', '01/03/1995', '0987654321', 'bnguyen@example.com', N'456 Đường 2, Phường 2, Quận 2', N'Trưởng phòng', 180),  
('NV003', NULL, N'Phạm Văn C', N'Nam', '01/03/1995', '0912345678', 'cpv@example.com', N'789 Đường 3, Phường 3, Quận 3', N'Nhân viên', 200),  
('NV004', NULL, N'Lê Thị D', N'Nữ', '01/03/1995', '0978563412', 'dlth@example.com', N'101 Đường 4, Phường 4, Quận 4', N'Nhân viên', 160),  
('NV005', NULL, N'Trần Văn E', N'Nam', '01/03/1995', '0934298765', 'etran@example.com', N'202 Đường 5, Phường 5, Quận 5', N'Nhân viên', 200),  
('NV006', NULL, N'Nguyễn Văn F', N'Nam', '01/03/1995', '0901234567', 'fnv@example.com', N'303 Đường 6, Phường 6, Quận 6', N'Nhân viên', 0),  
('NV007', NULL, N'Phạm Thị G', N'Nữ', '01/03/1995', '0981234567', 'gpt@example.com', N'404 Đường 7, Phường 7, Quận 7', N'Kế toán', 180),  
('NV008', NULL, N'Lê Văn H', N'Nam', '01/03/1995', '0919876543', 'hlv@example.com', N'505 Đường 8, Phường 8, Quận 8', N'Nhân viên', 160),  
('NV009', NULL, N'Nguyễn Văn I', N'Nam', '01/03/1995', '0971234567', 'inv@example.com', N'606 Đường 9, Phường 9, Quận 9', N'Nhân viên', 0),  
('NV010', NULL, N'Phạm Thị K', N'Nữ', '01/03/1995', '0902345678', 'kp@example.com', N'707 Đường 10, Phường 10, Quận 10', N'Quản lý', 200);


INSERT INTO Luong (MaNhanVien, LuongCoBan, Thang, SoNgayLam, ThuongChuyenCan, ThuongHieuSuat) VALUES
('NV001', 8000000, 1, 22, 500000, 1000000),
('NV002', 10000000, 1, 23, 600000, 1500000),
('NV003', 9000000, 1, 24, 700000, 1200000),
('NV004', 8500000, 1, 22, 500000, 1100000),
('NV005', 9500000, 1, 24, 700000, 1300000),
('NV006', 7500000, 1, 0, 0, 0),  -- Không làm việc
('NV007', 11000000, 1, 22, 600000, 1600000),
('NV008', 8000000, 1, 22, 500000, 1000000),
('NV010', 12000000, 1, 24, 800000, 1700000);

select * from NhanVien

select * from Luong

SELECT * FROM Luong WHERE MaNhanVien = 'NV001' AND Thang = 2;
DELETE FROM Luong WHERE MaNhanVien = 'NV001' AND Thang = 2; -- Thay MãNhânViênCầnXóa và 1 bằng giá trị cụ thể



SELECT COLUMN_NAME, DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Luong';

EXEC sp_help 'Luong';






























---- 11. Bảng Chi Tiet Hoa Don  
--CREATE TABLE ChiTietHoaDon (  
--    MaChiTiet INT IDENTITY(1,1) PRIMARY KEY,  
--    MaHoaDon INT NOT NULL,  
--    MaSanPham VARCHAR(30) NOT NULL,	0
--    TenSanPham NVARCHAR(250) NOT NULL,  
--    SoLuong INT,  
--    DonGia FLOAT,  
--    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),  
--    FOREIGN KEY (MaSanPham) REFERENCES ThucDon(MaSanPham)  
--);  