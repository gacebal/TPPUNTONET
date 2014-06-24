USE [basetp]
GO

/****** Object:  Table [dbo].[Categoria]    Script Date: 24/06/2014 0:13:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Categoria](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Valor] [smallint] NOT NULL,
	[FactorId] [smallint] NOT NULL,
 CONSTRAINT [PK_CategoriaSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Categoria]  WITH CHECK ADD  CONSTRAINT [FK_FactorCategoria] FOREIGN KEY([FactorId])
REFERENCES [dbo].[Factor] ([Id])
GO

ALTER TABLE [dbo].[Categoria] CHECK CONSTRAINT [FK_FactorCategoria]
GO

