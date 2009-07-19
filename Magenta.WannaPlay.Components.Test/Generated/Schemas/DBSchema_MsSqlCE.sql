
alter table "BookingEntry"  drop constraint FKAEB70FF589D01458


alter table "BookingEntry"  drop constraint FKAEB70FF57B13929


alter table "BookingEntry"  drop constraint FKAEB70FF5C3D4BC6C


alter table "Resident"  drop constraint FKE4613F23D3A8BAC3

drop table "BookingEntry"
drop table "DutyGuard"
drop table "Resident"
drop table "ResidenceAddress"
drop table "Facility"
create table "BookingEntry" (Id INT IDENTITY NOT NULL, FromTime DATETIME null, ToTime DATETIME null, BookedAt DATETIME null, FacilityId INT null, ResidentId INT null, BookedByGuardId INT null, primary key (Id))
create table "DutyGuard" (Id INT IDENTITY NOT NULL, Name NVARCHAR(255) null, primary key (Id))
create table "Resident" (Id INT IDENTITY NOT NULL, PassCardNumber NVARCHAR(255) null, Name NVARCHAR(255) null, AddressId INT null, primary key (Id))
create table "ResidenceAddress" (Id INT IDENTITY NOT NULL, Block NVARCHAR(255) null, Unit NVARCHAR(255) null, primary key (Id))
create table "Facility" (Id INT IDENTITY NOT NULL, Name NVARCHAR(255) null, FacilityType INT null, primary key (Id))
alter table "BookingEntry" add constraint FKAEB70FF589D01458 foreign key (FacilityId) references "Facility"
alter table "BookingEntry" add constraint FKAEB70FF57B13929 foreign key (ResidentId) references "Resident"
alter table "BookingEntry" add constraint FKAEB70FF5C3D4BC6C foreign key (BookedByGuardId) references "DutyGuard"
alter table "Resident" add constraint FKE4613F23D3A8BAC3 foreign key (AddressId) references "ResidenceAddress"
