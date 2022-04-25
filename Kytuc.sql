create database DemoKT
use DemoKT
create table Khu_nha
(
		Ma_Nha nvarchar(10) not null,
        Ten_Nha nvarchar(20) not null,
		constraint pk_manha primary key(Ma_Nha)
);
create table Phong
(
		Ma_Phong nvarchar(10) not null,
        Ten_Phong nvarchar(50) not null,
        Ma_Nha nvarchar(10) not null,
        Loai_Phong nvarchar(20) not null,
        So_Nguoi_Toi_Da int not null,
        So_Nguoi_Dang_O int,
        Tien_Thue decimal not null,
        Ghi_Chu text,
		constraint pk_maphong primary key(Ma_Phong),
		constraint fk_khunha_phong 
			foreign key (Ma_Nha) 
			references Khu_nha(Ma_Nha) 

);
create table Thiet_Bi
(
		Ma_Thiet_Bi nvarchar(10) not null,
        Ten_Thiet_Bi nvarchar(30) not null,
        Gia_Tri decimal not null,
		constraint pk_mathietbi primary key(Ma_Thiet_Bi)
);
create table Account 
(
	Account_id nvarchar(10) not null,
	Username nvarchar(100) not null,
    Pass nvarchar(1000) not null,
    Account_type int not null default 0,    -- 0 la staff va 1 la admin
	constraint pk_accountid primary key(Account_id)
);

create table Khoa
(
	Makhoa nvarchar(10) not null,
    Tenkhoa varchar(20),
	constraint pk_makhoa primary key(Makhoa)
);

create table Lop
(
	Malop nvarchar(10) not null,
    Tenlop varchar(30) not null,
    Makhoa nvarchar(10) not null,
	constraint pk_malop primary key(Malop),
    constraint fk_lop_makhoa 
		foreign key (Makhoa) 
		references Khoa(Makhoa)
);
create table Que
(
	Maque nvarchar(10) not null,
    Tenque varchar(20) not null,
	constraint pk_maque primary key(Maque),
);
create table Sinhvien
(
	Ma_sv nvarchar(10) not null,
    Ten_sv varchar(50) not null,
    Ngaysinh datetime not null,
    Gioitinh varchar(10) not null,
	Maque nvarchar(10),
	Makhoa nvarchar(10),
	Malop nvarchar(10),
	constraint pk_masv primary key(Ma_sv),
	constraint fk_sinhvien_maque 
		foreign key (Maque) 
		references Que(Maque),
	constraint fk_sinhvien_makhoa
		foreign key (Makhoa) 
		references Khoa(Makhoa),
	constraint fk_sinhvien_malop 
		foreign key (Malop) 
		references Lop(Malop),

);

create table Thietbi_Phong
(
		Ma_Phong nvarchar(10) not null,
        Ma_Thiet_Bi nvarchar(10) not null,
        So_Luong int,
        Tinh_Trang nvarchar(50) not null,
        constraint fk_thietiphong_maphong
			foreign key (Ma_Phong) 
			references Phong(Ma_Phong),
		constraint fk_thietiphong_mathietbi
		foreign key (Ma_Thiet_Bi) 
		references Thiet_Bi(Ma_Thiet_Bi)
);


create table Thutienphong
(
	Ma_Phong nvarchar(10) not null,
    Thang int not null,
    Nam int not null,
    Tiennha decimal not null,
    Tiendien decimal not null,
    Tiennuoc decimal not null,
    Tienvesinh decimal not null,
    Tienphat decimal,
    Ngayhethan date not null,
    Ngaydong date not null,
	constraint pk_thang_nam primary key(Thang,Nam),
    constraint fk_thutienphong_maphong
		foreign key (Ma_Phong) 
		references Phong(Ma_Phong)
);

