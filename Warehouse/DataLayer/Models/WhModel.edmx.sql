
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2022 18:12:08
-- Generated from EDMX file: D:\Projects\Warehouse\DataLayer\Models\WhModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Warehouse];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Products_Brands]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_Brands];
GO
IF OBJECT_ID(N'[dbo].[FK_Products_QuantityType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_Products_QuantityType];
GO
IF OBJECT_ID(N'[dbo].[FK_Receives_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Receives] DROP CONSTRAINT [FK_Receives_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_Receives_Staffs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Receives] DROP CONSTRAINT [FK_Receives_Staffs];
GO
IF OBJECT_ID(N'[dbo].[FK_Receives_Suppliers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Receives] DROP CONSTRAINT [FK_Receives_Suppliers];
GO
IF OBJECT_ID(N'[dbo].[FK_Ships_Customers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ships] DROP CONSTRAINT [FK_Ships_Customers];
GO
IF OBJECT_ID(N'[dbo].[FK_Ships_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ships] DROP CONSTRAINT [FK_Ships_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_Ships_Staffs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ships] DROP CONSTRAINT [FK_Ships_Staffs];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Brands]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Brands];
GO
IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[QuantityType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QuantityType];
GO
IF OBJECT_ID(N'[dbo].[Receives]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Receives];
GO
IF OBJECT_ID(N'[dbo].[Ships]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ships];
GO
IF OBJECT_ID(N'[dbo].[Staffs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Staffs];
GO
IF OBJECT_ID(N'[dbo].[Suppliers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Suppliers];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Brands'
CREATE TABLE [dbo].[Brands] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(150)  NOT NULL,
    [Description] nvarchar(350)  NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(150)  NOT NULL,
    [Address] nvarchar(250)  NULL,
    [Phone] nvarchar(50)  NOT NULL,
    [Email] nvarchar(100)  NOT NULL,
    [Image] varchar(50)  NULL
);
GO

-- Creating table 'Receives'
CREATE TABLE [dbo].[Receives] (
    [Id] uniqueidentifier  NOT NULL,
    [ProductId] uniqueidentifier  NOT NULL,
    [Quantity] int  NOT NULL,
    [ReceiveTime] datetime  NOT NULL,
    [StaffId] int  NOT NULL,
    [SupplierId] int  NULL
);
GO

-- Creating table 'Ships'
CREATE TABLE [dbo].[Ships] (
    [Id] uniqueidentifier  NOT NULL,
    [ProductId] uniqueidentifier  NOT NULL,
    [Quantity] int  NOT NULL,
    [ShipTime] datetime  NOT NULL,
    [StaffId] int  NOT NULL,
    [CustomerId] int  NOT NULL
);
GO

-- Creating table 'Staffs'
CREATE TABLE [dbo].[Staffs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(150)  NOT NULL,
    [Phone] nvarchar(50)  NOT NULL,
    [Email] nvarchar(100)  NOT NULL,
    [Address] nvarchar(250)  NULL,
    [Image] varchar(50)  NULL
);
GO

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Address] nvarchar(250)  NULL,
    [Phone] nvarchar(50)  NOT NULL,
    [Email] nvarchar(100)  NOT NULL,
    [Image] varchar(50)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'QuantityType'
CREATE TABLE [dbo].[QuantityType] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] varchar(50)  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Stock] int  NOT NULL,
    [QuantityTypeId] int  NOT NULL,
    [BrandId] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Brands'
ALTER TABLE [dbo].[Brands]
ADD CONSTRAINT [PK_Brands]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Receives'
ALTER TABLE [dbo].[Receives]
ADD CONSTRAINT [PK_Receives]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Ships'
ALTER TABLE [dbo].[Ships]
ADD CONSTRAINT [PK_Ships]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Staffs'
ALTER TABLE [dbo].[Staffs]
ADD CONSTRAINT [PK_Staffs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'QuantityType'
ALTER TABLE [dbo].[QuantityType]
ADD CONSTRAINT [PK_QuantityType]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomerId] in table 'Ships'
ALTER TABLE [dbo].[Ships]
ADD CONSTRAINT [FK_Ships_Customers]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ships_Customers'
CREATE INDEX [IX_FK_Ships_Customers]
ON [dbo].[Ships]
    ([CustomerId]);
GO

-- Creating foreign key on [StaffId] in table 'Receives'
ALTER TABLE [dbo].[Receives]
ADD CONSTRAINT [FK_Receives_Staffs]
    FOREIGN KEY ([StaffId])
    REFERENCES [dbo].[Staffs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Receives_Staffs'
CREATE INDEX [IX_FK_Receives_Staffs]
ON [dbo].[Receives]
    ([StaffId]);
GO

-- Creating foreign key on [SupplierId] in table 'Receives'
ALTER TABLE [dbo].[Receives]
ADD CONSTRAINT [FK_Receives_Suppliers]
    FOREIGN KEY ([SupplierId])
    REFERENCES [dbo].[Suppliers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Receives_Suppliers'
CREATE INDEX [IX_FK_Receives_Suppliers]
ON [dbo].[Receives]
    ([SupplierId]);
GO

-- Creating foreign key on [StaffId] in table 'Ships'
ALTER TABLE [dbo].[Ships]
ADD CONSTRAINT [FK_Ships_Staffs]
    FOREIGN KEY ([StaffId])
    REFERENCES [dbo].[Staffs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ships_Staffs'
CREATE INDEX [IX_FK_Ships_Staffs]
ON [dbo].[Ships]
    ([StaffId]);
GO

-- Creating foreign key on [BrandId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Products_Brands]
    FOREIGN KEY ([BrandId])
    REFERENCES [dbo].[Brands]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Products_Brands'
CREATE INDEX [IX_FK_Products_Brands]
ON [dbo].[Products]
    ([BrandId]);
GO

-- Creating foreign key on [QuantityTypeId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_Products_QuantityType]
    FOREIGN KEY ([QuantityTypeId])
    REFERENCES [dbo].[QuantityType]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Products_QuantityType'
CREATE INDEX [IX_FK_Products_QuantityType]
ON [dbo].[Products]
    ([QuantityTypeId]);
GO

-- Creating foreign key on [ProductId] in table 'Receives'
ALTER TABLE [dbo].[Receives]
ADD CONSTRAINT [FK_Receives_Products]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Receives_Products'
CREATE INDEX [IX_FK_Receives_Products]
ON [dbo].[Receives]
    ([ProductId]);
GO

-- Creating foreign key on [ProductId] in table 'Ships'
ALTER TABLE [dbo].[Ships]
ADD CONSTRAINT [FK_Ships_Products]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ships_Products'
CREATE INDEX [IX_FK_Ships_Products]
ON [dbo].[Ships]
    ([ProductId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------