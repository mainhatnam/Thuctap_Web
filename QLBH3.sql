USE [QLBH3]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 1/25/2022 9:07:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[MaLoaiDanhMuc] [int] NOT NULL,
	[TenDanhMuc] [nvarchar](100) NULL,
	[TienGoc] [numeric](18, 0) NULL,
	[TienGiamGia] [numeric](18, 0) NULL,
	[MoTaNgan] [nvarchar](500) NULL,
	[NoiDung] [nvarchar](1000) NULL,
	[Id_DanhMuc] [int] IDENTITY(1,1) NOT NULL,
	[Link] [char](100) NULL,
	[MaGiamGia] [int] NULL,
 CONSTRAINT [pk_tdm] PRIMARY KEY CLUSTERED 
(
	[Id_DanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucHoTro]    Script Date: 1/25/2022 9:07:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucHoTro](
	[MaLoaiDanhMuc] [int] NOT NULL,
	[Id_GoiHoTro] [int] IDENTITY(1,1) NOT NULL,
	[TenGoiHoTro] [nvarchar](100) NULL,
	[Link] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiDanhMuc] ASC,
	[Id_GoiHoTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiamGia]    Script Date: 1/25/2022 9:07:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiamGia](
	[MaGiamGia] [int] IDENTITY(1,1) NOT NULL,
	[TenGiamGia] [nvarchar](100) NULL,
	[TyLe] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiamGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hinh_GT_extra]    Script Date: 1/25/2022 9:07:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hinh_GT_extra](
	[Mahinh_extra] [int] IDENTITY(1,1) NOT NULL,
	[Link_hinh_extra] [text] NOT NULL,
	[Id_DanhMuc] [int] NOT NULL,
	[trangthai] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mahinh_extra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hinh_GT_MAIN]    Script Date: 1/25/2022 9:07:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hinh_GT_MAIN](
	[Mahinh_main] [int] IDENTITY(1,1) NOT NULL,
	[Link_hinh_mani] [text] NOT NULL,
	[Id_DanhMuc] [int] NOT NULL,
	[trangthai] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Mahinh_main] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiDanhMuc]    Script Date: 1/25/2022 9:07:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDanhMuc](
	[MaLoaiDanhMuc] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiDanhMuc] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiDanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DanhMuc] ON 

