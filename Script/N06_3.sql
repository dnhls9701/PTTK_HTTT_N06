﻿CREATE DATABASE QLTC;
GO
USE QLTC;

GO
CREATE TABLE KHACHHANG
(
	MAKHACHHANG VARCHAR(10) PRIMARY KEY NOT NULL,
	TENKHACHHANG NVARCHAR(40),
	GIOITINH NVARCHAR(3) CHECK(GIOITINH = N'NAM' OR GIOITINH = N'NỮ'),
	NGAYSINH DATE,
	SODIENTHOAI CHAR(10),
	DIACHI NVARCHAR(100),
	TENNGUOIGIAMHO NVARCHAR(40),
	MOIQUANHENGH NVARCHAR(10)
)
GO

CREATE TABLE TRUNGTAM
(
	MATRUNGTAM VARCHAR(10) PRIMARY KEY NOT NULL,
	TENTRUNGTAM NVARCHAR(40),
	DIACHI NVARCHAR(100)
)
GO

CREATE TABLE NHACUNGCAP
(
	MANHACUNGCAP VARCHAR(10) PRIMARY KEY NOT NULL,
	TENNHACUNGCAP NVARCHAR(40),
	SDTNCC CHAR(10),
	DIACHINCC NVARCHAR(100)
)
GO

CREATE TABLE TAIKHOAN
(
	TENTAIKHOAN VARCHAR(10) PRIMARY KEY NOT NULL,
	MATKHAU VARCHAR(20) NOT NULL,
	LOAIND INT NOT NULL
	CONSTRAINT C_TAIKHOAN_LOAIND CHECK(LOAIND IN(0, 1, 2))
	--0 là khách hàng, 1 là nhân viên, 2 là bộ phận điều hành
)
GO

CREATE TABLE NHANVIEN
(
	MANHANVIEN VARCHAR(10) PRIMARY KEY NOT NULL,
	TENNHANVIEN NVARCHAR(40),
	NGAYSINH DATE,
	SODIENTHOAI CHAR(10),
	EMAIL VARCHAR(40),
	DIACHI NVARCHAR(100),
	BANGCAP NVARCHAR(20),
	LUONG FLOAT,
	TRUNGTAMLAMVIEC VARCHAR(10) NOT NULL,
	VITRI INT NOT NULL,
	CONSTRAINT C_NHANVIEN_VITRI CHECK(VITRI IN(0, 1, 2, 3))
	--0: Nhân viên hướng dẫn, 1: Nhân viên y tế, 2: Bác sĩ, 3: Nhân viên kế toán
)
GO

CREATE TABLE BOPHANDIEUHANH
(
	MADIEUHANH VARCHAR(10) PRIMARY KEY NOT NULL,
	TRUNGTAMQUANLY VARCHAR(10) NOT NULL,
)
GO

CREATE TABLE VACXIN
(
	MAVACXIN VARCHAR(10) PRIMARY KEY NOT NULL,
	TENVACXIN NVARCHAR(40),
	MOTA NVARCHAR(100),
	SOLUONGTON INT,
	NHACUNGCAP VARCHAR(10),
	DONGIA FLOAT
)
GO

CREATE TABLE GOITIEM
(
	MAGOITIEM VARCHAR(10) PRIMARY KEY NOT NULL,
	TENGOITIEM NVARCHAR(40),
	MOTA NVARCHAR(100),
	GIAGOI FLOAT
)
GO

CREATE TABLE CHITIETGOITIEM
(
	MAGOITIEM VARCHAR(10) NOT NULL,
	MAVACXIN VARCHAR(10) NOT NULL,
	SOLUONG INT,
	PRIMARY KEY(MAGOITIEM, MAVACXIN)
)
GO

CREATE TABLE DONNHAPVACXIN
(
	MADONNHAP VARCHAR(10),
	MABOPHANDIEUHANH VARCHAR(10),
	TRUNGTAMQUANLY VARCHAR(10),
	NGAYNHAP DATE,
	PRIMARY KEY(MADONNHAP)
)
GO

