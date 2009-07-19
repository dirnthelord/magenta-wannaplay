if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKAEB70FF589D01458]') AND parent_object_id = OBJECT_ID('[BookingEntry]'))
alter table [BookingEntry]  drop constraint FKAEB70FF589D01458

if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKAEB70FF57B13929]') AND parent_object_id = OBJECT_ID('[BookingEntry]'))
alter table [BookingEntry]  drop constraint FKAEB70FF57B13929

if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKAEB70FF5C3D4BC6C]') AND parent_object_id = OBJECT_ID('[BookingEntry]'))
alter table [BookingEntry]  drop constraint FKAEB70FF5C3D4BC6C

if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKE4613F23D3A8BAC3]') AND parent_object_id = OBJECT_ID('[Resident]'))
alter table [Resident]  drop constraint FKE4613F23D3A8BAC3

if exists (select * from dbo.sysobjects where id = object_id(N'[BookingEntry]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [BookingEntry]
if exists (select * from dbo.sysobjects where id = object_id(N'[DutyGuard]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [DutyGuard]
if exists (select * from dbo.sysobjects where id = object_id(N'[Resident]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [Resident]
if exists (select * from dbo.sysobjects where id = object_id(N'[ResidenceAddress]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [ResidenceAddress]
if exists (select * from dbo.sysobjects where id = object_id(N'[Facility]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [Facility]
create table [BookingEntry] (
  Id INT IDENTITY NOT NULL,
   FromTime DATETIME null,
   ToTime DATETIME null,
   BookedAt DATETIME null,
   FacilityId INT null,
   ResidentId INT null,
   BookedByGuardId INT null,
   primary key (Id)
)
create table [DutyGuard] (
  Id INT IDENTITY NOT NULL,
   Name NVARCHAR(255) null,
   primary key (Id)
)
create table [Resident] (
  Id INT IDENTITY NOT NULL,
   PassCardNumber NVARCHAR(255) null,
   Name NVARCHAR(255) null,
   AddressId INT null,
   primary key (Id)
)
create table [ResidenceAddress] (
  Id INT IDENTITY NOT NULL,
   Block NVARCHAR(255) null,
   Unit NVARCHAR(255) null,
   primary key (Id)
)
create table [Facility] (
  Id INT IDENTITY NOT NULL,
   Name NVARCHAR(255) null,
   FacilityType INT null,
   primary key (Id)
)
alter table [BookingEntry] add constraint FKAEB70FF589D01458 foreign key (FacilityId) references [Facility]
alter table [BookingEntry] add constraint FKAEB70FF57B13929 foreign key (ResidentId) references [Resident]
alter table [BookingEntry] add constraint FKAEB70FF5C3D4BC6C foreign key (BookedByGuardId) references [DutyGuard]
alter table [Resident] add constraint FKE4613F23D3A8BAC3 foreign key (AddressId) references [ResidenceAddress]
