USE [master]
GO
/****** Object:  Database [OnlineShopping]    Script Date: 31.05.2021 19:16:39 ******/
CREATE DATABASE [OnlineShopping]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OnlineShopping', FILENAME = N'C:\Users\Burak\OnlineShopping.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OnlineShopping_log', FILENAME = N'C:\Users\Burak\OnlineShopping_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [OnlineShopping] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OnlineShopping].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OnlineShopping] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OnlineShopping] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OnlineShopping] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OnlineShopping] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OnlineShopping] SET ARITHABORT OFF 
GO
ALTER DATABASE [OnlineShopping] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OnlineShopping] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OnlineShopping] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OnlineShopping] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OnlineShopping] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OnlineShopping] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OnlineShopping] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OnlineShopping] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OnlineShopping] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OnlineShopping] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OnlineShopping] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OnlineShopping] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OnlineShopping] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OnlineShopping] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OnlineShopping] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OnlineShopping] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OnlineShopping] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OnlineShopping] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OnlineShopping] SET  MULTI_USER 
GO
ALTER DATABASE [OnlineShopping] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OnlineShopping] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OnlineShopping] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OnlineShopping] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OnlineShopping] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OnlineShopping] SET QUERY_STORE = OFF
GO
USE [OnlineShopping]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [OnlineShopping]
GO
/****** Object:  Table [dbo].[tblAdmin]    Script Date: 31.05.2021 19:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAdmin](
	[AdminId] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAd] [nvarchar](50) NULL,
	[KullaniciSifre] [nvarchar](50) NULL,
	[Bakiye] [money] NULL,
 CONSTRAINT [PK_tblAdmin] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblAlimEmri]    Script Date: 31.05.2021 19:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAlimEmri](
	[EmirId] [int] IDENTITY(1,1) NOT NULL,
	[AliciId] [int] NULL,
	[UrunId] [int] NULL,
	[Miktar] [int] NULL,
	[TeklifFiyat] [money] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_tblAlimEmri] PRIMARY KEY CLUSTERED 
(
	[EmirId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblAlimSatim]    Script Date: 31.05.2021 19:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAlimSatim](
	[IslemId] [int] IDENTITY(1,1) NOT NULL,
	[AliciId] [int] NULL,
	[SaticiId] [int] NULL,
	[UrunId] [int] NULL,
	[Miktar] [int] NULL,
	[ToplamFiyat] [money] NULL,
	[Tarih] [date] NULL,
 CONSTRAINT [PK_tblAlimSatim] PRIMARY KEY CLUSTERED 
(
	[IslemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBakiye]    Script Date: 31.05.2021 19:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBakiye](
	[KullaniciId] [int] NOT NULL,
	[MevcutBakiye] [money] NULL,
	[EklenecekBakiye] [money] NULL,
	[DovizId] [int] NULL,
	[BakiyeOnay] [bit] NULL,
 CONSTRAINT [PK_tblBakiye_1] PRIMARY KEY CLUSTERED 
(
	[KullaniciId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDoviz]    Script Date: 31.05.2021 19:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDoviz](
	[DovizId] [int] IDENTITY(1,1) NOT NULL,
	[DovizAd] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblIlan]    Script Date: 31.05.2021 19:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblIlan](
	[IlanId] [int] IDENTITY(1,1) NOT NULL,
	[SaticiId] [int] NULL,
	[UrunId] [int] NULL,
	[Miktar] [int] NULL,
	[BirimFiyat] [money] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_tblIlan] PRIMARY KEY CLUSTERED 
(
	[IlanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKullanici]    Script Date: 31.05.2021 19:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKullanici](
	[KullaniciId] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[TelNo] [nvarchar](15) NULL,
	[Adres] [nvarchar](500) NULL,
	[eMail] [nvarchar](50) NULL,
	[TcNo] [nvarchar](50) NULL,
	[KullaniciAd] [nvarchar](50) NULL,
	[KullaniciSifre] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblKullanici] PRIMARY KEY CLUSTERED 
(
	[KullaniciId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStok]    Script Date: 31.05.2021 19:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStok](
	[StokKod] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciId] [int] NOT NULL,
	[UrunId] [int] NULL,
	[UrunMiktar] [int] NULL,
	[UrunOnay] [bit] NULL,
 CONSTRAINT [PK_tblStok] PRIMARY KEY CLUSTERED 
(
	[StokKod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUrun]    Script Date: 31.05.2021 19:16:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUrun](
	[UrunId] [int] IDENTITY(1,1) NOT NULL,
	[UrunAd] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblUrun] PRIMARY KEY CLUSTERED 
(
	[UrunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblBakiye] ADD  CONSTRAINT [DF_tblBakiye_MevcutBakiye]  DEFAULT ((0)) FOR [MevcutBakiye]
GO
ALTER TABLE [dbo].[tblBakiye] ADD  CONSTRAINT [DF_tblBakiye_EklenecekBakiye]  DEFAULT ((0)) FOR [EklenecekBakiye]
GO
USE [master]
GO
ALTER DATABASE [OnlineShopping] SET  READ_WRITE 
GO