CREATE TABLE CHITIETDONNHAP
(
	MADONNHAP VARCHAR(10) NOT NULL,
	MAVACXIN VARCHAR(10) NOT NULL,
	SOLUONG INT,
	DONGIANHAP INT
	PRIMARY KEY (MADONNHAP, MAVACXIN)
)
GO

CREATE TABLE PHIEUDANGKY
(
	MADANGKY VARCHAR(10) PRIMARY KEY NOT NULL,
	NGAYLAPPHIEU DATE,
	MAKHACHHANG VARCHAR(10) NOT NULL,
	MATRUNGTAM VARCHAR(10) NOT NULL,
	NGAYTIEMDUKIEN DATE,
	LOAI INT --0:Đăng ký gói ; 1:Đăng ký lẻ

)
GO

CREATE TABLE CHITIETDKGOI
(
	MADANGKY VARCHAR(10),
	MAGOITIEM VARCHAR(10)
	PRIMARY KEY(MADANGKY, MAGOITIEM)
)
GO

CREATE TABLE CHITIETDKLE
(
	MADANGKY VARCHAR(10),
	MAVACXIN VARCHAR(10)
	PRIMARY KEY(MADANGKY, MAVACXIN)
)
GO

CREATE TABLE PHIEUTIEMCHUNG
(
	MAPHIEUTIEMCHUNG VARCHAR(10) PRIMARY KEY NOT NULL,
	MAVACXIN VARCHAR(10),
	MAKHACHHANG VARCHAR(10),
	NGAYTIEM DATE,
	GHICHU NVARCHAR(100)
)
GO

CREATE TABLE HOADON
(
	MAHOADON VARCHAR(10) PRIMARY KEY NOT NULL,
	MAKHACHHANG VARCHAR(10) NOT NULL,
	MATRUNGTAM VARCHAR(10) NOT NULL,
	NGAYTHANHTOAN DATE,
	SOTIEN FLOAT,
	NHANVIENLAPHOADON VARCHAR(10),
	HINHTHUCTHANHTOAN NVARCHAR(30),
	NOIDUNG NVARCHAR(200)
)
GO

CREATE TABLE PHIEUKHAMBENH
(
	MAPHIEUKHAMBENH VARCHAR(10) PRIMARY KEY NOT NULL,
	MAKHACHHANG VARCHAR(10) NOT NULL,
	MATRUNGTAM VARCHAR(10) NOT NULL,
	NGAYLAPPHIEU DATE,
	BACSI VARCHAR(10),
	BENHLY NVARCHAR(200)
)
GO

CREATE TABLE PHANCONG
(
	MANHANVIEN VARCHAR(10) ,
	NGAYPHANCONG DATE,
	CALAM INT,
	PHONGLAMVIEC INT NOT NULL,
	PRIMARY KEY(MANHANVIEN,NGAYPHANCONG,CALAM)
)
GO

CREATE TABLE LICHRANH
(
	MANHANVIEN VARCHAR(10) ,
	VITRI INT,
	NGAYRANH DATE,
	CARANH INT,
	PRIMARY KEY(MANHANVIEN,NGAYRANH,CARANH)
)

CREATE TABLE DATMUAVACXIN
(
	MADATMUA VARCHAR(10) PRIMARY KEY NOT NULL,
	NGAYDAT DATE,
	MAKHACHHANG VARCHAR(10),
	MATRUNGTAM VARCHAR(10),
	TINHTRANG NVARCHAR(100),
	LOAI INT --0:Đặt mua gói ; 1:Đặt mua lẻ
)

CREATE TABLE CHITIETDATMUAGOI
(
	MADATMUA VARCHAR(10),
	MAGOITIEM VARCHAR(10)
	PRIMARY KEY(MADATMUA, MAGOITIEM)
)

