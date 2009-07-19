if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK6A512690E5C9AA7]') AND parent_object_id = OBJECT_ID('DutyGuard'))
alter table DutyGuard  drop constraint FK6A512690E5C9AA7

if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKB9DFF92DE5C9AA7]') AND parent_object_id = OBJECT_ID('BookingSlot'))
alter table BookingSlot  drop constraint FKB9DFF92DE5C9AA7

if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKB9DFF92D36A74CD]') AND parent_object_id = OBJECT_ID('BookingSlot'))
alter table BookingSlot  drop constraint FKB9DFF92D36A74CD

if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKB9DFF92DFD36324C]') AND parent_object_id = OBJECT_ID('BookingSlot'))
alter table BookingSlot  drop constraint FKB9DFF92DFD36324C

if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKB9DFF92D89DFDB07]') AND parent_object_id = OBJECT_ID('BookingSlot'))
alter table BookingSlot  drop constraint FKB9DFF92D89DFDB07

if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKE4613F23E5C9AA7]') AND parent_object_id = OBJECT_ID('Resident'))
alter table Resident  drop constraint FKE4613F23E5C9AA7

if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FKE4613F23E516BB36]') AND parent_object_id = OBJECT_ID('Resident'))
alter table Resident  drop constraint FKE4613F23E516BB36

if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK81A05061E5C9AA7]') AND parent_object_id = OBJECT_ID('Facility'))
alter table Facility  drop constraint FK81A05061E5C9AA7

if exists (select 1 from sys.objects where object_id = OBJECT_ID(N'[FK31AB8EA7E5C9AA7]') AND parent_object_id = OBJECT_ID('ResidenceAddress'))
alter table ResidenceAddress  drop constraint FK31AB8EA7E5C9AA7

if exists (select * from dbo.sysobjects where id = object_id(N'[Entity]') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table [Entity]
if exists (select * from dbo.sysobjects where id = object_id(N'DutyGuard') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table DutyGuard
if exists (select * from dbo.sysobjects where id = object_id(N'BookingSlot') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table BookingSlot
if exists (select * from dbo.sysobjects where id = object_id(N'Resident') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Resident
if exists (select * from dbo.sysobjects where id = object_id(N'Facility') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table Facility
if exists (select * from dbo.sysobjects where id = object_id(N'ResidenceAddress') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table ResidenceAddress
create table [Entity] (
  Id INT IDENTITY NOT NULL,
   primary key (Id)
)
create table DutyGuard (
  EntityId INT not null,
   primary key (EntityId)
)
create table BookingSlot (
  EntityId INT not null,
   From DATETIME null,
   To DATETIME null,
   Facility_id INT null,
   Resident_id INT null,
   BookedBy_id INT null,
   primary key (EntityId)
)
create table Resident (
  EntityId INT not null,
   Number INT null,
   Address_id INT null,
   primary key (EntityId)
)
create table Facility (
  EntityId INT not null,
   Name NVARCHAR(255) null,
   primary key (EntityId)
)
create table ResidenceAddress (
  EntityId INT not null,
   Block NVARCHAR(255) null,
   Unit NVARCHAR(255) null,
   primary key (EntityId)
)
alter table DutyGuard add constraint FK6A512690E5C9AA7 foreign key (EntityId) references [Entity]
alter table BookingSlot add constraint FKB9DFF92DE5C9AA7 foreign key (EntityId) references [Entity]
alter table BookingSlot add constraint FKB9DFF92D36A74CD foreign key (Facility_id) references Facility
alter table BookingSlot add constraint FKB9DFF92DFD36324C foreign key (Resident_id) references Resident
alter table BookingSlot add constraint FKB9DFF92D89DFDB07 foreign key (BookedBy_id) references DutyGuard
alter table Resident add constraint FKE4613F23E5C9AA7 foreign key (EntityId) references [Entity]
alter table Resident add constraint FKE4613F23E516BB36 foreign key (Address_id) references ResidenceAddress
alter table Facility add constraint FK81A05061E5C9AA7 foreign key (EntityId) references [Entity]
alter table ResidenceAddress add constraint FK31AB8EA7E5C9AA7 foreign key (EntityId) references [Entity]
