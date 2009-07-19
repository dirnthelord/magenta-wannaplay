if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKB9DFF92D89D01458]') AND parent_object_id = OBJECT_ID('[BookingSlot]'))
alter table [BookingSlot]  drop constraint FKB9DFF92D89D01458

if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKB9DFF92D7B13929]') AND parent_object_id = OBJECT_ID('[BookingSlot]'))
alter table [BookingSlot]  drop constraint FKB9DFF92D7B13929

if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKB9DFF92D6341C05C]') AND parent_object_id = OBJECT_ID('[BookingSlot]'))
alter table [BookingSlot]  drop constraint FKB9DFF92D6341C05C

if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKE4613F23D3A8BAC3]') AND parent_object_id = OBJECT_ID('[Resident]'))
alter table [Resident]  drop constraint FKE4613F23D3A8BAC3

if exists (select * from dbo.sysobjects where id = object_id(N'[ResidenceAddress]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [ResidenceAddress]
if exists (select * from dbo.sysobjects where id = object_id(N'[DutyGuard]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [DutyGuard]
if exists (select * from dbo.sysobjects where id = object_id(N'[BookingSlot]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [BookingSlot]
if exists (select * from dbo.sysobjects where id = object_id(N'[Resident]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [Resident]
if exists (select * from dbo.sysobjects where id = object_id(N'[Facility]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [Facility]
create table [ResidenceAddress] (
  Id INT IDENTITY NOT NULL,
   Block NVARCHAR(255) null,
   Unit NVARCHAR(255) null,
   primary key (Id)
)
create table [DutyGuard] (
  Id INT IDENTITY NOT NULL,
   Name NVARCHAR(255) null,
   primary key (Id)
)
create table [BookingSlot] (
  Id INT IDENTITY NOT NULL,
   FromTime DATETIME null,
   ToTime DATETIME null,
   BookedAt DATETIME null,
   FacilityId INT null,
   ResidentId INT null,
   BookedById INT null,
   primary key (Id)
)
create table [Resident] (
  Id INT IDENTITY NOT NULL,
   Number NVARCHAR(255) null,
   Name NVARCHAR(255) null,
   AddressId INT null,
   primary key (Id)
)
create table [Facility] (
  Id INT IDENTITY NOT NULL,
   Name NVARCHAR(255) null,
   FacilityType INT null,
   primary key (Id)
)
alter table [BookingSlot] add constraint FKB9DFF92D89D01458 foreign key (FacilityId) references [Facility]
alter table [BookingSlot] add constraint FKB9DFF92D7B13929 foreign key (ResidentId) references [Resident]
alter table [BookingSlot] add constraint FKB9DFF92D6341C05C foreign key (BookedById) references [DutyGuard]
alter table [Resident] add constraint FKE4613F23D3A8BAC3 foreign key (AddressId) references [ResidenceAddress]
