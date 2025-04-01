﻿GO
CREATE DATABASE lab8;
GO
USE lab8;
exec sp_changedbowner mylogin;
SELECT name 
FROM sys.databases 
WHERE SUSER_SNAME(owner_sid) = 'mylogin';


-- Tạo các bảng
CREATE TABLE LOPHOC(
	MALOP CHAR(6) PRIMARY KEY,
	TENLOP NVARCHAR(25) NOT NULL,
);

CREATE TABLE SINHVIEN (
	MSSV CHAR(6) PRIMARY KEY,
	HOVATEN NVARCHAR(255) NOT NULL,
	MALOP CHAR(6) NOT NULL,
	FOREIGN KEY (MALOP) REFERENCES LOPHOC(MALOP),
);

CREATE TABLE CANBO (
	MACB CHAR(3) PRIMARY KEY,
	TENCANBO NVARCHAR(255) NOT NULL,
	MATKHAU varchar(255) NOT NULL,
);

CREATE TABLE MONHOC(
	MAMON CHAR(5) PRIMARY KEY,
	TENMON NVARCHAR(255) NOT NULL,
);

CREATE TABLE GIANGDAY(
	MACB CHAR(3) NOT NULL,
	MAMON CHAR(5) NOT NULL,
	MALOP CHAR(6) NOT NULL,
	PRIMARY KEY (MACB, MAMON, MALOP),
	FOREIGN KEY (MACB) 
		REFERENCES CANBO(MACB), 
	FOREIGN KEY (MAMON) 
		REFERENCES MONHOC(MAMON), 
	FOREIGN KEY (MALOP) 
		REFERENCES LOPHOC(MALOP), 
);

CREATE TABLE HOCMON(
	MSSV CHAR(6) NOT NULL,
	MAMON CHAR (5) NOT NULL,
	DIEMSO DECIMAL(3,1) NOT NULL DEFAULT 00.0,
	DIEMCHU VARCHAR(2) NOT NULL DEFAULT 'F',
	PRIMARY KEY (MSSV, MAMON),
	FOREIGN KEY (MSSV) REFERENCES SINHVIEN(MSSV),
	FOREIGN KEY (MAMON) REFERENCES MONHOC(MAMON),
);

-- Thêm dữ liệu vào bảng LOPHOC

INSERT INTO LOPHOC VALUES ('K44-01',N'CNPM 01');
INSERT INTO LOPHOC VALUES ('K44-02',N'CNPM 02');
INSERT INTO LOPHOC VALUES ('K44-03',N'CNPM 03');

-- Thêm dữ liệu vào bảng SINHVIEN

INSERT INTO SINHVIEN VALUES('B18001',N'Phạm Thị Bảo Nhiên','K44-01');
INSERT INTO SINHVIEN VALUES('B18002',N'Nguyễn Văn An','K44-01');
INSERT INTO SINHVIEN VALUES('B18003',N'Lê Hoài Anh','K44-01');
INSERT INTO SINHVIEN VALUES('B18004',N'Nguyễn Lâm Hoàng Anh','K44-01');
INSERT INTO SINHVIEN VALUES('B18005',N'Lê Minh Bằng','K44-01');

INSERT INTO SINHVIEN VALUES('B18006',N'Vương Thừa Chấn','K44-02');
INSERT INTO SINHVIEN VALUES('B18007',N'Cao Công Danh','K44-02');
INSERT INTO SINHVIEN VALUES('B18008',N'Trịnh Lê Long Đức','K44-02');
INSERT INTO SINHVIEN VALUES('B18009',N'Dương Lê Minh Hậu','K44-02');
INSERT INTO SINHVIEN VALUES('B18010',N'Nguyễn Vũ Hoàng','K44-02');

INSERT INTO SINHVIEN VALUES('B18011',N'Nguyễn Hoàng Thái Học','K44-03');
INSERT INTO SINHVIEN VALUES('B18012',N'Nguyễn Quốc Huy','K44-03');
INSERT INTO SINHVIEN VALUES('B18013',N'Võ Đoàn Gia Huy','K44-03');
INSERT INTO SINHVIEN VALUES('B18014',N'Vũ Thị Bích Huyền','K44-03');
INSERT INTO SINHVIEN VALUES('B18015',N'Hồ Việt Hưng','K44-03');

-- Thêm dữ liệu vào bảng CANBO

INSERT INTO CANBO VALUES('001',N'Nguyễn Văn Cường','123');
INSERT INTO CANBO VALUES('002',N'Huỳnh Minh Phương','123');
INSERT INTO CANBO VALUES('003',N'Thái Cẩm Nhung','123');

-- Thêm dữ liệu vào bảng MONHOC

INSERT INTO MONHOC VALUES ('CT101',N'Lập trình căn bản');
INSERT INTO MONHOC VALUES ('CT103',N'Cấu trúc dữ liệu');
INSERT INTO MONHOC VALUES ('CT251',N'Phát triển ứng dụng trên Windows');

-- Thêm dữ liệu vào bảng GIANGDAY

INSERT INTO GIANGDAY VALUES('001','CT101','K44-01');
INSERT INTO GIANGDAY VALUES('001','CT101','K44-02');

INSERT INTO GIANGDAY VALUES('001','CT103','K44-01');
INSERT INTO GIANGDAY VALUES('001','CT103','K44-03');

INSERT INTO GIANGDAY VALUES('002','CT101','K44-03');
INSERT INTO GIANGDAY VALUES('002','CT103','K44-02');

INSERT INTO GIANGDAY VALUES('003','CT251','K44-01');
INSERT INTO GIANGDAY VALUES('003','CT251','K44-02');
INSERT INTO GIANGDAY VALUES('003','CT251','K44-03');

-- Thêm dữ liệu vào bảng HOCMON

INSERT INTO HOCMON (MSSV,MAMON)
	SELECT SV.MSSV, GD.MAMON 
	FROM SINHVIEN SV JOIN GIANGDAY GD
	ON SV.MALOP = GD.MALOP;