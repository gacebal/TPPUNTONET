
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/11/2014 19:16:33
-- Generated from EDMX file: c:\users\negro\documents\visual studio 2013\Projects\trabajopuntonet\modelo\ModeloTP.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [basetp];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ProyectoFactor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FactorSet] DROP CONSTRAINT [FK_ProyectoFactor];
GO
IF OBJECT_ID(N'[dbo].[FK_FactorCategoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CategoriaSet] DROP CONSTRAINT [FK_FactorCategoria];
GO
IF OBJECT_ID(N'[dbo].[FK_GerenteProyecto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProyectoSet] DROP CONSTRAINT [FK_GerenteProyecto];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[GerenteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GerenteSet];
GO
IF OBJECT_ID(N'[dbo].[FactorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FactorSet];
GO
IF OBJECT_ID(N'[dbo].[CategoriaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategoriaSet];
GO
IF OBJECT_ID(N'[dbo].[ProyectoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProyectoSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'GerenteSet'
CREATE TABLE [dbo].[GerenteSet] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [dni] smallint  NOT NULL
);
GO

-- Creating table 'FactorSet'
CREATE TABLE [dbo].[FactorSet] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Ponderacion] smallint  NOT NULL,
    [ProyectoId] smallint  NOT NULL
);
GO

-- Creating table 'CategoriaSet'
CREATE TABLE [dbo].[CategoriaSet] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Valor] smallint  NOT NULL,
    [FactorId] smallint  NOT NULL
);
GO

-- Creating table 'ProyectoSet'
CREATE TABLE [dbo].[ProyectoSet] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [idGerente] smallint  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [GerenteId] smallint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'GerenteSet'
ALTER TABLE [dbo].[GerenteSet]
ADD CONSTRAINT [PK_GerenteSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FactorSet'
ALTER TABLE [dbo].[FactorSet]
ADD CONSTRAINT [PK_FactorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CategoriaSet'
ALTER TABLE [dbo].[CategoriaSet]
ADD CONSTRAINT [PK_CategoriaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProyectoSet'
ALTER TABLE [dbo].[ProyectoSet]
ADD CONSTRAINT [PK_ProyectoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProyectoId] in table 'FactorSet'
ALTER TABLE [dbo].[FactorSet]
ADD CONSTRAINT [FK_ProyectoFactor]
    FOREIGN KEY ([ProyectoId])
    REFERENCES [dbo].[ProyectoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProyectoFactor'
CREATE INDEX [IX_FK_ProyectoFactor]
ON [dbo].[FactorSet]
    ([ProyectoId]);
GO

-- Creating foreign key on [FactorId] in table 'CategoriaSet'
ALTER TABLE [dbo].[CategoriaSet]
ADD CONSTRAINT [FK_FactorCategoria]
    FOREIGN KEY ([FactorId])
    REFERENCES [dbo].[FactorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FactorCategoria'
CREATE INDEX [IX_FK_FactorCategoria]
ON [dbo].[CategoriaSet]
    ([FactorId]);
GO

-- Creating foreign key on [GerenteId] in table 'ProyectoSet'
ALTER TABLE [dbo].[ProyectoSet]
ADD CONSTRAINT [FK_GerenteProyecto]
    FOREIGN KEY ([GerenteId])
    REFERENCES [dbo].[GerenteSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_GerenteProyecto'
CREATE INDEX [IX_FK_GerenteProyecto]
ON [dbo].[ProyectoSet]
    ([GerenteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------