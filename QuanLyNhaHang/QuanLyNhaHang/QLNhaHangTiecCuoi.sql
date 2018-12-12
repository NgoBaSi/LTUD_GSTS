--Tao co so du lieu:
create database QLNhaHangTiecCuoi
go
--Su dung co so du lieu QLNH:
use QLNhaHangTiecCuoi
go

--Tao bang Login:
create table Login
(
   Username nvarchar(50) 
   ,Pass nvarchar(50)
)

go
--Tao bang NhanVien:
create table NhanVien(
	 MaNV char(50)primary key
	,TenNV nvarchar(50)
	,GioiTinh nvarchar(50)
	,NgaySinh datetime
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
	,MonKV datetime 
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
	BiaNuocngot bit
	,HoaThungtien bit
)
go
--Tao bang thong tin dich vu
create table ThongTinDV
(
	VuCong bit
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
	TienCoc int
	,PhiDV int
	,PhiTiec int
	,TongTien int
)
go	
--Tao Bang bang HoaDon:
create table HoaDon(
	MaHD char(10) primary key
   ,NgayThanhToan datetime
   ,TongTien nvarchar(50)
   ,TienKhachTra integer
   ,TienConDu integer
 )
go
--Tao bang DichVu:
/*create table DichVu
(
	MaDV nvarchar(50)primary key
   ,TenDV nvarchar(50)
   ,Gia integer
)
go
--Tao bang SanhTiec:
create table SanhTiec
(
	MaST nvarchar(50)primary key
   ,TenST nvarchar(50)
   ,TrangThai nvarchar(50)
)
go*/
--Lay danh sach nhan vien:
create proc sp_LayDSNV
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
create proc sp_LayDSDaily
as 
begin
select * from Daily
end
go
--Lay danh sach hoa don:
create proc sp_LayDSHD
as 
begin
select * from HoaDon
end
go 

--Lay danh sach KhachHang:
create proc sp_LayDSKH
as 
begin
select * from KhachHang
end
go 

--Lay danh sach Menu:
create proc sp_LayDSMN
as 
begin
select * from Menu
end
go 
--Lay danh sach ThuChi:
create proc sp_LayDSTC
as 
begin
select * from ThuChi
end
go 
--Lay danh sach DichVu:
create proc sp_LayDSDV
as 
begin
select * from DichVu
end
go
--Lay danh sach SanhTiec:
create proc sp_LayDSST
as 
begin
select * from SanhTiec
end
go 
--sp_themnv:
create proc sp_themnv(@manv char(10)
,@tennv nvarchar(50)
,@ngaysinh datetime
,@gioitinh nvarchar(50)
,@diachi nvarchar(50)
,@sdt nvarchar(50)
,@chucvu nvarchar(50)
,@luong integer
,@ghichu nvarchar(50))
as 
begin
insert into NhanVien(MaNV,TenNV,NgaySinh,GioiTinh,DiaChi,SDT,ChucVu,Luong,GhiChu)
values(@manv
,@tennv
,@ngaysinh
,@gioitinh
,@diachi
,@sdt
,@chucvu
,@luong
,@ghichu)
end
go 
--sp_themlogin:
create proc sp_themlogin(@username nvarchar(50)
,@pass nvarchar(50)
,@quyen nvarchar(50))
as
begin
insert into Login(Username,Pass,Quyen)
values(@username,@pass,@quyen)
end
go
--sp_themhd
create proc sp_themhd(@mahd nvarchar(50)
,@ngaylap datetime
,@tenban nvarchar(50)
,@sokhach integer
,@tongtien integer
,@tienKhachtra integer
,@tiencondu integer)
as
begin
insert into HoaDon(MaHD,NgayLap,TenBan,SoKhach,TongTien,TienKhachTra,TienConDu)
values(@mahd,@ngaylap,@tenban,@sokhach,@tongtien,@tienKhachtra,@tiencondu)
end
go
--sp_themmn
create proc sp_themmn
(@mama nvarchar(50)
,@tenma nvarchar(50)
,@gia integer
,@chiphi integer
,@donvi nvarchar(50))
as
begin
insert into Menu(MaMA,TenMA,Gia,ChiPhi,DonVi)
values(@mama,@tenma,@gia,@chiphi,@donvi)
end
go
--sp_themkh
create proc sp_themkh
(@cmnd nvarchar(50) 
,@tenkh nvarchar(50)
,@diachi nvarchar(50)
,@sdt nvarchar(50)
,@ghichu nvarchar(50))
as
begin
insert into KhachHang(CMND,TenKH,DiaChi,SDT,GhiChu)
values(@cmnd,@tenkh,@diachi,@sdt,@ghichu)
end
go
--sp_themluong
create proc sp_themluong
(@manv nvarchar(50)
,@thang nvarchar(50)
,@tennv nvarchar(50)
,@bophan nvarchar(50)
,@chucvu nvarchar(50)
,@luong integer
,@ngaycong integer
,@tangca integer
,@thuong integer
,@phat integer
,@tienung integer
,@thanhtoan integer)
as
begin
insert into Luong(MaNV,Thang,TenNV,BoPhan,ChucVu,Luong,NgayCong,TangCa,Thuong,Phat,TienUng,ThanhToan)
values(@manv,@thang,@tennv,@bophan,@chucvu,@luong,@ngaycong,@tangca,@thuong,@phat,@tienung,@thanhtoan)
end
go
--sp_themtc
create proc sp_themtc
(@stt integer 
,@ngay datetime
,@thu integer
,@chi integer
,@nhanvien nvarchar(50)
,@ghichu nvarchar(50)
)
as
begin
insert into ThuChi(STT,Ngay,Thu,Chi,NhanVien,GhiChu)
values(@stt,@ngay,@thu,@chi,@nhanvien,@ghichu)
end
go
--sp_themst
create proc sp_themst
(@mast nvarchar(50)
,@tenst nvarchar(50)
,@trangthai nvarchar(50)
)
as
begin
insert into SanhTiec(MaST,TenST,TrangThai)
values(@mast,@tenst,@trangthai)
end
go
--sp_themdv
create proc sp_themdv
(@madv nvarchar(50)
,@tendv nvarchar(50)
,@gia integer
)
as
begin
insert into DichVu(MaDV,TenDV,Gia)
values(@madv,@tendv,@gia)
end
go
--Lay danh sach nhan vien:
exec sp_LayDSNV
go
--Lay danh sach login:
exec sp_LayDSLogin 
go
--Lay danh sach daily
exec sp_LayDSDaily 
go
--Lay danh sach hoa don
exec sp_LayDSHD
go
--Lay danh sach dv
exec sp_LayDSDV
go