CREATE TABLE CHITIETDATMUALE
(
	MADATMUA VARCHAR(10),
	MAVACXIN VARCHAR(10)
	PRIMARY KEY(MADATMUA, MAVACXIN)
)



---KHOA NGOAI

ALTER TABLE KHACHHANG ADD
	CONSTRAINT FK_KHACHHANG_TAIKHOAN FOREIGN KEY (MAKHACHHANG) REFERENCES TAIKHOAN (TENTAIKHOAN)
GO

ALTER TABLE NHANVIEN ADD
	CONSTRAINT FK_NHANVIEN_TAIKHOAN FOREIGN KEY (MANHANVIEN) REFERENCES TAIKHOAN (TENTAIKHOAN)
GO
ALTER TABLE NHANVIEN ADD
	CONSTRAINT FK_NHANVIEN_TRUNGTAM FOREIGN KEY (TRUNGTAMLAMVIEC) REFERENCES TRUNGTAM (MATRUNGTAM)
GO

ALTER TABLE BOPHANDIEUHANH ADD
	CONSTRAINT FK_BOPHANDIEUHANH_TAIKHOAN FOREIGN KEY (MADIEUHANH) REFERENCES TAIKHOAN (TENTAIKHOAN)
GO
ALTER TABLE BOPHANDIEUHANH ADD
	CONSTRAINT FK_BOPHANDIEUHANH_TRUNGTAM FOREIGN KEY (TRUNGTAMQUANLY) REFERENCES TRUNGTAM (MATRUNGTAM)
GO

ALTER TABLE VACXIN ADD
	CONSTRAINT FK_VACXIN_NHACUNGCAP FOREIGN KEY (NHACUNGCAP) REFERENCES NHACUNGCAP (MANHACUNGCAP)
GO

ALTER TABLE CHITIETGOITIEM ADD
	CONSTRAINT FK_CHITIETGOITIEM_VACXIN FOREIGN KEY (MAVACXIN) REFERENCES VACXIN (MAVACXIN),
	CONSTRAINT FK_CHITIETGOITIEM_GOITIEM FOREIGN KEY (MAGOITIEM) REFERENCES GOITIEM (MAGOITIEM)
GO

ALTER TABLE DONNHAPVACXIN ADD
	CONSTRAINT FK_DONNHAPVACXIN_BOPHANDIEUHANH FOREIGN KEY (MABOPHANDIEUHANH) REFERENCES BOPHANDIEUHANH (MADIEUHANH),
	CONSTRAINT FK_DONNHAPVACXIN_TRUNGTAM FOREIGN KEY (TRUNGTAMQUANLY) REFERENCES TRUNGTAM (MATRUNGTAM)
GO

ALTER TABLE CHITIETDONNHAP ADD
	CONSTRAINT FK_CHITIETDONNHAP_VACXIN FOREIGN KEY (MAVACXIN) REFERENCES VACXIN (MAVACXIN),
	CONSTRAINT FK_CHITIETDONNHAP_DONNHAPVACXIN FOREIGN KEY (MADONNHAP) REFERENCES DONNHAPVACXIN (MADONNHAP)
GO

ALTER TABLE PHIEUDANGKY ADD
	CONSTRAINT FK_PHIEUDANGKY_KHACHHANG FOREIGN KEY (MAKHACHHANG) REFERENCES KHACHHANG (MAKHACHHANG),
	CONSTRAINT FK_PHIEUDANGKY_TRUNGTAM FOREIGN KEY (MATRUNGTAM) REFERENCES TRUNGTAM (MATRUNGTAM)
GO

ALTER TABLE CHITIETDKGOI ADD
	CONSTRAINT FK_CHITIETDKGOI_GOITIEM FOREIGN KEY (MAGOITIEM) REFERENCES GOITIEM (MAGOITIEM),
	CONSTRAINT FK_CHITIETDKGOI_PHIEUDANGKY FOREIGN KEY (MADANGKY) REFERENCES PHIEUDANGKY(MADANGKY)
