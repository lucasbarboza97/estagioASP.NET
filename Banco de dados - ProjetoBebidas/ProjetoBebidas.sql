
USE [ProjetoBebidas]
GO
/****** Object:  Table [dbo].[compra_bebida]    Script Date: 05/07/2021 14:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compra_bebida](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[data_compra] [date] NULL,
	[valor] [decimal](9, 2) NULL,
	[id_produto_comprado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[estoque_bebida]    Script Date: 05/07/2021 14:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estoque_bebida](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [char](3) NULL,
	[nome] [varchar](25) NULL,
	[preco] [decimal](9, 2) NULL,
	[qtd] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[produto_comprado]    Script Date: 05/07/2021 14:13:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produto_comprado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[qtd_comprada] [int] NULL,
	[id_estoque_bebida] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[estoque_bebida] ON 

INSERT [dbo].[estoque_bebida] ([id], [codigo], [nome], [preco], [qtd]) VALUES (2, N'101', N'Coca Cola', CAST(7.99 AS Decimal(9, 2)), 159)
INSERT [dbo].[estoque_bebida] ([id], [codigo], [nome], [preco], [qtd]) VALUES (3, N'102', N'Sprite', CAST(7.00 AS Decimal(9, 2)), 50)
INSERT [dbo].[estoque_bebida] ([id], [codigo], [nome], [preco], [qtd]) VALUES (4, N'103', N'Fanta', CAST(6.00 AS Decimal(9, 2)), 0)
INSERT [dbo].[estoque_bebida] ([id], [codigo], [nome], [preco], [qtd]) VALUES (5, N'104', N'Brahma', CAST(8.00 AS Decimal(9, 2)), 10)
INSERT [dbo].[estoque_bebida] ([id], [codigo], [nome], [preco], [qtd]) VALUES (6, N'105', N'Kuat', CAST(5.00 AS Decimal(9, 2)), 25)
INSERT [dbo].[estoque_bebida] ([id], [codigo], [nome], [preco], [qtd]) VALUES (7, N'106', N'Heineken', CAST(11.00 AS Decimal(9, 2)), 7)
SET IDENTITY_INSERT [dbo].[estoque_bebida] OFF
ALTER TABLE [dbo].[compra_bebida] ADD  DEFAULT ((0.0)) FOR [valor]
GO
ALTER TABLE [dbo].[estoque_bebida] ADD  DEFAULT ((0.0)) FOR [preco]
GO
ALTER TABLE [dbo].[estoque_bebida] ADD  DEFAULT ((0)) FOR [qtd]
GO
ALTER TABLE [dbo].[compra_bebida]  WITH CHECK ADD FOREIGN KEY([id_produto_comprado])
REFERENCES [dbo].[produto_comprado] ([id])
GO
ALTER TABLE [dbo].[produto_comprado]  WITH CHECK ADD FOREIGN KEY([id_estoque_bebida])
REFERENCES [dbo].[estoque_bebida] ([id])
GO
SELECT COUNT(id) FROM estoque_bebida