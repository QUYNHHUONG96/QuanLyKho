create table nhanvien
(
	manv varchar(20) primary key(manv),
	tennv nvarchar(100),
	ngaysinh datetime,
	sdt varchar(20),
	diachi nvarchar(100)
)
create table nhacc
(
	macc varchar(20) primary key (macc),
	tencc nvarchar(100),
	diachi nvarchar(100),
	sdt varchar(20),
	nuocsx nvarchar(50) 
)
create table loaihang
(
	maloaihang varchar(20) primary key (maloaihang),
	tenloaihang nvarchar(50),
	chitietloaihang nvarchar(100)
)
create table phieunhap
(
	mapn varchar(20) primary key (mapn),
	ngaynhap datetime,
	manv varchar(20)foreign key (manv) references nhanvien(manv),
)
create table chitietphieunhap(
	tenhang nvarchar(50),
	macc varchar(20)foreign key (macc) references nhacc(macc),
	mapn varchar(20)foreign key(mapn) references phieunhap(mapn),
	maloaihang varchar(20) foreign key (maloaihang) references loaihang(maloaihang),
	SLtheoLT int,
	SLthuc int,
	dongia bigint,
	thanhtien bigint
)

create table khohang
(
	mahang varchar(20) primary key,
	tenhang nvarchar(100),
	soluong int,
	gianhap int,
	giaxuat int,
	macc varchar(20)foreign key (macc) references nhacc(macc),
	maloaihang varchar(20) foreign key (maloaihang) references loaihang(maloaihang) 
)

create table khachhang
(
	makh varchar(20) primary key (makh),
	tenkh nvarchar(100),
	sdt varchar(20),
	diachi nvarchar(100)
)
create table phieuxuat
(
	mapx varchar(20) primary key (mapx),
	ngayxuat datetime,
	manv varchar(20)foreign key (manv) references nhanvien(manv),
	makh varchar(20)foreign key (makh) references khachhang(makh)
)
create table chitietphieuxuat
(
	mapx varchar(20)foreign key (mapx) references phieuxuat(mapx),
	mahang varchar(20)foreign key (mahang) references khohang(mahang),
	soluong int,
	dongia bigint
)
create table dangnhap
(
	username nvarchar(10) not null,
	pass nvarchar(10) not null 
)
