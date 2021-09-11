/*
Techizat:

1 Create Document 
- Document yaradilarken uygun sutunlara data insert edilmeli, file elave edilibse file cedveline insertde 
aparilmalidir. DocLevelId doc create edilerken verilir (order-i 1 olan level)
evvelceden yaradilan docLeveller orderlere uygun nomrelenmeli ve user cedveline bir nece ferqli ad soyad username passa sahib
userler elave edilmelidir. elave edilen userler ozude Her biri bir levele mesul sexs olaraq teyin edilecek.*/


use NewDatabase

select * from Document
select * from DocumentLevels
select * from [File]
select * from  [Status]
select * from  [User]
select * from DocumentComment
select * from DocumentHistory

/*Task1
GetAllDocument proc yaradilmalidir, Sened Yaradilarken hansi user createbyId olaraq elave edilibse 
sadece onun senedleri gosterilir*/

create proc GetAllDocument
(@userid int)
as
begin
select * from Document where CreateById=@userid
end

exec GetAllDocument @userid=2


/*Task2
WaitingDocument Proc yaradilmalidir Senedin hazirki levelinde mesul user kimdirse sadece ona uygun senedler getirilir.*/

create proc WaitingDocument
(@levelid int)
as
begin
declare @userid int
select @userid= Userid from DocumentLevels where id=@levelid 
select * from Document where CreateById= @userid
end

exec WaitingDocument @levelid=2


/*Task3 -- burda ne etmeli olduqumu anlamadim
qeyd : Sql week 14 icersinde screenshotlara nezer yetirin orada cedvellerde hansi datalar gosterilmelidir suutunlara baxin.

1.a Userlerin insert edilmesi
    CreateById yeni bu emeliyyati hansi user yerine yetiribse onun idsini menimsedmek ucun istifade edilir.
    Buna gorede evvelceden cedvele insert edilen userleri dinamik sekilde hansi cedvelde creatBy varsa ora assign ede bilmelisiz,
    GetCurrentUser func yaradaraq username ve passworda uygun eger dbda varsa onun idsin geri donderib istifade ede bilersiz createBylar ucun*/
	
	select * from User 
/*Task 4
1.b Doc levellerin insert edilmesi
  - doclevelelleri getiren view yaradilmalidir.
  - doclevelId
  - Name
  - UserId
  - Username*/

  create view vw_DocLevel as select 
  l.Id,
  l.Name as DocLevel,
  u.Name as userName,
  u.SurName as userSurName from DocumentLevels l 
  inner join [User] u on l.UserId=u.Id

  select * from vw_DocLevel


/*Task 5
	1.b.a Doc level ucun mesul userin update edilmesi 
    verilen username esasen dbdan user tapilir ve yeni responseUseridye assign edilir.*/

	create proc UpdateUser(@username nvarchar(50),@newusername nvarchar(50),@newusersurname nvarchar(50))
	as 
	begin
	declare @id int
	select @id=id from [User] where [name]=@username
	update [User]
	set [name]=@newusername,surname=@newusersurname
	where id=@id
	end

	exec  UpdateUser @username='Aysu',@newusername='Ali',@newusersurname='Aliyev'
	select * from vw_DocLevel
	

/*Task 6
1.c Document Get By Id proc*/

  create proc DocumentGetById(@id int)
  as
  begin
  select * from Document where id=@id
  end

  exec DocumentGetById @id=5


/*Task7
1.d Document Comment Create proc*/

	create proc CommentCreate(@comment nvarchar(300),@userid int,@documentid int)
	as
	begin
	insert into DocumentComment(comment,createbyid,documentid) values (@comment,@userid,@documentid)
	end

	exec CommentCreate @comment='sugheklrwghnwkjbndfksjbhieur',@userid=1,@documentid=1
	select * from DocumentComment


/*Task8
1.e GetAllDocumentCommentByDocId proc 
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


/*Task9
1.f CreateDocumentApprovalRequest proc 
    User documenti ya approve edir ya reject edir,
    her iki emeliyyatdada idye gore document tapilir, documentin hazirki docLevelIdsine gore current Level tapilir
    approve olarsa current levelin order + 1 yeni next level tapilir,
    reject olarse current levelin order - 1 yen prev levele tapilir - eger current level ozu ele 1 deyilse 

    tapilan evvelki ve ya novbeti levelId docLevelId-ye menimsedilir doc update olur 
    her bir halda DocApprovalRequest  ve DocHistory cedveline insert emeliyyati apariliacaq.*/
	
	create proc  DocumentApprovalRequestt(@id int)
	as
	begin 

	declare @level int
	select @level=DocumentLevelId from Document where id=@id

	declare @order int
	select @order=[order] from DocumentLevels where id=@level

	declare @newlevel int

	if @order=0
	begin
	
	if @level-1>1
	begin
	update Document
	set DocumentLevelId=@level-1
	where id=@id
	set @newlevel=@level-1
	end

	else
	begin
	update Document
    set DocumentLevelId=1
	where id=@id
	set @newlevel=1
	end	

	end

	else
	begin

	if @level<=3 or @level=8 or @level=9 
	begin
	update Document
	set DocumentLevelId=@level+1
	set @newlevel=@level+1
	end

	if @level=4
	begin
	update Document
	set DocumentLevelId=8
	set @newlevel=8
	end

	if @level=10
	begin
	update Document
	set DocumentLevelId=10
	set @newlevel=10
	end

	end

	declare @creater int
	select @creater= CreateById from Document where id=@id

	declare @updater int
	select @updater=UserId from DocumentLevels where id=@level

	insert into DocumentApprovalRequest(CreateById,[UpdateByID],[DocumentId],[DocumentLevelId]) 
	values (@creater,@updater,@id,@newlevel)

	insert into DocumentHistory([CreateById]
           ,[DocumentId]
           ,[OldDocumentLevelId]
           ,[NewDocumentLevelId])
     values (@id,@updater,@level,@newlevel)

	 end

	 select * from Document where id =3
	 exec DocumentApprovalRequestt @id=3
	 select * from DocumentHistory
	 select * from DocumentApprovalRequest
	 select * from Document where id =3


/*Task10
1.g GetAllHistoryByDocId proc*/

    create proc  GetAllHistoryByDocId(@id int)
	as
	begin
	select * from DocumentHistory where DocumentId=@id
	end

    exec  GetAllHistoryByDocId @id=1

/*Task 11
Umumi insert , delete , update emeliyyatlarindan sonra trigger islemeli ve elave edilen , redakte edilen ve ya silinen setr gosterilmelidir.*/


