--Tao co so du lieu:
create database QLNhaHangTiecCuoi
go
--Su dung co so du lieu QLNH:
use QLNhaHangTiecCuoi
go

--Tao bang Login:
create table Login
(
   Username nvarchar(50) primary key
   ,Pass nvarchar(50)
)

go
--Tao bang NhanVien:
create table NhanVien(
	 MaNV char(50)primary key
	,TenNV nvarchar(50)
	,GioiTinh nvarchar(50)
	,DiaChi nvarchar(50)
	,SDT nvarchar(50)
	,ChucVu nvarchar(50)
	,Luong integer
	,GhiChu nvarchar(50)
	)
go
--Tao bang KhachHang:
create table KhachHang(
    MaKH char(10) primary key
   ,TenKH nvarchar(50)
   ,NgaySinh nvarchar(50)
   ,GioiTinh nvarchar (50)
   ,DiaChi nvarchar(50)
   ,Email nvarchar (50)
   ,SDT nvarchar(50)
   ,GhiChu nvarchar(50)
)
go
--Tao bang Thong tin hop dong:
create table ThongTinHopDong
(
	 MaHD nvarchar(20) primary key
	,NgayLap datetime 
	,MaKH nvarchar(50)
	,HoTenKH nvarchar(50)
	,DiaChi nvarchar(50)
	,SDT integer
	,Email nvarchar(50)
	,NgayTC datetime
	,SLBan integer
	,SLNV integer
)
go
--Tao bang thong tin thuc don
create table ThongTinThucDon
(
	MaTD nvarchar(20) primary key
	,MonKV nvarchar(50) 
	,Mon1 nvarchar(50)
	,Mon2 nvarchar(50)
	,Mon3 nvarchar(50)
	,Lau nvarchar(50)
	,TrangMieng nvarchar(50)
	,Bia nvarchar(50)
	,NuocNgot nvarchar(50)
)
go
--Tao bang thong tin khuyen mai
create table ThongTinKM
(
	BiaNuocngot bit primary key
	,HoaThungtien bit
)
go
--Tao bang thong tin dich vu
create table ThongTinDV
(
	VuCong bit primary key
	,PhaoHoa bit
	,ThapLy bit
	,MC bit
	,CaSi bit
	,BanNhac bit
)
go
--Tao bang tinh tien hop dong
create table TinhTien
(
	TienCoc float primary key
	,PhiDV float
	,PhiTiec float
	,TongTien float
)
go	
--Tao Bang bang HoaDon:
create table HoaDon(
	MaHD char(10) primary key
   ,NgayThanhToan datetime
   ,TongTien float
   ,TienKhachTra float
   ,TienConDu float
 )
go
--Lay danh sach nhan vien:
create proc sp_LayDSNhanVien
as 
begin
select * from NhanVien
end
go
--Lay danh sach Login:
create proc sp_LayDSLogin
as 
begin
select * from Login
end
go 
--Lay danh sach Daily:
create proc sp_LayDSKhachHang
as 
begin
select * from KhachHang
end
go
--Lay danh sach hoa don:
create proc sp_LayDSHoaDon
as 
begin
select * from HoaDon
end
go 

--Lay danh sach KhachHang:
create proc sp_LayDSTinhTien
as 
begin
select * from TinhTien
end
go 

--Lay danh sach Menu:
create proc sp_LayDSThongTinDV
as 
begin
select * from ThongTinDV
end
go 
--Lay danh sach ThuChi:
create proc sp_LayDSThongTinHopDong
as 
begin
select * from ThongTinHopDong
end
go 
--Lay danh sach DichVu:
create proc sp_LayDSThongTinKM
as 
begin
select * from ThongTinKM
end
go
--Lay danh sach SanhTiec:
create proc sp_LayDSThongTinThucDon
as 
begin
select * from ThongTinThucDon
end
go 
--sp_themnv:
create proc sp_themnv
(
	@manv char(10)
	,@tennv nvarchar(50)
	,@gioitinh nvarchar(50)
	,@diachi nvarchar(50)
	,@sdt nvarchar(50)
	,@chucvu nvarchar(50)
	,@luong integer
	,@ghichu nvarchar(50)
)
as 
begin
	insert into NhanVien(MaNV,TenNV,GioiTinh,DiaChi,SDT,ChucVu,Luong,GhiChu)
	values
	(
		@manv
		,@tennv
		,@gioitinh
		,@diachi
		,@sdt
		,@chucvu
		,@luong
		,@ghichu
	)
