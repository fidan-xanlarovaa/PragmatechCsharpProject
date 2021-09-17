create database DocumentApprovalDatabase

use [DocumentApprovalDatabase]

create table [User](
Id int primary key identity,
[Name] nvarchar(50) not null,
SurName nvarchar(50) not null,
Username nvarchar(50) not null,
[Password] nvarchar(50) not null
)

create table Document(
Id int primary key identity,
Title nvarchar(50) not null,
[Description] nvarchar(50) not null,
CreateById int not null,
RecordDate datetime default getdate() not null,
DocumentLevelId int not null,
Constraint FK_User_Document foreign key (CreateById) References [User](id),
Constraint FK_DocumentLevels_Document foreign key (DocumentLevelId) References [DocumentLevels](Id)
)

create table [File](
Id int primary key identity,
[FileName] nvarchar(50) not null,
[FileUrl] nvarchar(50) not null,
DocumentId  int not null,
Constraint FK_Document_File foreign key (DocumentId ) References [Document](Id)
)

create table DocumentLevels(
Id int primary key identity,
[Name] nvarchar(50) not null,
UserId int not null,
[Order] int not null,
Constraint FK_User_DocumentLevels Foreign key(userid) References [User](id)
)

create table DocumentComment(
Id int primary key identity,
Comment nvarchar(50) not null,
CreateById int not null,
DocumentId int not null,
Constraint FK_User_DocumentComment foreign key (CreateById) References [User](id) ,
Constraint FK_Document_DocumentComment foreign key (DocumentId ) References [Document](Id)
)

create table DocumentHistory(
Id int primary key identity,
CreateById int not null,
DocumentId int not null,
OldDocumentLevelId int not null,
NewDocumentLevelId int not null,
Constraint FK_User_DocumentHistory foreign key (CreateById) References [User](id),
Constraint FK_Document_DocumentHistory foreign key (DocumentId ) References [Document](Id),
Constraint FK_DocumentLevels_DocumentHistory1 foreign key (NewDocumentLevelId) References [DocumentLevels](Id),
Constraint FK_DocumentLevels_DocumentHistory2 foreign key (OldDocumentLevelId) References [DocumentLevels](Id)
)

create table [Status](
Id int primary key identity,
[Name] nvarchar(50) not null
)

create table DocumentApprovalRequest(
Id int primary key identity,
CreateById int not null,
UpdateByID int not null,
DocumentId int not null,
StatusId int not null,
DocumentLevelId int not null,
Constraint FK_User_DocumentApprovalRequest foreign key (CreateById) References [User](id),
Constraint FK_User_DocumentApprovalRequest2 foreign key (UpdateById) References [User](id),
Constraint FK_Document_DocumentApprovalRequest foreign key (DocumentId ) References [Document](Id),
Constraint FK_Status_DocumentApprovalRequest foreign key (StatusId) References [Status](Id),
Constraint FK_DocumentLevels_DocumentApprovalRequest foreign key (DocumentLevelId) References [DocumentLevels](Id)
)


