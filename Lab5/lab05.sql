-- Ex1 --
create database QL_HANGHOA;
use QL_HANGHOA;

create table DAILY(
	STT_DL int identity(1,1) primary key,
	TEN_DAILY nvarchar(20) not null,
	DIACHI_DL nvarchar(20) not null
);

create table HANGHOA(
	MA_HANG nvarchar(3) primary key,
	TEN_HG nvarchar(20) not null
);

create table BAN(
	MA_HANG nvarchar(3),
	STT_DL int,
	NGAY_BAN Smalldatetime not null DEFAULT GETDATE(),
	SOLG_BAN int not null CHECK (SOLG_BAN > 0),
	TRIGIA_BAN float(8) not null CHECK (TRIGIA_BAN > 0),
	primary key(MA_HANG, STT_DL, NGAY_BAN),
	constraint FK_BAN_DAILY foreign key (STT_DL) references DAILY(STT_DL) ON DELETE CASCADE ON UPDATE CASCADE,
	constraint FK_BAN_HANG_HOA foreign key (MA_HANG) references HANGHOA(MA_HANG) ON DELETE CASCADE ON UPDATE CASCADE,
	CHECK (NGAY_BAN <= GETDATE())
);

create table MUA(
	MA_HANG nvarchar(3),
	STT_DL int,
	NGAY_MUA Smalldatetime not null DEFAULT GETDATE(),
	SOLG_MUA int not null CHECK (SOLG_MUA > 0),
	TRIGIA_MUA float(8) not null CHECK (TRIGIA_MUA > 0),
	primary key(MA_HANG, STT_DL, NGAY_MUA),
	constraint FK_MUA_DAILY foreign key (STT_DL) references DAILY(STT_DL) ON DELETE CASCADE ON UPDATE CASCADE,
	constraint FK_MUA_HANG_HOA foreign key (MA_HANG) references HANGHOA(MA_HANG) ON DELETE CASCADE ON UPDATE CASCADE,
	CHECK (NGAY_MUA <= GETDATE()) 
);

-- Ex2 --
alter table DAILY
add SODT nvarchar(11);

alter table HANGHOA
add DVT char(12), NCC char(30);

create table LOAI_HG(
	MA_LOAI char(2) primary key,
	TEN_LOAI char(50)
);

alter table HANGHOA
add MA_LOAI char(2);

alter table HANGHOA
add constraint FK_HANGHOA_LOAI_HG foreign key (MA_LOAI) references LOAI_HG(MA_LOAI) 
ON UPDATE CASCADE
ON DELETE CASCADE;

-- EX3 --

/* 3.1
Vì bảng MUA và bảng BAN có khóa ngoại (STT_DL và MA_HANG) tham chiếu đến bảng DAILY và HANGHOA. 
Nếu nhập dữ liệu vào MUA trước khi có dữ liệu trong DAILY và HANGHOA, SQL Server sẽ báo lỗi do 
vi phạm ràng buộc toàn vẹn khóa ngoại. Do đó, để chèn dữ liệu vào bảng MUA và BAN thành công, 
cần phải có sẵn dữ liệu trong bảng HANGHOA và DAILY để tham chiếu khóa ngoại hợp lệ.
*/

INSERT INTO MUA (MA_HANG, STT_DL, NGAY_MUA, SOLG_MUA, TRIGIA_MUA) 
VALUES ('A01', 1, '2025-03-30', 10, 5000);

/* 3.2
The INSERT statement conflicted with the FOREIGN KEY constraint "FK_MUA_DAILY". 
The conflict occurred in database "QL_HANGHOA", table "dbo.DAILY", column 'STT_DL'.
--> Lỗi này xuất hiện vì STT_DL chưa tồn tại trong DAILY. 
SQL Server không cho phép thêm dữ liệu vào bảng MUA khi không có khóa ngoại hợp lệ trong DAILY và HANGHOA.

Nhận xét về CASCADE UPDATE
Khi mã hàng thay đổi trong HANGHOA, tất cả các bản ghi liên quan trong MUA và BAN cũng được cập nhật theo.
Nếu không có CASCADE UPDATE, khi đổi MA_HANG, các bản ghi trong MUA sẽ trỏ đến một mã hàng không tồn tại, gây lỗi khi truy vấn.
*/

