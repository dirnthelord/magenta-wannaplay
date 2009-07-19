drop table if exists "BookingEntry"
drop table if exists "DutyGuard"
drop table if exists "Resident"
drop table if exists "ResidenceAddress"
drop table if exists "Facility"
create table "BookingEntry" (Id  integer, FromTime DATETIME, ToTime DATETIME, BookedAt DATETIME, FacilityId INTEGER, ResidentId INTEGER, BookedByGuardId INTEGER, primary key (Id))
create table "DutyGuard" (Id  integer, Name TEXT, primary key (Id))
create table "Resident" (Id  integer, PassCardNumber TEXT, Name TEXT, AddressId INTEGER, primary key (Id))
create table "ResidenceAddress" (Id  integer, Block TEXT, Unit TEXT, primary key (Id))
create table "Facility" (Id  integer, Name TEXT, FacilityType INTEGER, primary key (Id))