create table Thuephong
(
	Masothue nvarchar(10) not null,
    Ma_sv nvarchar(10) not null,
    Ma_Phong nvarchar(10) not null,
    NgayBDau date not null,
    Ngaykt date not null,
    Ghichu text,
	constraint pk_masothue primary key(Masothue),
    constraint fk_thuephong_masv
		foreign key (Ma_sv) 
		references Sinhvien(Ma_sv),
	constraint fk_thuephong_maphong
		foreign key (Ma_Phong) 
		references Phong(Ma_Phong)
);
create table Traphong
(
	Masothue nvarchar(10) not null,
    Ngaytra date not null,
    Tienvipham decimal,
    constraint fk_traphong_masothue
		foreign key (Masothue) 
		references Thuephong(Masothue)
);





-- Insert thong tin

-- 1.khu nha
select * from Khu_nha
insert into Khu_nha (Ma_nha, Ten_nha)
values	('KN1','Khu nha A'),
		('KN2','Khu nha B'),
		('KN3','Khu nha C'),
		('KN4','Khu nha D');
-- 2.phong
select * from Phong
insert into Phong (Ma_Phong, Ten_Phong, Ma_Nha, Loai_Phong, So_Nguoi_Toi_Da, So_Nguoi_Dang_O, Tien_Thue, Ghi_Chu)
values	('MP01','Phong 001','KN1','Phong doi',2,1,300000,'Khong'),
		('MP02','Phong 002','KN1','Phong ba',3,3,400000,'Khong'),
		('MP03','Phong 003','KN1','Phong bon',4,0,500000,'Khong'),
		('MP04','Phong 004','KN2','Phong doi',2,1,300000,'Khong'),
		('MP05','Phong 005','KN2','Phong ba',3,1,400000,'Khong'),
		('MP06','Phong 006','KN2','Phong bon',4,1,500000,'Khong'),
		('MP07','Phong 007','KN3','Phong doi',2,2,300000,'Khong'),
		('MP08','Phong 008','KN3','Phong ba',3,2,400000,'Khong'),
		('MP09','Phong 009','KN3','Phong bon',4,4,500000,'Khong'),
		('MP10','Phong 010','KN4','Phong doi',2,1,300000,'Khong'),
		('MP11','Phong 011','KN4','Phong ba',3,0,400000,'Khong'),
		('MP12','Phong 012','KN4','Phong bon',4,0,500000,'Khong');
-- 3.thiet bi
select * from Thiet_Bi
insert into Thiet_Bi (Ma_Thiet_Bi, Ten_Thiet_Bi, Gia_Tri)
values	('TB01','Ban hoc',1000000),
		('TB02','Ghe',100000),
		('TB03','Den hoc',100000),
		('TB04','Giuong don',850000),
		('TB05','Giuong tang don',1200000);

-- 4.thiet bi phong
select * from Thietbi_Phong
insert into Thietbi_Phong (Ma_Phong, Ma_Thiet_Bi, So_Luong, Tinh_Trang)
values	('MP01','TB01',2,'Moi'), ('MP01','TB02',2,'Moi'), ('MP01','TB03',2,'Moi'), ('MP01','TB05',1,'Nguyen ven'),

		('MP02','TB01',3,'Moi'), ('MP02','TB02',3,'Moi'), ('MP02','TB03',3,'Moi'), ('MP02','TB04',3,'Nguyen ven'),

		('MP03','TB01',4,'Moi'), ('MP03','TB02',4,'Moi'), ('MP03','TB03',4,'Moi'), ('MP03','TB05',2,'Nguyen ven'),

		('MP04','TB01',2,'Moi'), ('MP04','TB02',2,'Moi'), ('MP04','TB03',2,'Moi'), ('MP04','TB05',1,'Nguyen ven'),

		('MP05','TB01',3,'Moi'), ('MP05','TB02',3,'Moi'), ('MP05','TB03',3,'Moi'), ('MP05','TB04',3,'Nguyen ven'),

		('MP06','TB01',4,'Moi'), ('MP06','TB02',4,'Moi'), ('MP06','TB03',4,'Moi'), ('MP06','TB05',2,'Nguyen ven'),

		('MP07','TB01',2,'Moi'), ('MP07','TB02',2,'Moi'), ('MP07','TB03',2,'Moi'), ('MP07','TB05',1,'Nguyen ven'),
		
		('MP08','TB01',3,'Moi'), ('MP08','TB02',3,'Moi'), ('MP08','TB03',3,'Moi'), ('MP08','TB04',3,'Nguyen ven'),
		
		('MP09','TB01',4,'Moi'), ('MP09','TB02',4,'Moi'), ('MP09','TB03',4,'Moi'), ('MP09','TB05',2,'Nguyen ven'),
		
		('MP10','TB01',2,'Moi'), ('MP10','TB02',2,'Moi'), ('MP10','TB03',2,'Moi'), ('MP10','TB05',1,'Nguyen ven'),
		
		('MP11','TB01',3,'Moi'), ('MP11','TB02',3,'Moi'), ('MP11','TB03',3,'Moi'), ('MP11','TB04',3,'Nguyen ven'),
		
		('MP12','TB01',4,'Moi'), ('MP12','TB02',4,'Moi'), ('MP12','TB03',4,'Moi'), ('MP12','TB05',2,'Nguyen ven');

