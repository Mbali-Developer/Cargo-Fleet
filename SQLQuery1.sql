CREATE TABLE LOGIN(
EmpNum varchar(10) NOT NULL PRIMARY KEY,
EmpName varchar(50) NOT NULL,
Position varchar(50) NOT NULL,
Email varchar(50) NOT NULL,
Username varchar(50) NOT NULL,
UPassword varchar(50) NOT NULL)


CREATE TABLE VEHICLEINFO(
LicPlateNum varchar(25) NOT NULL PRIMARY KEY,
ModelMake varchar(50) NOT NULL,
Configure varchar(50) NOT NULL,
Bodytype varchar(50) NOT NULL,
Manufacturer varchar(50) NOT NULL,
RegistrationNum varchar(50) NOT NULL,
EngineSize varchar(50) NOT NULL,
Tank varchar(50) NOT NULL,
Numoftyres varchar(10) NOT NULL,
ODOcur varchar(25) NOT NULL,
ODOnext varchar(25) NOT NULL)

CREATE TABLE SCHEDULETRIP(
VehNum varchar(5) NOT NULL PRIMARY KEY,
AppointmentDate date NOT NULL,
ProcedureCode varchar(25) NOT NULL,
Description varchar(50) NOT NULL,
Configure varchar(50) NOT NULL,
Bodytype varchar(50) NOT NULL,
Destination varchar(50) NOT NULL,
Fuelusage varchar(25) NOT NULL,
TimeTravelled time NOT NULL)

CREATE TABLE VEHSERVICES(
VehNum varchar(5) NOT NULL PRIMARY KEY FOREIGN KEY REFERENCES SCHEDULETRIP(VehNum),
Servicetype varchar (25) NOT NULL,
AppointDate date NOT NULL,
DescripService varchar(50) NOT NULL)