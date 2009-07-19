
alter table "BookingSlot"  drop constraint FKB9DFF92D89D01458


alter table "BookingSlot"  drop constraint FKB9DFF92D7B13929


alter table "BookingSlot"  drop constraint FKB9DFF92D6341C05C


alter table "Resident"  drop constraint FKE4613F23D3A8BAC3

drop table "ResidenceAddress"
drop table "DutyGuard"
drop table "BookingSlot"
drop table "Resident"
drop table "Facility"
create table "ResidenceAddress" (Id INT IDENTITY NOT NULL, Block NVARCHAR(255) null, Unit NVARCHAR(255) null, primary key (Id))
create table "DutyGuard" (Id INT IDENTITY NOT NULL, Name NVARCHAR(255) null, primary key (Id))
create table "BookingSlot" (Id INT IDENTITY NOT NULL, FromTime DATETIME null, ToTime DATETIME null, BookedAt DATETIME null, FacilityId INT null, ResidentId INT null, BookedById INT null, primary key (Id))
create table "Resident" (Id INT IDENTITY NOT NULL, Number NVARCHAR(255) null, Name NVARCHAR(255) null, AddressId INT null, primary key (Id))
create table "Facility" (Id INT IDENTITY NOT NULL, Name NVARCHAR(255) null, primary key (Id))
alter table "BookingSlot" add constraint FKB9DFF92D89D01458 foreign key (FacilityId) references "Facility"
alter table "BookingSlot" add constraint FKB9DFF92D7B13929 foreign key (ResidentId) references "Resident"
alter table "BookingSlot" add constraint FKB9DFF92D6341C05C foreign key (BookedById) references "DutyGuard"
alter table "Resident" add constraint FKE4613F23D3A8BAC3 foreign key (AddressId) references "ResidenceAddress"