-- 5.Khoa
select * from Khoa
insert into Khoa(Makhoa, Tenkhoa)
values	('MK01','Cong Trinh'),
		('MK02','Co Khi'),
		('MK03','Van tai - Kinh Te'),
		('MK04','Cong Nghe Thong Tin'),
		('MK05','Dao Tao Quoc Te'),
		('MK06','Quan Ly Xay Dung'),
		('MK07','Kinh te');
-- 6.lop
select * from Lop
insert into Lop(Malop,Tenlop,Makhoa)
values ('ML01','Lop cong trinh','MK01'),
	   ('ML02','Lop co khi','MK02'),
	   ('ML03','Lop van tai','MK03'),
	   ('ML04','Lop cong nghe thong tin','MK04'),
	   ('ML05','Lop quoc te','MK05'),
	   ('ML06','Lop quan ly xay dung','MK06'),
	   ('ML07','Lop kinh te','MK07');
-- 7.Que
select * from Que
insert into Que(Maque,Tenque)
values ('MQ01','Ha Nam'),
	   ('MQ02','Nam Dinh'),
	   ('MQ03','Ha Noi'),
	   ('MQ04','Ho Chi Minh'),
	   ('MQ05','Thai Binh'),
	   ('MQ06','Nghe An'),
	   ('MQ07','Hai Phong');
-- 8.SinhVien
select * from Sinhvien
insert into Sinhvien(Ma_sv,Ten_sv,Ngaysinh,Gioitinh,Maque,Makhoa,Malop)
values ('MSV01','Nguyen Van An','2022-01-01','Nam','MQ01','MK01','ML01'),
	   ('MSV02','Nguyen Minh Anh','2022-01-02','Nu','MQ02','MK02','ML02'),
	   ('MSV03','Nguyen Van Anh','2022-01-03','Nu','MQ03','MK03','ML03'),
	   ('MSV04','Nguyen Van Binh','2022-01-04','Nam','MQ04','MK04','ML04'),
	   ('MSV05','Nguyen Van Chien','2022-01-05','Nam','MQ05','MK05','ML05'),
	   ('MSV06','Nguyen Van Dat','2022-01-06','Nam','MQ06','MK06','ML06'),
	   ('MSV07','Pham Thi Ngoc Anh','2022-01-07','Nu','MQ07','MK07','ML07'),
	   ('MSV08','Nguyen Hieu','2022-01-08','Nam','MQ06','MK06','ML06'),
	   ('MSV09','Nguyen Van Huy','2022-01-09','Nam','MQ05','MK05','ML05'),
	   ('MSV10','Nguyen Van Tai','2022-01-10','Nam','MQ04','MK04','ML04'),
	   ('MSV11','Nguyen Thi Van','2022-01-11','Nu','MQ03','MK03','ML03'),
	   ('MSV12','Nguyen Van Tuan','2022-01-12','Nam','MQ02','MK02','ML02');
