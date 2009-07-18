drop table if exists "Entity"
drop table if exists DutyGuard
drop table if exists BookingSlot
drop table if exists Resident
drop table if exists Facility
drop table if exists ResidenceAddress
create table "Entity" (Id  integer, primary key (Id))
create table DutyGuard (
  EntityId INTEGER not null,
   primary key (EntityId)
)
create table BookingSlot (
  EntityId INTEGER not null,
   From DATETIME,
   To DATETIME,
   Facility_id INTEGER,
   Resident_id INTEGER,
   BookedBy_id INTEGER,
   primary key (EntityId)
)
create table Resident (
  EntityId INTEGER not null,
   Number INTEGER,
   Address_id INTEGER,
   primary key (EntityId)
)
create table Facility (
  EntityId INTEGER not null,
   Name TEXT,
   primary key (EntityId)
)
create table ResidenceAddress (
  EntityId INTEGER not null,
   Block TEXT,
   Unit TEXT,
   primary key (EntityId)
)
