USE [master]
GO
/****** Object:  Database [kasirrr]    Script Date: 11/2/2019 6:38:04 PM ******/
CREATE DATABASE [kasirrr]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'kasirrr', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.DIMASSQL\MSSQL\DATA\kasirrr.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'kasirrr_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.DIMASSQL\MSSQL\DATA\kasirrr_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [kasirrr] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [kasirrr].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [kasirrr] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [kasirrr] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [kasirrr] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [kasirrr] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [kasirrr] SET ARITHABORT OFF 
GO
ALTER DATABASE [kasirrr] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [kasirrr] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [kasirrr] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [kasirrr] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [kasirrr] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [kasirrr] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [kasirrr] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [kasirrr] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [kasirrr] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [kasirrr] SET  DISABLE_BROKER 
GO
ALTER DATABASE [kasirrr] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [kasirrr] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [kasirrr] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [kasirrr] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [kasirrr] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [kasirrr] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [kasirrr] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [kasirrr] SET RECOVERY FULL 
GO
ALTER DATABASE [kasirrr] SET  MULTI_USER 
GO
ALTER DATABASE [kasirrr] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [kasirrr] SET DB_CHAINING OFF 
GO
ALTER DATABASE [kasirrr] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [kasirrr] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [kasirrr] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'kasirrr', N'ON'
GO
ALTER DATABASE [kasirrr] SET QUERY_STORE = OFF
GO
USE [kasirrr]
GO
/****** Object:  Table [dbo].[Suplier]    Script Date: 11/2/2019 6:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suplier](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama] [varchar](50) NULL,
	[telp] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[website] [varchar](100) NULL,
	[alamat] [text] NULL,
 CONSTRAINT [PK_Suplier] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Barang]    Script Date: 11/2/2019 6:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kode_brg] [varchar](20) NULL,
	[nama] [varchar](50) NULL,
	[deskripsi] [text] NULL,
	[stok] [int] NULL,
	[hrg_beli] [decimal](18, 2) NULL,
	[hrg_jual] [decimal](18, 2) NULL,
	[id_suplier] [int] NULL,
 CONSTRAINT [PK_Barang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[LaporanBarang]    Script Date: 11/2/2019 6:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[LaporanBarang]
AS
SELECT dbo.Barang.kode_brg AS kode, dbo.Barang.nama, dbo.Barang.hrg_beli AS hargaBeli, dbo.Barang.hrg_jual AS hargaJual, dbo.Suplier.nama AS suplier
FROM   dbo.Barang INNER JOIN
             dbo.Suplier ON dbo.Barang.id_suplier = dbo.Suplier.id
GO
/****** Object:  Table [dbo].[Pelanggan]    Script Date: 11/2/2019 6:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pelanggan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kode_plg] [char](5) NULL,
	[nama] [varchar](50) NULL,
	[gender] [varchar](20) NULL,
	[telp] [varchar](20) NULL,
	[alamat] [text] NULL,
 CONSTRAINT [PK_Pelanggan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Penjualan]    Script Date: 11/2/2019 6:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Penjualan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[notrx] [varchar](20) NULL,
	[tgl] [date] NULL,
	[kode_plg] [char](5) NULL,
	[kode_brg] [varchar](20) NULL,
	[harga] [decimal](18, 2) NULL,
	[qty] [int] NULL,
	[total] [decimal](18, 2) NULL,
	[id_user] [int] NULL,
 CONSTRAINT [PK_Penjualan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[loadBarang]    Script Date: 11/2/2019 6:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[loadBarang]
AS
SELECT dbo.Penjualan.id, dbo.Penjualan.notrx, dbo.Barang.kode_brg, dbo.Barang.nama AS Barang, dbo.Pelanggan.nama AS Pelanggan, dbo.Barang.stok, dbo.Penjualan.harga, dbo.Penjualan.qty, dbo.Penjualan.harga * dbo.Penjualan.qty AS Total
FROM   dbo.Penjualan INNER JOIN
             dbo.Pelanggan ON dbo.Penjualan.kode_plg = dbo.Pelanggan.kode_plg INNER JOIN
             dbo.Barang ON dbo.Penjualan.kode_brg = dbo.Barang.kode_brg
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/2/2019 6:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama] [varchar](50) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[role] [varchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailPenjualan]    Script Date: 11/2/2019 6:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailPenjualan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[notrx] [varchar](20) NULL,
	[total] [decimal](18, 2) NULL,
	[tunai] [decimal](18, 2) NULL,
	[kembali] [decimal](18, 2) NULL,
 CONSTRAINT [PK_DetailPenjualan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_cetak]    Script Date: 11/2/2019 6:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_cetak]
AS
SELECT dbo.Penjualan.notrx, dbo.Penjualan.tgl, dbo.Pelanggan.nama, dbo.Barang.nama AS Barang, dbo.Penjualan.harga, dbo.Penjualan.qty, dbo.Penjualan.total, dbo.DetailPenjualan.total AS SubTotal, dbo.DetailPenjualan.tunai, dbo.DetailPenjualan.kembali, dbo.Users.nama AS Kasir
FROM   dbo.Barang INNER JOIN
             dbo.Penjualan ON dbo.Barang.kode_brg = dbo.Penjualan.kode_brg INNER JOIN
             dbo.Pelanggan ON dbo.Penjualan.kode_plg = dbo.Pelanggan.kode_plg INNER JOIN
             dbo.DetailPenjualan ON dbo.Penjualan.notrx = dbo.DetailPenjualan.notrx INNER JOIN
             dbo.Users ON dbo.Penjualan.id_user = dbo.Users.id
GO
/****** Object:  View [dbo].[Vw_penjualan]    Script Date: 11/2/2019 6:38:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vw_penjualan]
AS
SELECT dbo.vw_cetak.notrx, dbo.vw_cetak.tgl, dbo.vw_cetak.SubTotal, dbo.Barang.hrg_beli * dbo.vw_cetak.qty AS Modal, dbo.vw_cetak.SubTotal - dbo.Barang.hrg_beli AS Untung
FROM   dbo.vw_cetak INNER JOIN
             dbo.Barang ON dbo.vw_cetak.harga = dbo.Barang.hrg_jual
GO
SET IDENTITY_INSERT [dbo].[Barang] ON 

INSERT [dbo].[Barang] ([id], [kode_brg], [nama], [deskripsi], [stok], [hrg_beli], [hrg_jual], [id_suplier]) VALUES (1, N'12912121', N'Buku', N'Buku 38 lembar', 187, CAST(1000.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Barang] ([id], [kode_brg], [nama], [deskripsi], [stok], [hrg_beli], [hrg_jual], [id_suplier]) VALUES (2, N'8888166603615', N'Waffer Tanggo', N'waffer tangg0 250 gr', -9, CAST(12000.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Barang] ([id], [kode_brg], [nama], [deskripsi], [stok], [hrg_beli], [hrg_jual], [id_suplier]) VALUES (3, N'8995179100724', N'Sarimi Sukses', N'Sarimi Sukses 12 ', 77, CAST(2000.00 AS Decimal(18, 2)), CAST(3000.00 AS Decimal(18, 2)), 2)
SET IDENTITY_INSERT [dbo].[Barang] OFF
SET IDENTITY_INSERT [dbo].[DetailPenjualan] ON 

INSERT [dbo].[DetailPenjualan] ([id], [notrx], [total], [tunai], [kembali]) VALUES (1, N'201909031012', CAST(3000.00 AS Decimal(18, 2)), CAST(9000.00 AS Decimal(18, 2)), CAST(6000.00 AS Decimal(18, 2)))
INSERT [dbo].[DetailPenjualan] ([id], [notrx], [total], [tunai], [kembali]) VALUES (2, N'201909031013', CAST(2000.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)), CAST(8000.00 AS Decimal(18, 2)))
INSERT [dbo].[DetailPenjualan] ([id], [notrx], [total], [tunai], [kembali]) VALUES (3, N'201909031014', CAST(3000.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)), CAST(7000.00 AS Decimal(18, 2)))
INSERT [dbo].[DetailPenjualan] ([id], [notrx], [total], [tunai], [kembali]) VALUES (4, N'201909031014', CAST(3000.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)), CAST(7000.00 AS Decimal(18, 2)))
INSERT [dbo].[DetailPenjualan] ([id], [notrx], [total], [tunai], [kembali]) VALUES (5, N'201909031015', CAST(3000.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)), CAST(7000.00 AS Decimal(18, 2)))
INSERT [dbo].[DetailPenjualan] ([id], [notrx], [total], [tunai], [kembali]) VALUES (6, N'201909031016', CAST(3000.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)), CAST(7000.00 AS Decimal(18, 2)))
INSERT [dbo].[DetailPenjualan] ([id], [notrx], [total], [tunai], [kembali]) VALUES (7, N'201909031017', CAST(3000.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)), CAST(7000.00 AS Decimal(18, 2)))
INSERT [dbo].[DetailPenjualan] ([id], [notrx], [total], [tunai], [kembali]) VALUES (8, N'201909031017', CAST(5000.00 AS Decimal(18, 2)), CAST(20000.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)))
INSERT [dbo].[DetailPenjualan] ([id], [notrx], [total], [tunai], [kembali]) VALUES (9, N'201909261001', CAST(5000.00 AS Decimal(18, 2)), CAST(50000.00 AS Decimal(18, 2)), CAST(45000.00 AS Decimal(18, 2)))
INSERT [dbo].[DetailPenjualan] ([id], [notrx], [total], [tunai], [kembali]) VALUES (10, N'201909261002', CAST(9000.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[DetailPenjualan] ([id], [notrx], [total], [tunai], [kembali]) VALUES (11, N'201910041001', CAST(2000.00 AS Decimal(18, 2)), CAST(90000.00 AS Decimal(18, 2)), CAST(88000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[DetailPenjualan] OFF
SET IDENTITY_INSERT [dbo].[Pelanggan] ON 

INSERT [dbo].[Pelanggan] ([id], [kode_plg], [nama], [gender], [telp], [alamat]) VALUES (1, N'P0001', N'Dimas', N'Laki-Laki', N'08232512', N'Suwawal')
INSERT [dbo].[Pelanggan] ([id], [kode_plg], [nama], [gender], [telp], [alamat]) VALUES (3, N'P0002', N'diki', N'Laki-Laki', N'082324567890', N'Jepara')
SET IDENTITY_INSERT [dbo].[Pelanggan] OFF
SET IDENTITY_INSERT [dbo].[Penjualan] ON 

INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (17, N'201909031001', CAST(N'2019-09-03' AS Date), N'P0001', N'8888166603615', CAST(15000.00 AS Decimal(18, 2)), 4, CAST(15000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (18, N'201909031002', CAST(N'2019-09-03' AS Date), N'P0001', N'8888166603615', CAST(15000.00 AS Decimal(18, 2)), 2, CAST(15000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (19, N'201909031003', CAST(N'2019-09-03' AS Date), N'P0001', N'8995179100724', CAST(3000.00 AS Decimal(18, 2)), 3, CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (22, N'201909031004', CAST(N'2019-09-03' AS Date), N'P0001', N'8888166603615', CAST(15000.00 AS Decimal(18, 2)), 2, CAST(15000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (23, N'201909031005', CAST(N'2019-09-03' AS Date), N'P0001', N'8888166603615', CAST(15000.00 AS Decimal(18, 2)), 1, CAST(15000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (24, N'201909031006', CAST(N'2019-09-03' AS Date), N'P0001', N'8995179100724', CAST(3000.00 AS Decimal(18, 2)), 1, CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (25, N'201909031007', CAST(N'2019-09-03' AS Date), N'P0001', N'8888166603615', CAST(15000.00 AS Decimal(18, 2)), 1, CAST(15000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (26, N'201909031008', CAST(N'2019-09-03' AS Date), N'P0001', N'8995179100724', CAST(3000.00 AS Decimal(18, 2)), 1, CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (27, N'201909031009', CAST(N'2019-09-03' AS Date), N'P0001', N'8995179100724', CAST(3000.00 AS Decimal(18, 2)), 1, CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (28, N'201909031010', CAST(N'2019-09-03' AS Date), N'P0001', N'8888166603615', CAST(15000.00 AS Decimal(18, 2)), 1, CAST(15000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (29, N'201909031011', CAST(N'2019-09-03' AS Date), N'P0001', N'12912121', CAST(2000.00 AS Decimal(18, 2)), 1, CAST(2000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (30, N'201909031012', CAST(N'2019-09-03' AS Date), N'P0001', N'8995179100724', CAST(3000.00 AS Decimal(18, 2)), 1, CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (31, N'201909031013', CAST(N'2019-09-03' AS Date), N'P0001', N'12912121', CAST(2000.00 AS Decimal(18, 2)), 1, CAST(2000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (32, N'201909031014', CAST(N'2019-09-03' AS Date), N'P0001', N'8995179100724', CAST(3000.00 AS Decimal(18, 2)), 1, CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (33, N'201909031015', CAST(N'2019-09-03' AS Date), N'P0001', N'8995179100724', CAST(3000.00 AS Decimal(18, 2)), 1, CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (34, N'201909031016', CAST(N'2019-09-03' AS Date), N'P0001', N'8995179100724', CAST(3000.00 AS Decimal(18, 2)), 1, CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (35, N'201909031017', CAST(N'2019-09-03' AS Date), N'P0001', N'8995179100724', CAST(3000.00 AS Decimal(18, 2)), 1, CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (36, N'201909031017', CAST(N'2019-09-03' AS Date), N'P0001', N'12912121', CAST(2000.00 AS Decimal(18, 2)), 1, CAST(2000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (37, N'201909261001', CAST(N'2019-09-26' AS Date), N'P0001', N'12912121', CAST(2000.00 AS Decimal(18, 2)), 1, CAST(2000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (38, N'201909261001', CAST(N'2019-09-26' AS Date), N'P0001', N'8995179100724', CAST(3000.00 AS Decimal(18, 2)), 1, CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (39, N'201909261002', CAST(N'2019-09-26' AS Date), N'P0001', N'12912121', CAST(2000.00 AS Decimal(18, 2)), 3, CAST(2000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (40, N'201909261002', CAST(N'2019-09-26' AS Date), N'P0001', N'8995179100724', CAST(3000.00 AS Decimal(18, 2)), 1, CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (41, N'201910041001', CAST(N'2019-10-04' AS Date), N'P0001', N'12912121', CAST(2000.00 AS Decimal(18, 2)), 1, CAST(2000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (42, N'201910251001', CAST(N'2019-10-25' AS Date), N'P0001', N'12912121', CAST(2000.00 AS Decimal(18, 2)), 1, CAST(2000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Penjualan] ([id], [notrx], [tgl], [kode_plg], [kode_brg], [harga], [qty], [total], [id_user]) VALUES (44, N'201911011001', CAST(N'2019-11-01' AS Date), N'P0001', N'12912121', CAST(2000.00 AS Decimal(18, 2)), 1, CAST(2000.00 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[Penjualan] OFF
SET IDENTITY_INSERT [dbo].[Suplier] ON 

INSERT [dbo].[Suplier] ([id], [nama], [telp], [email], [website], [alamat]) VALUES (2, N'Semoga jaya', N'08232515341', N'semogjaya@gmail.com', N'httpsemogjaya.com', N'Jepara')
SET IDENTITY_INSERT [dbo].[Suplier] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [nama], [username], [password], [role]) VALUES (1, N'dimas', N'admin', N'admin', N'Admin')
INSERT [dbo].[Users] ([id], [nama], [username], [password], [role]) VALUES (2, N'ari', N'kasir', N'kasir', N'Kasir')
SET IDENTITY_INSERT [dbo].[Users] OFF
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[31] 4[34] 2[17] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -720
         Left = -21
      End
      Begin Tables = 
         Begin Table = "Barang"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 378
               Right = 347
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Suplier"
            Begin Extent = 
               Top = 65
               Left = 520
               Bottom = 345
               Right = 864
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'LaporanBarang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'LaporanBarang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[36] 4[3] 2[42] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Penjualan"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 364
               Right = 541
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Barang"
            Begin Extent = 
               Top = 18
               Left = 605
               Bottom = 352
               Right = 890
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pelanggan"
            Begin Extent = 
               Top = 18
               Left = 993
               Bottom = 310
               Right = 1215
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'loadBarang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'loadBarang'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[16] 4[67] 2[3] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Barang"
            Begin Extent = 
               Top = 275
               Left = 1046
               Bottom = 600
               Right = 1257
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DetailPenjualan"
            Begin Extent = 
               Top = 95
               Left = 1564
               Bottom = 407
               Right = 1805
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pelanggan"
            Begin Extent = 
               Top = 9
               Left = 615
               Bottom = 360
               Right = 889
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Penjualan"
            Begin Extent = 
               Top = 46
               Left = 124
               Bottom = 440
               Right = 414
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Users"
            Begin Extent = 
               Top = 34
               Left = 1286
               Bottom = 374
               Right = 1508
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_cetak'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'= 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_cetak'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_cetak'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[53] 4[8] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "vw_cetak"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 344
               Right = 448
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Barang"
            Begin Extent = 
               Top = 13
               Left = 563
               Bottom = 360
               Right = 960
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
         Width = 1000
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_penjualan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_penjualan'
GO
USE [master]
GO
ALTER DATABASE [kasirrr] SET  READ_WRITE 
GO