INSERT [dbo].[DanhMuc] ([MaLoaiDanhMuc], [TenDanhMuc], [TienGoc], [TienGiamGia], [MoTaNgan], [NoiDung], [Id_DanhMuc], [Link], [MaGiamGia]) VALUES (1, N'Gói Thương Gia 2', CAST(500000 AS Numeric(18, 0)), CAST(0 AS Numeric(18, 0)), N'6GB/ngày + 1.500 tin nhắn SMS nội mạng VinaPhone + 4.000 phút nội mạng VNPT + 500 phút ngoại mạng', N'Giới thiệu Gói Thương gia 2', 2, N'                                                                                                    ', 5)
INSERT [dbo].[DanhMuc] ([MaLoaiDanhMuc], [TenDanhMuc], [TienGoc], [TienGiamGia], [MoTaNgan], [NoiDung], [Id_DanhMuc], [Link], [MaGiamGia]) VALUES (1, N'Gói Thương Gia 1', CAST(350000 AS Numeric(18, 0)), CAST(0 AS Numeric(18, 0)), N'4GB/ngày + 1.000 SMS nội mạng VinaPhone + 4.000 phút nội mạng VNPT + 300 phút ngoại mạng', N'Giới thiệu Gói Thương gia 1', 3, N'                                                                                                    ', 5)
INSERT [dbo].[DanhMuc] ([MaLoaiDanhMuc], [TenDanhMuc], [TienGoc], [TienGiamGia], [MoTaNgan], [NoiDung], [Id_DanhMuc], [Link], [MaGiamGia]) VALUES (1, N'Gói Digi249', CAST(249000 AS Numeric(18, 0)), CAST(207500 AS Numeric(18, 0)), N'Gói cước giải trí sành điệu từ VinaPhone. Đặc biệt, giá cước ưu đãi hơn khi đăng ký chu kỳ dài tháng.', N'Gói Digi249', 4, N'                                                                                                    ', 5)
INSERT [dbo].[DanhMuc] ([MaLoaiDanhMuc], [TenDanhMuc], [TienGoc], [TienGiamGia], [MoTaNgan], [NoiDung], [Id_DanhMuc], [Link], [MaGiamGia]) VALUES (1, N'Gói Digi129', CAST(129000 AS Numeric(18, 0)), CAST(107500 AS Numeric(18, 0)), N'Gói cước giải trí sành điệu từ VinaPhone. Đặc biệt, giá cước ưu đãi hơn khi đăng ký chu kỳ dài tháng.', N'Gói Digi129', 5, N'                                                                                                    ', 5)
INSERT [dbo].[DanhMuc] ([MaLoaiDanhMuc], [TenDanhMuc], [TienGoc], [TienGiamGia], [MoTaNgan], [NoiDung], [Id_DanhMuc], [Link], [MaGiamGia]) VALUES (2, N'Truyền hình K+', CAST(66000 AS Numeric(18, 0)), CAST(33000 AS Numeric(18, 0)), N'Truyền hình K+', N'Truyền hình K+', 6, N'                                                                                                    ', 1)
INSERT [dbo].[DanhMuc] ([MaLoaiDanhMuc], [TenDanhMuc], [TienGoc], [TienGiamGia], [MoTaNgan], [NoiDung], [Id_DanhMuc], [Link], [MaGiamGia]) VALUES (2, N'Truyền hình K+', CAST(66000 AS Numeric(18, 0)), CAST(33000 AS Numeric(18, 0)), N'Truyền hình K+', N'Truyền hình K+', 8, N'                                                                                                    ', 5)
INSERT [dbo].[DanhMuc] ([MaLoaiDanhMuc], [TenDanhMuc], [TienGoc], [TienGiamGia], [MoTaNgan], [NoiDung], [Id_DanhMuc], [Link], [MaGiamGia]) VALUES (2, N'THomeTV 5 Super - Trang bị đầu thông minh Android và 03 Wifi Mesh', CAST(3400000 AS Numeric(18, 0)), CAST(272000 AS Numeric(18, 0)), N'HomeTV 5 Super - Trang bị đầu thông minh Android và 03 Wifi Mesh', N'HomeTV 5 Super - Trang bị đầu thông minh Android và 03 Wifi Mesh', 9, N'                                                                                                    ', 3)
INSERT [dbo].[DanhMuc] ([MaLoaiDanhMuc], [TenDanhMuc], [TienGoc], [TienGiamGia], [MoTaNgan], [NoiDung], [Id_DanhMuc], [Link], [MaGiamGia]) VALUES (2, N'HomeTV 4 Super - Trang bị đầu thông minh Android và 02 Wifi Mesh', CAST(290000 AS Numeric(18, 0)), CAST(232000 AS Numeric(18, 0)), N'HomeTV 4 Super - Trang bị đầu thông minh Android và 02 Wifi Mesh', N'HomeTV 4 Super - Trang bị đầu thông minh Android và 02 Wifi Mesh', 10, N'                                                                                                    ', 3)
INSERT [dbo].[DanhMuc] ([MaLoaiDanhMuc], [TenDanhMuc], [TienGoc], [TienGiamGia], [MoTaNgan], [NoiDung], [Id_DanhMuc], [Link], [MaGiamGia]) VALUES (2, N'HomeTV Super 3 - Trang bị đầu thông minh Android và 01 Wifi Mesh', CAST(255000 AS Numeric(18, 0)), CAST(204000 AS Numeric(18, 0)), N'HomeTV Super 3 - Trang bị đầu thông minh Android và 01 Wifi Mesh', N'HomeTV Super 3 - Trang bị đầu thông minh Android và 01 Wifi Mesh', 11, N'                                                                                                    ', 3)
INSERT [dbo].[DanhMuc] ([MaLoaiDanhMuc], [TenDanhMuc], [TienGoc], [TienGiamGia], [MoTaNgan], [NoiDung], [Id_DanhMuc], [Link], [MaGiamGia]) VALUES (3, N'Chữ ký số VNPT-CA (3 năm)', CAST(3112000 AS Numeric(18, 0)), CAST(2489600 AS Numeric(18, 0)), N'Chữ ký số VNPT-CA (3 năm)', N'Chữ ký số VNPT-CA (3 năm)', 12, N'                                                                                                    ', 3)
INSERT [dbo].[DanhMuc] ([MaLoaiDanhMuc], [TenDanhMuc], [TienGoc], [TienGiamGia], [MoTaNgan], [NoiDung], [Id_DanhMuc], [Link], [MaGiamGia]) VALUES (3, N'Chữ ký số VNPT-CA (2 năm)', CAST(219000 AS Numeric(18, 0)), CAST(1752000 AS Numeric(18, 0)), N'Chữ ký số VNPT-CA (2 năm)', N'Chữ ký số VNPT-CA (2 năm)', 13, N'                                                                                                    ', 3)
INSERT [dbo].[DanhMuc] ([MaLoaiDanhMuc], [TenDanhMuc], [TienGoc], [TienGiamGia], [MoTaNgan], [NoiDung], [Id_DanhMuc], [Link], [MaGiamGia]) VALUES (3, N'Quản lý Nhà thuốc VNPT Pharmacy', CAST(100000 AS Numeric(18, 0)), CAST(90000 AS Numeric(18, 0)), N'Quản lý Nhà thuốc VNPT Pharmacy', N'Quản lý Nhà thuốc VNPT Pharmacy', 14, N'                                                                                                    ', 3)
INSERT [dbo].[DanhMuc] ([MaLoaiDanhMuc], [TenDanhMuc], [TienGoc], [TienGiamGia], [MoTaNgan], [NoiDung], [Id_DanhMuc], [Link], [MaGiamGia]) VALUES (3, N'Chữ ký số VNPT-CA (1 năm)', CAST(1273000 AS Numeric(18, 0)), CAST(1018400 AS Numeric(18, 0)), N'Chữ ký số VNPT-CA (1 năm)', N'Chữ ký số VNPT-CA (1 năm)', 15, N'                                                                                                    ', 3)
SET IDENTITY_INSERT [dbo].[DanhMuc] OFF
GO
SET IDENTITY_INSERT [dbo].[DanhMucHoTro] ON 

INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (1, 1, N'Chọn Sim Số', N'')
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (1, 2, N'Gói Trả Trước', N'')
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (1, 3, N'Sim Kèm Gói', N'')
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (1, 4, N'Gói Trả Sau', N'')
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (2, 5, N'Internet Cáp Quang', N'')
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (2, 6, N'Home TV', N'')
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (2, 7, N'Truyền hình MyTV', N'')
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (2, 8, N'Home Combo', N'')
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (3, 9, N'Gói tích hợp SME', N'')
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (3, 10, N'Chữ ký số VNPT-CA', N'')
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (3, 11, N'Xác thực hàng hóa - VNPT Check', N'')
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (3, 12, N'Quản lý nhà thuốc - VNPT Pharmacy', N'')
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (3, 13, N'Kê khai BHXH trực tuyến - VNPT BHXH', NULL)
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (3, 14, N'Hóa đơn điện tử', NULL)
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (3, 15, N'Quản lý văn bản điều hành - iOffice', NULL)
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (3, 16, N'Phòng họp không giấy tờ - eCabinet', NULL)
INSERT [dbo].[DanhMucHoTro] ([MaLoaiDanhMuc], [Id_GoiHoTro], [TenGoiHoTro], [Link]) VALUES (3, 17, N'Truyền hình hội nghị VNPT - Meeting', NULL)
SET IDENTITY_INSERT [dbo].[DanhMucHoTro] OFF
GO
SET IDENTITY_INSERT [dbo].[GiamGia] ON 

