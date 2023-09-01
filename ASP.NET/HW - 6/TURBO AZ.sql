 Use TURBO_AZ



CREATE TABLE Showrooms
(
    [id]          int PRIMARY KEY IDENTITY (1,1),
    [Name]        nvarchar(20) ,
    [Address]     nvarchar(20),
    [PhoneNumber] nvarchar(20)
)
go
INSERT INTO Showrooms(Name,Address,PhoneNumber) VALUES('smth','smth','smth1')
SELECT * FROM Showrooms

------------------------------------------------------

CREATE TABLE BodyTypes
(
    [id]          int PRIMARY KEY IDENTITY (1,1),
    [Type]        nvarchar(20) 
)
go
INSERT INTO BodyTypes(Type) VALUES('smth1')
SELECT * FROM BodyTypes

------------------------------------------------------

CREATE TABLE Cities
(
    [id]          int PRIMARY KEY IDENTITY (1,1),
    [City]        nvarchar(20) 
)
go
INSERT INTO Cities([City]) VALUES('Baku1')
SELECT * FROM Cities

-----------------------------------------------------

CREATE TABLE Colors
(
    [id]          int PRIMARY KEY IDENTITY (1,1),
    [Color]        nvarchar(20) 
) 
go
INSERT INTO Colors(Color) VALUES('smth1')
SELECT * FROM Colors

-----------------------------------------------------

CREATE TABLE WheelDriveTypes
(
    [id]          int PRIMARY KEY IDENTITY (1,1),
    [Type]        nvarchar(20) 
)
go
INSERT INTO WheelDriveTypes(Type) VALUES('smth1')
SELECT * FROM WheelDriveTypes

-----------------------------------------------------

CREATE TABLE FuelTypes
(
    [id]          int PRIMARY KEY IDENTITY (1,1),
    [Type]        nvarchar(20) 
)
go
INSERT INTO FuelTypes(Type) VALUES('smth1')
SELECT * FROM FuelTypes

-----------------------------------------------------

CREATE TABLE TransmissionTypes
(
    [id]          int PRIMARY KEY IDENTITY (1,1),
    [Type]        nvarchar(20) 
)
go
INSERT INTO TransmissionTypes(Type) VALUES('smth1')
SELECT * FROM TransmissionTypes

------------------------------------------------------

CREATE TABLE Cars
(
    [id]                int PRIMARY KEY IDENTITY (1,1),
    [Make]              nvarchar(20) NOT NULL,
    [Model]             nvarchar(20) NOT NULL,
    [Year]              date NOT NULL,
    [VIN]               nvarchar(20) NOT NULL,
    [Mileage]           int NOT NULL,
    [EngineVolume]      int NOT NULL,
    [HorsePower]        int NOT NULL,
    [PassengerCount]    int NOT NULL,
    [Price]             money NOT NULL,
    [PhoneNumber]       nvarchar(20) NOT NULL,
    [ShowRoomId]        int NOT NULL foreign key references Showrooms(id),
    [BodyTypeId]        int NOT NULL foreign key references BodyTypes(id),
    [CityId]            int NOT NULL foreign key references Cities(id),
    [ColorId]           int NOT NULL foreign key references Colors(id),
    [WheelDriveTypeId]  int NOT NULL foreign key references WheelDriveTypes(id),
    [FuelTypeId]        int NOT NULL foreign key references FuelTypes(id),
    [TransmissionTypeId]int NOT NULL foreign key references TransmissionTypes(id),
)
go
INSERT INTO Cars(Make,Model,Year,VIN,Mileage,EngineVolume,HorsePower,PassengerCount,Price,PhoneNumber,ShowRoomId,BodyTypeId,CityId,ColorId,WheelDriveTypeId,FuelTypeId,TransmissionTypeId) VALUES('smth1','smth2','12.12.2023','smth1',121,222,333,444,3333,'smthP',1,1,1,1,1,1,1)
SELECT * FROM Cars