-- 9.Thu tien phong
select * from Thutienphong
insert into Thutienphong(Ma_Phong, Thang, Nam, Tiennha, Tiendien, Tiennuoc, Tienvesinh, Tienphat, Ngayhethan, Ngaydong)
values ('MP01',01,2022,2000000,300000,50000,20000,0,'2023-12-12','2022-01-01'),
	   ('MP02',02,2022,2100000,310000,51000,20000,0,'2023-12-12','2022-01-01'),
	   ('MP03',03,2022,2200000,320000,52000,20000,0,'2023-12-12','2022-01-01'),
	   ('MP04',04,2022,2300000,330000,53000,20000,0,'2023-12-12','2022-01-01'),
	   ('MP05',05,2022,2100000,340000,54000,20000,0,'2023-12-12','2022-01-01'),
	   ('MP06',06,2022,2200000,350000,55000,20000,0,'2023-12-12','2022-01-01'),
	   ('MP07',07,2022,2300000,340000,56000,20000,0,'2023-12-12','2022-01-01'),
	   ('MP08',08,2022,2000000,330000,57000,20000,0,'2023-12-12','2022-01-01'),
	   ('MP09',09,2022,2000000,320000,58000,20000,0,'2023-12-12','2022-01-01'),
	   ('MP10',10,2022,2500000,310000,59000,20000,0,'2023-12-12','2022-01-01'),
	   ('MP11',11,2022,2400000,300000,51000,20000,0,'2023-12-12','2022-01-01'),
	   ('MP12',12,2022,2600000,300000,50000,20000,0,'2023-12-12','2022-01-01');
	   
	   
-- 10.account
select * from Account
insert into Account(Account_id, Username, Pass, Account_type)
values ('ID01','tranminhhien','hien1234',1),
	   ('ID02','nguyenconghieu','hieu1234',1),
	   ('ID03','phamngochai','hai1234',1),
	   ('ID04','phamquockhanh','khanh1234',1),
	   ('ID05','ad','1',1),
	   ('ID06','nguyenminhanh','minhanh5678',0),
	   ('ID07','nguyenmaianh','maianh5678',0),
	   ('ID08','nguyenvanbinh','binh5678',0),
	   ('ID09','nguyenvanchien','chien5678',0);
-- 11.Thue phong
select * from Thuephong
insert into Thuephong(Masothue, Ma_sv, Ma_Phong, NgayBDau, Ngaykt, Ghichu)
values ('MST01','MSV01','MP01','2021-12-01','2022-06-01','khong co ghi chu'),
	   ('MST02','MSV02','MP02','2021-11-01','2022-05-01','khong co ghi chu'),
	   ('MST03','MSV03','MP03','2021-10-01','2022-07-01','khong co ghi chu'),
	   ('MST04','MSV04','MP04','2021-11-01','2022-08-01','khong co ghi chu'),
	   ('MST05','MSV05','MP05','2021-10-01','2022-05-01','khong co ghi chu'),
	   ('MST06','MSV06','MP06','2021-10-01','2022-06-01','khong co ghi chu'),
	   ('MST07','MSV07','MP07','2021-11-01','2022-07-01','khong co ghi chu'),
	   ('MST08','MSV08','MP08','2021-12-01','2022-08-01','khong co ghi chu');
-- 12.Traphong
select * from Traphong
insert into Traphong(Masothue, Ngaytra, Tienvipham)
values ('MST01','2022-06-01',0),
	   ('MST02','2022-05-01',0),
	   ('MST03','2022-07-01',0),
	   ('MST04','2022-08-01',0),
	   ('MST05','2022-05-01',0),
	   ('MST06','2022-06-01',0),
	   ('MST07','2022-07-01',0),
	   ('MST08','2022-08-01',0);