end
go 
--sp_themlogin:
create proc sp_themlogin(@username nvarchar(50)
	,@pass nvarchar(50)
	,@quyen nvarchar(50))
as
begin
	insert into Login(Username,Pass)
	values(@username,@pass)
end
go
--sp_themhd
create proc sp_themhd(@mahd nvarchar(50)
,@ngaythanhtoan datetime
,@tongtien integer
,@tienkhachtra integer
,@tiencondu integer)
as
begin
insert into HoaDon(MaHD,NgayThanhToan,TongTien,TienKhachTra,TienConDu)
values(@mahd,@ngaythanhtoan,@tongtien,@tienkhachtra,@tiencondu)
end
go
--sp_themkh
create proc sp_themkh
(@makh nvarchar(50) 
,@tenkh nvarchar(50)
,@ngaysinh datetime
,@gioitinh nvarchar (5)
,@diachi nvarchar(50)
,@email nvarchar (50)
,@sdt nvarchar(50)
,@ghichu nvarchar(50))
as
begin
insert into KhachHang(MaKH,TenKH,NgaySinh,GioiTinh,DiaChi,Email,SDT,GhiChu)
values(@makh,@tenkh,@ngaysinh,@gioitinh,@diachi,@email,@sdt,@ghichu)
end
go
--sp_themttdv
create proc sp_themttdv(
	@vucong bit
	,@phaohoa bit
	,@thaply bit
	,@mc bit
	,@casi bit
	,@bannhac bit
)
as
begin
insert into ThongTinDV(VuCong
	,PhaoHoa
	,ThapLy
	,MC
	,CaSi
	,BanNhac
)
values (@vucong
	,@phaohoa
	,@thaply
	,@mc
	,@casi
	,@bannhac
)
end
go
--sp_themtthdong
create proc sp_themTTHDong
(
	 @mahd nvarchar
	,@ngaylap datetime 
	,@makh nvarchar
	,@hotenkh nvarchar
	,@diachi nvarchar
	,@sdt integer
	,@email nvarchar
	,@ngaytc datetime
	,@slban integer
	,@slnv integer
)
as
begin
insert into ThongTinHopDong(MaHD,NgayLap,MaKH,HoTenKH,DiaChi,SDT,Email,NgayTC,SLBan,SLNV)
values (@mahd,@ngaylap,@makh,@hotenkh,@diachi,@sdt,@email,@ngaytc,@slban,@slnv)
end
go
--Tao bang thong tin thuc don
create proc sp_themTTThucDon
(
	@matd nvarchar
	,@monkv nvarchar
	,@mon1 nvarchar
	,@mon2 nvarchar
	,@mon3 nvarchar
	,@lau nvarchar
	,@trangmieng nvarchar
	,@bia nvarchar
	,@nuocngot nvarchar
)
as
begin
insert into ThongTinThucDon(MaTD,MonKV,Mon1,Mon2,Mon3,Lau,TrangMieng,Bia,NuocNgot)
values (@matd,@monkv,@mon1,@mon2,@mon3,@lau,@trangmieng,@bia,@nuocngot)
end
go
--Tao bang thong tin khuyen mai
create proc sp_themThongTinKM
(
	@bianuocngot bit
	,@hoathungtien bit
)
as
begin
insert into ThongTinKM (BiaNuocngot,HoaThungtien)
values (@bianuocngot,@hoathungtien)
end
go
--xoa bang
create proc sp_xoakh(
@makh nvarchar(50)
)
as
begin
delete from KhachHang where MaKH ='' 
end
go