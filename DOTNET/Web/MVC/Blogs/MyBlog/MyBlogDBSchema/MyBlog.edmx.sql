
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 01/25/2013 09:55:19
-- Generated from EDMX file: D:\MyPractices\Web\MVC\Blogs\MyBlog\MyBlogDBSchema\MyBlog.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyBlog];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BlogsBlogPost]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BlogPosts] DROP CONSTRAINT [FK_BlogsBlogPost];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Blogs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Blogs];
GO
IF OBJECT_ID(N'[dbo].[BlogPosts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BlogPosts];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Blogs'
CREATE TABLE [dbo].[Blogs] (
    [BlogID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(100)  NOT NULL,
    [TStamp] datetime  NOT NULL,
    [Description] nvarchar(1000)  NOT NULL
);
GO

-- Creating table 'BlogPosts'
CREATE TABLE [dbo].[BlogPosts] (
    [PostID] int IDENTITY(1,1) NOT NULL,
    [BlogID] int  NOT NULL,
    [Name] nvarchar(20)  NOT NULL,
    [Email] nvarchar(50)  NOT NULL,
    [Post] nvarchar(1000)  NOT NULL,
    [TStamp] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [BlogID] in table 'Blogs'
ALTER TABLE [dbo].[Blogs]
ADD CONSTRAINT [PK_Blogs]
    PRIMARY KEY CLUSTERED ([BlogID] ASC);
GO

-- Creating primary key on [PostID] in table 'BlogPosts'
ALTER TABLE [dbo].[BlogPosts]
ADD CONSTRAINT [PK_BlogPosts]
    PRIMARY KEY CLUSTERED ([PostID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BlogID] in table 'BlogPosts'
ALTER TABLE [dbo].[BlogPosts]
ADD CONSTRAINT [FK_BlogsBlogPost]
    FOREIGN KEY ([BlogID])
    REFERENCES [dbo].[Blogs]
        ([BlogID])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BlogsBlogPost'
CREATE INDEX [IX_FK_BlogsBlogPost]
ON [dbo].[BlogPosts]
    ([BlogID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------