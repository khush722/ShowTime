USE [master]
GO
/****** Object:  Database [ShowTime]    Script Date: 2/10/2020 11:11:52 am ******/
CREATE DATABASE [ShowTime]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShowTime_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ShowTime.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ShowTime_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ShowTime.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ShowTime] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShowTime].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShowTime] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShowTime] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShowTime] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShowTime] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShowTime] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShowTime] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShowTime] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShowTime] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShowTime] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShowTime] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShowTime] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShowTime] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShowTime] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShowTime] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShowTime] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShowTime] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShowTime] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShowTime] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShowTime] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShowTime] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShowTime] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShowTime] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShowTime] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShowTime] SET  MULTI_USER 
GO
ALTER DATABASE [ShowTime] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShowTime] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShowTime] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShowTime] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ShowTime] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ShowTime', N'ON'
GO
ALTER DATABASE [ShowTime] SET QUERY_STORE = OFF
GO
USE [ShowTime]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2/10/2020 11:11:52 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](255) NULL,
	[LastName] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [nvarchar](255) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 2/10/2020 11:11:52 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [nvarchar](50) NULL,
	[Title] [nvarchar](255) NULL,
	[Year] [nvarchar](255) NULL,
	[Rental_Cost] [money] NULL,
	[Copies] [nvarchar](50) NULL,
	[Plot] [ntext] NULL,
	[Genre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 2/10/2020 11:11:52 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovies](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MovieIDFK] [int] NULL,
	[CustIDFK] [int] NULL,
	[DateRented] [datetime] NULL,
	[DateReturned] [datetime] NULL,
	[Rented] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 2/10/2020 11:11:52 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_name] [varchar](15) NULL,
	[password] [varchar](15) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (1, N'Jimmy', N'Carry', N'America', N'786868')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1, N'7', N'Spiderman 2', N'2011', 2.0000, N'10', N'An adventureious movie', N'adventure')
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[RentedMovies] ON 

INSERT [dbo].[RentedMovies] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned], [Rented]) VALUES (1, 1, 1, CAST(N'2020-08-13T12:23:15.240' AS DateTime), CAST(N'2020-08-13T12:23:34.683' AS DateTime), 0)
INSERT [dbo].[RentedMovies] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned], [Rented]) VALUES (2, 1, 1, CAST(N'2020-08-13T12:24:37.327' AS DateTime), CAST(N'2020-08-13T12:24:41.307' AS DateTime), 0)
INSERT [dbo].[RentedMovies] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned], [Rented]) VALUES (3, 1, 1, CAST(N'2020-08-13T12:27:53.980' AS DateTime), CAST(N'2020-08-13T12:27:59.100' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[RentedMovies] OFF
GO
INSERT [dbo].[users] ([user_name], [password]) VALUES (N'jim', N'1234')
GO
ALTER TABLE [dbo].[RentedMovies]  WITH CHECK ADD  CONSTRAINT [FK1] FOREIGN KEY([MovieIDFK])
REFERENCES [dbo].[Movies] ([MovieID])
GO
ALTER TABLE [dbo].[RentedMovies] CHECK CONSTRAINT [FK1]
GO
ALTER TABLE [dbo].[RentedMovies]  WITH CHECK ADD  CONSTRAINT [FK2] FOREIGN KEY([CustIDFK])
REFERENCES [dbo].[Customer] ([CustID])
GO
ALTER TABLE [dbo].[RentedMovies] CHECK CONSTRAINT [FK2]
GO
USE [master]
GO
ALTER DATABASE [ShowTime] SET  READ_WRITE 
GO