GO

ALTER TABLE CHITIETDKLE ADD
	CONSTRAINT FK_CHITIETDKLE_GOITIEM FOREIGN KEY (MAVACXIN) REFERENCES VACXIN (MAVACXIN),
	CONSTRAINT FK_CHITIETDKLE_PHIEUDANGKY FOREIGN KEY (MADANGKY) REFERENCES PHIEUDANGKY(MADANGKY)
GO

ALTER TABLE PHIEUTIEMCHUNG ADD
	CONSTRAINT FK_PHIEUTIEMCHUNG_KHACHHANG FOREIGN KEY (MAKHACHHANG) REFERENCES KHACHHANG (MAKHACHHANG),
	CONSTRAINT FK_PHIEUTIEMCHUNG_VACXIN FOREIGN KEY (MAVACXIN) REFERENCES VACXIN (MAVACXIN)
GO

ALTER TABLE HOADON ADD 
	CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY (MAKHACHHANG) REFERENCES KHACHHANG(MAKHACHHANG),
	CONSTRAINT FK_HOADON_TRUNGTAM FOREIGN KEY (MATRUNGTAM) REFERENCES TRUNGTAM(MATRUNGTAM),
	CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY (NHANVIENLAPHOADON) REFERENCES NHANVIEN (MANHANVIEN)
GO

ALTER TABLE PHIEUKHAMBENH ADD
	CONSTRAINT FK_PHIEUKHAMBENH_KHACHHANG FOREIGN KEY (MAKHACHHANG) REFERENCES KHACHHANG(MAKHACHHANG),
	CONSTRAINT FK_PHIEUKHAMBENH_TRUNGTAM FOREIGN KEY (MATRUNGTAM) REFERENCES TRUNGTAM(MATRUNGTAM),
	CONSTRAINT FK_PHIEUKHAMBENH_NHANVIEN FOREIGN KEY (BACSI) REFERENCES NHANVIEN(MANHANVIEN)
GO

ALTER TABLE PHANCONG ADD
	CONSTRAINT FK_PHANCONG_NHANVIEN FOREIGN KEY (MANHANVIEN) REFERENCES NHANVIEN(MANHANVIEN)
GO

ALTER TABLE LICHRANH ADD
	CONSTRAINT FK_LICHRANH_NHANVIEN FOREIGN KEY (MANHANVIEN) REFERENCES NHANVIEN(MANHANVIEN)
GO

ALTER TABLE DATMUAVACXIN ADD
	CONSTRAINT FK_DATMUAVACXIN_KHACHHANG FOREIGN KEY (MAKHACHHANG) REFERENCES KHACHHANG(MAKHACHHANG),
	CONSTRAINT FK_DATMUAVACXIN_TRUNGTAM FOREIGN KEY (MATRUNGTAM) REFERENCES TRUNGTAM(MATRUNGTAM)
GO

ALTER TABLE CHITIETDATMUAGOI ADD
	CONSTRAINT FK_CHITIETDATMUAGOI_GOITIEM FOREIGN KEY (MAGOITIEM) REFERENCES GOITIEM (MAGOITIEM),
	CONSTRAINT FK_CHITIETDATMUAGOI_DATMUA FOREIGN KEY (MADATMUA) REFERENCES DATMUAVACXIN (MADATMUA)
GO

ALTER TABLE CHITIETDATMUALE ADD
	CONSTRAINT FK_CHITIETDATMUALE_VACXIN FOREIGN KEY (MAVACXIN) REFERENCES VACXIN (MAVACXIN),
	CONSTRAINT FK_CHITIETDATMUALE_DATMUA FOREIGN KEY (MADATMUA) REFERENCES DATMUAVACXIN (MADATMUA)
GO

CREATE PROC CHECKMAKH
@makhachhang VARCHAR(10)
AS
BEGIN
	SELECT * FROM KHACHHANG WHERE MAKHACHHANG = @makhachhang
END