
alter table "BookingEntry"  drop constraint FKAEB70FF589D01458


alter table "BookingEntry"  drop constraint FKAEB70FF57B13929


alter table "BookingEntry"  drop constraint FKAEB70FF5C3D4BC6C

drop table "DutyGuard"
drop table "Resident"
drop table "Facility"
drop table "BookingEntry"
create table "DutyGuard" (Id INT IDENTITY NOT NULL, Name NVARCHAR(255) null, primary key (Id))
create table "Resident" (Id INT IDENTITY NOT NULL, AddressBlock NVARCHAR(255) null, AddressUnit NVARCHAR(255) null, PassCardNumber NVARCHAR(255) null, Name NVARCHAR(255) null, primary key (Id))
create table "Facility" (Id INT IDENTITY NOT NULL, Name NVARCHAR(255) null, FacilityType INT null, primary key (Id))
create table "BookingEntry" (Id INT IDENTITY NOT NULL, PeriodFrom DATETIME null, PeriodTo DATETIME null, BookedAtDateTime DATETIME null, FacilityId INT null, ResidentId INT null, BookedByGuardId INT null, primary key (Id))
alter table "BookingEntry" add constraint FKAEB70FF589D01458 foreign key (FacilityId) references "Facility"
alter table "BookingEntry" add constraint FKAEB70FF57B13929 foreign key (ResidentId) references "Resident"
alter table "BookingEntry" add constraint FKAEB70FF5C3D4BC6C foreign key (BookedByGuardId) references "DutyGuard"
