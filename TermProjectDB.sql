USE master;
GO

IF  DB_ID('TermProjectDB') IS NOT NULL
DROP DATABASE TermProjectDB;
GO

CREATE DATABASE TermProjectDB;
GO

USE TermProjectDB;
GO

-------------------------------------- DATABASE TABLES ------------------------------------------->

CREATE TABLE dbo.PaymentMethod 
(
	PaymentID INT IDENTITY (1, 1) PRIMARY KEY,
	PmntType varchar(20) NOT NULL,
)


CREATE TABLE dbo.Driver
(
	DriverId int IDENTITY (1, 1) PRIMARY KEY NOT NULL,
	First_Name varchar(50) NOT NULL,
	Last_Name varchar(50) NOT NULL,
	[Address] varchar(100) NOT NULL,
	City varchar(100) NOT NULL, 
	[State] varchar(100) NOT NULL,
	ZipCode varchar(100) NOT NULL,
	Phone varchar(10) NOT NULL,
	Email varchar(100) NOT NULL
)

CREATE TABLE dbo.Car
(
	CarId int PRIMARY KEY CLUSTERED(CarId) NOT NULL, 
	DriverId INT NOT NULL,
	CarMake varchar(50) NOT NULL,
	LicensePlate varchar(50) NOT NULL,
	[Description] varchar(100) NOT NULL 
)

CREATE TABLE dbo.Rider
(
	RiderId int IDENTITY (1, 1) PRIMARY KEY NOT NULL,
	First_Name varchar(100) NOT NULL,
	Last_Name varchar(100) NOT NULL,
	[Address] varchar(100) NOT NULL,
	City varchar(100) NOT NULL, 
	[State] varchar(100) NOT NULL,
	ZipCode varchar(100) NOT NULL,
	Phone varchar(100) NOT NULL,
	Email varchar(100) NOT NULL,
	PaymentID INT NOT NULL
)


CREATE TABLE dbo.Schedule
(
	ScheduleId int IDENTITY (1, 1) PRIMARY KEY NOT NULL, 
	RiderId INT NOT NULL,
	Pickup_Location varchar(100) NOT NULL,
	Dropoff_Location varchar(100) NOT NULL,
	Pickup_Time DateTime NOT NULL,
	Cost MONEY NOT NULL,
	DriverId INT NULL,
	CarId INT NULL
)

GO

-------------------------------------- INSERT DATA INTO PAYMENT METHOD ------------------------------>

SET IDENTITY_INSERT dbo.PaymentMethod ON;

INSERT INTO dbo.PaymentMethod(PaymentID,PmntType) VALUES(1,'Cash');
INSERT INTO dbo.PaymentMethod(PaymentID,PmntType) VALUES(2,'Check');
INSERT INTO dbo.PaymentMethod(PaymentID,PmntType) VALUES(3,'Credit Card');
INSERT INTO dbo.PaymentMethod(PaymentID,PmntType) VALUES(4,'Debit Card');
INSERT INTO dbo.PaymentMethod(PaymentID,PmntType) VALUES(5,'PayPal');

SET IDENTITY_INSERT dbo.PaymentMethod OFF;

-------------------------------------   INSERT DATA INTO DRIVER  ----------------------------------->

SET IDENTITY_INSERT dbo.Driver ON;

INSERT INTO dbo.Driver(DriverId, First_Name, Last_Name, [Address], City, [State], ZipCode, Phone, Email) 
	VALUES(01, 'Jace', 'Riders', '768 5th Ave Ste 303', 'Wilsonville', 'OR', '97062', '9715724760', 'jrider@carpetride.com');

INSERT INTO dbo.Driver(DriverId, First_Name, Last_Name, [Address], City, [State], ZipCode, Phone, Email) 
	VALUES(02, 'Tiena', 'Valefort', '67 N 26 West Ave', 'Salem', 'OR', '97062', '5025262175', 'tvalefort@carpetride.com');	

INSERT INTO dbo.Driver(DriverId, First_Name, Last_Name, [Address], City, [State], ZipCode, Phone, Email) 
	VALUES(03, 'Noctis', 'Lucis-Caellum', '1 N Citadel', 'Lucis', 'WA', '97003', '2755826270', 'ncaellum@carpetride.com');