INSERT INTO DAILY (TEN_DAILY, DIACHI_DL) 
VALUES (N'Đại lý A', N'123 Đường ABC');

INSERT INTO HANGHOA (MA_HANG, TEN_HG) 
VALUES ('A02', N'Hàng A');

INSERT INTO MUA (MA_HANG, STT_DL, NGAY_MUA, SOLG_MUA, TRIGIA_MUA) 
VALUES ('A02', 1, '2025-03-29', 10, 5000);

INSERT INTO BAN (MA_HANG, STT_DL, NGAY_BAN, SOLG_BAN, TRIGIA_BAN) 
VALUES ('A02', 1, '2025-03-30', 5, 2500);

select * from MUA, BAN;

UPDATE HANGHOA SET MA_HANG = 'B02' WHERE MA_HANG = 'A01';
select * from MUA, BAN;

/* 3.3
Sau khi chạy UPDATE, cả hai bảng MUA và BAN sẽ tự động cập nhật MA_HANG = 'A01' thành B02 nhờ CASCADE UPDATE.

Nhận xét về CASCADE UPDATE
Khi cập nhật mã hàng (MA_HANG) trong HANGHOA, tất cả bản ghi trong MUA và BAN có mã hàng đó cũng được cập nhật theo.
Giúp đảm bảo tính nhất quán của dữ liệu. Nếu không có CASCADE UPDATE, khi cập nhật MA_HANG trong HANGHOA, 
các bản ghi trong MUA và BAN vẫn giữ A01, khiến dữ liệu trở nên không hợp lệ (không thể tham chiếu đến HANGHOA nữa).
*/

/*3.4
Trường hợp 1: CASCADE DELETE được bật
Nếu CASCADE DELETE được kích hoạt, khi xóa một mã hàng trong HANGHOA, tất cả các bản ghi liên quan trong MUA cũng sẽ bị xóa.

Trường hợp 2: CASCADE DELETE không được bật
Nếu CASCADE DELETE bị tắt, khi cố gắng xóa một mã hàng trong HANGHOA mà vẫn có dữ liệu liên quan trong MUA, SQL Server sẽ báo lỗi.

Nhận xét về CASCADE DELETE
Khi CASCADE DELETE được bật: Xóa một bản ghi trong HANGHOA sẽ tự động xóa tất cả bản ghi liên quan trong MUA và BAN.
Khi CASCADE DELETE không được bật: Không thể xóa bản ghi trong HANGHOA nếu nó đang được tham chiếu ở MUA hoặc BAN.
*/

-- Ex4 --

-- 4.1 --
create table product(
	prod_nr int not null primary key,
	name varchar(30) not null,
	price money not null,
	type varchar(30) not null
);

-- 4.2 --
insert into product (prod_nr, name, price, type) values
(4, 'ColorTv', 700, 'electronic'),
(5,'Fan',350,'electronic'),
(6,'Heater',200,'electronic'),
(7,'Webcam',60,'Computer');

-- 4.3 --
select * from product;

-- 4.4 --
-- Tính trị giá trung bình ban đầu
DECLARE @avg_price MONEY;
SELECT @avg_price = AVG(price) FROM product;
PRINT 'Tri gia trung binh ban dau: ' + CAST(@avg_price AS VARCHAR);

-- 4.5 --
WHILE @avg_price < 500
BEGIN
    -- Tăng giá 5% cho tất cả sản phẩm
    UPDATE product
    SET price = price * 1.05;

    -- Cập nhật lại trị giá trung bình
    SELECT @avg_price = AVG(price) FROM product;
