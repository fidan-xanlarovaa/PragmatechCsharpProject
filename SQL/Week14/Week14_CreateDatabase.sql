create database NewDatabase

use [NewDatabase]

create table [User](
Id int primary key identity,
[Name] nvarchar(50),
SurName nvarchar(50)
)

create table Document(
Id int primary key identity,
Title nvarchar(50),
[Description] nvarchar(50),
CreateById int,
RecordDate datetime,
DocumentLevelId int,
Constraint FK_User_Document foreign key (CreateById) References [User](id),
Constraint FK_DocumentLevels_Document foreign key (DocumentLevelId) References [DocumentLevels](Id)
)

create table [File](
Id int primary key identity,
[FileName] nvarchar(50),
[FileUrl] nvarchar(50),
DocumentId  int,
Constraint FK_Document_File foreign key (DocumentId ) References [Document](Id)
)

create table DocumentLevels(
Id int primary key identity,
[Name] nvarchar(50),
UserId int,
[Order] int,
Constraint FK_User_DocumentLevels Foreign key(userid) References [User](id)
)

create table DocumentComment(
Id int primary key identity,
Comment nvarchar(50),
CreateById int,
DocumentId int,
Constraint FK_User_DocumentComment foreign key (CreateById) References [User](id),
Constraint FK_Document_DocumentComment foreign key (DocumentId ) References [Document](Id)
)

create table DocumentHistory(
Id int primary key identity,
CreateById int,
DocumentId int,
OldDocumentLevelId int,
NewDocumentLevelId int,
Constraint FK_User_DocumentHistory foreign key (CreateById) References [User](id),
Constraint FK_Document_DocumentHistory foreign key (DocumentId ) References [Document](Id),
Constraint FK_DocumentLevels_DocumentHistory1 foreign key (NewDocumentLevelId) References [DocumentLevels](Id),
Constraint FK_DocumentLevels_DocumentHistory2 foreign key (OldDocumentLevelId) References [DocumentLevels](Id)
)

create table [Status](
Id int primary key identity,
[Name] nvarchar(50)
)

create table DocumentApprovalRequest(
Id int primary key identity,
CreateById int,
UpdateByID int,
DocumentId int,
StatusId int,
DocumentLevelId int,
Constraint FK_User_DocumentApprovalRequest foreign key (CreateById) References [User](id),
Constraint FK_User_DocumentApprovalRequest2 foreign key (UpdateById) References [User](id),
Constraint FK_Document_DocumentApprovalRequest foreign key (DocumentId ) References [Document](Id),
Constraint FK_Status_DocumentApprovalRequest foreign key (StatusId) References [Status](Id),
Constraint FK_DocumentLevels_DocumentApprovalRequest foreign key (DocumentLevelId) References [DocumentLevels](Id)
)


