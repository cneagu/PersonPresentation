CREATE DATABASE PersonPresentation_DB;
USE PersonPresentation_DB;

CREATE TABLE Persons(
CNP nvarchar(13) NOT NULL,
FirstName nvarchar(30) NOT NULL,
LastName nvarchar(120) NOT NULL,
Birth datetime NOT NULL,
Age int,
Sex nvarchar(3),
CONSTRAINT PK_Persons PRIMARY KEY (CNP)
);

CREATE TABLE Address(
CNP nvarchar(13) NOT NULL,
Country nvarchar(30) NOT NULL,
County nvarchar(30) NOT NULL,
City nvarchar(80) NOT NULL,
PostalCode int,
CONSTRAINT PK_Address PRIMARY KEY (CNP),
CONSTRAINT FK_Persons_Address FOREIGN KEY (CNP)
	REFERENCES Persons (CNP) ON DELETE CASCADE
);