USE [master]
GO
/****** Object:  Database [TP4_JorgeGarcia]    Script Date: 29/11/2021 03:02:49 ******/
CREATE DATABASE [TP4_JorgeGarcia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP4_JorgeGarcia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TP4_JorgeGarcia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP4_JorgeGarcia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TP4_JorgeGarcia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4_JorgeGarcia] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4_JorgeGarcia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4_JorgeGarcia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET  MULTI_USER 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4_JorgeGarcia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4_JorgeGarcia] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TP4_JorgeGarcia] SET QUERY_STORE = OFF
GO
USE [TP4_JorgeGarcia]
GO
/****** Object:  Table [dbo].[vehiculos]    Script Date: 29/11/2021 03:02:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vehiculos](
	[dni] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[sexo] [int] NOT NULL,
	[edad] [int] NOT NULL,
	[sumaAsegurada] [float] NOT NULL,
	[anio] [int] NOT NULL,
	[tipo] [int] NOT NULL,
 CONSTRAINT [PK_vehiculos] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vida]    Script Date: 29/11/2021 03:02:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vida](
	[dni] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[sexo] [int] NOT NULL,
	[edad] [int] NOT NULL,
	[sumaAsegurada] [float] NOT NULL,
	[fumador] [bit] NOT NULL,
 CONSTRAINT [PK_VIDA] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (706437, N'Rogers', N'Brock', 1, 28, 1000000, 2018, 3)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (1225109, N'Chrissy', N'Crasswell', 2, 41, 1000000, 2016, 2)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (1421638, N'Ermengarde', N'Solon', 1, 63, 1000000, 2013, 3)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (1564040, N'Guenna', N'McMurdo', 2, 53, 1000000, 2000, 2)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (1886192, N'Elias', N'Cammish', 2, 36, 1000000, 2004, 1)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (3016539, N'Michaela', N'Slocket', 2, 55, 1000000, 2005, 1)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (4659539, N'Jasen', N'Bonifant', 1, 68, 1000000, 2006, 2)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (5105921, N'Kellby', N'Lisle', 2, 30, 1000000, 2021, 1)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (5825786, N'Bess', N'McGibbon', 1, 39, 1000000, 2004, 1)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (5860867, N'Arlette', N'Authers', 2, 18, 1000000, 2016, 1)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (6094661, N'Birgit', N'Plaunch', 1, 40, 1000000, 2005, 2)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (6160362, N'Laurie', N'Le Count', 1, 22, 1000000, 2007, 1)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (7187873, N'Huntington', N'Stockton', 2, 19, 1000000, 2011, 3)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (7317832, N'Othelia', N'Phelipeau', 2, 60, 1000000, 2015, 2)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (7377382, N'Kendall', N'McMurtyr', 1, 54, 1000000, 2008, 2)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (7741138, N'Carlita', N'Calbreath', 2, 45, 1000000, 2019, 3)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (8515788, N'John', N'Burry', 1, 72, 1000000, 2019, 2)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (9776026, N'Ellynn', N'Curragh', 1, 20, 1000000, 2011, 2)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (9826648, N'Erasmus', N'Carthy', 1, 53, 1000000, 2011, 3)
INSERT [dbo].[vehiculos] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [anio], [tipo]) VALUES (9999793, N'Donovan', N'Tyhurst', 2, 78, 1000000, 2014, 1)
GO
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (1921891, N'Ginnie', N'Meneer', 1, 28, 1000000, 0)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (3163768, N'Lynn', N'Derrick', 1, 34, 1000000, 0)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (3566851, N'Mattie', N'Cornfoot', 2, 29, 1000000, 0)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (4343082, N'Egon', N'Mattei', 1, 28, 1000000, 1)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (4632812, N'Donelle', N'Fooks', 2, 59, 1000000, 1)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (4716883, N'Melli', N'Snellman', 1, 20, 1000000, 1)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (4940190, N'Aluin', N'Sisland', 1, 36, 1000000, 0)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (5221206, N'Tadeas', N'Davinet', 1, 23, 1000000, 0)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (6058627, N'Carol', N'Van Schafflaer', 2, 35, 1000000, 1)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (6417120, N'Baird', N'Blankenship', 2, 24, 1000000, 0)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (6535275, N'Gerald', N'Martlew', 2, 78, 1000000, 1)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (6568443, N'Concordia', N'Wards', 2, 29, 1000000, 0)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (6695172, N'Luisa', N'Diben', 2, 25, 1000000, 1)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (6724741, N'Saba', N'March', 2, 47, 1000000, 1)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (7194426, N'Dorree', N'Sarfat', 1, 42, 1000000, 1)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (8017328, N'Maurice', N'McTurlough', 2, 50, 1000000, 0)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (8102736, N'Vasily', N'Keener', 1, 67, 1000000, 0)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (8610242, N'Todd', N'Klimowski', 1, 55, 1000000, 1)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (9571836, N'Zaccaria', N'Capron', 2, 58, 1000000, 0)
INSERT [dbo].[vida] ([dni], [nombre], [apellido], [sexo], [edad], [sumaAsegurada], [fumador]) VALUES (9612458, N'Hilario', N'Gawkes', 1, 65, 1000000, 1)
GO
USE [master]
GO
ALTER DATABASE [TP4_JorgeGarcia] SET  READ_WRITE 
GO
