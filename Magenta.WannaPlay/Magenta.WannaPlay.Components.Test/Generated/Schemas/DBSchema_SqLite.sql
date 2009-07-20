drop table if exists "DutyGuard"
drop table if exists "Resident"
drop table if exists "Facility"
drop table if exists "BookingEntry"
create table "DutyGuard" (Id  integer, Name TEXT, primary key (Id))
create table "Resident" (Id  integer, AddressBlock TEXT, AddressUnit TEXT, PassCardNumber TEXT, Name TEXT, primary key (Id))
create table "Facility" (Id  integer, Name TEXT, FacilityType INTEGER, primary key (Id))
create table "BookingEntry" (Id  integer, PeriodFrom DATETIME, PeriodTo DATETIME, BookedAtDateTime DATETIME, FacilityId INTEGER, ResidentId INTEGER, BookedByGuardId INTEGER, primary key (Id))
