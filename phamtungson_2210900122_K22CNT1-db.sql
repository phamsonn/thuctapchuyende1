USE [phamtungson_2210900122_K22CNT1]
GO
/****** Object:  Table [dbo].[chi_tiet_hoa_don]    Script Date: 10/31/2024 8:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chi_tiet_hoa_don](
	[ma_hd] [char](10) NOT NULL,
	[ma_sp] [char](10) NOT NULL,
	[ma_size] [char](10) NOT NULL,
	[so_luong] [int] NULL,
	[don_gia] [decimal](10, 2) NULL,
	[thanh_tien] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_hd] ASC,
	[ma_sp] ASC,
	[ma_size] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[hoa_don]    Script Date: 10/31/2024 8:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hoa_don](
	[ma_hd] [char](10) NOT NULL,
	[ngay_laphd] [datetime] NULL,
	[ngay_giao_hang] [datetime] NULL,
	[dc_giao_hang] [varchar](50) NULL,
	[ma_kh] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_hd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[khach_hang]    Script Date: 10/31/2024 8:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[khach_hang](
	[ma_kh] [char](10) NOT NULL,
	[ten_DN] [varchar](50) NULL,
	[ho_ten] [varchar](50) NULL,
	[ngay_sinh] [datetime] NULL,
	[gioi_tinh] [char](5) NULL,
	[mat_khau] [varchar](100) NULL,
	[diachi] [varchar](100) NULL,
	[sdt] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_kh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[san_pham]    Script Date: 10/31/2024 8:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[san_pham](
	[ma_sp] [char](10) NOT NULL,
	[ten_sp] [varchar](50) NULL,
	[gia_ban] [decimal](10, 2) NULL,
	[loai_sp] [int] NULL,
	[gioi_tinh] [char](5) NULL,
	[anh] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_sp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[size]    Script Date: 10/31/2024 8:05:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[size](
	[ma_size] [char](10) NOT NULL,
	[size] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_size] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[chi_tiet_hoa_don]  WITH CHECK ADD FOREIGN KEY([ma_hd])
REFERENCES [dbo].[hoa_don] ([ma_hd])
GO
ALTER TABLE [dbo].[chi_tiet_hoa_don]  WITH CHECK ADD FOREIGN KEY([ma_size])
REFERENCES [dbo].[size] ([ma_size])
GO
ALTER TABLE [dbo].[chi_tiet_hoa_don]  WITH CHECK ADD FOREIGN KEY([ma_sp])
REFERENCES [dbo].[san_pham] ([ma_sp])
GO
ALTER TABLE [dbo].[hoa_don]  WITH CHECK ADD FOREIGN KEY([ma_kh])
REFERENCES [dbo].[khach_hang] ([ma_kh])
GO