INSERT [dbo].[GiamGia] ([MaGiamGia], [TenGiamGia], [TyLe]) VALUES (1, N'Giảm 10%', 10)
INSERT [dbo].[GiamGia] ([MaGiamGia], [TenGiamGia], [TyLe]) VALUES (2, N'Giảm 17%', 17)
INSERT [dbo].[GiamGia] ([MaGiamGia], [TenGiamGia], [TyLe]) VALUES (3, N'Giảm 20%', 20)
INSERT [dbo].[GiamGia] ([MaGiamGia], [TenGiamGia], [TyLe]) VALUES (4, N'Giảm 50%', 50)
INSERT [dbo].[GiamGia] ([MaGiamGia], [TenGiamGia], [TyLe]) VALUES (5, N'', 0)
SET IDENTITY_INSERT [dbo].[GiamGia] OFF
GO
SET IDENTITY_INSERT [dbo].[Hinh_GT_extra] ON 

INSERT [dbo].[Hinh_GT_extra] ([Mahinh_extra], [Link_hinh_extra], [Id_DanhMuc], [trangthai]) VALUES (4, N'/img/img_extra/2DBfwcJEQ0aclB6SxCoDHmDB2O9Yam1G0w4x1JsZ.png', 2, 1)
INSERT [dbo].[Hinh_GT_extra] ([Mahinh_extra], [Link_hinh_extra], [Id_DanhMuc], [trangthai]) VALUES (5, N'/img/img_extra/3LiE5X09fbqVlMrEo1R4YilDK3kwfpTYxX4Eal70.png', 3, 1)
INSERT [dbo].[Hinh_GT_extra] ([Mahinh_extra], [Link_hinh_extra], [Id_DanhMuc], [trangthai]) VALUES (6, N'/img/img_extra/3qTxqkUWPHjyaEkxZHmWieYDBVZDLdD1Oq2oOnXJ.png', 4, 1)
INSERT [dbo].[Hinh_GT_extra] ([Mahinh_extra], [Link_hinh_extra], [Id_DanhMuc], [trangthai]) VALUES (7, N'/img/img_extra/fwoRdqWoXKZzXpc0IDIy42cgJwO1RTKzaCKiLorG.png', 5, 1)
INSERT [dbo].[Hinh_GT_extra] ([Mahinh_extra], [Link_hinh_extra], [Id_DanhMuc], [trangthai]) VALUES (8, N'/img/img_extra/QTPYMVmo2aKn2trEp0026gS4nsuB98YEFyUAlSnW.png', 6, 1)
INSERT [dbo].[Hinh_GT_extra] ([Mahinh_extra], [Link_hinh_extra], [Id_DanhMuc], [trangthai]) VALUES (9, N'/img/img_extra/tC2NnpeH8WtwzfP8O14s0X6DoeKpExOd2npnso2d.png', 4, 1)
INSERT [dbo].[Hinh_GT_extra] ([Mahinh_extra], [Link_hinh_extra], [Id_DanhMuc], [trangthai]) VALUES (10, N'/img/img_extra/tC2NnpeH8WtwzfP8O14s0X6DoeKpExOd2npnso2d.png', 5, 1)
INSERT [dbo].[Hinh_GT_extra] ([Mahinh_extra], [Link_hinh_extra], [Id_DanhMuc], [trangthai]) VALUES (11, N'/img/img_extra/XTNFUztMGdf62DxL6Sro4aL327KocSb57odiWPon.png', 6, 1)
INSERT [dbo].[Hinh_GT_extra] ([Mahinh_extra], [Link_hinh_extra], [Id_DanhMuc], [trangthai]) VALUES (13, N'/img/img_extra/Zj1TNxYKLjcnrzcMsJP8DO2JHX5jD6DuBMHga8vx.png', 8, 1)
SET IDENTITY_INSERT [dbo].[Hinh_GT_extra] OFF
GO
SET IDENTITY_INSERT [dbo].[Hinh_GT_MAIN] ON 