INSERT INTO dbo.Driver(DriverId, First_Name, Last_Name, [Address], City, [State], ZipCode, Phone, Email) 
	VALUES(04, 'Emma', 'Swan', '25 SW Apple Street', 'Storybrooke', 'MN', '04005', '5724578502', 'eswan@carpetride.com');

INSERT INTO dbo.Driver(DriverId, First_Name, Last_Name, [Address], City, [State], ZipCode, Phone, Email) 
	VALUES(05, 'Casey', 'Tresor', '1224 N Midnight Ave', 'Glendor', 'CA', '97003', '9672745710', 'ctresor@carpetride.com');

SET IDENTITY_INSERT dbo.Driver OFF;


-------------------------------------   INSERT DATA INTO CAR  ----------------------------------->

INSERT INTO dbo.Car(CarId,DriverId,CarMake,LicensePlate,[Description]) VALUES(1,01,'Toyota','472-RFH','A toyota Prius four-seater');
INSERT INTO dbo.Car(CarId,DriverId,CarMake,LicensePlate,[Description]) VALUES(2,02,'Ford','175-RFB','A Ford hatchback');
INSERT INTO dbo.Car(CarId,DriverId,CarMake,LicensePlate,[Description]) VALUES(3,03,'Audi','682-WOF','A rich man convertible');
INSERT INTO dbo.Car(CarId,DriverId,CarMake,LicensePlate,[Description]) VALUES(4,04,'Volkswagen','E83-KAE','A tiny yellow beetle');
INSERT INTO dbo.Car(CarId,DriverId,CarMake,LicensePlate,[Description]) VALUES(5,05,'Peugeot','WONDER','A French convertible');


-------------------------------------   INSERT DATA INTO RIDER  ----------------------------------->

SET IDENTITY_INSERT dbo.Rider ON;

INSERT INTO dbo.Rider(RiderId, First_Name, Last_Name, [Address], City, [State], ZipCode, Phone, Email, PaymentID) 
				VALUES(001, 'Hunter', 'Long', '768 5th Ave Ste 300', 'Wilsonville', 'OR', '97062', '5032852659', 'hlong@gmail.com', 1);

INSERT INTO dbo.Rider(RiderId, First_Name, Last_Name, [Address], City, [State], ZipCode, Phone, Email, PaymentID) 
				VALUES(002, 'Cassandra', 'De Bellefort', '768 5th Ave Ste 932', 'Wilsonville', 'OR', '97062', '9719672946', 'cdebelle@intel.com', 2);

INSERT INTO dbo.Rider(RiderId, First_Name, Last_Name, [Address], City, [State], ZipCode, Phone, Email, PaymentID) 
				VALUES(003, 'Galen', 'Sage', '200 Beaverton-Hillsdale Hwy Ste 4D', 'Beaverton', 'OR', '97005', '5019258258', 'gsage@gmail.com', 3);

INSERT INTO dbo.Rider(RiderId, First_Name, Last_Name, [Address], City, [State], ZipCode, Phone, Email, PaymentID) 
				VALUES(004, 'Gabriella', 'Hernandez', '20 W 64th St Apt 38', 'Salem', 'OR', '01915', '5033565873', 'ghernandez@gabichic.net', 4);

INSERT INTO dbo.Rider(RiderId, First_Name, Last_Name, [Address], City, [State], ZipCode, Phone, Email, PaymentID) 
				VALUES(005, 'Issiah', 'Tunde', '768 SE 86th Ave', 'Portland', 'OR', '97220', '5033726943', 'itunde@yahoo.com', 5);


SET IDENTITY_INSERT Rider OFF;

-------------------------------------   INSERT DATA INTO SCHEDULE  ----------------------------------->

SET IDENTITY_INSERT dbo.Schedule ON;

INSERT INTO dbo.Schedule(ScheduleId, RiderId, Pickup_Location, Dropoff_Location, Pickup_Time, Cost, DriverId, CarId)
			VALUES(0001,002,'768 5th Ave Ste 932','Lloyd Center Mall', '12/3/2018 13:30', 40.00, NULL , '')

