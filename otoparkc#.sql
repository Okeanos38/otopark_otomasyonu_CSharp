USE [master]
GO
/****** Object:  Database [otopark]    Script Date: 25.07.2020 23:00:43 ******/
CREATE DATABASE [otopark]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'otopark', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\otopark.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'otopark_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\otopark_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [otopark] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [otopark].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [otopark] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [otopark] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [otopark] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [otopark] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [otopark] SET ARITHABORT OFF 
GO
ALTER DATABASE [otopark] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [otopark] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [otopark] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [otopark] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [otopark] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [otopark] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [otopark] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [otopark] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [otopark] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [otopark] SET  ENABLE_BROKER 
GO
ALTER DATABASE [otopark] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [otopark] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [otopark] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [otopark] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [otopark] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [otopark] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [otopark] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [otopark] SET RECOVERY FULL 
GO
ALTER DATABASE [otopark] SET  MULTI_USER 
GO
ALTER DATABASE [otopark] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [otopark] SET DB_CHAINING OFF 
GO
ALTER DATABASE [otopark] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [otopark] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [otopark] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'otopark', N'ON'
GO
ALTER DATABASE [otopark] SET QUERY_STORE = OFF
GO
USE [otopark]
GO
/****** Object:  Table [dbo].[arac_durumu]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[arac_durumu](
	[park_yeri] [nvarchar](30) NOT NULL,
	[durumu] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[park_yeri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[arac_sahibi]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[arac_sahibi](
	[tc_kimlik] [nvarchar](11) NOT NULL,
	[ad] [nvarchar](30) NOT NULL,
	[soyad] [nvarchar](30) NOT NULL,
	[cep_telefonu] [nvarchar](12) NOT NULL,
	[plaka_no] [nvarchar](20) NOT NULL,
	[arac_marka] [nvarchar](30) NOT NULL,
	[arac_renk] [nvarchar](20) NOT NULL,
	[park_yeri] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tc_kimlik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[marka_bilgileri]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marka_bilgileri](
	[marka] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_marka_bilgileri] PRIMARY KEY CLUSTERED 
(
	[marka] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[renk_bilgileri]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[renk_bilgileri](
	[renk] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK__arac_bil__E106DD284AA1C5DA] PRIMARY KEY CLUSTERED 
(
	[renk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[arac_durumu] ([park_yeri], [durumu]) VALUES (N'Parkyeri-1', N'DOLU')
INSERT [dbo].[arac_durumu] ([park_yeri], [durumu]) VALUES (N'Parkyeri-10', N'DOLU')
INSERT [dbo].[arac_durumu] ([park_yeri], [durumu]) VALUES (N'Parkyeri-2', N'BOŞ')
INSERT [dbo].[arac_durumu] ([park_yeri], [durumu]) VALUES (N'Parkyeri-3', N'BOŞ')
INSERT [dbo].[arac_durumu] ([park_yeri], [durumu]) VALUES (N'Parkyeri-4', N'BOŞ')
INSERT [dbo].[arac_durumu] ([park_yeri], [durumu]) VALUES (N'Parkyeri-5', N'BOŞ')
INSERT [dbo].[arac_durumu] ([park_yeri], [durumu]) VALUES (N'Parkyeri-6', N'BOŞ')
INSERT [dbo].[arac_durumu] ([park_yeri], [durumu]) VALUES (N'Parkyeri-7', N'BOŞ')
INSERT [dbo].[arac_durumu] ([park_yeri], [durumu]) VALUES (N'Parkyeri-8', N'BOŞ')
INSERT [dbo].[arac_durumu] ([park_yeri], [durumu]) VALUES (N'Parkyeri-9', N'BOŞ')
GO
INSERT [dbo].[arac_sahibi] ([tc_kimlik], [ad], [soyad], [cep_telefonu], [plaka_no], [arac_marka], [arac_renk], [park_yeri]) VALUES (N'1', N'Volkan', N'Korkmaz', N'1', N'10 KC 338', N'Bentley', N'Pembe', N'Parkyeri-1')
INSERT [dbo].[arac_sahibi] ([tc_kimlik], [ad], [soyad], [cep_telefonu], [plaka_no], [arac_marka], [arac_renk], [park_yeri]) VALUES (N'17548834961', N'Meral', N'Korkmaz', N'05536481697', N'10KC138', N'Tofaş', N'mavi', N'Parkyeri-10')
GO
INSERT [dbo].[marka_bilgileri] ([marka]) VALUES (N'aa')
INSERT [dbo].[marka_bilgileri] ([marka]) VALUES (N'Alfa Romeo')
INSERT [dbo].[marka_bilgileri] ([marka]) VALUES (N'aSA')
INSERT [dbo].[marka_bilgileri] ([marka]) VALUES (N'Aston Martin')
INSERT [dbo].[marka_bilgileri] ([marka]) VALUES (N'Audi')
INSERT [dbo].[marka_bilgileri] ([marka]) VALUES (N'Bentley')
INSERT [dbo].[marka_bilgileri] ([marka]) VALUES (N'Bugatti')
INSERT [dbo].[marka_bilgileri] ([marka]) VALUES (N'Buick')
INSERT [dbo].[marka_bilgileri] ([marka]) VALUES (N'BWM')
INSERT [dbo].[marka_bilgileri] ([marka]) VALUES (N'Cadillac')
GO
INSERT [dbo].[renk_bilgileri] ([renk]) VALUES (N'Kırmızı')
INSERT [dbo].[renk_bilgileri] ([renk]) VALUES (N'Pembe')
INSERT [dbo].[renk_bilgileri] ([renk]) VALUES (N'Sarı')
GO
/****** Object:  StoredProcedure [dbo].[arac_durumu_göster]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[arac_durumu_göster]
as
select * from arac_durumu
GO
/****** Object:  StoredProcedure [dbo].[arac_sahibi_göster]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[arac_sahibi_göster]
as
Select * from arac_sahibi
GO
/****** Object:  StoredProcedure [dbo].[arac_sahibi_güncelle]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[arac_sahibi_güncelle](
@tc_kimlik nvarchar(11),
@ad nvarchar(30),
@soyad nvarchar(30),
@cep_telefonu nvarchar(12),
@plaka_no nvarchar(20),
@arac_marka nVARCHAR(30),
@arac_renk nVARCHAR(20) 
)
AS 
BEGIN
UPDATE arac_sahibi SET ad=@ad, soyad=@soyad,cep_telefonu=@cep_telefonu,plaka_no=@plaka_no,arac_marka=@arac_marka,arac_renk=@arac_renk WHERE tc_kimlik=@tc_kimlik
END
GO
/****** Object:  StoredProcedure [dbo].[arac_sahibi_kayit]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[arac_sahibi_kayit]
(
@tc_kimlik nvarchar(11),
@ad nvarchar(30),
@soyad nvarchar(30),
@cep_telefonu nvarchar(12),
@plaka_no nvarchar(20),
@arac_marka nVARCHAR(30),
@arac_renk nVARCHAR(20),
@park_yeri nVARCHAR(20)
)
AS
IF EXISTS(SELECT * FROM dbo.arac_sahibi WHERE  tc_kimlik=@tc_kimlik)
BEGIN
PRINT 'Sistemde id numarası mevcuttur!'
END
ELSE
BEGIN
INSERT INTO arac_sahibi(tc_kimlik,ad,soyad,cep_telefonu,plaka_no,arac_marka,arac_renk,park_yeri) VALUES (@tc_kimlik,@ad,@soyad,
@cep_telefonu,@plaka_no,@arac_marka,@arac_renk,@park_yeri)
END
GO
/****** Object:  StoredProcedure [dbo].[arac_sahibi_parkyeri_secimi]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[arac_sahibi_parkyeri_secimi](
@park_yeri nVARCHAR(20)
)
AS
BEGIN
SELECT * FROM arac_sahibi WHERE park_yeri=@park_yeri
END
GO
/****** Object:  StoredProcedure [dbo].[arac_sahibi_plaka_secimi]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[arac_sahibi_plaka_secimi](
@plaka_no nVARCHAR(20)
)
AS
BEGIN
SELECT * FROM arac_sahibi WHERE plaka_no=@plaka_no
END
GO
/****** Object:  StoredProcedure [dbo].[arac_sahibi_sil]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[arac_sahibi_sil](
@tc_kimlik nVarchar(11)
)
AS
BEGIN
DELETE from arac_sahibi where tc_kimlik = @tc_kimlik
END

GO
/****** Object:  StoredProcedure [dbo].[aracdurumu_aracsahibi_baglantı]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aracdurumu_aracsahibi_baglantı]
as
begin
SELECT        arac_sahibi.tc_kimlik, arac_sahibi.ad, arac_sahibi.soyad, arac_sahibi.cep_telefonu, arac_sahibi.plaka_no, arac_sahibi.park_yeri, arac_durumu.durumu
FROM            arac_sahibi INNER JOIN
                         arac_durumu ON arac_sahibi.park_yeri = arac_durumu.park_yeri
-- inner join işlemi ile 3 tabloyu birbirine bağladık
end
GO
/****** Object:  StoredProcedure [dbo].[aracdurumu_dolu_göster]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[aracdurumu_dolu_göster]
AS
BEGIN
SELECT * FROM arac_durumu WHERE durumu='DOLU'
END
GO
/****** Object:  StoredProcedure [dbo].[aracdurumu_güncelle]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[aracdurumu_güncelle](
@park_yeri nVarchar (30)
)
as
begin
UPDATE arac_durumu set durumu='DOLU' WHERE park_yeri=@park_yeri
end
GO
/****** Object:  StoredProcedure [dbo].[aracdurumubos_güncelle]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[aracdurumubos_güncelle](
@park_yeri nVarchar (30)
)
as
begin
UPDATE arac_durumu set durumu='BOŞ' WHERE park_yeri=@park_yeri
end
GO
/****** Object:  StoredProcedure [dbo].[marka_kayit]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[marka_kayit]
(
@marka nVARCHAR(30)
)
AS
BEGIN
INSERT INTO marka_bilgileri(marka) VALUES (@marka)
END
GO
/****** Object:  StoredProcedure [dbo].[markabilgileri]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[markabilgileri]
AS
BEGIN
SELECT marka from marka_bilgileri
END
GO
/****** Object:  StoredProcedure [dbo].[park_yeri_bos]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[park_yeri_bos]
as
begin
select * from arac_durumu where durumu='BOŞ'
end
GO
/****** Object:  StoredProcedure [dbo].[plaka_sil]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[plaka_sil](
@plaka_no nVARCHAR(20)
)
AS
BEGIN
DELETE FROM arac_sahibi WHERE plaka_no=@plaka_no
END
GO
/****** Object:  StoredProcedure [dbo].[renk_kayit]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[renk_kayit](
@renk nVARCHAR(30)
)
AS
BEGIN
INSERT INTO renk_bilgileri(renk) VALUES (@renk)
END
GO
/****** Object:  StoredProcedure [dbo].[renkbilgileri]    Script Date: 25.07.2020 23:00:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[renkbilgileri]
AS
BEGIN
SELECT * from renk_bilgileri
END
GO
USE [master]
GO
ALTER DATABASE [otopark] SET  READ_WRITE 
GO
