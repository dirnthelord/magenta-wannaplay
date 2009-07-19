
alter table "BookingSlot"  drop constraint FKB9DFF92D36A74CD


alter table "BookingSlot"  drop constraint FKB9DFF92DFD36324C


alter table "BookingSlot"  drop constraint FKB9DFF92D89DFDB07


alter table "Resident"  drop constraint FKE4613F23E516BB36

drop table "ResidenceAddress"
drop table "DutyGuard"
drop table "BookingSlot"
drop table "Resident"
drop table "Facility"
create table "ResidenceAddress" (Id INT IDENTITY NOT NULL, Block NVARCHAR(255) null, Unit NVARCHAR(255) null, primary key (Id))
create table "DutyGuard" (Id INT IDENTITY NOT NULL, Name NVARCHAR(255) null, primary key (Id))
create table "BookingSlot" (Id INT IDENTITY NOT NULL, FromTime DATETIME null, ToTime DATETIME null, BookedAt DATETIME null, Facility_id INT null, Resident_id INT null, BookedBy_id INT null, primary key (Id))
create table "Resident" (Id INT IDENTITY NOT NULL, Number NVARCHAR(255) null, Name NVARCHAR(255) null, Address_id INT null, primary key (Id))
create table "Facility" (Id INT IDENTITY NOT NULL, Name NVARCHAR(255) null, primary key (Id))
alter table "BookingSlot" add constraint FKB9DFF92D36A74CD foreign key (Facility_id) references "Facility"
alter table "BookingSlot" add constraint FKB9DFF92DFD36324C foreign key (Resident_id) references "Resident"
alter table "BookingSlot" add constraint FKB9DFF92D89DFDB07 foreign key (BookedBy_id) references "DutyGuard"
alter table "Resident" add constraint FKE4613F23E516BB36 foreign key (Address_id) references "ResidenceAddress"
