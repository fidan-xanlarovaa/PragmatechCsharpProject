/*Techizat:

1 Create Document 
- Document yaradilarken uygun sutunlara data insert edilmeli, file elave edilibse file cedveline insertde 
aparilmalidir. DocLevelId doc create edilerken verilir (order-i 1 olan level)
evvelceden yaradilan docLeveller orderlere uygun nomrelenmeli ve user cedveline bir nece ferqli ad soyad username passa sahib
userler elave edilmelidir. elave edilen userler ozude Her biri bir levele mesul sexs olaraq teyin edilecek.*/

use DocumentApprovalDatabase

create function LoginUser(@username nvarchar(50),@password  nvarchar(50))
returns int  --id geri qaytarmali olduqu ucun
as

begin
declare @userid int
if ( exists(select * from [User] where Username=@username and [Password]=@password  ))
begin
select @userid=id from [User] where Username=@username and [Password]=@password 
end

else
begin
set @userid=0
end

return @userid
end

select dbo.LoginUser('f.x','123')


/*GetAllDocument proc yaradilmalidir, Sened Yaradilarken hansi user createbyId olaraq elave edilibse 
sadece onun senedleri gosterilir*/

create proc GetAllDocument --burda yalnizca hemin userin create etdiyi senedler gosterilir
(@userid int)
as
begin
select * from Document where CreateById=@userid
end

declare @userid int
select @userid=dbo.LoginUser('f.x','123')
exec GetAllDocument @userid=@userid


/*WaitingDocument Proc yaradilmalidir Senedin hazirki levelinde mesul user kimdirse sadece ona uygun senedler getirilir.
qeyd : Sql week 14 icersinde screenshotlara nezer yetirin orada cedvellerde hansi datalar gosterilmelidir suutunlara baxin.*/

create proc WaitingDocument(@userid int) --burda ise create elediyi yox responsible olduqu senedler getirilir where hissesine DIQQET
as
begin
select * from Document d inner join DocumentLevels l on l.Id=d.DocumentLevelId where l.UserId=@userid 
end

declare @userid int
select @userid=dbo.LoginUser('f.x','123')
exec WaitingDocument @userid=@userid


/*1.a Userlerin insert edilmesi
    CreateById yeni bu emeliyyati hansi user yerine yetiribse onun idsini menimsedmek ucun istifade edilir.
    Buna gorede evvelceden cedvele insert edilen userleri dinamik sekilde hansi cedvelde creatBy varsa ora assign ede bilmelisiz,
    GetCurrentUser func yaradaraq username ve passworda uygun eger dbda varsa onun idsin geri donderib istifade ede bilersiz createBylar ucun*/

	create proc InsertUser(@name nvarchar(50), @surname nvarchar(50),@username nvarchar(50),@password nvarchar(50))
	as
	begin
	insert into [User](name,surname,username,[password]) values(@name,@surname,@username,@password)
	end

	exec InsertUser @name='aa',@surname='aa',@username='aa',@password='aa'
	select*from [User]


/*1.b Doc levellerin insert edilmesi
  - doclevelelleri getiren view yaradilmalidir.
  - doclevelId
  - Name
  - UserId
  - Username*/

  create proc InsertDocLevel(@name nvarchar(50),@userid int,@order int)
  as
  begin
  insert into DocumentLevels values(@name ,@userid ,@order)
  end
  
  exec InsertDocLevel @name='bbb' ,@userid=8 ,@order=8
  select*from DocumentLevels

  create view vw_DocLevel as select 
  l.Id,
  l.Name as DocLevel,
  u.Name as userName,
  u.SurName as userSurName from DocumentLevels l 
  inner join [User] u on l.UserId=u.Id

  select * from vw_DocLevel


  /*1.b.a Doc level ucun mesul userin update edilmesi 
    verilen username esasen dbdan user tapilir ve yeni responseUseridye assign edilir.*/

	create proc UpdateResponsibleUser(@levelid int,@username nvarchar(50))
	as
	begin
	declare @userid int
	select @userid=id from [User] where username=@username
	Update DocumentLevels
	set userid=@userid where id= @levelid
	end

	exec UpdateResponsibleUser @levelid=9 ,@username='f.x'
	select * from DocumentLevels
	select *from [User]


