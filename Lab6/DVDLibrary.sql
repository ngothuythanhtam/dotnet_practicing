create database Lab6;
use Lab6;

create Login mylogin with password = 'mylogin', CHECK_POLICY = OFF
EXEC sp_changedbowner 'mylogin';

SELECT name, suser_sname(owner_sid) AS owner
FROM sys.databases
WHERE suser_sname(owner_sid) = 'mylogin';

/*************************************************************************************/
create table DVDLibrary(
	DVDCodeNo int primary key,
	DVDTitle nvarchar(100) not null,
	[Language] nvarchar(20) not null,
	subtitle bit not null,
	price money not null
);
select * from DVDLibrary;


create table ChucVu(
	MaCV int primary key,
	TenCV nvarchar(30)
);

/*************************************************************************************/
create table CanBo(
	MaCB int primary key,
	TenCB nvarchar(30),
	MaCV int,
	constraint FK_MaCV foreign key (MaCV) references ChucVu(MaCV),
	SoGioGiang int,
	DonGia money
);

insert into ChucVu(MaCV, TenCV) values (1, 'Giang Vien');
INSERT INTO ChucVu (MaCV, TenCV) VALUES 
(2, 'Truong Khoa'),
(3, 'Pho Truong Khoa'),
(4, 'Tro Giang'),
(5, 'Nhan Vien Hanh Chinh');

select * from CanBo;

/*************************************************************************************/
create database ThanhToan;
use ThanhToan;

create table Phong(
	MaPhong int primary key,
	TenPhong varchar(20)
);

create table KhachHang (
	SoHD int primary key,
	TenKH nvarchar(30),
	SoCMND varchar(11),
	SoTien money,
	NgayTT datetime,
	SoPhong int,
	constraint FK_MaPhong foreign key (SoPhong) references Phong(MaPhong)
);

INSERT INTO Phong(MaPhong, TenPhong) VALUES 
(1, 'A01'),
(2, 'A02'),
(3, 'A03'),
(4, 'A04'),
(5, 'A05');

select * from KhachHang;