INSERT INTO dbo.Schedule(ScheduleId, RiderId, Pickup_Location, Dropoff_Location, Pickup_Time, Cost, DriverId, CarId)
			VALUES(0002,003,'4185 SE 24th Street','200 Beaverton-Hillsdale Hwy Ste 4D', '12/3/2018 17:15', 60.00, NULL , '')

INSERT INTO dbo.Schedule(ScheduleId, RiderId, Pickup_Location, Dropoff_Location, Pickup_Time, Cost, DriverId, CarId)
			VALUES(0003,001,'Oregon Tech','768 5th Ave Ste 300', '12/3/2018 14:30', 40.00, NULL , '')

INSERT INTO dbo.Schedule(ScheduleId, RiderId, Pickup_Location, Dropoff_Location, Pickup_Time, Cost, DriverId, CarId)
			VALUES(0004,005,'Downtown Portland','768 SE 86th Ave', '12/3/2018 16:30', 25.00, NULL , '')

INSERT INTO dbo.Schedule(ScheduleId, RiderId, Pickup_Location, Dropoff_Location, Pickup_Time, Cost, DriverId, CarId)
			VALUES(0005,004,'Oregon Tech','Washington Square', '12/3/2018 18:30', 50.00, NULL , '')

SET IDENTITY_INSERT dbo.Schedule OFF;
GO

-------------------------------------   SELECT DATA FROM ALL TABLES  ----------------------------------->

USE TermProjectDB
GO

SELECT * FROM dbo.PaymentMethod
SELECT * FROM dbo.Rider
SELECT * FROM dbo.Driver
SELECT * FROM dbo.Car
SELECT * FROM dbo.Schedule


-------------------------------------   CREATE STORED PROCEDURES  ----------------------------------->

USE [TermProjectDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_ListRider]    Script Date: 12/4/2018 10:04:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListRider] 
AS
-- =============================================
-- Author:		Christian R
-- Create date: 
-- Description:	
/*
	EXEC [dbo].[sp_ListRider]
*/
-- =============================================

BEGIN

SET NOCOUNT ON;  

SELECT [RiderId]
      ,[First_Name]
      ,[Last_Name]
      ,[Address]
      ,[Email]
      ,[City]
      ,[State]
      ,[ZipCode]
      ,[Phone]
      ,[PaymentId]
FROM [dbo].[Rider]
ORDER BY RiderId

END
GO


USE [TermProjectDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_ListDriver]    Script Date: 12/4/2018 10:04:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListDriver] 
AS
-- =============================================
-- Author:		Christian R
-- Create date: 
-- Description:	
/*
	EXEC [dbo].[sp_ListDriver]
*/
-- =============================================

BEGIN

SET NOCOUNT ON;  

SELECT [DriverId]
      ,[First_Name]
      ,[Last_Name]
      ,[Address]
      ,[City]
      ,[State]
      ,[ZipCode]
      ,[Phone]
      ,[Email]
  FROM [dbo].[Driver]
ORDER BY DriverId

END
GO


USE [TermProjectDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_ListSchedule]    Script Date: 12/4/2018 10:04:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ListSchedule] 
AS
-- =============================================
-- Author:		Christian R
-- Create date: 
-- Description:	
/*
	EXEC [dbo].[sp_ListSchedule]
*/
-- =============================================

BEGIN

SET NOCOUNT ON;  

SELECT [ScheduleId]
      ,[RiderId]
      ,[Pickup_Location]
      ,[Dropoff_Location]
      ,[Pickup_Time]
      ,[Cost]
      ,[DriverId]
      ,[CarId]
  FROM [dbo].[Schedule]
WHERE DriverId IS NULL
ORDER BY ScheduleId

END
GO

-------------------------------------   CREATE STORED PROCEDURES  ----------------------------------->


USE [TermProjectDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertRider]    Script Date: 12/5/2018 3:20:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertRider] 
	@First_Name [varchar](100),
	@Last_Name [varchar](100),
	@Address [varchar](100),
	@City [varchar](100),
	@State [varchar](100),
	@ZipCode [varchar](100),
	@Phone [varchar](100),
	@Email [varchar](100),
	@PaymentID [int]
AS