/*1.c Document Get By Id proc*/

	create proc DocumentGetById(@id int)
    as
    begin
    select * from Document where id=@id
    end

    exec DocumentGetById @id=5


/*1.d Document Comment Create proc*/

    create proc CommentCreate(@comment nvarchar(300),@userid int,@documentid int)
	as
	begin
	insert into DocumentComment(comment,createbyid,documentid) values (@comment,@userid,@documentid)
	end

	exec CommentCreate @comment='sugheklrwghnwkjbndfksjbhieur',@userid=1,@documentid=1
	select * from DocumentComment


/*1.e GetAllDocumentCommentByDocId proc 
    Username
    Comment
    Date*/

	create proc  GetAllDocumentCommentByDocId(@id int)
	as
	begin
	select c.id, c.Comment, u.Name as UserName, d.RecordDate as DocumentRecordDate from DocumentComment c 
	inner join [User] u on u.Id=c.CreateById
	inner join [Document] d on c.DocumentId=d.id
	where c.DocumentId=@id
	end
	
	exec GetAllDocumentCommentByDocId @id=1


/*1.f CreateDocumentApprovalRequest proc 
    User documenti ya approve edir ya reject edir,
    her iki emeliyyatdada idye gore document tapilir, documentin hazirki docLevelIdsine gore current Level tapilir
    approve olarsa current levelin order + 1 yeni next level tapilir,
    reject olarse current levelin order - 1 yen prev levele tapilir - eger current level ozu ele 1 deyilse 

    tapilan evvelki ve ya novbeti levelId docLevelId-ye menimsedilir doc update olur 
    her bir halda DocApprovalRequest  ve DocHistory cedveline insert emeliyyati apariliacaq. 

	exists docu yoxla
	funksiyalara ayir
	statusu yoxla*/


	create proc CreateDocumentApprovalRequest(@documentid int,@Answerofuser nvarchar(50))
	as
	begin

	if (exists(select * from Document where id=@documentid))
	begin

	--find current level order
	declare @currentorder int
	select @currentorder=dbo.FindCurrentLevel(@documentid)

	if(@Answerofuser='approve')
	begin

	declare @neworder int
	declare @statusid int
	set @statusid=1

	if @currentorder+1<7
	begin
	set @neworder=@currentorder+1
	end

	else
	begin
	set @neworder=7
	end

	end

	if(@Answerofuser='reject')
	begin
	set @statusid=2

	if (@currentorder-1>1)
	begin
	set @neworder=@currentorder-1
	end

	else
	begin
	set @neworder=1
	end
	
	end

	begin transaction
	exec UpdateDocumentLevel @documentid= @documentid ,@levelorder=@neworder
	exec DocumentHistoryInsert @documentid=@documentid ,@new=@neworder,@old=@currentorder
	
	exec DocumentApprovalRequestInsert @documentid=@documentid,@new=@neworder,@statusid=@statusid

	commit transaction

	end

	else
	begin
	print 'bele document movcud deyil'
	end

	end

	
	CreateDocumentApprovalRequest @documentid=1 ,@Answerofuser='approve'

	select * from Document
	select * from DocumentHistory
	select * from DocumentApprovalRequest
	

	--find current level

	create function FindCurrentLevel(@documentid int)
	returns int
	as
	begin
	declare @order int
	select @order= l.[Order] from Document d inner join DocumentLevels l on l.Id=d.DocumentLevelId
	return @order
	end

	--update document

	create proc UpdateDocumentLevel(@documentid int,@levelorder int)
	as
	begin
	update Document
	set DocumentLevelId=@levelorder where id=@documentid
	end

	-- insert DocumentApprovalRequest

	create proc DocumentApprovalRequestInsert(@documentid int,@new int,@statusid int)
	as
	begin
	declare @creater int
	select @creater= CreateById from Document where id=@documentid

	declare @updater int
	select @updater=UserId from DocumentLevels where id=@new

	insert into DocumentApprovalRequest(CreateById,[UpdateByID],[DocumentId],[DocumentLevelId],StatusId) 
	values (@creater,@updater,@documentid,@new,@statusid)
	end


	-- insert DocumentHistory

	create proc DocumentHistoryInsert(@documentid int,@new int,@old int)
	as
	begin
	
	declare @creater int
	select @creater= CreateById from Document where id=@documentid

	insert into DocumentHistory([CreateById],[DocumentId],[OldDocumentLevelId],[NewDocumentLevelId])values (@documentid,@creater,@old,@new)
	end

	

