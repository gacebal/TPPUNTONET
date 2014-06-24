USE [basetp]
GO

/****** Object:  Table [dbo].[Proyecto]    Script Date: 24/06/2014 0:13:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Proyecto](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[GerenteId] [smallint] NOT NULL,
 CONSTRAINT [PK_ProyectoSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Proyecto]  WITH CHECK ADD  CONSTRAINT [FK_GerenteProyecto] FOREIGN KEY([GerenteId])
REFERENCES [dbo].[Gerente] ([Id])
GO

ALTER TABLE [dbo].[Proyecto] CHECK CONSTRAINT [FK_GerenteProyecto]
GO