END

-- Hiển thị trị giá trung bình cuối cùng
PRINT 'Tri gia trung binh sau khi dieu chinh: ' + CAST(@avg_price AS VARCHAR);

-- Hiển thị bảng giá chi tiết sau khi tăng giá
SELECT * FROM product;


-- Ex5 --

-- 5.1
DROP PROCEDURE IF EXISTS TonKho;
GO
Create Procedure TonKho 
@STT_DL int, @Ma_HAng nvarchar(3),  
@TongMua int Output, @TongBan int Output, @Ton int Output 
As 
Begin 
    Select @TongMua=Sum(SoLg_Mua)  
    From Mua 
    Where STT_DL=@STT_DL and Ma_HAng=@Ma_Hang 

    If @TongMua Is NULL Return 

    Select @TongBan=Sum(SoLg_Ban)  
    From Ban 
    Where STT_DL=@STT_DL and Ma_Hang=@Ma_Hang 

    If @TongBan Is NULL  
    Set @TongBan = 0 

    Set @Ton = @TongMua-@TongBan 
End  
GO

Declare @Mua int, @Ban int, @Ton int 
Execute TonKho 1, 'A02', @Mua Output, @Ban Output, @Ton Output 
PRINT 'Tong mua: ' + ISNULL(CAST(@Mua AS VARCHAR(20)), '0') 
    + ' - Tong ban: ' + ISNULL(CAST(@Ban AS VARCHAR(20)), '0') 
    + ' - Ton: ' + ISNULL(CAST(@Ton AS VARCHAR(20)), '0');

-- 5.2
GO
Create Procedure BanHang 
	@STT_DL int, @Ma_Hang nvarchar(3), @SoLgBan int, @DonGia int 
As 
Begin 
	Declare  @TongMua int, @TongBan int 
	Select @TongMua=Sum(SoLg_Mua)  
	From Mua 
	Where STT_DL=@STT_DL and Ma_HAng=@Ma_Hang 
	If @TongMua Is NULL 
		Begin 
			print 'Mat hang ' + @Ma_Hang + ' khong co' + ' o dai ly' 
			Return 
		End 
	Select @TongBan=Sum(SoLg_Ban)  
	From Ban 
	Where STT_DL=@STT_DL and Ma_Hang=@Ma_Hang 
	if @TongBan Is Null  
		Set @TongBan=0 
		if @TongMua >= @TongBan + @SoLgBan 
			Insert Into Ban Values(@Ma_Hang, @STT_DL, GetDate(), @SoLgBan, @DonGia)  
		else print 'Khong du hang de ban' 
End
Go

select * from daily;
INSERT INTO DAILY (TEN_DAILY, DIACHI_DL) 
VALUES (N'Đại lý C', N'123 Đường ABC'),
       (N'Đại lý D', N'74 Đường LA'),
       (N'Đại lý E', N'99 Đường XYZ');

INSERT INTO HANGHOA (MA_HANG, TEN_HG) 
VALUES ('004', N'Hàng X'),
       ('005', N'Hàng Y'),
       ('006', N'Hàng Z');

INSERT INTO MUA (MA_HANG, STT_DL, NGAY_MUA, SOLG_MUA, TRIGIA_MUA) 
VALUES ('004', 3, '2025-03-28', 20, 10000),
       ('005', 4, '2025-03-29', 15, 7500),
       ('006', 5, '2025-03-30', 10, 5000);

INSERT INTO BAN (MA_HANG, STT_DL, NGAY_BAN, SOLG_BAN, TRIGIA_BAN) 
VALUES ('003', 3, '2025-03-29', 5, 2500),
       ('004', 4, '2025-03-30', 4, 2000),
       ('005', 5, '2025-03-31', 3, 1500);

EXEC BanHang 3, '004', 5, 12;  
SELECT * FROM BAN WHERE STT_DL = 3 AND MA_HANG = '004';