-- =============================================
-- Author:		Christian R
-- Create date: 
-- Description:	
/*
	EXEC [dbo].[sp_InsertRider] @First_Name='Gary', @Last_Name='Singh', @Address='200 First St', @City='Los Angeles', @State='CA',
		@ZipCode='90058', @Phone='2131157889', @Email='gs@uber.com', @PaymentID=1
*/
-- =============================================

BEGIN

SET NOCOUNT ON;  

declare @RiderID as int

INSERT INTO dbo.Rider(First_Name, Last_Name, [Address], City, [State], ZipCode, Phone, Email, PaymentID) 
				VALUES(@First_Name, @Last_Name, @Address, @City,  @State, @ZipCode, @Phone, @Email, @PaymentID)

SELECT @RiderID = SCOPE_IDENTITY()

END
GO



USE [TermProjectDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertDriver]    Script Date: 12/5/2018 3:30:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertDriver] 
	@First_Name [varchar](50),
	@Last_Name [varchar](50),
	@Address [varchar](100),
	@City [varchar](100),
	@State [varchar](100),
	@ZipCode [varchar](100),
	@Phone [varchar](100),
	@Email [varchar](100)
AS

-- =============================================
-- Author:		Christian R
-- Create date: 
-- Description:	
/*
	EXEC [dbo].[sp_InsertDriver] @First_Name='Gary', @Last_Name='Singh', @Address='200 First St', @City='Los Angeles', @State='CA',
		@ZipCode='90058', @Phone='2131157889', @Email='gs@uber.com'
*/
-- =============================================

BEGIN

SET NOCOUNT ON;  

declare @DriverID as int

INSERT INTO dbo.Driver(First_Name, Last_Name, [Address], City, [State], ZipCode, Phone, Email) 
				VALUES(@First_Name, @Last_Name, @Address, @City,  @State, @ZipCode, @Phone, @Email)

SELECT @DriverID = SCOPE_IDENTITY()

END
GO


USE [TermProjectDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertSchedule] 
	@RiderId [INT],
	@Pickup_Location [varchar](100),
	@Dropoff_Location [varchar](100),
	@Pickup_Time [datetime],
	@Cost [money],
	@DriverId [INT] = NULL ,
	@CarId [int]
AS

-- =============================================
-- Author:		Christian R
-- Create date: 
-- Description:	
/*

	EXEC [dbo].[sp_InsertSchedule] 	@RiderId = 2, @Pickup_Location='768 5th Ave Ste 932', @Dropoff_Location='Lloyd Center Mall', 
		@Pickup_Time='12/3/2018 13:30', @Cost=40.50, @DriverId=NULL, @CarId=''

*/
-- =============================================



BEGIN

SET NOCOUNT ON;  

INSERT INTO dbo.Schedule(RiderId, Pickup_Location, Dropoff_Location, Pickup_Time, Cost, DriverId, CarId)
			VALUES(@RiderId, @Pickup_Location, @Dropoff_Location, @Pickup_Time, @Cost, @DriverId, @CarId)

END
GO

-------------------------------------   EXECUTE STORED PROCEDURES  ----------------------------------->

EXEC [dbo].[sp_ListRider]

EXEC [dbo].[sp_ListDriver]

EXEC [dbo].[sp_ListSchedule]

EXEC [dbo].[sp_InsertRider] @First_Name='Gary', @Last_Name='Singh', @Address='200 First St', @City='Los Angeles', @State='CA',
	@ZipCode='90058', @Phone='2131157889', @Email='gs@uber.com', @PaymentID=1

EXEC [dbo].[sp_InsertDriver] @First_Name='Gary', @Last_Name='Singh', @Address='200 First St', @City='Los Angeles', @State='CA',
	@ZipCode='90058', @Phone='2131157889', @Email='gs@uber.com'

EXEC [dbo].[sp_InsertSchedule] 	@RiderId = 2, @Pickup_Location='768 5th Ave Ste 932', @Dropoff_Location='Lloyd Center Mall', 
	@Pickup_Time='12/3/2018 13:30', @Cost=40.50, @DriverId=NULL, @CarId=''

-------------------------------------   CREATE STORED PROCEDURES  ----------------------------------->

