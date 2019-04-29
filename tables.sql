DROP TABLE Interviews;
DROP TABLE "Applications";
DROP TABLE "jobs";
DROP TABLE "User";



CREATE TABLE "User" (
	ID int NOT NULL IDENTITY PRIMARY KEY,
	role varchar(50),
	firstName  varchar(50),
	lastName varchar(50),
	username varchar(50),
	email varchar(255),
	password  varchar(100),
	securityQuestion  varchar(100),
	securityAnswer  varchar(100),
);

CREATE TABLE "Jobs" (
	ID int NOT NULL IDENTITY PRIMARY KEY,
	title varchar(500),
	"description" varchar(500),
	designation varchar(50),
	skills varchar(500),
	"location" varchar(50),
	department varchar(50),
	minEducation varchar(50),
	minExperience int,
	minAge int,
	maxAge int,
	gender varchar(50),
	closingDate DateTime,
	salary int,
	benefits varchar(50),
	document varchar(50),
	status varchar(50),
);


CREATE TABLE "Applications" (
	ID int NOT NULL IDENTITY PRIMARY KEY,
	userID int,
	jobID int,
	appliedAt DateTime DEFAULT GETDATE(),
	FOREIGN KEY (userID) REFERENCES "User"(ID),
	FOREIGN KEY (jobID) REFERENCES "Jobs"(ID)
);

CREATE TABLE "Interviews" (
	ID int NOT NULL IDENTITY PRIMARY KEY,
	userID int,
	jobID int,
	scheduledTime DATETIME,
	happendTime DATETIME,
	FOREIGN KEY (userID) REFERENCES "User"(ID),
	FOREIGN KEY (jobID) REFERENCES "Jobs"(ID)
);


INSERT INTO "User" (
	firstName,
	lastName,
	username,
	email,
	password,
	securityQuestion,
	securityAnswer
	) VALUES (
	'Ahmed',
	'Pervaiz',
	'asherk',
	'asherk@gmail.com',
	'sadsasadssadasdsadasd',
	'noQuestion',
	'npAnswer'
	);