/*1.g GetAllHistoryByDocId proc */

	
    create proc  GetAllHistoryByDocId(@id int)
	as
	begin
	select * from DocumentHistory where DocumentId=@id
	end

    exec  GetAllHistoryByDocId @id=1



/*Umumi insert , delete , update emeliyyatlarindan sonra trigger islemeli ve elave edilen , redakte edilen ve ya silinen setr gosterilmelidir.*/

-- for Document
use documentApprovalDatabase
create trigger UpdateDocument 
on Document
after update
as begin 
select * from deleted
select * from inserted
end

create trigger InsertDocument 
on Document
after insert
as begin 
select * from inserted
end

create trigger DeleteDocument 
on Document
after delete
as begin 
select * from deleted
end


-- for DocumentApprovalRequest

create trigger UpdateDocumentApprovalRequest
on DocumentApprovalRequest
after update
as begin 
select * from deleted
select * from inserted
end

create trigger InsertDocumentApprovalRequest
on DocumentApprovalRequest
after insert
as begin 
select * from inserted
end

create trigger DeleteDocumentApprovalRequest
on DocumentApprovalRequest
after delete
as begin 
select * from deleted
end


--for DocumentComment

create trigger UpdateDocumentComment
on DocumentComment
after update
as begin 
select * from deleted
select * from inserted
end

create trigger InsertDocumentComment
on DocumentComment
after insert
as begin 
select * from inserted
end

create trigger DeleteDocumentComment 
on DocumentComment
after delete
as begin 
select * from deleted
end


-- for DocumentHistory

create trigger UpdateDocumentHistory
on DocumentHistory
after update
as begin 
select * from deleted
select * from inserted
end

create trigger InsertDocumentHistory 
on DocumentHistory
after insert
as begin 
select * from inserted
end

create trigger DeleteDocumentHistory 
on DocumentHistory
after delete
as begin 
select * from deleted
end


-- for DocumentLevels

create trigger UpdateDocumentLevels
on DocumentLevels
after update
as begin 
select * from deleted
select * from inserted
end

create trigger InsertDocumentLevels 
on DocumentLevels
after insert
as begin 
select * from inserted
end

create trigger DeleteDocumentLevels
on DocumentLevels
after delete
as begin 
select * from deleted
end


--for File

create trigger UpdateFile
on [File]
after update
as
begin
select * from deleted 
select * from inserted
end

create trigger InsertFile
on [File]
after insert
as
begin 
select * from inserted
end

create trigger DeleteFile
on [File]
after delete
as
begin
select * from deleted
end



--for User

create trigger UpdateUser
on [User]
after update
as
begin
select * from deleted 
select * from inserted
end

create trigger InsertUser
on [User]
after insert
as
begin 
select * from inserted
end

create trigger DeleteUser
on [User]
after delete
as
begin
select * from deleted
end


--for Status

create trigger UpdateStatus
on [Status]
after update
as
begin
select * from deleted 
select * from inserted
end

create trigger InsertStatus
on [Status]
after insert
as
begin 
select * from inserted
end

create trigger DeleteStatus
on [Status]
after delete
as
begin
select * from deleted
end