INSERT [dbo].[Hinh_GT_MAIN] ([Mahinh_main], [Link_hinh_mani], [Id_DanhMuc], [trangthai]) VALUES (1, N'/img/img_main/2ZKYWXrmpH9deCnE8yPYngYOoPF5da8WlrEiVmeG.png', 2, 1)
INSERT [dbo].[Hinh_GT_MAIN] ([Mahinh_main], [Link_hinh_mani], [Id_DanhMuc], [trangthai]) VALUES (2, N'/img/img_main/uVrvpMqE6j16ih26fF7oZRbGDCx4wVDxGDPg2zdA.png', 3, 1)
INSERT [dbo].[Hinh_GT_MAIN] ([Mahinh_main], [Link_hinh_mani], [Id_DanhMuc], [trangthai]) VALUES (3, N'/img/img_main/CP5NOUaEV0bullCA6Ya4294V37pQni7ftUJrvOJN.png', 4, 1)
SET IDENTITY_INSERT [dbo].[Hinh_GT_MAIN] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiDanhMuc] ON 

INSERT [dbo].[LoaiDanhMuc] ([MaLoaiDanhMuc], [TenLoaiDanhMuc]) VALUES (1, N'DI ĐỘNG')
INSERT [dbo].[LoaiDanhMuc] ([MaLoaiDanhMuc], [TenLoaiDanhMuc]) VALUES (2, N'INTERNET-TRUYỀN HÌNH')
INSERT [dbo].[LoaiDanhMuc] ([MaLoaiDanhMuc], [TenLoaiDanhMuc]) VALUES (3, N'DỊCH VỤ CNTT')
INSERT [dbo].[LoaiDanhMuc] ([MaLoaiDanhMuc], [TenLoaiDanhMuc]) VALUES (4, N'DỊCH VỤ GIÁ TRỊ GIA TĂNG')
SET IDENTITY_INSERT [dbo].[LoaiDanhMuc] OFF
GO
ALTER TABLE [dbo].[Hinh_GT_extra] ADD  DEFAULT ((0)) FOR [trangthai]
GO
ALTER TABLE [dbo].[Hinh_GT_MAIN] ADD  DEFAULT ((0)) FOR [trangthai]
GO
ALTER TABLE [dbo].[DanhMuc]  WITH CHECK ADD  CONSTRAINT [fk_giamgia] FOREIGN KEY([MaGiamGia])
REFERENCES [dbo].[GiamGia] ([MaGiamGia])
GO
ALTER TABLE [dbo].[DanhMuc] CHECK CONSTRAINT [fk_giamgia]
GO
ALTER TABLE [dbo].[DanhMuc]  WITH CHECK ADD  CONSTRAINT [fk_tdm_mldm_ldm] FOREIGN KEY([MaLoaiDanhMuc])
REFERENCES [dbo].[LoaiDanhMuc] ([MaLoaiDanhMuc])
GO
ALTER TABLE [dbo].[DanhMuc] CHECK CONSTRAINT [fk_tdm_mldm_ldm]
GO
ALTER TABLE [dbo].[DanhMucHoTro]  WITH CHECK ADD  CONSTRAINT [fk_ght] FOREIGN KEY([MaLoaiDanhMuc])
REFERENCES [dbo].[LoaiDanhMuc] ([MaLoaiDanhMuc])
GO
ALTER TABLE [dbo].[DanhMucHoTro] CHECK CONSTRAINT [fk_ght]
GO
ALTER TABLE [dbo].[Hinh_GT_extra]  WITH CHECK ADD  CONSTRAINT [fk_danhmuc_extra] FOREIGN KEY([Id_DanhMuc])
REFERENCES [dbo].[DanhMuc] ([Id_DanhMuc])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Hinh_GT_extra] CHECK CONSTRAINT [fk_danhmuc_extra]
GO
ALTER TABLE [dbo].[Hinh_GT_MAIN]  WITH CHECK ADD  CONSTRAINT [fk_danhmuc] FOREIGN KEY([Id_DanhMuc])
REFERENCES [dbo].[DanhMuc] ([Id_DanhMuc])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Hinh_GT_MAIN] CHECK CONSTRAINT [fk_danhmuc]
GO
