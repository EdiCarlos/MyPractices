Use MoviePlex;
go
create table MP_Theaters
(
TheaterId int constraint ck_pk_mp_TheatersPrimaryKey primary key identity(1000, 1), 
Name varchar(300) not null, 
NumberOfScreens int constraint ck_df_mp_Theatersdefault default 1 not null, 
TheaterBrandID int, 
DBCreationDate Datetime not null, 
CreationUserId varchar(30) null,
)
go
create table MP_TheatersBrand
(
TheaterBrandId int constraint ck_pk_mp_TheatersBrand_id primary key identity(100, 1), 
BrandName varchar(40) not null,
)
go
alter table MP_Theaters
add constraint ck_fk_mp_Theaters_TheaterBrandId foreign key (TheaterBrandId) references MP_TheatersBrand(TheaterBrandId)
on delete no action on update no action
go
insert into MP_TheatersBrand values('Fame Adlabs');
insert into MP_TheatersBrand values('CineMax');
insert into MP_Theaters values('CineMax Malad', 4, 100, GETDATE(), 'axkhan2');
go
if OBJECT_ID(N'MP_Movies', N'U') is not null
drop table MP_Movies
go
Create table MP_Movies
(
MovieId int constraint ck_pk_MP_Movies_Id primary key identity(1, 1), 
MovieName varchar(100) not null, 
LanguageCode char(5) default 'en-En', 
CertificationId int null, 
GenereId int null, 
ReleaseDate datetime not null, 
Description varchar(1000) not null, 
Duration numeric(2, 2)null
)
go
if OBJECT_ID(N'MP_MovieCertifications', N'U') is not null
drop table MP_MovieCertifications
go
Create table MP_MovieCertifications
(
CertificationId int constraint ck_pk_mp_movicecertifications primary key, 
CertificationType char(2),
CertificationName varchar(30) null, 
CertificationDescription nvarchar(1000) null 
)
go
if OBJECT_ID(N'MP_Genere', N'U') is not null
drop table MP_Genere
go
create table MP_Genere
(
GenereID int constraint ck_pk_Genere_id primary key, 
GenereType varchar(50) not null, 
)
go
if OBJECT_ID(N'MP_Language', N'U') is not null
drop table MP_Language
go
create table MP_Language
(
LanguageCode char(5) constraint ck_pk_languagecode primary key, 
Language char(2) not null, 
)
go
if OBJECT_ID(N'ck_fk_mp_Movies_certificationid', N'F') is not null
alter table MP_Movies
drop constraint ck_fk_mp_Movies_certificationid
go
alter table MP_Movies
add constraint ck_fk_mp_Movies_certificationid foreign key (CertificationId) references MP_MovieCertifications(CertificationId)
on delete set null on update cascade
go
if OBJECT_ID(N'ck_fk_mp_Movies_genereid', N'F') is not null
alter table MP_Movies
drop constraint ck_fk_mp_Movies_genereid
go
alter table MP_Movies 
add constraint ck_fk_mp_Movies_genereid foreign key (GenereId) references MP_Genere(GenereID)
on delete no action on update cascade
go
if OBJECT_ID(N'ck_fk_mp_Movies_LanguageCode', N'F') is not null
alter table MP_Movies
drop constraint ck_fk_mp_Movies_LanguageCode
go
alter table MP_Movies 
add constraint ck_fk_mp_Movies_LanguageCode foreign key (LanguageCode) references MP_Language(LanguageCode)
on delete no action on update cascade
go
if OBJECT_ID(N'MP_Screens', N'U') is not null
drop table MP_Screens
go
create table MP_Screens
(
ScreenId int constraint ck_pk_MP_screens_id primary key identity(1, 1), 
TheaterId int not null, 
ScreenName varchar(50) not null, 
Capacity int null
)
go
if OBJECT_ID(N'MP_ScreenZones', N'U') is not null
drop table MP_ScreenZones
go
create table MP_ScreenZones
(
ZoneId int constraint ck_pk_mp_screenzone primary key identity(100, 1), 
ZoneName nvarchar(30),
)
go
if OBJECT_ID(N'MP_ScreenSeats', N'U') is not null
drop table MP_ScreenSeats
go
create table MP_ScreenSeats
(
ScreenSeatId int constraint ck_pk_ScreenSeats primary key identity(1, 1),
ZoneId int constraint ck_fk_ScreenSeats_ZoneId foreign key references MP_ScreenZones(ZoneId) on delete no action on update no action not null, 
ScreenId int constraint ck_fk_screentseats_Screenid foreign key references MP_Screens(ScreenId) on delete no action on update no action not null, 
SeatName nvarchar(10) not null
) 
go
if OBJECT_ID(N'MP_Shows', N'U') is not null
drop table MP_Shows
go
create table MP_Shows
(
ShowId int constraint ck_pk_mp_shows_id primary key identity(1, 1), 
ScreenId int constraint ck_fk_mp_Shows_screen_id foreign key references MP_Screens(ScreenId) on delete no action on update no action not null, 
MovieId int constraint ck_fk_mp_Show_movie_id foreign key references MP_Movies(MovieId) on delete no action on update no action not null, 
MinimumAgeLimit int constraint ck_chk_mp_show_agelimit check(MinimumAgeLimit <= 100) default 18 not null, 
ShowDate datetime not null, 
StartTime DateTime not null, 
EndTime DateTime not null, 
IsActive bit not null default 1
)
go
if OBJECT_ID(N'MP_ShowCost', N'U') is not null
drop table MP_ShowCost
go
Create table MP_ShowCost
(
ShowId int constraint ck_fk_mp_showcost_showid foreign key references MP_Shows(ShowId) not null, 
ZoneId int constraint ck_fk_mp_Zone_zoneid foreign key references MP_ScreenZones(ZoneId) not null, 
Cost money not null
)
go
if OBJECT_ID(N'MP_ShowReservations', N'U') is not null
drop table MP_ShowReservations
go
Create table MP_ShowReservations
(
ReservationId int constraint ck_pk_ShowReservation_id primary key identity(1000, 1), 
ShowId int constraint ck_fk_ShowReservation_showid foreign key references MP_Shows(ShowId) not null, 
UserId nvarchar(50) not null, 
TotalSeats int null, 
TotalAmount money not null, 
ReservationDate DateTime not null default getdate(), 
ReferenceNumber nvarchar(30) not null
)
go
if OBJECT_ID(N'MP_ReservedSeats', N'U') is not null
drop table MP_ReservedSeats
go
Create table MP_ReservedSeats
(
ReservationId int constraint ck_fk_ReservedSeats foreign key references MP_ShowReservations(ReservationId) not null, 
ScreenSeatId int constraint ck_fk_ReserverSeats_ScreenSeat_id foreign key references MP_ScreenSeats(ScreenSeatId) not null
)
go
if OBJECT_ID(N'MP_Country', N'U') is not null
drop table MP_Country
go 
Create table MP_Country
(
CountryId int constraint ck_pk_mp_country_code primary key identity(1, 1),
CountryISOCode nvarchar(10) null, 
CountryName varchar(40) unique not null
)
go
if OBJECT_ID(N'MP_State', N'U') is not null
drop table MP_State
go 
Create table MP_State
(
StateId int constraint ck_pk_mp_state_id primary key identity(1, 1),
CountryId int constraint ck_fk_mp_state_countryid foreign key references MP_Country(CountryId) not null, 
StateName varchar(40) unique not null
)
go
if OBJECT_ID(N'MP_City', N'U') is not null
drop table MP_City
go 
Create table MP_City
(
CityId int constraint ck_pk_mp_city_id primary key identity(1, 1),
StateId int constraint ck_fk_mp_city_stateid foreign key references MP_State(StateId) not null, 
CityName varchar(40) not null
)
go
if OBJECT_ID(N'MP_ZipCodes', N'U') is not null
drop table MP_ZipCodes
go 
Create table MP_ZipCodes
(
ZipId int constraint ck_pk_mp_zipcode_id primary key identity(1, 1),
CityId int constraint ck_fk_mp_zip_cityid foreign key references MP_City(CityId) not null, 
ZipCodes nvarchar(40) not null
)
go
if OBJECT_ID(N'MP_AddressGroups', N'U') is not null
drop table MP_AddressGroups
go 
Create table MP_AddressGroups
(
AddressGroupId int constraint ck_pk_mp_Addressgroup_id primary key identity(1, 1),
CountryId int not null,
CityId int not null, 
StateId int not null,
ZipCodeId int not null
)
go
if OBJECT_ID(N'MP_Address', N'U') is not null
drop table MP_Address
go 
create table MP_Address
(
AddressId int constraint ck_fk_mp_address_id primary key identity(1, 1), 
ReferenceId int not null, 
Address1 nvarchar(300) not null, 
Address2 nvarchar(300) null, 
AddressGroupId int constraint ck_fk_mp_address_groupid foreign key references MP_AddressGroups(AddressGroupId) not null
)
go
if OBJECT_ID(N'MP_UserInfo', N'U') is not null
drop table MP_UserInfo
go 
Create table MP_UserInfo
(
Uid uniqueidentifier constraint ck_pk_mp_UserInfo primary key default newid(), 
EmailId nvarchar(100) unique not null, 
Password nvarchar(30) not null, 
IsValidEmail bit not null default 0
)