-- 5.3
Go
CREATE PROCEDURE TinhTonKhoTheoDaiLy
    @STT_DL int
AS
BEGIN
    SELECT 
        h.MA_HANG,
        h.TEN_HG,
        ISNULL(SUM(b.SOLG_BAN), 0) AS TongBan,
        ISNULL(SUM(m.SOLG_MUA), 0) AS TongMua,
        ISNULL(SUM(m.SOLG_MUA), 0) - ISNULL(SUM(b.SOLG_BAN), 0) AS TonKho
    FROM
        HANGHOA h
    LEFT JOIN BAN b ON h.MA_HANG = b.MA_HANG AND b.STT_DL = @STT_DL
    LEFT JOIN MUA m ON h.MA_HANG = m.MA_HANG AND m.STT_DL = @STT_DL
    GROUP BY h.MA_HANG, h.TEN_HG;
END
Go
EXEC TinhTonKhoTheoDaiLy '1'

-- 5.4
Go
Create Procedure TonKho_TatCaDaiLy 	
As 
Begin
	Select dl.STT_DL, dl.TEN_DAILY, h.Ma_Hang, sum(m.SoLG_Mua) as TongMua, sum(b.SoLG_Ban) as TongBan, sum(m.SoLG_Mua) - sum(b.SoLG_Ban) as Ton
	from DAILY dl
	cross join HangHoa h
	LEFT JOIN Mua m ON h.Ma_Hang = m.Ma_Hang AND m.STT_DL = dl.STT_DL
	LEFT JOIN Ban b ON h.Ma_Hang = b.Ma_Hang AND b.STT_DL = dl.STT_DL
	GROUP BY dl.STT_DL, dl.TEN_DAILY, h.Ma_Hang
End
Go
EXEC TonKho_TatCaDaiLy;  

-- 5.5
Go
CREATE PROCEDURE XoaHangHoa
    @Ma_Hang nvarchar(3)
AS
BEGIN
    DELETE FROM BAN WHERE MA_HANG = @Ma_Hang;
    DELETE FROM MUA WHERE MA_HANG = @Ma_Hang;
    DELETE FROM HANGHOA WHERE MA_HANG = @Ma_Hang;
END
Go
EXEC XoaHangHoa '002';

-- Ex6 --
create table nhanvien(
	manv int not null primary key,
	hoten varchar(30) not null,
	diachi varchar(30) not null
);

-- 6.1
Go
create procedure insert_nhanvien @manv int, @hoten varchar(30), @diachi varchar(30)
as 
begin
	insert into nhanvien (manv, hoten, diachi) values (@manv, @hoten, @diachi)
end
Go
exec insert_nhanvien 1,'Thanh Tam', '123 abc';

-- 6.2
declare 
	@manv int = 2,
	@hoten varchar(30) = 'Nguyen Van Thanh',
	@diachi varchar(30) = '01 Ly Tu Trong, NK - TPCT'
EXECUTE insert_nhanvien @manv, @hoten, @diachi
select * from nhanvien;

-- 6.3
go
create procedure update_diachi @manv int, @diachi varchar(30)
as
begin
	update nhanvien set diachi = @diachi where manv = @manv
end
go

-- 6.4
declare @manv int = 2, @diachi varchar(30) = '10 Ly Tu Trong, Q.NK - TPCT'
execute update_diachi @manv, @diachi
select * from nhanvien;

-- Ex7 --
CREATE DATABASE Northwind;
USE Northwind;

CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(40) NOT NULL,
    QuantityPerUnit NVARCHAR(20),
    UnitPrice MONEY,
    UnitsInStock SMALLINT,
    UnitsOnOrder SMALLINT,
    ReorderLevel SMALLINT,
    Discontinued BIT
);

