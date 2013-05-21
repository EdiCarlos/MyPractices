
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 08/24/2012 13:14:13
-- Generated from EDMX file: D:\MyPractices\DOTNET\WPF\MoviePlexSamples\MoviePlexSampleProj\MoviePlexDAL\MPEntity.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MoviePlex];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ck_fk_mp_address_groupid]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MP_Address] DROP CONSTRAINT [FK_ck_fk_mp_address_groupid];
GO
IF OBJECT_ID(N'[dbo].[FK_ck_fk_mp_city_stateid]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MP_City] DROP CONSTRAINT [FK_ck_fk_mp_city_stateid];
GO
IF OBJECT_ID(N'[dbo].[FK_ck_fk_mp_Movies_certificationid]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MP_Movies] DROP CONSTRAINT [FK_ck_fk_mp_Movies_certificationid];
GO
IF OBJECT_ID(N'[dbo].[FK_ck_fk_mp_Movies_genereid]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MP_Movies] DROP CONSTRAINT [FK_ck_fk_mp_Movies_genereid];
GO
IF OBJECT_ID(N'[dbo].[FK_ck_fk_mp_Movies_LanguageCode]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MP_Movies] DROP CONSTRAINT [FK_ck_fk_mp_Movies_LanguageCode];
GO
IF OBJECT_ID(N'[dbo].[FK_ck_fk_mp_Show_movie_id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MP_Shows] DROP CONSTRAINT [FK_ck_fk_mp_Show_movie_id];
GO
IF OBJECT_ID(N'[MoviePlexModelStoreContainer].[FK_ck_fk_mp_showcost_showid]', 'F') IS NOT NULL
    ALTER TABLE [MoviePlexModelStoreContainer].[MP_ShowCost] DROP CONSTRAINT [FK_ck_fk_mp_showcost_showid];
GO
IF OBJECT_ID(N'[dbo].[FK_ck_fk_mp_Shows_screen_id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MP_Shows] DROP CONSTRAINT [FK_ck_fk_mp_Shows_screen_id];
GO
IF OBJECT_ID(N'[dbo].[FK_ck_fk_mp_state_countryid]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MP_State] DROP CONSTRAINT [FK_ck_fk_mp_state_countryid];
GO
IF OBJECT_ID(N'[dbo].[FK_ck_fk_mp_Theaters_TheaterBrandId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MP_Theaters] DROP CONSTRAINT [FK_ck_fk_mp_Theaters_TheaterBrandId];
GO
IF OBJECT_ID(N'[dbo].[FK_ck_fk_mp_zip_cityid]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MP_ZipCodes] DROP CONSTRAINT [FK_ck_fk_mp_zip_cityid];
GO
IF OBJECT_ID(N'[MoviePlexModelStoreContainer].[FK_ck_fk_mp_Zone_zoneid]', 'F') IS NOT NULL
    ALTER TABLE [MoviePlexModelStoreContainer].[MP_ShowCost] DROP CONSTRAINT [FK_ck_fk_mp_Zone_zoneid];
GO
IF OBJECT_ID(N'[MoviePlexModelStoreContainer].[FK_ck_fk_ReservedSeats]', 'F') IS NOT NULL
    ALTER TABLE [MoviePlexModelStoreContainer].[MP_ReservedSeats] DROP CONSTRAINT [FK_ck_fk_ReservedSeats];
GO
IF OBJECT_ID(N'[MoviePlexModelStoreContainer].[FK_ck_fk_ReserverSeats_ScreenSeat_id]', 'F') IS NOT NULL
    ALTER TABLE [MoviePlexModelStoreContainer].[MP_ReservedSeats] DROP CONSTRAINT [FK_ck_fk_ReserverSeats_ScreenSeat_id];
GO
IF OBJECT_ID(N'[dbo].[FK_ck_fk_ScreenSeats_ZoneId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MP_ScreenSeats] DROP CONSTRAINT [FK_ck_fk_ScreenSeats_ZoneId];
GO
IF OBJECT_ID(N'[dbo].[FK_ck_fk_screentseats_Screenid]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MP_ScreenSeats] DROP CONSTRAINT [FK_ck_fk_screentseats_Screenid];
GO
IF OBJECT_ID(N'[dbo].[FK_ck_fk_ShowReservation_showid]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MP_ShowReservations] DROP CONSTRAINT [FK_ck_fk_ShowReservation_showid];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[MP_Address]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_Address];
GO
IF OBJECT_ID(N'[dbo].[MP_AddressGroups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_AddressGroups];
GO
IF OBJECT_ID(N'[dbo].[MP_City]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_City];
GO
IF OBJECT_ID(N'[dbo].[MP_Country]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_Country];
GO
IF OBJECT_ID(N'[dbo].[MP_Genere]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_Genere];
GO
IF OBJECT_ID(N'[dbo].[MP_Language]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_Language];
GO
IF OBJECT_ID(N'[dbo].[MP_MovieCertifications]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_MovieCertifications];
GO
IF OBJECT_ID(N'[dbo].[MP_Movies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_Movies];
GO
IF OBJECT_ID(N'[MoviePlexModelStoreContainer].[MP_ReservedSeats]', 'U') IS NOT NULL
    DROP TABLE [MoviePlexModelStoreContainer].[MP_ReservedSeats];
GO
IF OBJECT_ID(N'[dbo].[MP_Screens]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_Screens];
GO
IF OBJECT_ID(N'[dbo].[MP_ScreenSeats]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_ScreenSeats];
GO
IF OBJECT_ID(N'[dbo].[MP_ScreenZones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_ScreenZones];
GO
IF OBJECT_ID(N'[MoviePlexModelStoreContainer].[MP_ShowCost]', 'U') IS NOT NULL
    DROP TABLE [MoviePlexModelStoreContainer].[MP_ShowCost];
GO
IF OBJECT_ID(N'[dbo].[MP_ShowReservations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_ShowReservations];
GO
IF OBJECT_ID(N'[dbo].[MP_Shows]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_Shows];
GO
IF OBJECT_ID(N'[dbo].[MP_State]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_State];
GO
IF OBJECT_ID(N'[dbo].[MP_Theaters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_Theaters];
GO
IF OBJECT_ID(N'[dbo].[MP_TheatersBrand]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_TheatersBrand];
GO
IF OBJECT_ID(N'[dbo].[MP_UserInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_UserInfo];
GO
IF OBJECT_ID(N'[dbo].[MP_ZipCodes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MP_ZipCodes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MP_Address'
CREATE TABLE [dbo].[MP_Address] (
    [AddressId] int IDENTITY(1,1) NOT NULL,
    [ReferenceId] int  NOT NULL,
    [Address1] nvarchar(300)  NOT NULL,
    [Address2] nvarchar(300)  NULL,
    [AddressGroupId] int  NOT NULL
);
GO

-- Creating table 'MP_AddressGroups'
CREATE TABLE [dbo].[MP_AddressGroups] (
    [AddressGroupId] int IDENTITY(1,1) NOT NULL,
    [CountryId] int  NOT NULL,
    [CityId] int  NOT NULL,
    [StateId] int  NOT NULL,
    [ZipCodeId] int  NOT NULL
);
GO

-- Creating table 'MP_City'
CREATE TABLE [dbo].[MP_City] (
    [CityId] int IDENTITY(1,1) NOT NULL,
    [StateId] int  NOT NULL,
    [CityName] varchar(40)  NOT NULL
);
GO

-- Creating table 'MP_Country'
CREATE TABLE [dbo].[MP_Country] (
    [CountryId] int IDENTITY(1,1) NOT NULL,
    [CountryISOCode] nvarchar(10)  NULL,
    [CountryName] varchar(40)  NOT NULL
);
GO

-- Creating table 'MP_Genere'
CREATE TABLE [dbo].[MP_Genere] (
    [GenereID] int  NOT NULL,
    [GenereType] varchar(50)  NOT NULL
);
GO

-- Creating table 'MP_Language'
CREATE TABLE [dbo].[MP_Language] (
    [LanguageCode] char(5)  NOT NULL,
    [Language] char(2)  NOT NULL
);
GO

-- Creating table 'MP_MovieCertifications'
CREATE TABLE [dbo].[MP_MovieCertifications] (
    [CertificationId] int  NOT NULL,
    [CertificationType] char(2)  NULL,
    [CertificationName] varchar(30)  NULL,
    [CertificationDescription] nvarchar(1000)  NULL
);
GO

-- Creating table 'MP_Movies'
CREATE TABLE [dbo].[MP_Movies] (
    [MovieId] int IDENTITY(1,1) NOT NULL,
    [MovieName] varchar(100)  NOT NULL,
    [LanguageCode] char(5)  NULL,
    [CertificationId] int  NULL,
    [GenereId] int  NULL,
    [ReleaseDate] datetime  NOT NULL,
    [Description] varchar(1000)  NOT NULL,
    [Duration] decimal(2,2)  NULL
);
GO

-- Creating table 'MP_Screens'
CREATE TABLE [dbo].[MP_Screens] (
    [ScreenId] int IDENTITY(1,1) NOT NULL,
    [TheaterId] int  NOT NULL,
    [ScreenName] varchar(50)  NOT NULL,
    [Capacity] int  NULL
);
GO

-- Creating table 'MP_ScreenSeats'
CREATE TABLE [dbo].[MP_ScreenSeats] (
    [ScreenSeatId] int IDENTITY(1,1) NOT NULL,
    [ZoneId] int  NOT NULL,
    [ScreenId] int  NOT NULL,
    [SeatName] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'MP_ScreenZones'
CREATE TABLE [dbo].[MP_ScreenZones] (
    [ZoneId] int IDENTITY(1,1) NOT NULL,
    [ZoneName] nvarchar(30)  NULL
);
GO

-- Creating table 'MP_ShowCost'
CREATE TABLE [dbo].[MP_ShowCost] (
    [ShowId] int  NOT NULL,
    [ZoneId] int  NOT NULL,
    [Cost] decimal(19,4)  NOT NULL
);
GO

-- Creating table 'MP_ShowReservations'
CREATE TABLE [dbo].[MP_ShowReservations] (
    [ReservationId] int IDENTITY(1,1) NOT NULL,
    [ShowId] int  NOT NULL,
    [UserId] nvarchar(50)  NOT NULL,
    [TotalSeats] int  NULL,
    [TotalAmount] decimal(19,4)  NOT NULL,
    [ReservationDate] datetime  NOT NULL,
    [ReferenceNumber] nvarchar(30)  NOT NULL,
    [IsActive] bit  NOT NULL
);
GO

-- Creating table 'MP_Shows'
CREATE TABLE [dbo].[MP_Shows] (
    [ShowId] int IDENTITY(1,1) NOT NULL,
    [ScreenId] int  NOT NULL,
    [MovieId] int  NOT NULL,
    [MinimumAgeLimit] int  NOT NULL,
    [ShowDate] datetime  NOT NULL,
    [StartTime] datetime  NOT NULL,
    [EndTime] datetime  NOT NULL
);
GO

-- Creating table 'MP_State'
CREATE TABLE [dbo].[MP_State] (
    [StateId] int IDENTITY(1,1) NOT NULL,
    [CountryId] int  NOT NULL,
    [StateName] varchar(40)  NOT NULL
);
GO

-- Creating table 'MP_Theaters'
CREATE TABLE [dbo].[MP_Theaters] (
    [TheaterId] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(300)  NOT NULL,
    [NumberOfScreens] int  NOT NULL,
    [TheaterBrandID] int  NULL,
    [DBCreationDate] datetime  NOT NULL,
    [CreationUserId] varchar(30)  NULL
);
GO

-- Creating table 'MP_TheatersBrand'
CREATE TABLE [dbo].[MP_TheatersBrand] (
    [TheaterBrandId] int IDENTITY(1,1) NOT NULL,
    [BrandName] varchar(40)  NOT NULL
);
GO

-- Creating table 'MP_UserInfo'
CREATE TABLE [dbo].[MP_UserInfo] (
    [Uid] uniqueidentifier  NOT NULL,
    [EmailId] nvarchar(100)  NOT NULL,
    [Password] nvarchar(30)  NOT NULL,
    [IsValidEmail] bit  NOT NULL
);
GO

-- Creating table 'MP_ZipCodes'
CREATE TABLE [dbo].[MP_ZipCodes] (
    [ZipId] int IDENTITY(1,1) NOT NULL,
    [CityId] int  NOT NULL,
    [ZipCodes] nvarchar(40)  NOT NULL
);
GO

-- Creating table 'MP_ReservedSeats'
CREATE TABLE [dbo].[MP_ReservedSeats] (
    [MP_ShowReservations_ReservationId] int  NOT NULL,
    [MP_ScreenSeats_ScreenSeatId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AddressId] in table 'MP_Address'
ALTER TABLE [dbo].[MP_Address]
ADD CONSTRAINT [PK_MP_Address]
    PRIMARY KEY CLUSTERED ([AddressId] ASC);
GO

-- Creating primary key on [AddressGroupId] in table 'MP_AddressGroups'
ALTER TABLE [dbo].[MP_AddressGroups]
ADD CONSTRAINT [PK_MP_AddressGroups]
    PRIMARY KEY CLUSTERED ([AddressGroupId] ASC);
GO

-- Creating primary key on [CityId] in table 'MP_City'
ALTER TABLE [dbo].[MP_City]
ADD CONSTRAINT [PK_MP_City]
    PRIMARY KEY CLUSTERED ([CityId] ASC);
GO

-- Creating primary key on [CountryId] in table 'MP_Country'
ALTER TABLE [dbo].[MP_Country]
ADD CONSTRAINT [PK_MP_Country]
    PRIMARY KEY CLUSTERED ([CountryId] ASC);
GO

-- Creating primary key on [GenereID] in table 'MP_Genere'
ALTER TABLE [dbo].[MP_Genere]
ADD CONSTRAINT [PK_MP_Genere]
    PRIMARY KEY CLUSTERED ([GenereID] ASC);
GO

-- Creating primary key on [LanguageCode] in table 'MP_Language'
ALTER TABLE [dbo].[MP_Language]
ADD CONSTRAINT [PK_MP_Language]
    PRIMARY KEY CLUSTERED ([LanguageCode] ASC);
GO

-- Creating primary key on [CertificationId] in table 'MP_MovieCertifications'
ALTER TABLE [dbo].[MP_MovieCertifications]
ADD CONSTRAINT [PK_MP_MovieCertifications]
    PRIMARY KEY CLUSTERED ([CertificationId] ASC);
GO

-- Creating primary key on [MovieId] in table 'MP_Movies'
ALTER TABLE [dbo].[MP_Movies]
ADD CONSTRAINT [PK_MP_Movies]
    PRIMARY KEY CLUSTERED ([MovieId] ASC);
GO

-- Creating primary key on [ScreenId] in table 'MP_Screens'
ALTER TABLE [dbo].[MP_Screens]
ADD CONSTRAINT [PK_MP_Screens]
    PRIMARY KEY CLUSTERED ([ScreenId] ASC);
GO

-- Creating primary key on [ScreenSeatId] in table 'MP_ScreenSeats'
ALTER TABLE [dbo].[MP_ScreenSeats]
ADD CONSTRAINT [PK_MP_ScreenSeats]
    PRIMARY KEY CLUSTERED ([ScreenSeatId] ASC);
GO

-- Creating primary key on [ZoneId] in table 'MP_ScreenZones'
ALTER TABLE [dbo].[MP_ScreenZones]
ADD CONSTRAINT [PK_MP_ScreenZones]
    PRIMARY KEY CLUSTERED ([ZoneId] ASC);
GO

-- Creating primary key on [ShowId], [ZoneId], [Cost] in table 'MP_ShowCost'
ALTER TABLE [dbo].[MP_ShowCost]
ADD CONSTRAINT [PK_MP_ShowCost]
    PRIMARY KEY CLUSTERED ([ShowId], [ZoneId], [Cost] ASC);
GO

-- Creating primary key on [ReservationId] in table 'MP_ShowReservations'
ALTER TABLE [dbo].[MP_ShowReservations]
ADD CONSTRAINT [PK_MP_ShowReservations]
    PRIMARY KEY CLUSTERED ([ReservationId] ASC);
GO

-- Creating primary key on [ShowId] in table 'MP_Shows'
ALTER TABLE [dbo].[MP_Shows]
ADD CONSTRAINT [PK_MP_Shows]
    PRIMARY KEY CLUSTERED ([ShowId] ASC);
GO

-- Creating primary key on [StateId] in table 'MP_State'
ALTER TABLE [dbo].[MP_State]
ADD CONSTRAINT [PK_MP_State]
    PRIMARY KEY CLUSTERED ([StateId] ASC);
GO

-- Creating primary key on [TheaterId] in table 'MP_Theaters'
ALTER TABLE [dbo].[MP_Theaters]
ADD CONSTRAINT [PK_MP_Theaters]
    PRIMARY KEY CLUSTERED ([TheaterId] ASC);
GO

-- Creating primary key on [TheaterBrandId] in table 'MP_TheatersBrand'
ALTER TABLE [dbo].[MP_TheatersBrand]
ADD CONSTRAINT [PK_MP_TheatersBrand]
    PRIMARY KEY CLUSTERED ([TheaterBrandId] ASC);
GO

-- Creating primary key on [Uid] in table 'MP_UserInfo'
ALTER TABLE [dbo].[MP_UserInfo]
ADD CONSTRAINT [PK_MP_UserInfo]
    PRIMARY KEY CLUSTERED ([Uid] ASC);
GO

-- Creating primary key on [ZipId] in table 'MP_ZipCodes'
ALTER TABLE [dbo].[MP_ZipCodes]
ADD CONSTRAINT [PK_MP_ZipCodes]
    PRIMARY KEY CLUSTERED ([ZipId] ASC);
GO

-- Creating primary key on [MP_ShowReservations_ReservationId], [MP_ScreenSeats_ScreenSeatId] in table 'MP_ReservedSeats'
ALTER TABLE [dbo].[MP_ReservedSeats]
ADD CONSTRAINT [PK_MP_ReservedSeats]
    PRIMARY KEY NONCLUSTERED ([MP_ShowReservations_ReservationId], [MP_ScreenSeats_ScreenSeatId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AddressGroupId] in table 'MP_Address'
ALTER TABLE [dbo].[MP_Address]
ADD CONSTRAINT [FK_ck_fk_mp_address_groupid]
    FOREIGN KEY ([AddressGroupId])
    REFERENCES [dbo].[MP_AddressGroups]
        ([AddressGroupId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ck_fk_mp_address_groupid'
CREATE INDEX [IX_FK_ck_fk_mp_address_groupid]
ON [dbo].[MP_Address]
    ([AddressGroupId]);
GO

-- Creating foreign key on [StateId] in table 'MP_City'
ALTER TABLE [dbo].[MP_City]
ADD CONSTRAINT [FK_ck_fk_mp_city_stateid]
    FOREIGN KEY ([StateId])
    REFERENCES [dbo].[MP_State]
        ([StateId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ck_fk_mp_city_stateid'
CREATE INDEX [IX_FK_ck_fk_mp_city_stateid]
ON [dbo].[MP_City]
    ([StateId]);
GO

-- Creating foreign key on [CityId] in table 'MP_ZipCodes'
ALTER TABLE [dbo].[MP_ZipCodes]
ADD CONSTRAINT [FK_ck_fk_mp_zip_cityid]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[MP_City]
        ([CityId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ck_fk_mp_zip_cityid'
CREATE INDEX [IX_FK_ck_fk_mp_zip_cityid]
ON [dbo].[MP_ZipCodes]
    ([CityId]);
GO

-- Creating foreign key on [CountryId] in table 'MP_State'
ALTER TABLE [dbo].[MP_State]
ADD CONSTRAINT [FK_ck_fk_mp_state_countryid]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[MP_Country]
        ([CountryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ck_fk_mp_state_countryid'
CREATE INDEX [IX_FK_ck_fk_mp_state_countryid]
ON [dbo].[MP_State]
    ([CountryId]);
GO

-- Creating foreign key on [GenereId] in table 'MP_Movies'
ALTER TABLE [dbo].[MP_Movies]
ADD CONSTRAINT [FK_ck_fk_mp_Movies_genereid]
    FOREIGN KEY ([GenereId])
    REFERENCES [dbo].[MP_Genere]
        ([GenereID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ck_fk_mp_Movies_genereid'
CREATE INDEX [IX_FK_ck_fk_mp_Movies_genereid]
ON [dbo].[MP_Movies]
    ([GenereId]);
GO

-- Creating foreign key on [LanguageCode] in table 'MP_Movies'
ALTER TABLE [dbo].[MP_Movies]
ADD CONSTRAINT [FK_ck_fk_mp_Movies_LanguageCode]
    FOREIGN KEY ([LanguageCode])
    REFERENCES [dbo].[MP_Language]
        ([LanguageCode])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ck_fk_mp_Movies_LanguageCode'
CREATE INDEX [IX_FK_ck_fk_mp_Movies_LanguageCode]
ON [dbo].[MP_Movies]
    ([LanguageCode]);
GO

-- Creating foreign key on [CertificationId] in table 'MP_Movies'
ALTER TABLE [dbo].[MP_Movies]
ADD CONSTRAINT [FK_ck_fk_mp_Movies_certificationid]
    FOREIGN KEY ([CertificationId])
    REFERENCES [dbo].[MP_MovieCertifications]
        ([CertificationId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ck_fk_mp_Movies_certificationid'
CREATE INDEX [IX_FK_ck_fk_mp_Movies_certificationid]
ON [dbo].[MP_Movies]
    ([CertificationId]);
GO

-- Creating foreign key on [MovieId] in table 'MP_Shows'
ALTER TABLE [dbo].[MP_Shows]
ADD CONSTRAINT [FK_ck_fk_mp_Show_movie_id]
    FOREIGN KEY ([MovieId])
    REFERENCES [dbo].[MP_Movies]
        ([MovieId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ck_fk_mp_Show_movie_id'
CREATE INDEX [IX_FK_ck_fk_mp_Show_movie_id]
ON [dbo].[MP_Shows]
    ([MovieId]);
GO

-- Creating foreign key on [ScreenId] in table 'MP_Shows'
ALTER TABLE [dbo].[MP_Shows]
ADD CONSTRAINT [FK_ck_fk_mp_Shows_screen_id]
    FOREIGN KEY ([ScreenId])
    REFERENCES [dbo].[MP_Screens]
        ([ScreenId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ck_fk_mp_Shows_screen_id'
CREATE INDEX [IX_FK_ck_fk_mp_Shows_screen_id]
ON [dbo].[MP_Shows]
    ([ScreenId]);
GO

-- Creating foreign key on [ScreenId] in table 'MP_ScreenSeats'
ALTER TABLE [dbo].[MP_ScreenSeats]
ADD CONSTRAINT [FK_ck_fk_screentseats_Screenid]
    FOREIGN KEY ([ScreenId])
    REFERENCES [dbo].[MP_Screens]
        ([ScreenId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ck_fk_screentseats_Screenid'
CREATE INDEX [IX_FK_ck_fk_screentseats_Screenid]
ON [dbo].[MP_ScreenSeats]
    ([ScreenId]);
GO

-- Creating foreign key on [ZoneId] in table 'MP_ScreenSeats'
ALTER TABLE [dbo].[MP_ScreenSeats]
ADD CONSTRAINT [FK_ck_fk_ScreenSeats_ZoneId]
    FOREIGN KEY ([ZoneId])
    REFERENCES [dbo].[MP_ScreenZones]
        ([ZoneId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ck_fk_ScreenSeats_ZoneId'
CREATE INDEX [IX_FK_ck_fk_ScreenSeats_ZoneId]
ON [dbo].[MP_ScreenSeats]
    ([ZoneId]);
GO

-- Creating foreign key on [ZoneId] in table 'MP_ShowCost'
ALTER TABLE [dbo].[MP_ShowCost]
ADD CONSTRAINT [FK_ck_fk_mp_Zone_zoneid]
    FOREIGN KEY ([ZoneId])
    REFERENCES [dbo].[MP_ScreenZones]
        ([ZoneId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ck_fk_mp_Zone_zoneid'
CREATE INDEX [IX_FK_ck_fk_mp_Zone_zoneid]
ON [dbo].[MP_ShowCost]
    ([ZoneId]);
GO

-- Creating foreign key on [ShowId] in table 'MP_ShowCost'
ALTER TABLE [dbo].[MP_ShowCost]
ADD CONSTRAINT [FK_ck_fk_mp_showcost_showid]
    FOREIGN KEY ([ShowId])
    REFERENCES [dbo].[MP_Shows]
        ([ShowId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ShowId] in table 'MP_ShowReservations'
ALTER TABLE [dbo].[MP_ShowReservations]
ADD CONSTRAINT [FK_ck_fk_ShowReservation_showid]
    FOREIGN KEY ([ShowId])
    REFERENCES [dbo].[MP_Shows]
        ([ShowId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ck_fk_ShowReservation_showid'
CREATE INDEX [IX_FK_ck_fk_ShowReservation_showid]
ON [dbo].[MP_ShowReservations]
    ([ShowId]);
GO

-- Creating foreign key on [TheaterBrandID] in table 'MP_Theaters'
ALTER TABLE [dbo].[MP_Theaters]
ADD CONSTRAINT [FK_ck_fk_mp_Theaters_TheaterBrandId]
    FOREIGN KEY ([TheaterBrandID])
    REFERENCES [dbo].[MP_TheatersBrand]
        ([TheaterBrandId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ck_fk_mp_Theaters_TheaterBrandId'
CREATE INDEX [IX_FK_ck_fk_mp_Theaters_TheaterBrandId]
ON [dbo].[MP_Theaters]
    ([TheaterBrandID]);
GO

-- Creating foreign key on [MP_ShowReservations_ReservationId] in table 'MP_ReservedSeats'
ALTER TABLE [dbo].[MP_ReservedSeats]
ADD CONSTRAINT [FK_MP_ReservedSeats_MP_ShowReservations]
    FOREIGN KEY ([MP_ShowReservations_ReservationId])
    REFERENCES [dbo].[MP_ShowReservations]
        ([ReservationId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [MP_ScreenSeats_ScreenSeatId] in table 'MP_ReservedSeats'
ALTER TABLE [dbo].[MP_ReservedSeats]
ADD CONSTRAINT [FK_MP_ReservedSeats_MP_ScreenSeats]
    FOREIGN KEY ([MP_ScreenSeats_ScreenSeatId])
    REFERENCES [dbo].[MP_ScreenSeats]
        ([ScreenSeatId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MP_ReservedSeats_MP_ScreenSeats'
CREATE INDEX [IX_FK_MP_ReservedSeats_MP_ScreenSeats]
ON [dbo].[MP_ReservedSeats]
    ([MP_ScreenSeats_ScreenSeatId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------