USE [DSS_ES]
GO
/****** Object:  Table [dbo].[ChuyenNganh]    Script Date: 11/26/2017 11:50:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenNganh](
	[MaNganh] [nvarchar](100) NOT NULL,
	[NhomNganh] [int] NOT NULL,
 CONSTRAINT [PK_ChuyenNganh] PRIMARY KEY CLUSTERED 
(
	[MaNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhomNganh]    Script Date: 11/26/2017 11:50:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomNganh](
	[NhomNganh] [int] NOT NULL,
	[TenChuyenNganh] [nvarchar](300) NULL,
 CONSTRAINT [PK_Nganh] PRIMARY KEY CLUSTERED 
(
	[NhomNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Truong]    Script Date: 11/26/2017 11:50:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Truong](
	[MaTruong] [nvarchar](100) NOT NULL,
	[TenTruong] [nvarchar](300) NOT NULL,
	[DiaChi] [nvarchar](300) NOT NULL,
	[Website] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_Truong] PRIMARY KEY CLUSTERED 
(
	[MaTruong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TruongNganh]    Script Date: 11/26/2017 11:50:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TruongNganh](
	[MaTruong] [nvarchar](100) NOT NULL,
	[MaNganh] [nvarchar](100) NOT NULL,
	[NamDT] [int] NOT NULL,
	[SoCB] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TuyenSinh]    Script Date: 11/26/2017 11:50:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuyenSinh](
	[MaTruong] [nvarchar](100) NOT NULL,
	[MaNganh] [nvarchar](100) NOT NULL,
	[DiemChuan] [real] NOT NULL,
	[ChiTieu] [int] NULL,
	[SLDaTuyen] [int] NULL
) ON [PRIMARY]

GO
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'106', 7)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'206', 7)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'207', 9)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'52480101', 7)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'52480102', 13)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'52480103', 10)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'52480104', 6)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'52480105', 11)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'52480201', 4)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'52480202', 1)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'52480299', 1)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'52510302', 2)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'52510304', 3)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'52520214', 9)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'52520402', 8)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'52905216', 5)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'KT22', 4)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'KT23', 12)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'QT13', 6)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'QT14', 4)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'QT15', 4)
INSERT [dbo].[ChuyenNganh] ([MaNganh], [NhomNganh]) VALUES (N'QT32', 7)
INSERT [dbo].[NhomNganh] ([NhomNganh], [TenChuyenNganh]) VALUES (1, N'an toàn thông tin')
INSERT [dbo].[NhomNganh] ([NhomNganh], [TenChuyenNganh]) VALUES (2, N'công nghệ điện từ        ')
INSERT [dbo].[NhomNganh] ([NhomNganh], [TenChuyenNganh]) VALUES (3, N'công nghệ kỹ thuật máy tính')
INSERT [dbo].[NhomNganh] ([NhomNganh], [TenChuyenNganh]) VALUES (4, N'công nghệ thông tin')
INSERT [dbo].[NhomNganh] ([NhomNganh], [TenChuyenNganh]) VALUES (5, N'hệ thống nhúng')
INSERT [dbo].[NhomNganh] ([NhomNganh], [TenChuyenNganh]) VALUES (6, N'hệ thống thông tin')
INSERT [dbo].[NhomNganh] ([NhomNganh], [TenChuyenNganh]) VALUES (7, N'khoa học máy tính')
INSERT [dbo].[NhomNganh] ([NhomNganh], [TenChuyenNganh]) VALUES (8, N'kỹ thuật hạt nhân')
INSERT [dbo].[NhomNganh] ([NhomNganh], [TenChuyenNganh]) VALUES (9, N'kỹ thuật máy tính')
INSERT [dbo].[NhomNganh] ([NhomNganh], [TenChuyenNganh]) VALUES (10, N'kỹ thuật phần mềm')
INSERT [dbo].[NhomNganh] ([NhomNganh], [TenChuyenNganh]) VALUES (11, N'máy tính và khoa học thông tin')
INSERT [dbo].[NhomNganh] ([NhomNganh], [TenChuyenNganh]) VALUES (12, N'toán - tin')
INSERT [dbo].[NhomNganh] ([NhomNganh], [TenChuyenNganh]) VALUES (13, N'truyền thông và mạng máy tính')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'BKA', N'Đại học Bách khoa Hà Nội', N'Số 1 Đại Cồ Việt, Hai Bà Trưng, Hà Nội', N'https://hust.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'BVH', N'Học Viện Công Nghệ Bưu Chính Viễn Thông ( Phía Bắc )', N'Km10 Đường Nguyễn Trãi, Quận Hà Đông, Hà Nội', N'http://portal.ptit.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'BVS', N'Học Viện Công Nghệ Bưu Chính Viễn Thông (phía Nam)', N'Hồ Chí Minh', N'hcm.ptit.edu.vn / hvbcvthcm@ptithcm.edu.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'BVU', N'ĐH Bà Rịa Vũng Tàu', N'Vũng Tàu', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DBD', N'ĐH Bình Dương', N'Bình Dương', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DBL', N'ĐH Bạc Liêu', N'Bạc Liêu', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DCN', N'Đại Học Công Nghiệp Hà Nội', N'Hà Nội', N'haui.edu.vn / dhcnhn@haui.edu.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DCT', N'ĐH công nghiệp thực phẩm TP HCM', N'Hồ Chí Minh', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DCV', N'ĐH Công Nghiệp Vinh', N'Nghệ An', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DDK', N'ĐH Bách Khoa-ĐH Đà Nẵng', N'Đà Nẵng', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DDL', N'ĐH Điện lực', N'Hà Nội', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DDM', N'Đại học Công nghiệp Quảng Ninh', N'Quảng Ninh', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DDP', N'Phân Hiệu Đại học Đà Nẵng tại Kontum', N'Kon Tum', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DDS', N'Đại Học Sư Phạm – Đại Học Đà Nẵng', N'Đà Nẵng', N'ued.udn.vn / ued.help247@gmail.com')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DHV', N'Đại học Hùng Vương - TP Hồ Chí Minh', N'Hồ Chí Minh', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DKK', N'Đại Học Kinh Tế Kỹ Thuật Công Nghiệp', N'Hà Nội', N'daotao.uneti.edu.vn / uneti@vnn.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DKT', N'Đại học Hải Dương', N'Hải Dương', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DMT', N'ĐH Tài nguyên và môi trường Hà Nội', N'Hà Nội', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DNV', N'Đại học Nội Vụ', N'Hà Nội', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DPQ', N'Đại học Phạm Văn Đồng', N'Quảng Ngãi', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DQB', N'Đại học Quảng Bình', N'Quảng Bình', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DQH', N'Học Viện Kĩ Thuật Quân Sự - Hệ Dân sự', N'100 đường Hoàng Quốc Việt, Q.Cầu Giấy, Hà Nội', N'http://mta.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DQN', N'Đại Học Quy Nhơn', N'Bình Định', N'qnu.edu.vn / dqn@moet.edu.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DTM', N'ĐH Tài Nguyên môi trường TPHCM', N'Hồ Chí Minh', N'hcmunre.edu.vn / info@hcmunre.edu.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DTT', N'Đại Học Tôn Đức Thắng', N'Đường Nguyễn Hữu Thọ, Phường Tân Phong, Quận 7, Tp.HCM', N'http://www.tdtu.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'DVT', N'Đại Học Trà Vinh', N'Trà Vinh', N'tvu.edu.vn / webmaster@tvu.edu.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'GHA', N'Đại Học Giao Thông Vận Tải ( Cơ sở Phía Bắc )', N'Láng Thượng, Đống Đa, Hà Nội', N'http://utc.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'GSA', N'Đại Học Giao Thông Vận Tải ( Cơ sở Phía Nam)', N'Hồ Chí Minh', N'utc2.edu.vn / banbientap@utc2.eu.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'GTA', N'ĐH Công nghệ giao thông vận tải', N'Hà Nội', N'http://utt.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'GTS', N'Đại Học Giao Thông Vận Tải TPHCM', N'Số 2, Đường D3, Khu Văn Thánh Bắc, Phường 25, Q. Bình Thạnh, TP. Hồ Chí Minh', N'http://ut.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'HNM', N'Đại học Thủ Đô Hà Nội', N'Hà Nội', N'daihocthudo.edu.vn / banbientap@daihocthudo.edu.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'HUI', N'Đại Học Công Nghiệp TPHCM', N'Hồ Chí Minh', N'hui.edu.vn / ptchc@iuh.edu.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'HVN', N'Học Viện Nông Nghiệp Việt Nam', N'Hà Nội', N'vnua.edu.vn / webmaster@vnua.edu.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'KHA', N'Đại Học Kinh Tế Quốc Dân', N'207 đường Giải Phóng, Q. Hai Bà Trưng, Hà Nội', N'http://neu.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'KMA', N'Học Viện Kỹ Thuật Mật Mã', N'Hà Nội', N'actvn.edu.vn / actvn@outlook.com')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'MBS', N'Đại Học Mở TPHCM', N'97 Võ Văn Tần, P6, Q3 TP HCM', N'http://www.oude.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'MHN', N'Viện Đại Học Mở Hà Nội', N'Hà Nội', N'hou.edu.vn / mhn@hou.edu.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'NHF', N'Đại Học Hà Nội', N'Km9, đường Nguyễn Trãi, Q.Thanh Xuân, Hà Nội', N'http://hanu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'NLS', N'Đại Học Nông Lâm TPHCM', N'Khu phố 6, P Linh Trung, Q. Thủ Đức, TP HCM', N'http://hcmuaf.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'QHT', N'Đại Học Khoa Học Tự Nhiên – Đại Học Quốc Gia Hà Nội', N'Số 334 Nguyễn Trãi, Quận Thanh Xuân, Hà Nội', N'http://hus.vnu.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'QSB', N'Đại Học Bách Khoa – Đại Học Quốc Gia TPHCM', N'268 Lý Th­ường Kiệt, phường 14, quận 10, TP.Hồ Chí Minh', N'http://www.hcmut.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'QSC', N'Đại Học Công Nghệ Thông Tin – Đại Học Quốc Gia TPHCM', N'KM 20, xa lộ Hà Nội, phường Linh Trung, quận Thủ Đức, TP.Hồ Chí Minh', N'https://uit.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'QSQ', N'Đại Học Quốc Tế – Đại Học Quốc Gia TPHCM', N'Khu phố 6, phường Linh Trung, Q.Thủ Đức, Tp.HCM', N'http://www.hcmiu.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'QST', N'Đại Học Khoa Học Tự Nhiên – Đại Học Quốc Gia TPHCM', N'Hồ Chí Minh', N'web.hcmus.edu.vn / webmaster@hcmus.edu.vn ')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'SGD', N'Đại Học Sài Gòn', N'Hồ Chí Minh', N'sgu.edu.vn / p_daotao@sgu.edu.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'SP2', N'Đại Học Sư Phạm Hà Nội 2', N'Số 32, Đường Nguyễn Văn Linh, Phường Xuân Hòa, thị xã Phúc Yên, tỉnh Vĩnh Phúc', N'http://www.hpu2.edu.vn/')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'SPS', N'Đại Học Sư Phạm TPHCM', N'Hồ Chí Minh', N'hcmup.edu.vn / webmaster@hcmup.edu.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'TAG', N'ĐH An Giang', N'An Giang', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'TCT', N'ĐH Cần Thơ', N'Cần Thơ', N'0')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'THV', N'Đại Học Hùng Vương', N'Phường Nông Trang, thành phố Việt Trì, tỉnh Phú Thọ', N'http://www.hvu.edu.vn/ / info@hvu.edu.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'TSN', N'Đại Học Nha Trang', N'Nha Trang', N'ntu.edu.vn / ')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'VGU', N'Đại Học Việt Đức', N'Khu phố 6, Phường Linh Trung, Quận Thủ Đức, Tp. Hồ Chí Minh', N'http://vgu.edu.vn/vi')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'VLU', N'Đại Học Sư Phạm Kỹ Thuật Vĩnh Long', N'Vĩnh Long', N'vlute.edu.vn / spktvl@vlute.edu.vn')
INSERT [dbo].[Truong] ([MaTruong], [TenTruong], [DiaChi], [Website]) VALUES (N'XDA', N'Đại Học Xây Dựng Hà Nội', N'55 đường Giải Phóng, quận Hai Bà Trưng, TP.Hà Nội', N'http://nuce.edu.vn/')
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'BKA', N'KT22', 1969, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'BKA', N'KT23', 1969, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'BKA', N'QT14', 1969, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'BKA', N'QT15', 1969, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'BKA', N'QT32', 1969, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'BKA', N'QT13', 1969, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'THV', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'THV', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'QSB', N'106', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'QSB', N'206', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'QSB', N'207', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'QSC', N'52480103', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'QSC', N'52480101', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'QSC', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'QSC', N'52480299', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'QSC', N'52520214', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'QSC', N'52480104', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'QSC', N'52480102', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DQH', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DQH', N'52480103', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'KHA', N'52480101', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'QSQ', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'XDA', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'GHA', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'NHF', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'BVH', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'BVH', N'52480299', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'GTS', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'GTS', N'52480102', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'QHT', N'52480105', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DTT', N'52480101', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DTT', N'52480103', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DTT', N'52480102', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'NLS', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'VGU', N'52480101', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'MBS', N'52480101', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'SP2', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'SPS', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DVT', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'QST', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'QST', N'52520402', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DCN', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DCN', N'52480103', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DCN', N'52480101', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DCN', N'52510304', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DCN', N'52480102', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DCN', N'52480104', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'KMA', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'KMA', N'52480202', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'MHN', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'GSA', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'BVS', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'BVS', N'52480299', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'HNM', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'HVN', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'SGD', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DQN', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'VLU', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DDS', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'HUI', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'HUI', N'52510302', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'TSN', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DTM', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DTM', N'52480104', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DKK', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'GTA', N'52480104', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'GTA', N'52480102', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'TAG', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'TAG', N'52480103', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DDL', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DMT', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'TCT', N'52480103', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'TCT', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'TCT', N'52480102', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'TCT', N'52520214', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'TCT', N'52480104', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'TCT', N'52480101', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DDK', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DDK', N'52905216', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DCT', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DCT', N'52480299', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'BVU', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DBD', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DBL', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DCV', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DDM', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DDP', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DHV', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DKT', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DNV', N'52480104', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DPQ', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DQB', N'52480201', 0, 0)
INSERT [dbo].[TruongNganh] ([MaTruong], [MaNganh], [NamDT], [SoCB]) VALUES (N'DQB', N'52480103', 0, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'BKA', N'KT22', 28.25, 500, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'BKA', N'KT23', 25.75, 120, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'BKA', N'QT14', 23.5, 60, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'BKA', N'QT15', 22, 60, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'BKA', N'QT32', 21.25, 40, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'BKA', N'QT13', 20, 40, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'THV', N'52480201', 15.5, 15, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'THV', N'52480201', 15.5, 20, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'QSB', N'106', 28, 270, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'QSB', N'206', 26, 45, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'QSB', N'207', 24.5, 45, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'QSC', N'52480103', 26, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'QSC', N'52480101', 26, 130, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'QSC', N'52480201', 26, 120, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'QSC', N'52480299', 26, 60, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'QSC', N'52520214', 26, 60, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'QSC', N'52480104', 26, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'QSC', N'52480102', 26, 120, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DQH', N'52480201', 24.5, 130, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DQH', N'52480103', 23.5, 70, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'KHA', N'52480101', 24.5, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'QSQ', N'52480201', 23.5, 120, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'XDA', N'52480201', 23.25, 115, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'GHA', N'52480201', 23, 200, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'NHF', N'52480201', 23, 500, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'BVH', N'52480201', 25, 620, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'BVH', N'52480299', 24, 200, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'GTS', N'52480201', 22, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'GTS', N'52480102', 19.5, 70, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'QHT', N'52480105', 21.75, 90, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DTT', N'52480101', 21.25, 120, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DTT', N'52480103', 21.25, 120, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DTT', N'52480102', 19.75, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'NLS', N'52480201', 21, 210, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'VGU', N'52480101', 21, 60, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'MBS', N'52480101', 20.75, 170, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'SP2', N'52480201', 20.75, 150, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'SPS', N'52480201', 20.75, 180, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DVT', N'52480201', 20.5, 120, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'QST', N'52480201', 26, 900, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'QST', N'52520402', 20.5, 50, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DCN', N'52480201', 23, 210, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DCN', N'52480103', 21.5, 200, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DCN', N'52480101', 20.5, 140, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DCN', N'52510304', 20.25, 140, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DCN', N'52480102', 20.25, 80, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DCN', N'52480104', 20, 140, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'KMA', N'52480201', 22.75, 210, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'KMA', N'52480202', 21.25, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'MHN', N'52480201', 20.5, 290, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'GSA', N'52480201', 20, 70, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'BVS', N'52480201', 23.25, 620, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'BVS', N'52480299', 21.75, 200, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'HNM', N'52480201', 18.92, 40, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'HVN', N'52480201', 18.75, 125, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'SGD', N'52480201', 22, 280, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DQN', N'52480201', 18, 300, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'VLU', N'52480201', 18, 150, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DDS', N'52480201', 17.75, 230, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'HUI', N'52480201', 20.75, 500, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'HUI', N'52510302', 17.5, 360, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'TSN', N'52480201', 17.5, 120, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DTM', N'52480201', 25.7, 90, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DTM', N'52480104', 17.25, 50, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DKK', N'52480201', 19.25, 500, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'GTA', N'52480104', 17, 30, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'GTA', N'52480102', 17, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'TAG', N'52480201', 17, 60, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'TAG', N'52480103', 15.5, 60, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DDL', N'52480201', 19.25, 200, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DMT', N'52480201', 16.5, 180, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'TCT', N'52480103', 20.5, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'TCT', N'52480201', 20.25, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'TCT', N'52480102', 18.25, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'TCT', N'52520214', 16.5, 120, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'TCT', N'52480104', 16.5, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'TCT', N'52480101', 16.5, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DDK', N'52480201', 26, 275, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DDK', N'52905216', 16.25, 50, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DCT', N'52480201', 19.5, 189, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DCT', N'52480299', 16, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'BVU', N'52480201', 15.5, 250, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DBD', N'52480201', 15.5, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DBL', N'52480201', 15.5, 50, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DCV', N'52480201', 15.5, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DDM', N'52480201', 18, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DDP', N'52480201', 15.5, 25, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DHV', N'52480201', 15.5, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DKT', N'52480201', 15.5, 50, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DNV', N'52480104', 15.5, 140, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DPQ', N'52480201', 15.5, 100, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DQB', N'52480201', 15.5, 55, 0)
INSERT [dbo].[TuyenSinh] ([MaTruong], [MaNganh], [DiemChuan], [ChiTieu], [SLDaTuyen]) VALUES (N'DQB', N'52480103', 15.5, 60, 0)
ALTER TABLE [dbo].[ChuyenNganh]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenNganh_NhomNganh] FOREIGN KEY([NhomNganh])
REFERENCES [dbo].[NhomNganh] ([NhomNganh])
GO
ALTER TABLE [dbo].[ChuyenNganh] CHECK CONSTRAINT [FK_ChuyenNganh_NhomNganh]
GO
ALTER TABLE [dbo].[TruongNganh]  WITH CHECK ADD  CONSTRAINT [FK_TruongNganh_ChuyenNganh] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[ChuyenNganh] ([MaNganh])
GO
ALTER TABLE [dbo].[TruongNganh] CHECK CONSTRAINT [FK_TruongNganh_ChuyenNganh]
GO
ALTER TABLE [dbo].[TruongNganh]  WITH CHECK ADD  CONSTRAINT [FK_TruongNganh_Truong] FOREIGN KEY([MaTruong])
REFERENCES [dbo].[Truong] ([MaTruong])
GO
ALTER TABLE [dbo].[TruongNganh] CHECK CONSTRAINT [FK_TruongNganh_Truong]
GO
ALTER TABLE [dbo].[TuyenSinh]  WITH CHECK ADD  CONSTRAINT [FK_TuyenSinh_ChuyenNganh] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[ChuyenNganh] ([MaNganh])
GO
ALTER TABLE [dbo].[TuyenSinh] CHECK CONSTRAINT [FK_TuyenSinh_ChuyenNganh]
GO
ALTER TABLE [dbo].[TuyenSinh]  WITH CHECK ADD  CONSTRAINT [FK_TuyenSinh_Truong] FOREIGN KEY([MaTruong])
REFERENCES [dbo].[Truong] ([MaTruong])
GO
ALTER TABLE [dbo].[TuyenSinh] CHECK CONSTRAINT [FK_TuyenSinh_Truong]
GO
