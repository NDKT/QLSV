create database QuanLySinhVien
go
use QuanLySinhVien
go

create table TaiKhoan (
	ID int identity primary key,
	TenDangNhap varchar(255) unique,
	MatKhau varchar(255)
)
go
create table Lop (
	MaLop varchar(255) primary key,
	TenLop nvarchar(255),
)
go

create table MonHoc(
	MaMH varchar(255) primary key,
	TenMH nvarchar(255),
	TC int,
	KieuThi nvarchar(255),
	Tiet int
)

go
create table SinhVien(
	MaSV varchar(255) not null primary key,
	TenSV nvarchar(255),
	NgayNhapHoc date,
	QueQuan nvarchar(255),
	NgaySinh date,
	GioiTinh nvarchar(10),
	MaLop varchar(255)
	foreign key (MaLop) references Lop(MaLop)
)
go

create table Diem(
	MaSV varchar(255),
	MaMH varchar(255),
	ChuyenCan float,
	ThuongXuyen float,
	KetThuc float,
	TongKet as (ChuyenCan*0.1+ThuongXuyen*0.3 + KetThuc*0.6),
	foreign key (MaSV) references SinhVien(MaSV),
	foreign key (MaMH) references MonHoc(MaMH),
	primary key (MaSV, MaMH)
)
go

insert into TaiKhoan (TenDangNhap, MatKhau) values ('admin', '1234567')