drop table if exists "BookingSlot"
drop table if exists "DutyGuard"
drop table if exists "Resident"
drop table if exists "ResidenceAddress"
drop table if exists "Facility"
create table "BookingSlot" (Id  integer, From DATETIME, To DATETIME, Facility_id INTEGER, Resident_id INTEGER, BookedBy_id INTEGER, primary key (Id))
create table "DutyGuard" (Id  integer, NameFirst TEXT, NameLast TEXT, primary key (Id))
create table "Resident" (Id  integer, NameFirst TEXT, NameLast TEXT, Number INTEGER, Address_id INTEGER, primary key (Id))
create table "ResidenceAddress" (Id  integer, Block TEXT, Unit TEXT, primary key (Id))
create table "Facility" (Id  integer, Name TEXT, primary key (Id))
