CREATE [ProjetoBebidas]
GO
USE [ProjetoBebidas]
GO
/****** Object:  Database [ProjetoBebidas]    Script Date: 06/07/2021 18:07:11 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'ProjetoBebidas')
BEGIN
CREATE DATABASE [ProjetoBebidas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjetoBebidas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProjetoBebidas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProjetoBebidas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProjetoBebidas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
END
GO
ALTER DATABASE [ProjetoBebidas] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjetoBebidas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjetoBebidas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjetoBebidas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjetoBebidas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProjetoBebidas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjetoBebidas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET RECOVERY FULL 
GO
ALTER DATABASE [ProjetoBebidas] SET  MULTI_USER 
GO
ALTER DATABASE [ProjetoBebidas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjetoBebidas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjetoBebidas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjetoBebidas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProjetoBebidas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProjetoBebidas] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProjetoBebidas', N'ON'
GO
ALTER DATABASE [ProjetoBebidas] SET QUERY_STORE = OFF
GO
USE [ProjetoBebidas]
GO
/****** Object:  Table [dbo].[compra_bebida]    Script Date: 06/07/2021 18:07:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[compra_bebida]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[compra_bebida](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[valor] [decimal](9, 2) NULL,
	[qtd_compra] [int] NULL,
	[data_compra] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[estoque_bebida]    Script Date: 06/07/2021 18:07:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[estoque_bebida]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[estoque_bebida](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [char](3) NULL,
	[nome] [varchar](25) NULL,
	[preco] [decimal](9, 2) NULL,
	[qtd] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[produto_comprado]    Script Date: 06/07/2021 18:07:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[produto_comprado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[produto_comprado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[qtd_comprada] [int] NULL,
	[id_estoque_bebida] [int] NULL,
	[compra_bebida_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[compra_bebida] ON 

INSERT [dbo].[compra_bebida] ([id], [valor], [qtd_compra], [data_compra]) VALUES (1, CAST(79.90 AS Decimal(9, 2)), 26, NULL)
INSERT [dbo].[compra_bebida] ([id], [valor], [qtd_compra], [data_compra]) VALUES (2, CAST(77.00 AS Decimal(9, 2)), 7, NULL)
INSERT [dbo].[compra_bebida] ([id], [valor], [qtd_compra], [data_compra]) VALUES (3, CAST(145.00 AS Decimal(9, 2)), 145, NULL)
INSERT [dbo].[compra_bebida] ([id], [valor], [qtd_compra], [data_compra]) VALUES (4, CAST(30.00 AS Decimal(9, 2)), 30, CAST(N'2021-07-06T17:19:25.000' AS DateTime))
INSERT [dbo].[compra_bebida] ([id], [valor], [qtd_compra], [data_compra]) VALUES (5, CAST(20.00 AS Decimal(9, 2)), 20, CAST(N'2021-07-06T17:33:57.000' AS DateTime))
INSERT [dbo].[compra_bebida] ([id], [valor], [qtd_compra], [data_compra]) VALUES (6, CAST(19.00 AS Decimal(9, 2)), 19, CAST(N'2021-07-06T17:45:43.000' AS DateTime))
INSERT [dbo].[compra_bebida] ([id], [valor], [qtd_compra], [data_compra]) VALUES (7, CAST(20.00 AS Decimal(9, 2)), 20, CAST(N'2021-07-06T17:48:32.000' AS DateTime))
INSERT [dbo].[compra_bebida] ([id], [valor], [qtd_compra], [data_compra]) VALUES (8, CAST(15.00 AS Decimal(9, 2)), 15, CAST(N'2021-07-06T18:02:45.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[compra_bebida] OFF
GO
SET IDENTITY_INSERT [dbo].[estoque_bebida] ON 

INSERT [dbo].[estoque_bebida] ([id], [codigo], [nome], [preco], [qtd]) VALUES (2, N'101', N'Coca Cola', CAST(7.99 AS Decimal(9, 2)), 130)
INSERT [dbo].[estoque_bebida] ([id], [codigo], [nome], [preco], [qtd]) VALUES (3, N'102', N'Sprite', CAST(7.00 AS Decimal(9, 2)), 50)
INSERT [dbo].[estoque_bebida] ([id], [codigo], [nome], [preco], [qtd]) VALUES (4, N'103', N'Fanta', CAST(6.00 AS Decimal(9, 2)), 0)
INSERT [dbo].[estoque_bebida] ([id], [codigo], [nome], [preco], [qtd]) VALUES (5, N'104', N'Brahma', CAST(8.00 AS Decimal(9, 2)), 10)
INSERT [dbo].[estoque_bebida] ([id], [codigo], [nome], [preco], [qtd]) VALUES (6, N'105', N'Kuat', CAST(5.00 AS Decimal(9, 2)), 20)
INSERT [dbo].[estoque_bebida] ([id], [codigo], [nome], [preco], [qtd]) VALUES (7, N'106', N'Heineken', CAST(11.00 AS Decimal(9, 2)), 7)
SET IDENTITY_INSERT [dbo].[estoque_bebida] OFF
GO
SET IDENTITY_INSERT [dbo].[produto_comprado] ON 

INSERT [dbo].[produto_comprado] ([id], [qtd_comprada], [id_estoque_bebida], [compra_bebida_id]) VALUES (3, 60, 2, 3)
INSERT [dbo].[produto_comprado] ([id], [qtd_comprada], [id_estoque_bebida], [compra_bebida_id]) VALUES (4, 25, 6, 3)
INSERT [dbo].[produto_comprado] ([id], [qtd_comprada], [id_estoque_bebida], [compra_bebida_id]) VALUES (5, 10, 2, 4)
INSERT [dbo].[produto_comprado] ([id], [qtd_comprada], [id_estoque_bebida], [compra_bebida_id]) VALUES (6, 10, 5, 4)
INSERT [dbo].[produto_comprado] ([id], [qtd_comprada], [id_estoque_bebida], [compra_bebida_id]) VALUES (7, 10, 6, 5)
INSERT [dbo].[produto_comprado] ([id], [qtd_comprada], [id_estoque_bebida], [compra_bebida_id]) VALUES (8, 10, 6, 5)
INSERT [dbo].[produto_comprado] ([id], [qtd_comprada], [id_estoque_bebida], [compra_bebida_id]) VALUES (9, 19, 2, 6)
INSERT [dbo].[produto_comprado] ([id], [qtd_comprada], [id_estoque_bebida], [compra_bebida_id]) VALUES (10, 10, 2, 7)
INSERT [dbo].[produto_comprado] ([id], [qtd_comprada], [id_estoque_bebida], [compra_bebida_id]) VALUES (11, 10, 2, 7)
INSERT [dbo].[produto_comprado] ([id], [qtd_comprada], [id_estoque_bebida], [compra_bebida_id]) VALUES (12, 10, 2, 8)
INSERT [dbo].[produto_comprado] ([id], [qtd_comprada], [id_estoque_bebida], [compra_bebida_id]) VALUES (13, 5, 6, 8)
SET IDENTITY_INSERT [dbo].[produto_comprado] OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__compra_be__valor__286302EC]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[compra_bebida] ADD  DEFAULT ((0.0)) FOR [valor]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__estoque_b__preco__29572725]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[estoque_bebida] ADD  DEFAULT ((0.0)) FOR [preco]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF__estoque_beb__qtd__2A4B4B5E]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[estoque_bebida] ADD  DEFAULT ((0)) FOR [qtd]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__produto_c__compr__36B12243]') AND parent_object_id = OBJECT_ID(N'[dbo].[produto_comprado]'))
ALTER TABLE [dbo].[produto_comprado]  WITH CHECK ADD FOREIGN KEY([compra_bebida_id])
REFERENCES [dbo].[compra_bebida] ([id])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__produto_c__id_es__2C3393D0]') AND parent_object_id = OBJECT_ID(N'[dbo].[produto_comprado]'))
ALTER TABLE [dbo].[produto_comprado]  WITH CHECK ADD FOREIGN KEY([id_estoque_bebida])
REFERENCES [dbo].[estoque_bebida] ([id])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__produto_c__id_es__30F848ED]') AND parent_object_id = OBJECT_ID(N'[dbo].[produto_comprado]'))
ALTER TABLE [dbo].[produto_comprado]  WITH CHECK ADD FOREIGN KEY([id_estoque_bebida])
REFERENCES [dbo].[estoque_bebida] ([id])
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__produto_c__id_es__35BCFE0A]') AND parent_object_id = OBJECT_ID(N'[dbo].[produto_comprado]'))
ALTER TABLE [dbo].[produto_comprado]  WITH CHECK ADD FOREIGN KEY([id_estoque_bebida])
REFERENCES [dbo].[estoque_bebida] ([id])
GO
USE [master]
GO
ALTER DATABASE [ProjetoBebidas] SET  READ_WRITE 
GO