CREATE TABLE Customers (
    CustomerID CHAR(5) PRIMARY KEY,
    CompanyName NVARCHAR(40) NOT NULL,
    ContactName NVARCHAR(30),
    ContactTitle NVARCHAR(30),
    AddressCustomer NVARCHAR(60),
    City NVARCHAR(15),
    Region NVARCHAR(15),
    PostalCode NVARCHAR(10),
    Country NVARCHAR(15),
    Phone NVARCHAR(24),
    Fax NVARCHAR(24)
);

CREATE TABLE Orders (
    OrderID int IDENTITY(1,1) PRIMARY KEY,
    CustomerID char(5) FOREIGN KEY REFERENCES Customers(CustomerID),
    OrderDate datetime
);

CREATE TABLE Order_Details (
    OrderID int FOREIGN KEY REFERENCES Orders(OrderID),
    ProductID int FOREIGN KEY REFERENCES Products(ProductID),
    UnitPrice money,
    Quantity smallint,
    Discount real
);
INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, AddressCustomer, City, Region, PostalCode, Country)
VALUES ('ALFKI', 'Alfreds Futterkiste', 'Maria Anders', 'Sales Representative', 'Obere Str. 57', 'Berlin', 'Berlin', '12209', 'Germany');

INSERT INTO Products (ProductName, UnitsInStock, UnitPrice, QuantityPerUnit)
VALUES ('New Product', 2, 10.00, 100);
SET IDENTITY_INSERT Orders ON;
INSERT INTO Orders (CustomerID, OrderID, OrderDate)
VALUES ('ALFKI', 10249, GETDATE());
SET IDENTITY_INSERT Orders OFF;

INSERT INTO Order_Details (OrderID, ProductID, UnitPrice, Quantity, Discount)
VALUES (10249, 1, 10.00, 5, 0);

go
CREATE PROCEDURE CalculateMoney_Order
    @OrderID char(5)
AS
BEGIN
    SELECT SUM(UnitPrice * Quantity - UnitPrice * Quantity * Discount) AS Total_Price
    FROM Order_Details
    WHERE OrderID = @OrderID
END
Exec CalculateMoney_Order '10249'
select * from Order_Details;

 -- Ex8 --
create table account (
	 acc_Id int primary key,
	 acc_Number varchar(9),
	 acc_Name varchar(30)
 );

GO
CREATE FUNCTION dbo.IsValidModulo11 (@accountNumber VARCHAR(9))
RETURNS BIT
AS
BEGIN
    DECLARE @Sum INT = 0;
    DECLARE @Position INT = 9;
    DECLARE @NumberString VARCHAR(9);

    -- Chuẩn hóa thành 9 chữ số (thêm số 0 vào đầu nếu cần)
    SET @NumberString = RIGHT('000000000' + @accountNumber, 9);

    -- Kiểm tra độ dài
    IF LEN(@NumberString) != 9
        RETURN 0;

    -- Tính tổng theo trọng số
    WHILE @Position >= 1
    BEGIN
        SET @Sum = @Sum + (CAST(SUBSTRING(@NumberString, 10 - @Position, 1) AS INT) * @Position);
        SET @Position = @Position - 1;
    END

    -- Kiểm tra Modulo 11 và trả về kết quả
    RETURN CASE WHEN @Sum % 11 = 0 THEN 1 ELSE 0 END;
END
GO

ALTER TABLE account
ADD CONSTRAINT CK_Account_Modulo11
CHECK (dbo.IsValidModulo11(acc_Number) = 1);

SELECT dbo.IsValidModulo11('999999999') AS IsValid; -- Returns 1 (Valid) or 0 (Invalid)

INSERT INTO account(acc_Id, acc_Number, acc_Name)  VALUES (1, '972428577', 'Nguyen Van A'); --  Hợp lệ
INSERT INTO account(acc_Id, acc_Number, acc_Name)  VALUES (2, '999999999', 'Nguyen Van B'); --  khong hợp lệ