drop table if exists "ResidenceAddress"
drop table if exists "DutyGuard"
drop table if exists "BookingSlot"
drop table if exists "Resident"
drop table if exists "Facility"
create table "ResidenceAddress" (Id  integer, Block TEXT, Unit TEXT, primary key (Id))
create table "DutyGuard" (Id  integer, Name TEXT, primary key (Id))
create table "BookingSlot" (Id  integer, FromTime DATETIME, ToTime DATETIME, BookedAt DATETIME, FacilityId INTEGER, ResidentId INTEGER, BookedById INTEGER, primary key (Id))
create table "Resident" (Id  integer, Number TEXT, Name TEXT, AddressId INTEGER, primary key (Id))
create table "Facility" (Id  integer, Name TEXT, primary key (Id))
