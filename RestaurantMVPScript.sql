USE [master]
GO
/****** Object:  Database [RestaurantMVP]    Script Date: 30/05/2020 11:26:06 ******/
CREATE DATABASE [RestaurantMVP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RestaurantMVP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RestaurantMVP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RestaurantMVP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RestaurantMVP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RestaurantMVP] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RestaurantMVP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RestaurantMVP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RestaurantMVP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RestaurantMVP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RestaurantMVP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RestaurantMVP] SET ARITHABORT OFF 
GO
ALTER DATABASE [RestaurantMVP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RestaurantMVP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RestaurantMVP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RestaurantMVP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RestaurantMVP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RestaurantMVP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RestaurantMVP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RestaurantMVP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RestaurantMVP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RestaurantMVP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RestaurantMVP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RestaurantMVP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RestaurantMVP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RestaurantMVP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RestaurantMVP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RestaurantMVP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RestaurantMVP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RestaurantMVP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RestaurantMVP] SET  MULTI_USER 
GO
ALTER DATABASE [RestaurantMVP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RestaurantMVP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RestaurantMVP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RestaurantMVP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RestaurantMVP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RestaurantMVP] SET QUERY_STORE = OFF
GO
USE [RestaurantMVP]
GO
/****** Object:  Table [dbo].[Alergeni]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alergeni](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Alergeni] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorie]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorie](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nume] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Categorie] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comanda]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comanda](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fk_utilizator] [int] NOT NULL,
	[stare] [varchar](100) NOT NULL,
	[timp_inregistrare] [datetime] NOT NULL,
	[discount] [float] NOT NULL,
	[cost_transport] [float] NOT NULL,
	[pret_total] [float] NOT NULL,
	[ora_estimativa_livrare] [datetime] NOT NULL,
 CONSTRAINT [PK_Comanda] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComandaMeniu]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComandaMeniu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fk_comanda] [int] NOT NULL,
	[fk_meniu] [int] NOT NULL,
	[cantitate] [int] NOT NULL,
 CONSTRAINT [PK_ComandaMeniu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComandaPreparat]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComandaPreparat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fk_comanda] [int] NOT NULL,
	[fk_preparat] [int] NOT NULL,
	[cantitate] [int] NOT NULL,
 CONSTRAINT [PK_ComandaPreparat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Meniu]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meniu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nume] [varchar](500) NOT NULL,
	[fk_categorie] [int] NOT NULL,
 CONSTRAINT [PK_Meniu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MeniuPreparat]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeniuPreparat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fk_meniu] [int] NOT NULL,
	[fk_preparat] [int] NOT NULL,
	[cantitate] [int] NOT NULL,
 CONSTRAINT [PK_MeniuPreparat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Preparat]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preparat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nume] [varchar](500) NOT NULL,
	[pret] [float] NOT NULL,
	[unitate_masura] [varchar](5) NOT NULL,
	[cantitate_per_portie] [float] NOT NULL,
	[cantitate_totala] [float] NOT NULL,
	[fk_categorie] [int] NOT NULL,
 CONSTRAINT [PK_Preparat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PreparatAlergeni]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreparatAlergeni](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fk_preparat] [int] NOT NULL,
	[fk_alergeni] [int] NOT NULL,
 CONSTRAINT [PK_PreparatAlergeni] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilizator]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilizator](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[prenume] [varchar](500) NOT NULL,
	[nume] [varchar](500) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[parola] [varchar](500) NOT NULL,
	[telefon] [varchar](15) NOT NULL,
	[adresa] [varchar](100) NOT NULL,
	[angajat] [bit] NOT NULL,
 CONSTRAINT [PK_Utilizator] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Utilizator]    Script Date: 30/05/2020 11:26:07 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Utilizator] ON [dbo].[Utilizator]
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Utilizator] ADD  CONSTRAINT [DF_Utilizator_angajat]  DEFAULT ((0)) FOR [angajat]
GO
ALTER TABLE [dbo].[Comanda]  WITH CHECK ADD  CONSTRAINT [FK_Comanda_Utilizator] FOREIGN KEY([fk_utilizator])
REFERENCES [dbo].[Utilizator] ([id])
GO
ALTER TABLE [dbo].[Comanda] CHECK CONSTRAINT [FK_Comanda_Utilizator]
GO
ALTER TABLE [dbo].[ComandaMeniu]  WITH CHECK ADD  CONSTRAINT [FK_ComandaMeniu_Comanda] FOREIGN KEY([fk_comanda])
REFERENCES [dbo].[Comanda] ([id])
GO
ALTER TABLE [dbo].[ComandaMeniu] CHECK CONSTRAINT [FK_ComandaMeniu_Comanda]
GO
ALTER TABLE [dbo].[ComandaMeniu]  WITH CHECK ADD  CONSTRAINT [FK_ComandaMeniu_Meniu1] FOREIGN KEY([fk_meniu])
REFERENCES [dbo].[Meniu] ([id])
GO
ALTER TABLE [dbo].[ComandaMeniu] CHECK CONSTRAINT [FK_ComandaMeniu_Meniu1]
GO
ALTER TABLE [dbo].[ComandaPreparat]  WITH CHECK ADD  CONSTRAINT [FK_ComandaPreparat_Comanda] FOREIGN KEY([fk_comanda])
REFERENCES [dbo].[Comanda] ([id])
GO
ALTER TABLE [dbo].[ComandaPreparat] CHECK CONSTRAINT [FK_ComandaPreparat_Comanda]
GO
ALTER TABLE [dbo].[ComandaPreparat]  WITH CHECK ADD  CONSTRAINT [FK_ComandaPreparat_Preparat] FOREIGN KEY([fk_preparat])
REFERENCES [dbo].[Preparat] ([id])
GO
ALTER TABLE [dbo].[ComandaPreparat] CHECK CONSTRAINT [FK_ComandaPreparat_Preparat]
GO
ALTER TABLE [dbo].[Meniu]  WITH CHECK ADD  CONSTRAINT [FK_Meniu_Categorie] FOREIGN KEY([fk_categorie])
REFERENCES [dbo].[Categorie] ([id])
GO
ALTER TABLE [dbo].[Meniu] CHECK CONSTRAINT [FK_Meniu_Categorie]
GO
ALTER TABLE [dbo].[MeniuPreparat]  WITH CHECK ADD  CONSTRAINT [FK_MeniuPreparat_Meniu] FOREIGN KEY([fk_meniu])
REFERENCES [dbo].[Meniu] ([id])
GO
ALTER TABLE [dbo].[MeniuPreparat] CHECK CONSTRAINT [FK_MeniuPreparat_Meniu]
GO
ALTER TABLE [dbo].[MeniuPreparat]  WITH CHECK ADD  CONSTRAINT [FK_MeniuPreparat_Preparat] FOREIGN KEY([fk_preparat])
REFERENCES [dbo].[Preparat] ([id])
GO
ALTER TABLE [dbo].[MeniuPreparat] CHECK CONSTRAINT [FK_MeniuPreparat_Preparat]
GO
ALTER TABLE [dbo].[Preparat]  WITH CHECK ADD  CONSTRAINT [FK_Preparat_Categorie] FOREIGN KEY([fk_categorie])
REFERENCES [dbo].[Categorie] ([id])
GO
ALTER TABLE [dbo].[Preparat] CHECK CONSTRAINT [FK_Preparat_Categorie]
GO
ALTER TABLE [dbo].[PreparatAlergeni]  WITH CHECK ADD  CONSTRAINT [FK_PreparatAlergeni_Alergeni] FOREIGN KEY([fk_alergeni])
REFERENCES [dbo].[Alergeni] ([id])
GO
ALTER TABLE [dbo].[PreparatAlergeni] CHECK CONSTRAINT [FK_PreparatAlergeni_Alergeni]
GO
ALTER TABLE [dbo].[PreparatAlergeni]  WITH CHECK ADD  CONSTRAINT [FK_PreparatAlergeni_Preparat] FOREIGN KEY([fk_preparat])
REFERENCES [dbo].[Preparat] ([id])
GO
ALTER TABLE [dbo].[PreparatAlergeni] CHECK CONSTRAINT [FK_PreparatAlergeni_Preparat]
GO
/****** Object:  StoredProcedure [dbo].[spAutentificareUtilizator]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAutentificareUtilizator]
	@Email VARCHAR(100),
	@Parola VARCHAR(500)
AS
BEGIN
	DECLARE @sqlcmd NVARCHAR(MAX);
	DECLARE @params NVARCHAR(MAX);
	SET @sqlcmd = N'
	SELECT * FROM dbo.Utilizator
	WHERE email = @Email AND parola = @Parola';
	SET @params = N'
	@Email VARCHAR(100),
	@Parola VARCHAR(500)';
	EXECUTE sp_executesql @sqlcmd, @params, @Email, @Parola;
END
GO
/****** Object:  StoredProcedure [dbo].[spInregistrareUtilizator]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInregistrareUtilizator]
	@Prenume VARCHAR(500),
	@Nume VARCHAR(500),
	@Email VARCHAR(100),
	@Parola VARCHAR(500),
	@Telefon VARCHAR(15),
	@Adresa VARCHAR(100)
AS
BEGIN
	DECLARE @sqlcmd NVARCHAR(MAX);
	DECLARE @params NVARCHAR(MAX);
	SET @sqlcmd = N'
	INSERT INTO dbo.Utilizator(prenume, nume, email, parola, telefon, adresa)
	VALUES (@Prenume, @Nume, @Email, @Parola, @Telefon, @Adresa)';
	SET @params = N'
	@Prenume VARCHAR(500),
	@Nume VARCHAR(500),
	@Email VARCHAR(100),
	@Parola VARCHAR(500),
	@Telefon VARCHAR(15),
	@Adresa VARCHAR(100)';
	EXECUTE sp_executesql @sqlcmd, @params, @Prenume, @Nume, @Email, @Parola, @Telefon, @Adresa;
END
GO
/****** Object:  StoredProcedure [dbo].[spReturneazaCostTotalMeniu]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReturneazaCostTotalMeniu]
	@IDMeniu INT
AS
BEGIN
	DECLARE @sqlcmd NVARCHAR(MAX);
	DECLARE @params NVARCHAR(MAX);
	SET @sqlcmd = N'
	SELECT SUM(p.pret)
	FROM dbo.Meniu as m
	INNER JOIN dbo.MeniuPreparat mp ON mp.fk_meniu = m.id
	INNER JOIN dbo.Preparat p on mp.fk_preparat = p.id
	WHERE m.id = @IDMeniu';
	SET @params = N'
	@IDMeniu INT';
	EXECUTE sp_executesql @sqlcmd, @params, @IDMeniu;
END
GO
/****** Object:  StoredProcedure [dbo].[spReturneazaPreparateleMeniului]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReturneazaPreparateleMeniului]
	@IDMeniu INT
AS
BEGIN
	DECLARE @sqlcmd NVARCHAR(MAX);
	DECLARE @params NVARCHAR(MAX);
	SET @sqlcmd = N'
	SELECT p.id, mp.cantitate, p.unitate_masura, p.pret, p.cantitate_totala
	FROM dbo.Meniu as m
	INNER JOIN dbo.MeniuPreparat mp ON mp.fk_meniu = m.id
	INNER JOIN dbo.Preparat p on mp.fk_preparat = p.id
	WHERE m.id = @IDMeniu';
	SET @params = N'
	@IDMeniu INT';
	EXECUTE sp_executesql @sqlcmd, @params, @IDMeniu;
END
GO
/****** Object:  StoredProcedure [dbo].[spReturneazaStocMaximMeniu]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReturneazaStocMaximMeniu]
	@IDMeniu INT
AS
BEGIN
	DECLARE @sqlcmd NVARCHAR(MAX);
	DECLARE @params NVARCHAR(MAX);
	SET @sqlcmd = N'
	SELECT MIN(p.cantitate_totala / p.cantitate_per_portie) as stoc_maxim
	FROM dbo.Meniu as m
	INNER JOIN dbo.MeniuPreparat as mp ON mp.fk_meniu = m.id
	INNER JOIN dbo.Preparat as p ON mp.fk_preparat = p.id
	WHERE m.id = @IDMeniu
	';
	SET @params = N'
	@IDMeniu INT
	';
	EXECUTE sp_executesql @sqlcmd, @params, @IDMeniu;
END
GO
/****** Object:  StoredProcedure [dbo].[spReturneazaStocMaximPreparat]    Script Date: 30/05/2020 11:26:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spReturneazaStocMaximPreparat]
	@IDPreparat INT
AS
BEGIN
	DECLARE @sqlcmd NVARCHAR(MAX);
	DECLARE @params NVARCHAR(MAX);
	SET @sqlcmd = N'
	SELECT p.cantitate_totala / p.cantitate_per_portie as stoc_maxim
	FROM dbo.Preparat as p
	WHERE p.id = @IDPreparat
	';
	SET @params = N'
	@IDPreparat INT
	';
	EXECUTE sp_executesql @sqlcmd, @params, @IDPreparat;
END
GO
USE [master]
GO
ALTER DATABASE [RestaurantMVP] SET  READ_WRITE 
GO
