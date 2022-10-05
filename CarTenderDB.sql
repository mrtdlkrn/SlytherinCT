USE [master]
GO
/****** Object:  Database [CarTenderDB]    Script Date: 04/10/2022 18:12:47 ******/
CREATE DATABASE [CarTenderDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarTenderDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CarTenderDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarTenderDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CarTenderDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CarTenderDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarTenderDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarTenderDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarTenderDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarTenderDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarTenderDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarTenderDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarTenderDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarTenderDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarTenderDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarTenderDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarTenderDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarTenderDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarTenderDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarTenderDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarTenderDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarTenderDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CarTenderDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarTenderDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarTenderDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarTenderDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarTenderDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarTenderDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarTenderDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarTenderDB] SET RECOVERY FULL 
GO
ALTER DATABASE [CarTenderDB] SET  MULTI_USER 
GO
ALTER DATABASE [CarTenderDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarTenderDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarTenderDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarTenderDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarTenderDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarTenderDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CarTenderDB', N'ON'
GO
ALTER DATABASE [CarTenderDB] SET QUERY_STORE = OFF
GO
USE [CarTenderDB]
GO
/****** Object:  Table [dbo].[AddressInformation]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddressInformation](
	[ID] [uniqueidentifier] NOT NULL,
	[NeighborhoodID] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_AddressInformation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Advert]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advert](
	[ID] [uniqueidentifier] NOT NULL,
	[Header] [nvarchar](250) NULL,
	[PrePrice] [decimal](18, 2) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Information] [nvarchar](200) NULL,
	[CarID] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_Advert] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdvertStatusHistory]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdvertStatusHistory](
	[ID] [uniqueidentifier] NOT NULL,
	[Information] [nvarchar](200) NULL,
	[AdvertID] [uniqueidentifier] NOT NULL,
	[StatuID] [uniqueidentifier] NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_AdvertStatusHistory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authorazition]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authorazition](
	[ID] [uniqueidentifier] NOT NULL,
	[AutherizationPath] [nvarchar](250) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_Authorazition] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BidCar]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BidCar](
	[ID] [uniqueidentifier] NOT NULL,
	[BidID] [uniqueidentifier] NOT NULL,
	[CarID] [uniqueidentifier] NOT NULL,
	[StartPrice] [decimal](18, 2) NOT NULL,
	[MinimumPrice] [decimal](18, 2) NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_BidCar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BidCorporateUser]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BidCorporateUser](
	[ID] [uniqueidentifier] NOT NULL,
	[BidID] [uniqueidentifier] NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[CorporateID] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_BidCorporateUser] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BidInformation]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BidInformation](
	[ID] [uniqueidentifier] NOT NULL,
	[BidName] [nvarchar](200) NULL,
	[IsCorporate] [bit] NOT NULL,
	[IsApproved] [bit] NOT NULL,
	[FinishedDate] [datetime] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[ApprovedBy] [uniqueidentifier] NULL,
	[FinishedBy] [uniqueidentifier] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[UserID] [uniqueidentifier] NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
	[AddressInformationID] [uniqueidentifier] NULL,
 CONSTRAINT [PK_BidInformation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BidOfferDetail]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BidOfferDetail](
	[BidCarID] [uniqueidentifier] NOT NULL,
	[BidUserOfferID] [uniqueidentifier] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_BidOfferDetail] PRIMARY KEY CLUSTERED 
(
	[BidCarID] ASC,
	[BidUserOfferID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BidStatusHistory]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BidStatusHistory](
	[ID] [uniqueidentifier] NOT NULL,
	[Information] [nvarchar](150) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[BidID] [uniqueidentifier] NOT NULL,
	[StatuID] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_BidStatusHistory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BidUserOffer]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BidUserOffer](
	[ID] [uniqueidentifier] NOT NULL,
	[BidCorporateUserID] [uniqueidentifier] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_BidUserOffer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BrandModel]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BrandModel](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[BrandID] [bigint] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_BrandModel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[ID] [uniqueidentifier] NOT NULL,
	[Year] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Information] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
	[IsCorparate] [bit] NULL,
	[ModelID] [bigint] NOT NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarBuyerInformation]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarBuyerInformation](
	[ID] [uniqueidentifier] NOT NULL,
	[CarID] [uniqueidentifier] NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Note] [nvarchar](250) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_CarBuyerInformation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarComission]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarComission](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ComissionFee] [decimal](18, 2) NOT NULL,
	[Information] [nvarchar](200) NULL,
	[MinCarPrice] [decimal](18, 2) NOT NULL,
	[MaxCarPrice] [decimal](18, 2) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_CarComission] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarDetail]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarDetail](
	[ID] [uniqueidentifier] NOT NULL,
	[CarDetailName] [nvarchar](150) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_CarDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarDetailValue]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarDetailValue](
	[ID] [uniqueidentifier] NOT NULL,
	[CarDetailValueName] [nvarchar](150) NOT NULL,
	[CarDetailID] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_CarDetailValue] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarImage]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarImage](
	[ID] [uniqueidentifier] NOT NULL,
	[CarID] [uniqueidentifier] NOT NULL,
	[ImagePath] [nvarchar](150) NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_CarImage] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarModification]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarModification](
	[ModificationID] [uniqueidentifier] NOT NULL,
	[CarID] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_CarModification] PRIMARY KEY CLUSTERED 
(
	[ModificationID] ASC,
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarSaleHistory]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarSaleHistory](
	[ID] [uniqueidentifier] NOT NULL,
	[CarID] [uniqueidentifier] NOT NULL,
	[SellerID] [uniqueidentifier] NOT NULL,
	[BuyerID] [uniqueidentifier] NOT NULL,
	[Comission] [decimal](18, 2) NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[ModifiedDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_CarSaleHistory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarStatusHistory]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarStatusHistory](
	[ID] [uniqueidentifier] NOT NULL,
	[Information] [nvarchar](150) NULL,
	[CarID] [uniqueidentifier] NOT NULL,
	[CarStatuID] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_CarStatusHistory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarValue]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarValue](
	[CarID] [uniqueidentifier] NOT NULL,
	[CarValueID] [uniqueidentifier] NOT NULL,
	[Version] [timestamp] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_CarValue] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC,
	[CarValueID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[ID] [uniqueidentifier] NOT NULL,
	[CityName] [nvarchar](200) NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comission]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comission](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ComissionName] [nvarchar](50) NOT NULL,
	[Information] [nvarchar](200) NULL,
	[MinCarPrice] [decimal](18, 2) NOT NULL,
	[MaxCarPrice] [decimal](18, 2) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_Comission] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComissionInformation]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComissionInformation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ComissionID] [int] NOT NULL,
	[NoterComissionID] [int] NOT NULL,
	[CarComissionID] [int] NOT NULL,
	[Information] [nvarchar](200) NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_ComissionInformation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CorparateBid]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CorparateBid](
	[ID] [uniqueidentifier] NOT NULL,
	[CorparateID] [uniqueidentifier] NOT NULL,
	[BidID] [uniqueidentifier] NOT NULL,
	[Information] [nvarchar](200) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_CorparateBid] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Corporate]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Corporate](
	[ID] [uniqueidentifier] NOT NULL,
	[CorporateName] [nvarchar](250) NULL,
	[CorporatePhone] [nvarchar](13) NULL,
	[AddressInformationID] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_Corporate] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CorporateRole]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CorporateRole](
	[ID] [uniqueidentifier] NOT NULL,
	[RoleName] [nvarchar](100) NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_CorporateRole] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CorporateStatusHistory]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CorporateStatusHistory](
	[ID] [uniqueidentifier] NOT NULL,
	[Information] [nvarchar](150) NULL,
	[CorporateID] [uniqueidentifier] NOT NULL,
	[StatuID] [uniqueidentifier] NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_CorporateStatusHistory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CorporateUser]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CorporateUser](
	[UserID] [uniqueidentifier] NOT NULL,
	[CorporateID] [uniqueidentifier] NOT NULL,
	[CorporateRoleID] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_CorporateUser] PRIMARY KEY CLUSTERED 
(
	[CorporateID] ASC,
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[District]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[District](
	[ID] [uniqueidentifier] NOT NULL,
	[TownID] [uniqueidentifier] NOT NULL,
	[DistrictName] [nvarchar](200) NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_District] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expertise]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expertise](
	[ID] [uniqueidentifier] NOT NULL,
	[ExpertiseName] [nvarchar](200) NOT NULL,
	[AddressInformationID] [uniqueidentifier] NOT NULL,
	[Latitude] [decimal](18, 2) NOT NULL,
	[Longitude] [decimal](18, 2) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
	[LocationImage] [nvarchar](200) NULL,
 CONSTRAINT [PK_Expertise] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Message]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Message](
	[ID] [uniqueidentifier] NOT NULL,
	[MessageContentID] [uniqueidentifier] NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MessageContent]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MessageContent](
	[ID] [uniqueidentifier] NOT NULL,
	[ContentText] [nvarchar](250) NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_MessageContent] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modification]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modification](
	[ID] [uniqueidentifier] NOT NULL,
	[ModificationComponentName] [nvarchar](200) NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_Modification] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Neighborhood]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Neighborhood](
	[ID] [uniqueidentifier] NOT NULL,
	[DistrictID] [uniqueidentifier] NOT NULL,
	[NeighborhoodName] [nvarchar](150) NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_Neighborhood] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NoterComission]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoterComission](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ComissionFee] [decimal](18, 2) NOT NULL,
	[Information] [nvarchar](200) NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_NoterComission] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Package]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Package](
	[ID] [uniqueidentifier] NOT NULL,
	[PackageName] [nvarchar](200) NULL,
	[BidCount] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_Package] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PackageCorporate]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PackageCorporate](
	[CorporateID] [uniqueidentifier] NOT NULL,
	[PackageID] [uniqueidentifier] NOT NULL,
	[Version] [timestamp] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_PackageCorporate] PRIMARY KEY CLUSTERED 
(
	[PackageID] ASC,
	[CorporateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PageAuthorization]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PageAuthorization](
	[ID] [uniqueidentifier] NOT NULL,
	[PageAuthorizationName] [nvarchar](150) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_PageAuthorization] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [uniqueidentifier] NOT NULL,
	[RoleName] [nvarchar](50) NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleAutherization]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAutherization](
	[RoleID] [uniqueidentifier] NOT NULL,
	[AuthorizationID] [uniqueidentifier] NOT NULL,
	[PageAuthorizationID] [uniqueidentifier] NOT NULL,
	[Version] [timestamp] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_RoleAutherization] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[AuthorizationID] ASC,
	[PageAuthorizationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[ID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](10) NOT NULL,
	[StatusName] [nvarchar](150) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Town]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Town](
	[ID] [uniqueidentifier] NOT NULL,
	[CityID] [uniqueidentifier] NOT NULL,
	[TownName] [nvarchar](200) NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_Town] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TramerComponent]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TramerComponent](
	[ID] [uniqueidentifier] NOT NULL,
	[TramerComponentName] [nvarchar](250) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_TramerComponent] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TramerInformation]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TramerInformation](
	[ID] [uniqueidentifier] NOT NULL,
	[TramerPrice] [decimal](18, 2) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CarID] [uniqueidentifier] NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_TramerInformation] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TramerInformationComponent]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TramerInformationComponent](
	[TramerComponentID] [uniqueidentifier] NOT NULL,
	[TramerInformationID] [uniqueidentifier] NOT NULL,
	[ID] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_TramerInformationComponent] PRIMARY KEY CLUSTERED 
(
	[TramerInformationID] ASC,
	[TramerComponentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TramerStatusHistory]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TramerStatusHistory](
	[ID] [uniqueidentifier] NOT NULL,
	[TramerInformationComponentID] [uniqueidentifier] NOT NULL,
	[TramerInformationComponentTramerInformationID] [uniqueidentifier] NOT NULL,
	[TramerInformationComponentTramerComponentID] [uniqueidentifier] NOT NULL,
	[StatuID] [uniqueidentifier] NOT NULL,
	[Information] [nvarchar](150) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_TramerStatusHistory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[FirstAndLastName] [nvarchar](200) NOT NULL,
	[Phone] [nvarchar](13) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[PasswordHash] [varbinary](200) NOT NULL,
	[PasswordSalt] [varbinary](200) NOT NULL,
	[IsCorporate] [bit] NOT NULL,
	[Information] [nvarchar](200) NOT NULL,
	[IsApproved] [bit] NOT NULL,
	[IsEmailVerificated] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ApprovedBy] [uniqueidentifier] NULL,
	[RoleID] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
	[IsKVKKApproved] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAutoBidOffer]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAutoBidOffer](
	[Id] [uniqueidentifier] NOT NULL,
	[MaximumOffer] [decimal](18, 2) NOT NULL,
	[IncrementAmount] [decimal](18, 2) NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[BidId] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[ModifiedBy] [uniqueidentifier] NULL,
 CONSTRAINT [PK_UserAutoBidOffer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserCar]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserCar](
	[UserID] [uniqueidentifier] NOT NULL,
	[CarID] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_UserCar] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC,
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserFavoriteCar]    Script Date: 04/10/2022 18:12:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserFavoriteCar](
	[CarID] [uniqueidentifier] NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_UserFavoriteCar] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Role] ([ID], [RoleName], [IsActive]) VALUES (N'00da4414-19ce-41c5-8489-4bf85b9ff5ca', N'User', 1)
GO
INSERT [dbo].[User] ([ID], [UserName], [FirstAndLastName], [Phone], [Email], [PasswordHash], [PasswordSalt], [IsCorporate], [Information], [IsApproved], [IsEmailVerificated], [CreatedDate], [ApprovedBy], [RoleID], [IsActive], [IsKVKKApproved]) VALUES (N'f0596df6-587a-45d2-8ebc-3ee936a3851d', N'burkay', N'burkay akgul', N'21341234', N'dfasfasd', 0xB8B6E6404C2E9C4AACC42F5C334BCC25, 0xA821C4A35F94FA449A7FB3DEA288E366, 1, N'fsda', 1, 1, CAST(N'2022-10-04T02:47:28.977' AS DateTime), NULL, N'00da4414-19ce-41c5-8489-4bf85b9ff5ca', 1, 1)
GO
INSERT [dbo].[User] ([ID], [UserName], [FirstAndLastName], [Phone], [Email], [PasswordHash], [PasswordSalt], [IsCorporate], [Information], [IsApproved], [IsEmailVerificated], [CreatedDate], [ApprovedBy], [RoleID], [IsActive], [IsKVKKApproved]) VALUES (N'76da84bb-43b1-4b89-97cd-7182a04075a0', N'burkay123', N'adfsfasd afsdfasd', N'343224332', N'vcxsxcvsdaf', 0x193A981679E76B4B9F9225C206FD3A51, 0xDA61AE6EA1C3B344B7D738BEE6B9745C, 1, N'fvczsdfadfas', 1, 1, CAST(N'2022-10-04T02:47:57.953' AS DateTime), NULL, N'00da4414-19ce-41c5-8489-4bf85b9ff5ca', 1, 1)
GO
ALTER TABLE [dbo].[AddressInformation] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Advert] ADD  CONSTRAINT [DF__Advert__CreatedD__75A278F5]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Advert] ADD  CONSTRAINT [DF__Advert__IsActive__76969D2E]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[AdvertStatusHistory] ADD  CONSTRAINT [DF__AdvertSta__Creat__778AC167]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[AdvertStatusHistory] ADD  CONSTRAINT [DF__AdvertSta__IsAct__787EE5A0]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Authorazition] ADD  CONSTRAINT [DF__Authorazi__Creat__797309D9]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Authorazition] ADD  CONSTRAINT [DF__Authorazi__IsAct__7A672E12]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[BidCar] ADD  CONSTRAINT [DF__BidCar__CreatedD__7B5B524B]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[BidCar] ADD  CONSTRAINT [DF__BidCar__IsActive__7C4F7684]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[BidCorporateUser] ADD  CONSTRAINT [DF__BidCorpor__Creat__7D439ABD]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[BidCorporateUser] ADD  CONSTRAINT [DF__BidCorpor__IsAct__7E37BEF6]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[BidInformation] ADD  CONSTRAINT [DF__BidInform__Creat__7F2BE32F]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[BidInformation] ADD  CONSTRAINT [DF__BidInform__IsAct__00200768]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[BidOfferDetail] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[BidStatusHistory] ADD  CONSTRAINT [DF__BidStatus__Creat__02084FDA]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[BidStatusHistory] ADD  CONSTRAINT [DF__BidStatus__IsAct__02FC7413]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[BidUserOffer] ADD  CONSTRAINT [DF__BidUserOf__Creat__03F0984C]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[BidUserOffer] ADD  CONSTRAINT [DF__BidUserOf__IsAct__04E4BC85]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[BrandModel] ADD  CONSTRAINT [DF_BrandModel_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Car] ADD  CONSTRAINT [DF__Car__CreatedDate__05D8E0BE]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Car] ADD  CONSTRAINT [DF__Car__IsActive__06CD04F7]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[CarBuyerInformation] ADD  CONSTRAINT [DF__CarBuyerI__Creat__07C12930]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[CarBuyerInformation] ADD  CONSTRAINT [DF__CarBuyerI__IsAct__08B54D69]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[CarComission] ADD  CONSTRAINT [DF_CarComission_StartDate]  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[CarComission] ADD  CONSTRAINT [DF_CarComission_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[CarDetail] ADD  CONSTRAINT [DF__CarDetail__IsAct__09A971A2]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[CarDetailValue] ADD  CONSTRAINT [DF__CarDetail__IsAct__0A9D95DB]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[CarImage] ADD  CONSTRAINT [DF__CarImage__IsActi__0B91BA14]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[CarModification] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[CarSaleHistory] ADD  CONSTRAINT [DF_CarSaleHistory_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[CarSaleHistory] ADD  CONSTRAINT [DF_CarSaleHistory_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[CarStatusHistory] ADD  CONSTRAINT [DF__CarStatus__Creat__0D7A0286]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[CarStatusHistory] ADD  CONSTRAINT [DF__CarStatus__IsAct__0E6E26BF]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[City] ADD  CONSTRAINT [DF__City__IsActive__0F624AF8]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Comission] ADD  CONSTRAINT [DF_Comission_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[ComissionInformation] ADD  CONSTRAINT [DF_ComissionInformation_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[ComissionInformation] ADD  CONSTRAINT [DF_ComissionInformation_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[CorparateBid] ADD  CONSTRAINT [DF_CorparateBid_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[CorparateBid] ADD  CONSTRAINT [DF_CorparateBid_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Corporate] ADD  CONSTRAINT [DF__Corporate__Creat__10566F31]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Corporate] ADD  CONSTRAINT [DF__Corporate__IsAct__114A936A]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[CorporateRole] ADD  CONSTRAINT [DF__Corporate__IsAct__123EB7A3]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[CorporateStatusHistory] ADD  CONSTRAINT [DF__Corporate__Creat__1332DBDC]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[CorporateStatusHistory] ADD  CONSTRAINT [DF__Corporate__IsAct__14270015]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[CorporateUser] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[District] ADD  CONSTRAINT [DF__District__IsActi__160F4887]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Expertise] ADD  CONSTRAINT [DF__Expertise__IsAct__17036CC0]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Message] ADD  CONSTRAINT [DF__Message__Created__17F790F9]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Message] ADD  CONSTRAINT [DF__Message__IsActiv__18EBB532]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[MessageContent] ADD  CONSTRAINT [DF__MessageCo__IsAct__19DFD96B]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Modification] ADD  CONSTRAINT [DF__Modificat__IsAct__1AD3FDA4]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Neighborhood] ADD  CONSTRAINT [DF__Neighborh__IsAct__1BC821DD]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[NoterComission] ADD  CONSTRAINT [DF_NoterComission_StartDate]  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[NoterComission] ADD  CONSTRAINT [DF_NoterComission_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Package] ADD  CONSTRAINT [DF__Package__IsActiv__1CBC4616]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[PageAuthorization] ADD  CONSTRAINT [DF__PageAutho__IsAct__1DB06A4F]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Role] ADD  CONSTRAINT [DF_Role_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[Role] ADD  CONSTRAINT [DF__Role__IsActive__1EA48E88]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Status] ADD  CONSTRAINT [DF__Status__IsActive__1F98B2C1]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Town] ADD  CONSTRAINT [DF__Town__IsActive__208CD6FA]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[TramerComponent] ADD  CONSTRAINT [DF__TramerCom__Creat__2180FB33]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[TramerComponent] ADD  CONSTRAINT [DF__TramerCom__IsAct__22751F6C]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[TramerInformation] ADD  CONSTRAINT [DF__TramerInf__Creat__236943A5]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[TramerInformation] ADD  CONSTRAINT [DF__TramerInf__IsAct__245D67DE]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[TramerInformationComponent] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[TramerStatusHistory] ADD  CONSTRAINT [DF__TramerSta__Creat__2645B050]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[TramerStatusHistory] ADD  CONSTRAINT [DF__TramerSta__IsAct__2739D489]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_ID]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_PasswordHash]  DEFAULT (CONVERT([binary](16),newid())) FOR [PasswordHash]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_PasswordSalt]  DEFAULT (CONVERT([binary](16),newid())) FOR [PasswordSalt]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF__User__CreatedDat__282DF8C2]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF__User__IsActive__29221CFB]  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_IsKVKKApproved]  DEFAULT ((1)) FOR [IsKVKKApproved]
GO
ALTER TABLE [dbo].[UserAutoBidOffer] ADD  CONSTRAINT [DF_UserAutoBidOffer_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[UserAutoBidOffer] ADD  CONSTRAINT [DF_UserAutoBidOffer_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[UserCar] ADD  DEFAULT (CONVERT([bit],(1))) FOR [IsActive]
GO
ALTER TABLE [dbo].[AddressInformation]  WITH CHECK ADD  CONSTRAINT [FK_AddressInformation_Neighborhood_NeighborhoodID] FOREIGN KEY([NeighborhoodID])
REFERENCES [dbo].[Neighborhood] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AddressInformation] CHECK CONSTRAINT [FK_AddressInformation_Neighborhood_NeighborhoodID]
GO
ALTER TABLE [dbo].[Advert]  WITH CHECK ADD  CONSTRAINT [FK_Advert_Car_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Advert] CHECK CONSTRAINT [FK_Advert_Car_CarID]
GO
ALTER TABLE [dbo].[Advert]  WITH CHECK ADD  CONSTRAINT [FK_Advert_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Advert] CHECK CONSTRAINT [FK_Advert_User_CreatedBy]
GO
ALTER TABLE [dbo].[AdvertStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_AdvertStatusHistory_Advert_AdvertID] FOREIGN KEY([AdvertID])
REFERENCES [dbo].[Advert] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AdvertStatusHistory] CHECK CONSTRAINT [FK_AdvertStatusHistory_Advert_AdvertID]
GO
ALTER TABLE [dbo].[AdvertStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_AdvertStatusHistory_Status_StatuID] FOREIGN KEY([StatuID])
REFERENCES [dbo].[Status] ([ID])
GO
ALTER TABLE [dbo].[AdvertStatusHistory] CHECK CONSTRAINT [FK_AdvertStatusHistory_Status_StatuID]
GO
ALTER TABLE [dbo].[AdvertStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_AdvertStatusHistory_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[AdvertStatusHistory] CHECK CONSTRAINT [FK_AdvertStatusHistory_User_CreatedBy]
GO
ALTER TABLE [dbo].[AdvertStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_AdvertStatusHistory_User_ModifiedBy] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[AdvertStatusHistory] CHECK CONSTRAINT [FK_AdvertStatusHistory_User_ModifiedBy]
GO
ALTER TABLE [dbo].[BidCar]  WITH CHECK ADD  CONSTRAINT [FK_BidCar_BidInformation_BidID] FOREIGN KEY([BidID])
REFERENCES [dbo].[BidInformation] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BidCar] CHECK CONSTRAINT [FK_BidCar_BidInformation_BidID]
GO
ALTER TABLE [dbo].[BidCar]  WITH CHECK ADD  CONSTRAINT [FK_BidCar_Car_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BidCar] CHECK CONSTRAINT [FK_BidCar_Car_CarID]
GO
ALTER TABLE [dbo].[BidCar]  WITH CHECK ADD  CONSTRAINT [FK_BidCar_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[BidCar] CHECK CONSTRAINT [FK_BidCar_User_CreatedBy]
GO
ALTER TABLE [dbo].[BidCar]  WITH CHECK ADD  CONSTRAINT [FK_BidCar_User_ModifiedBy] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[BidCar] CHECK CONSTRAINT [FK_BidCar_User_ModifiedBy]
GO
ALTER TABLE [dbo].[BidCorporateUser]  WITH CHECK ADD  CONSTRAINT [FK_BidCorporateUser_BidInformation_BidID] FOREIGN KEY([BidID])
REFERENCES [dbo].[BidInformation] ([ID])
GO
ALTER TABLE [dbo].[BidCorporateUser] CHECK CONSTRAINT [FK_BidCorporateUser_BidInformation_BidID]
GO
ALTER TABLE [dbo].[BidCorporateUser]  WITH CHECK ADD  CONSTRAINT [FK_BidCorporateUser_Corporate_CorporateID] FOREIGN KEY([CorporateID])
REFERENCES [dbo].[Corporate] ([ID])
GO
ALTER TABLE [dbo].[BidCorporateUser] CHECK CONSTRAINT [FK_BidCorporateUser_Corporate_CorporateID]
GO
ALTER TABLE [dbo].[BidCorporateUser]  WITH CHECK ADD  CONSTRAINT [FK_BidCorporateUser_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[BidCorporateUser] CHECK CONSTRAINT [FK_BidCorporateUser_User_CreatedBy]
GO
ALTER TABLE [dbo].[BidCorporateUser]  WITH CHECK ADD  CONSTRAINT [FK_BidCorporateUser_User_ModifiedBy] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[BidCorporateUser] CHECK CONSTRAINT [FK_BidCorporateUser_User_ModifiedBy]
GO
ALTER TABLE [dbo].[BidCorporateUser]  WITH CHECK ADD  CONSTRAINT [FK_BidCorporateUser_User_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[BidCorporateUser] CHECK CONSTRAINT [FK_BidCorporateUser_User_UserID]
GO
ALTER TABLE [dbo].[BidInformation]  WITH CHECK ADD  CONSTRAINT [FK_BidInformation_AddressInformation] FOREIGN KEY([AddressInformationID])
REFERENCES [dbo].[AddressInformation] ([ID])
GO
ALTER TABLE [dbo].[BidInformation] CHECK CONSTRAINT [FK_BidInformation_AddressInformation]
GO
ALTER TABLE [dbo].[BidInformation]  WITH CHECK ADD  CONSTRAINT [FK_BidInformation_User_ApprovedBy] FOREIGN KEY([ApprovedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[BidInformation] CHECK CONSTRAINT [FK_BidInformation_User_ApprovedBy]
GO
ALTER TABLE [dbo].[BidInformation]  WITH CHECK ADD  CONSTRAINT [FK_BidInformation_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[BidInformation] CHECK CONSTRAINT [FK_BidInformation_User_CreatedBy]
GO
ALTER TABLE [dbo].[BidInformation]  WITH CHECK ADD  CONSTRAINT [FK_BidInformation_User_FinishedBy] FOREIGN KEY([FinishedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[BidInformation] CHECK CONSTRAINT [FK_BidInformation_User_FinishedBy]
GO
ALTER TABLE [dbo].[BidInformation]  WITH CHECK ADD  CONSTRAINT [FK_BidInformation_User_ModifiedBy] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[BidInformation] CHECK CONSTRAINT [FK_BidInformation_User_ModifiedBy]
GO
ALTER TABLE [dbo].[BidInformation]  WITH CHECK ADD  CONSTRAINT [FK_BidInformation_User_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[BidInformation] CHECK CONSTRAINT [FK_BidInformation_User_UserID]
GO
ALTER TABLE [dbo].[BidOfferDetail]  WITH CHECK ADD  CONSTRAINT [FK_BidOfferDetail_BidCar_BidCarID] FOREIGN KEY([BidCarID])
REFERENCES [dbo].[BidCar] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BidOfferDetail] CHECK CONSTRAINT [FK_BidOfferDetail_BidCar_BidCarID]
GO
ALTER TABLE [dbo].[BidOfferDetail]  WITH CHECK ADD  CONSTRAINT [FK_BidOfferDetail_BidUserOffer_BidUserOfferID] FOREIGN KEY([BidUserOfferID])
REFERENCES [dbo].[BidUserOffer] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BidOfferDetail] CHECK CONSTRAINT [FK_BidOfferDetail_BidUserOffer_BidUserOfferID]
GO
ALTER TABLE [dbo].[BidStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_BidStatusHistory_BidInformation_BidID] FOREIGN KEY([BidID])
REFERENCES [dbo].[BidInformation] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BidStatusHistory] CHECK CONSTRAINT [FK_BidStatusHistory_BidInformation_BidID]
GO
ALTER TABLE [dbo].[BidStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_BidStatusHistory_Status_StatuID] FOREIGN KEY([StatuID])
REFERENCES [dbo].[Status] ([ID])
GO
ALTER TABLE [dbo].[BidStatusHistory] CHECK CONSTRAINT [FK_BidStatusHistory_Status_StatuID]
GO
ALTER TABLE [dbo].[BidStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_BidStatusHistory_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[BidStatusHistory] CHECK CONSTRAINT [FK_BidStatusHistory_User_CreatedBy]
GO
ALTER TABLE [dbo].[BidStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_BidStatusHistory_User_ModifiedBy] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[BidStatusHistory] CHECK CONSTRAINT [FK_BidStatusHistory_User_ModifiedBy]
GO
ALTER TABLE [dbo].[BidUserOffer]  WITH CHECK ADD  CONSTRAINT [FK_BidUserOffer_BidCorporateUser_BidCorporateUserID] FOREIGN KEY([BidCorporateUserID])
REFERENCES [dbo].[BidCorporateUser] ([ID])
GO
ALTER TABLE [dbo].[BidUserOffer] CHECK CONSTRAINT [FK_BidUserOffer_BidCorporateUser_BidCorporateUserID]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_BrandModel] FOREIGN KEY([ModelID])
REFERENCES [dbo].[BrandModel] ([ID])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_BrandModel]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_User_CreatedBy]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_User_ModifiedBy] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_User_ModifiedBy]
GO
ALTER TABLE [dbo].[CarBuyerInformation]  WITH CHECK ADD  CONSTRAINT [FK_CarBuyerInformation_Car_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([ID])
GO
ALTER TABLE [dbo].[CarBuyerInformation] CHECK CONSTRAINT [FK_CarBuyerInformation_Car_CarID]
GO
ALTER TABLE [dbo].[CarBuyerInformation]  WITH CHECK ADD  CONSTRAINT [FK_CarBuyerInformation_User_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[CarBuyerInformation] CHECK CONSTRAINT [FK_CarBuyerInformation_User_UserID]
GO
ALTER TABLE [dbo].[CarDetailValue]  WITH CHECK ADD  CONSTRAINT [FK_CarDetailValue_CarDetail_CarDetailID] FOREIGN KEY([CarDetailID])
REFERENCES [dbo].[CarDetail] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarDetailValue] CHECK CONSTRAINT [FK_CarDetailValue_CarDetail_CarDetailID]
GO
ALTER TABLE [dbo].[CarImage]  WITH CHECK ADD  CONSTRAINT [FK_CarImage_Car_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarImage] CHECK CONSTRAINT [FK_CarImage_Car_CarID]
GO
ALTER TABLE [dbo].[CarModification]  WITH CHECK ADD  CONSTRAINT [FK_CarModification_Car_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarModification] CHECK CONSTRAINT [FK_CarModification_Car_CarID]
GO
ALTER TABLE [dbo].[CarModification]  WITH CHECK ADD  CONSTRAINT [FK_CarModification_Modification_ModificationID] FOREIGN KEY([ModificationID])
REFERENCES [dbo].[Modification] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarModification] CHECK CONSTRAINT [FK_CarModification_Modification_ModificationID]
GO
ALTER TABLE [dbo].[CarSaleHistory]  WITH CHECK ADD  CONSTRAINT [FK_CarSaleHistory_Car] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([ID])
GO
ALTER TABLE [dbo].[CarSaleHistory] CHECK CONSTRAINT [FK_CarSaleHistory_Car]
GO
ALTER TABLE [dbo].[CarSaleHistory]  WITH CHECK ADD  CONSTRAINT [FK_CarSaleHistory_CarSaleHistory] FOREIGN KEY([ID])
REFERENCES [dbo].[CarSaleHistory] ([ID])
GO
ALTER TABLE [dbo].[CarSaleHistory] CHECK CONSTRAINT [FK_CarSaleHistory_CarSaleHistory]
GO
ALTER TABLE [dbo].[CarSaleHistory]  WITH CHECK ADD  CONSTRAINT [FK_CarSaleHistory_User] FOREIGN KEY([SellerID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[CarSaleHistory] CHECK CONSTRAINT [FK_CarSaleHistory_User]
GO
ALTER TABLE [dbo].[CarSaleHistory]  WITH CHECK ADD  CONSTRAINT [FK_CarSaleHistory_User1] FOREIGN KEY([BuyerID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[CarSaleHistory] CHECK CONSTRAINT [FK_CarSaleHistory_User1]
GO
ALTER TABLE [dbo].[CarSaleHistory]  WITH CHECK ADD  CONSTRAINT [FK_CarSaleHistory_User2] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[CarSaleHistory] CHECK CONSTRAINT [FK_CarSaleHistory_User2]
GO
ALTER TABLE [dbo].[CarSaleHistory]  WITH CHECK ADD  CONSTRAINT [FK_CarSaleHistory_User3] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[CarSaleHistory] CHECK CONSTRAINT [FK_CarSaleHistory_User3]
GO
ALTER TABLE [dbo].[CarStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_CarStatusHistory_Car_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarStatusHistory] CHECK CONSTRAINT [FK_CarStatusHistory_Car_CarID]
GO
ALTER TABLE [dbo].[CarStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_CarStatusHistory_Status_CarStatuID] FOREIGN KEY([CarStatuID])
REFERENCES [dbo].[Status] ([ID])
GO
ALTER TABLE [dbo].[CarStatusHistory] CHECK CONSTRAINT [FK_CarStatusHistory_Status_CarStatuID]
GO
ALTER TABLE [dbo].[CarStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_CarStatusHistory_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[CarStatusHistory] CHECK CONSTRAINT [FK_CarStatusHistory_User_CreatedBy]
GO
ALTER TABLE [dbo].[CarStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_CarStatusHistory_User_ModifiedBy] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[CarStatusHistory] CHECK CONSTRAINT [FK_CarStatusHistory_User_ModifiedBy]
GO
ALTER TABLE [dbo].[CarValue]  WITH CHECK ADD  CONSTRAINT [FK_CarValue_Car_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([ID])
GO
ALTER TABLE [dbo].[CarValue] CHECK CONSTRAINT [FK_CarValue_Car_CarID]
GO
ALTER TABLE [dbo].[CarValue]  WITH CHECK ADD  CONSTRAINT [FK_CarValue_CarDetailValue_CarValueID] FOREIGN KEY([CarValueID])
REFERENCES [dbo].[CarDetailValue] ([ID])
GO
ALTER TABLE [dbo].[CarValue] CHECK CONSTRAINT [FK_CarValue_CarDetailValue_CarValueID]
GO
ALTER TABLE [dbo].[ComissionInformation]  WITH CHECK ADD  CONSTRAINT [FK_ComissionInformation_CarComission] FOREIGN KEY([CarComissionID])
REFERENCES [dbo].[CarComission] ([ID])
GO
ALTER TABLE [dbo].[ComissionInformation] CHECK CONSTRAINT [FK_ComissionInformation_CarComission]
GO
ALTER TABLE [dbo].[ComissionInformation]  WITH CHECK ADD  CONSTRAINT [FK_ComissionInformation_Comission] FOREIGN KEY([ComissionID])
REFERENCES [dbo].[Comission] ([ID])
GO
ALTER TABLE [dbo].[ComissionInformation] CHECK CONSTRAINT [FK_ComissionInformation_Comission]
GO
ALTER TABLE [dbo].[ComissionInformation]  WITH CHECK ADD  CONSTRAINT [FK_ComissionInformation_NoterComission] FOREIGN KEY([NoterComissionID])
REFERENCES [dbo].[NoterComission] ([ID])
GO
ALTER TABLE [dbo].[ComissionInformation] CHECK CONSTRAINT [FK_ComissionInformation_NoterComission]
GO
ALTER TABLE [dbo].[CorparateBid]  WITH CHECK ADD  CONSTRAINT [FK_CorparateBid_BidInformation] FOREIGN KEY([BidID])
REFERENCES [dbo].[BidInformation] ([ID])
GO
ALTER TABLE [dbo].[CorparateBid] CHECK CONSTRAINT [FK_CorparateBid_BidInformation]
GO
ALTER TABLE [dbo].[CorparateBid]  WITH CHECK ADD  CONSTRAINT [FK_CorparateBid_Corporate] FOREIGN KEY([CorparateID])
REFERENCES [dbo].[Corporate] ([ID])
GO
ALTER TABLE [dbo].[CorparateBid] CHECK CONSTRAINT [FK_CorparateBid_Corporate]
GO
ALTER TABLE [dbo].[CorparateBid]  WITH CHECK ADD  CONSTRAINT [FK_CorparateBid_User] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[CorparateBid] CHECK CONSTRAINT [FK_CorparateBid_User]
GO
ALTER TABLE [dbo].[Corporate]  WITH CHECK ADD  CONSTRAINT [FK_Corporate_AddressInformation_AddressInformationID] FOREIGN KEY([AddressInformationID])
REFERENCES [dbo].[AddressInformation] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Corporate] CHECK CONSTRAINT [FK_Corporate_AddressInformation_AddressInformationID]
GO
ALTER TABLE [dbo].[Corporate]  WITH CHECK ADD  CONSTRAINT [FK_Corporate_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Corporate] CHECK CONSTRAINT [FK_Corporate_User_CreatedBy]
GO
ALTER TABLE [dbo].[CorporateStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_CorporateStatusHistory_Corporate_CorporateID] FOREIGN KEY([CorporateID])
REFERENCES [dbo].[Corporate] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CorporateStatusHistory] CHECK CONSTRAINT [FK_CorporateStatusHistory_Corporate_CorporateID]
GO
ALTER TABLE [dbo].[CorporateStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_CorporateStatusHistory_Status_StatuID] FOREIGN KEY([StatuID])
REFERENCES [dbo].[Status] ([ID])
GO
ALTER TABLE [dbo].[CorporateStatusHistory] CHECK CONSTRAINT [FK_CorporateStatusHistory_Status_StatuID]
GO
ALTER TABLE [dbo].[CorporateStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_CorporateStatusHistory_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[CorporateStatusHistory] CHECK CONSTRAINT [FK_CorporateStatusHistory_User_CreatedBy]
GO
ALTER TABLE [dbo].[CorporateStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_CorporateStatusHistory_User_ModifiedBy] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[CorporateStatusHistory] CHECK CONSTRAINT [FK_CorporateStatusHistory_User_ModifiedBy]
GO
ALTER TABLE [dbo].[CorporateUser]  WITH CHECK ADD  CONSTRAINT [FK_CorporateUser_Corporate_CorporateID] FOREIGN KEY([CorporateID])
REFERENCES [dbo].[Corporate] ([ID])
GO
ALTER TABLE [dbo].[CorporateUser] CHECK CONSTRAINT [FK_CorporateUser_Corporate_CorporateID]
GO
ALTER TABLE [dbo].[CorporateUser]  WITH CHECK ADD  CONSTRAINT [FK_CorporateUser_CorporateRole_CorporateRoleID] FOREIGN KEY([CorporateRoleID])
REFERENCES [dbo].[CorporateRole] ([ID])
GO
ALTER TABLE [dbo].[CorporateUser] CHECK CONSTRAINT [FK_CorporateUser_CorporateRole_CorporateRoleID]
GO
ALTER TABLE [dbo].[CorporateUser]  WITH CHECK ADD  CONSTRAINT [FK_CorporateUser_User_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[CorporateUser] CHECK CONSTRAINT [FK_CorporateUser_User_UserID]
GO
ALTER TABLE [dbo].[District]  WITH CHECK ADD  CONSTRAINT [FK_District_Town_TownID] FOREIGN KEY([TownID])
REFERENCES [dbo].[Town] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[District] CHECK CONSTRAINT [FK_District_Town_TownID]
GO
ALTER TABLE [dbo].[Expertise]  WITH CHECK ADD  CONSTRAINT [FK_Expertise_AddressInformation_AddressInformationID] FOREIGN KEY([AddressInformationID])
REFERENCES [dbo].[AddressInformation] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Expertise] CHECK CONSTRAINT [FK_Expertise_AddressInformation_AddressInformationID]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_MessageContent_MessageContentID] FOREIGN KEY([MessageContentID])
REFERENCES [dbo].[MessageContent] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_MessageContent_MessageContentID]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_User_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_User_UserID]
GO
ALTER TABLE [dbo].[Neighborhood]  WITH CHECK ADD  CONSTRAINT [FK_Neighborhood_District_DistrictID] FOREIGN KEY([DistrictID])
REFERENCES [dbo].[District] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Neighborhood] CHECK CONSTRAINT [FK_Neighborhood_District_DistrictID]
GO
ALTER TABLE [dbo].[PackageCorporate]  WITH CHECK ADD  CONSTRAINT [FK_PackageCorporate_Corporate_CorporateID] FOREIGN KEY([CorporateID])
REFERENCES [dbo].[Corporate] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PackageCorporate] CHECK CONSTRAINT [FK_PackageCorporate_Corporate_CorporateID]
GO
ALTER TABLE [dbo].[PackageCorporate]  WITH CHECK ADD  CONSTRAINT [FK_PackageCorporate_Package_PackageID] FOREIGN KEY([PackageID])
REFERENCES [dbo].[Package] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PackageCorporate] CHECK CONSTRAINT [FK_PackageCorporate_Package_PackageID]
GO
ALTER TABLE [dbo].[RoleAutherization]  WITH CHECK ADD  CONSTRAINT [FK_RoleAutherization_Authorazition_AuthorizationID] FOREIGN KEY([AuthorizationID])
REFERENCES [dbo].[Authorazition] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RoleAutherization] CHECK CONSTRAINT [FK_RoleAutherization_Authorazition_AuthorizationID]
GO
ALTER TABLE [dbo].[RoleAutherization]  WITH CHECK ADD  CONSTRAINT [FK_RoleAutherization_PageAuthorization_PageAuthorizationID] FOREIGN KEY([PageAuthorizationID])
REFERENCES [dbo].[PageAuthorization] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RoleAutherization] CHECK CONSTRAINT [FK_RoleAutherization_PageAuthorization_PageAuthorizationID]
GO
ALTER TABLE [dbo].[RoleAutherization]  WITH CHECK ADD  CONSTRAINT [FK_RoleAutherization_Role_RoleID] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RoleAutherization] CHECK CONSTRAINT [FK_RoleAutherization_Role_RoleID]
GO
ALTER TABLE [dbo].[Town]  WITH CHECK ADD  CONSTRAINT [FK_Town_City_CityID] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Town] CHECK CONSTRAINT [FK_Town_City_CityID]
GO
ALTER TABLE [dbo].[TramerComponent]  WITH CHECK ADD  CONSTRAINT [FK_TramerComponent_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TramerComponent] CHECK CONSTRAINT [FK_TramerComponent_User_CreatedBy]
GO
ALTER TABLE [dbo].[TramerInformation]  WITH CHECK ADD  CONSTRAINT [FK_TramerInformation_Car_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TramerInformation] CHECK CONSTRAINT [FK_TramerInformation_Car_CarID]
GO
ALTER TABLE [dbo].[TramerInformation]  WITH CHECK ADD  CONSTRAINT [FK_TramerInformation_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[TramerInformation] CHECK CONSTRAINT [FK_TramerInformation_User_CreatedBy]
GO
ALTER TABLE [dbo].[TramerInformation]  WITH CHECK ADD  CONSTRAINT [FK_TramerInformation_User_ModifiedBy] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[TramerInformation] CHECK CONSTRAINT [FK_TramerInformation_User_ModifiedBy]
GO
ALTER TABLE [dbo].[TramerInformationComponent]  WITH CHECK ADD  CONSTRAINT [FK_TramerInformationComponent_TramerComponent_TramerComponentID] FOREIGN KEY([TramerComponentID])
REFERENCES [dbo].[TramerComponent] ([ID])
GO
ALTER TABLE [dbo].[TramerInformationComponent] CHECK CONSTRAINT [FK_TramerInformationComponent_TramerComponent_TramerComponentID]
GO
ALTER TABLE [dbo].[TramerInformationComponent]  WITH CHECK ADD  CONSTRAINT [FK_TramerInformationComponent_TramerInformation_TramerInformationID] FOREIGN KEY([TramerInformationID])
REFERENCES [dbo].[TramerInformation] ([ID])
GO
ALTER TABLE [dbo].[TramerInformationComponent] CHECK CONSTRAINT [FK_TramerInformationComponent_TramerInformation_TramerInformationID]
GO
ALTER TABLE [dbo].[TramerStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_TramerStatusHistory_Status_StatuID] FOREIGN KEY([StatuID])
REFERENCES [dbo].[Status] ([ID])
GO
ALTER TABLE [dbo].[TramerStatusHistory] CHECK CONSTRAINT [FK_TramerStatusHistory_Status_StatuID]
GO
ALTER TABLE [dbo].[TramerStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_TramerStatusHistory_TramerInformationComponent_TramerInformationComponentTramerInformationID_TramerInformationComponentTrame~] FOREIGN KEY([TramerInformationComponentTramerInformationID], [TramerInformationComponentTramerComponentID])
REFERENCES [dbo].[TramerInformationComponent] ([TramerInformationID], [TramerComponentID])
GO
ALTER TABLE [dbo].[TramerStatusHistory] CHECK CONSTRAINT [FK_TramerStatusHistory_TramerInformationComponent_TramerInformationComponentTramerInformationID_TramerInformationComponentTrame~]
GO
ALTER TABLE [dbo].[TramerStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_TramerStatusHistory_User_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[TramerStatusHistory] CHECK CONSTRAINT [FK_TramerStatusHistory_User_CreatedBy]
GO
ALTER TABLE [dbo].[TramerStatusHistory]  WITH CHECK ADD  CONSTRAINT [FK_TramerStatusHistory_User_ModifiedBy] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[TramerStatusHistory] CHECK CONSTRAINT [FK_TramerStatusHistory_User_ModifiedBy]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role_RoleID] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role_RoleID]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_User_ApprovedBy] FOREIGN KEY([ApprovedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_User_ApprovedBy]
GO
ALTER TABLE [dbo].[UserAutoBidOffer]  WITH CHECK ADD  CONSTRAINT [FK_UserAutoBidOffer_BidInformation] FOREIGN KEY([BidId])
REFERENCES [dbo].[BidInformation] ([ID])
GO
ALTER TABLE [dbo].[UserAutoBidOffer] CHECK CONSTRAINT [FK_UserAutoBidOffer_BidInformation]
GO
ALTER TABLE [dbo].[UserAutoBidOffer]  WITH CHECK ADD  CONSTRAINT [FK_UserAutoBidOffer_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[UserAutoBidOffer] CHECK CONSTRAINT [FK_UserAutoBidOffer_User]
GO
ALTER TABLE [dbo].[UserAutoBidOffer]  WITH CHECK ADD  CONSTRAINT [FK_UserAutoBidOffer_User1] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[UserAutoBidOffer] CHECK CONSTRAINT [FK_UserAutoBidOffer_User1]
GO
ALTER TABLE [dbo].[UserAutoBidOffer]  WITH CHECK ADD  CONSTRAINT [FK_UserAutoBidOffer_User2] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[UserAutoBidOffer] CHECK CONSTRAINT [FK_UserAutoBidOffer_User2]
GO
ALTER TABLE [dbo].[UserCar]  WITH CHECK ADD  CONSTRAINT [FK_UserCar_Car_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([ID])
GO
ALTER TABLE [dbo].[UserCar] CHECK CONSTRAINT [FK_UserCar_Car_CarID]
GO
ALTER TABLE [dbo].[UserCar]  WITH CHECK ADD  CONSTRAINT [FK_UserCar_User_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[UserCar] CHECK CONSTRAINT [FK_UserCar_User_UserID]
GO
ALTER TABLE [dbo].[UserFavoriteCar]  WITH CHECK ADD  CONSTRAINT [FK_UserFavoriteCar_Car_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([ID])
GO
ALTER TABLE [dbo].[UserFavoriteCar] CHECK CONSTRAINT [FK_UserFavoriteCar_Car_CarID]
GO
ALTER TABLE [dbo].[UserFavoriteCar]  WITH CHECK ADD  CONSTRAINT [FK_UserFavoriteCar_User_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[UserFavoriteCar] CHECK CONSTRAINT [FK_UserFavoriteCar_User_UserID]
GO
/****** Object:  StoredProcedure [dbo].[CreateBidCar]    Script Date: 04/10/2022 18:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CreateBidCar] (
@bidid uniqueidentifier,
@carid uniqueidentifier, 
@createdby uniqueidentifier,
@startprice decimal(18, 2),
@minimumprice decimal(18, 2)
)
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRANSACTION
		BEGIN TRY
			declare @id uniqueidentifier

			SET @id = NEWID()

			

			INSERT INTO [dbo].[BidCar](ID,BidID,CarID,StartPrice,MinimumPrice,CreatedDate,CreatedBy,IsActive)
				VALUES (@id,@bidid,@carid,@startprice,@minimumprice,GETDATE(),@createdby,1)

			

			COMMIT TRANSACTION
		END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[CreateBidInformation]    Script Date: 04/10/2022 18:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CreateBidInformation] (
@bidname nvarchar(max),
@iscorparate bit, 
@createdby uniqueidentifier
)
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRANSACTION
		BEGIN TRY
			declare @id uniqueidentifier


			SET @id = NEWID()

			

			INSERT INTO [dbo].[BidInformation](ID,BidName,IsCorporate,IsApproved,CreatedDate,CreatedBy,IsActive)
				VALUES (@id,@bidname,@iscorparate,0,GETDATE(),@createdby,1)

			COMMIT TRANSACTION
		END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Delete-BidCorporateUser]    Script Date: 04/10/2022 18:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Delete-BidCorporateUser] (
@ID uniqueidentifier,
@BidCorporateUserID uniqueidentifier,
@Price DECIMAL(18,2),
@CreatedDate DateTime,
@UserID uniqueidentifier,
@CorporateID uniqueidentifier,
@BidID uniqueidentifier,
@UserName nvarchar(max)
)
as
begin
	SET NOCOUNT ON;
	begin transaction 	
		declare @sub uniqueidentifier
		set @sub = (select ID from [BidUserOffer] where @BidCorporateUserID = @BidCorporateUserID and @Price = @Price and CreatedDate = @CreatedDate and IsActive=1)
			if (@sub = null)
				begin
					rollback transaction 
				end
			else
				begin
					update BidUserOffer set IsActive=0
				end
	commit transaction 
end
GO
/****** Object:  StoredProcedure [dbo].[Insert-BidCorporateUser]    Script Date: 04/10/2022 18:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert-BidCorporateUser] (
@BidCorporateUserID uniqueidentifier,
@Price DECIMAL(18,2),
@CreatedDate DateTime,
@UserID uniqueidentifier,
@CorporateID uniqueidentifier,
@BidID uniqueidentifier,
@UserName nvarchar(max)
)
as
begin
	SET NOCOUNT ON;
	begin transaction 	
		declare @sub uniqueidentifier
		set @sub = (select ID from [BidUserOffer] where @BidCorporateUserID = @BidCorporateUserID and @Price = @Price and CreatedDate = @CreatedDate and IsActive=1)
			if (@sub = null)
				begin
					rollback transaction 
				end
			else
				begin
					declare @sub1 uniqueidentifier,@sub2 uniqueidentifier
					set @sub1 = (select ID from BidCorporateUser where UserID = @UserID and CorporateID=@CorporateID and BidID=@BidID and IsActive=1)
					set @sub2 = (select ID from [User] where UserName = @UserName)
					insert into [BidUserOffer](BidCorporateUserID,Price,CreatedDate,CreatedBy) values(@sub1,@Price,GETDATE(),@sub2)
				end
	commit transaction 
end

-----------------------------------------------------------------------------------------------------------------------------
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Insert-BidOfferDetail]    Script Date: 04/10/2022 18:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert-BidOfferDetail] (
@BidCarID uniqueidentifier,
@BidUserOfferID uniqueidentifier,
@Price decimal(18,2)
)
AS
BEGIN
	SET NOCOUNT ON;
    BEGIN TRANSACTION
        BEGIN TRY

            INSERT INTO [dbo].[BidOfferDetail](BidCarID,BidUserOfferID,Price)
                VALUES (@BidCarID,@BidUserOfferID,@Price)
		COMMIT TRANSACTION
		END TRY
    BEGIN CATCH
        ROLLBACK
    END CATCH
END
---------------------------------------------------------------------------------
SET ANSI_NULLS ON
GO
/****** Object:  StoredProcedure [dbo].[Insert-BidStatusHistory]    Script Date: 04/10/2022 18:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert-BidStatusHistory] (
@Information nvarchar(max),
@BidID uniqueidentifier,
@StatuID uniqueidentifier,
@CreatedBy uniqueidentifier
)
AS
BEGIN
	SET NOCOUNT ON;
    BEGIN TRANSACTION
        BEGIN TRY
			Declare @id uniqueidentifier
            
			Set @id = NEWID();

			INSERT INTO [dbo].[BidStatusHistory](ID,Information,BidID,StatuID,CreatedBy)
                VALUES (@id,@Information,@BidID,@StatuID,@CreatedBy)

				
		COMMIT TRANSACTION
		END TRY
    BEGIN CATCH
        ROLLBACK
    END CATCH
END
---------------------------------------------------
SET ANSI_NULLS ON
GO
/****** Object:  StoredProcedure [dbo].[SelectBidCars]    Script Date: 04/10/2022 18:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectBidCars]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT bidcar.ID,bid.BidName,car.Brand + car.Model AS [Car Name],bidcar.StartPrice,bidcar.MinimumPrice,us.FirstAndLastName [Creator FullName],
				bidcar.CreatedDate
			FROM BidCar as bidcar
			INNER JOIN [Car] AS car ON bidcar.CarID = car.ID
			INNER JOIN [BidInformation] AS bid ON bidcar.BidID = bid.ID
			INNER JOIN [User] AS us ON bidcar.CreatedBy = us.ID
END
GO
/****** Object:  StoredProcedure [dbo].[SelectBidInformation]    Script Date: 04/10/2022 18:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectBidInformation]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT bid.ID,bid.BidName,bid.IsCorporate,us.FirstAndLastName AS [Creator Name],bid.CreatedDate,bid.FinishedDate,finishedby.FirstAndLastName FROM BidInformation AS bid
			INNER JOIN [User] AS us
				ON bid.UserID = us.ID
				INNER JOIN [User] AS finishedby
				ON bid.FinishedBy = FinishedBy.ID
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateBidCar]    Script Date: 04/10/2022 18:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateBidCar] (
@bidcarid uniqueidentifier,
@bidid uniqueidentifier, 
@carid uniqueidentifier, 
@startprice decimal(18,2),
@minimumprice decimal(18,2),
@modifiedby uniqueidentifier,
@isactive bit
)
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRANSACTION
		BEGIN TRY
			

			UPDATE BidCar SET BidID = @bidid, CarID = @carid, StartPrice = @startprice , MinimumPrice  = @minimumprice, ModifiedBy = @modifiedby,
				ModifiedDate = GETDATE(), IsActive = @isactive
				WHERE ID = @bidcarid

			COMMIT TRANSACTION
		END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Update-BidCorporateUser]    Script Date: 04/10/2022 18:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Update-BidCorporateUser] (
@ID uniqueidentifier,
@BidCorporateUserID uniqueidentifier,
@Price DECIMAL(18,2),
@CreatedDate DateTime,
@UserID uniqueidentifier,
@CorporateID uniqueidentifier,
@BidID uniqueidentifier,
@UserName nvarchar(max)
)
as
begin
	SET NOCOUNT ON;

	begin transaction 	
		declare @sub uniqueidentifier
		set @sub = (select ID from [BidUserOffer] where @BidCorporateUserID = @BidCorporateUserID and @Price = @Price and CreatedDate = @CreatedDate and IsActive=1)
			if (@sub = null)
				begin
					rollback transaction 
				end
			else
				begin
					declare @sub1 uniqueidentifier
					set @sub1 = (select ID from BidCorporateUser where UserID = @UserID and CorporateID=@CorporateID and BidID=@BidID and IsActive=1)
					update BidUserOffer set BidCorporateUserID = @sub1, Price=@Price where ID=@ID
				end
	commit transaction 
end
--------------------------------------------------------------------------------------
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[UpdateBidInformation]    Script Date: 04/10/2022 18:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateBidInformation] (
@bidinformationId uniqueidentifier, 
@bidname nvarchar(max),
@iscorparate bit, 
@isapproved bit, 
@isactive bit,
@userid uniqueidentifier = NULL,
@approvedby uniqueidentifier = NULL,
@modified uniqueidentifier,
@finishedby uniqueidentifier = NULL,
@finisheddate datetime = NULL
)
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRANSACTION
		BEGIN TRY


		 --User bilgisi null gelirse veritabaninda var olan kaydi atariz
		IF @userid = NULL 
		BEGIN 
			SELECT @userid =  UserID FROM BidInformation WHERE ID = @bidinformationId
		END

		--Onaylayan bilgisi null gelirse veritabaninda var olan kaydi atariz
		IF @approvedby = NULL
		BEGIN
			SELECT @approvedby =  ApprovedBy FROM BidInformation WHERE ID = @bidinformationId
		END

		--Ihale bitirme tarihi veya ihaleyi bitiren kisi null gelirse veritabaninda var olan kaydi atariz
		IF  @finisheddate = NULL OR @finishedby = NULL
		BEGIN
			SELECT @finisheddate =  FinishedDate, @finishedby = FinishedBy FROM BidInformation WHERE ID = @bidinformationId
		END


			UPDATE BidInformation SET BidName = @bidname, IsCorporate = @iscorparate,IsApproved = @isapproved,ApprovedBy =@approvedby ,ModifiedBy = @modified, ModifiedDate = GETDATE(),FinishedBy = @finishedby,FinishedDate = @finisheddate, IsActive = @isactive
				WHERE ID = @bidinformationId

			COMMIT TRANSACTION
		END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Update-BidOfferDetail]    Script Date: 04/10/2022 18:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Update-BidOfferDetail] (
@BidCarID uniqueidentifier,
@BidUserOfferID uniqueidentifier,
@Price decimal(18,2)
)
AS
BEGIN
	SET NOCOUNT ON;

    BEGIN TRANSACTION
        BEGIN TRY

            Update [dbo].[BidOfferDetail] set Price = @Price , IsActive = 1  where BidCarID = @BidCarID and BidUserOfferID = @BidUserOfferID

		COMMIT TRANSACTION
		END TRY
    BEGIN CATCH
        ROLLBACK
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Update-BidStatusHistory]    Script Date: 04/10/2022 18:12:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Update-BidStatusHistory] (
@BidID uniqueidentifier,
@StatuID uniqueidentifier,
@Information nvarchar(max),
@ModifiedBy uniqueidentifier

)
AS
BEGIN
	SET NOCOUNT ON;

    BEGIN TRANSACTION
        BEGIN TRY

            Update [dbo].[BidStatusHistory] set Information = @Information , ModifiedBy = @ModifiedBy ,ModifiedDate = GETDATE() where BidID = @BidID and StatuID = @StatuID

		COMMIT TRANSACTION
		END TRY
    BEGIN CATCH
        ROLLBACK
    END CATCH
END
GO
USE [master]
GO
ALTER DATABASE [CarTenderDB] SET  READ_WRITE 
GO
