-- Script Date: 12-Feb-18 12:47  - ErikEJ.SqlCeScripting version 3.5.2.74
-- Database information:
-- Database: C:\Users\moura\Documents\Visual Studio 2017\Projects\LocalDBPrototype\CybitLocalDB.db
-- ServerVersion: 3.18.0
-- DatabaseSize: 20 KB
-- Created: 07-Feb-18 23:38

-- User Table information:
-- Number of tables: 4
-- DetectedThreats: -1 row(s)
-- Device: -1 row(s)
-- Users: -1 row(s)
-- VideoCards: -1 row(s)

SELECT 1;
PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [Device] (
  [id] INTEGER  NOT NULL
, [model] text NOT NULL
, [name] text NOT NULL
, [manufacturer] text NOT NULL
, [os_name] text NOT NULL
, [latest_os_update] text NOT NULL
, [latest_quick_scan] text NOT NULL
, [latest_full_scan] text NOT NULL
, [motherboard_manufacturer] text NOT NULL
, [battery_status] numeric(53,0)  NOT NULL
, [ram_status] text NOT NULL
, [processor_status] text NOT NULL
, [av_latest_update] text NOT NULL
, [disk_status] text NOT NULL
, [battery_availability] numeric(53,0)  NOT NULL
, [processor_availability] numeric(53,0)  NOT NULL
, [disk_availability] numeric(53,0)  NOT NULL
, [nbr_quick_scan] numeric(53,0)  NOT NULL
, [nbr_full_scan] numeric(53,0)  NOT NULL
, CONSTRAINT [sqlite_master_PK_Device] PRIMARY KEY ([id])
);
CREATE TABLE [VideoCards] (
  [id] INTEGER  NOT NULL
, [device_id] bigint  NOT NULL
, [model] text NOT NULL
, [RAM] numeric(53,0)  NOT NULL
, [driver_version] text NOT NULL
, [video_card_status] text NOT NULL
, CONSTRAINT [sqlite_master_PK_VideoCards] PRIMARY KEY ([id])
, FOREIGN KEY ([device_id]) REFERENCES [Device] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [Users] (
  [id] INTEGER  NOT NULL
, [firstname] text NOT NULL
, [lastname] text NOT NULL
, [email] text NOT NULL
, [password] text NOT NULL
, [score] numeric(53,0)  NOT NULL
, [device_id] bigint  NOT NULL
, CONSTRAINT [sqlite_master_PK_Users] PRIMARY KEY ([id])
, FOREIGN KEY ([device_id]) REFERENCES [Device] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [DetectedThreats] (
  [id] INTEGER  NOT NULL
, [threat_id] numeric(53,0)  NOT NULL
, [device_id] bigint  NOT NULL
, [detection_date] text NOT NULL
, [threat_status_id] numeric(53,0)  NOT NULL
, CONSTRAINT [sqlite_master_PK_DetectedThreats] PRIMARY KEY ([id])
, FOREIGN KEY ([device_id]) REFERENCES [Device] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
COMMIT;

