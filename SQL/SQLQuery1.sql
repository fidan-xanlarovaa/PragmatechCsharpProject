create Database PhoneBook

use PhoneBook

create table Contact(
id uniqueidentifier primary key ,
[Name] nvarchar(50),
[Surame] nvarchar(50),
[Number1] nvarchar(50),
[Number2] nvarchar(50),
[Number3] nvarchar(50),
[Description] nvarchar(500),
[Address] nvarchar(50),
[Website] nvarchar(50),
[Email] nvarchar(50)

)


create table [User](
id uniqueidentifier primary key ,
Username  nvarchar(50) unique not null,
[Password] nvarchar(50) not null
)