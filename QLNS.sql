--drop database QLNSu
CREATE DATABASE QLNSu
GO
USE QLNSu;

CREATE TABLE ChucVu
(
	MaCV varchar(10) primary key,
	TenCV nvarchar(50) not null unique,
) 
GO
CREATE TABLE PhongBan
(
	MaPB varchar(10) primary key,
	TenPB nvarchar(50) not null unique
)
GO
CREATE TABLE NhanVien
(
	MaNV varchar(10) primary key,
	HoTenNV nvarchar(30) not null,
	DiaChi nvarchar(50) not null,
	CMND char(12) unique,
	SDT char(10) unique,
	GioiTinh nvarchar(3),
	Email nvarchar (30) unique,
	NgaySinh date,
	MaCV varchar(10) not null foreign key(MaCV) references ChucVu(MaCV),
	MaPB varchar(10) not null foreign key(MaPB) references PhongBan(MaPB)
)
GO
CREATE TABLE Luong
(
	MaLuong varchar(10) primary key,
	LuongCB int not null,
	HSL float not null,
	TongLuong int,
	PhuCap int,
	Thuong int,
	KiLuat int,
	SoGioTangCa int,
	NgayCong int,
	GhiChu nvarchar(50) NULL,
	MaNV varchar(10) not null foreign key(MaNV) references NhanVien(MaNV)
)
GO
CREATE TABLE HopDong
(
	MaHD varchar(20) primary key,
	NgayKy date,
	NgayBD date,
	HanHD int,
	GhiChu nvarchar(50) NULL,
	MaNV varchar(10) foreign key(MaNV) references NhanVien(MaNV)
)
GO 
CREATE TABLE NghiPhep
(
	MaNghiPhep varchar(10) primary key,
	NgayPhep date,
	SoNgayNghi int,
	LyDo nvarchar(50),
	GhiChu nvarchar(50) NULL,
	MaNV varchar(10) foreign key(MaNV) references NhanVien(MaNV)
)

insert into PhongBan(MaPB,TenPB) values
('PKD', N'Kinh doanh'),
('PKT', N'Kế toán'),
('PNS', N'Nhân sự'),
('PKTH', N'Kỹ thuật')

insert into ChucVu(MaCV, TenCV) values
('GD', N'Giám đốc'),
('PGD', N'Phó Giám đốc'),
('TP', N'Trưởng phòng'),
('PP', N'Phó Phòng'),
('NV', N'Nhân viên')

select nv.MaNV, nv.HoTenNV, cv.TenCV, pb.TenPB, l.Thuong, l.PhuCap, l.LuongCB, l.SoGioTangCa, l.HSL, l.KiLuat, l.NgayCong, l.GhiChu from NhanVien nv, Luong l, ChucVu cv, PhongBan pb where nv.MaNV=l.MaNV and nv.MaCV=cv.MaCV and nv.MaPB=pb.MaPB
select nv.MaNV, nv.HoTenNV, nv.DiaChi, nv.CMND, nv.SDT, nv.GioiTinh, nv.Email, nv.NgaySinh, pb.TenPB, cv.TenCV from NhanVien nv, ChucVu cv, PhongBan pb where nv.MaCV=cv.MaCV and nv.MaPB=pb.MaPB
select * from PhongBan
select * from ChucVu
select * from NhanVien