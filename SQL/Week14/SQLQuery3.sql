/*Techizat:

1 Create Document 
- Document yaradilarken uygun sutunlara data insert edilmeli, file elave edilibse file cedveline insertde 
aparilmalidir. DocLevelId doc create edilerken verilir (order-i 1 olan level)
evvelceden yaradilan docLeveller orderlere uygun nomrelenmeli ve user cedveline bir nece ferqli ad soyad username passa sahib
userler elave edilmelidir. elave edilen userler ozude Her biri bir levele mesul sexs olaraq teyin edilecek.*/

/*


GetAllDocument proc yaradilmalidir, Sened Yaradilarken hansi user createbyId olaraq elave edilibse 
sadece onun senedleri gosterilir

WaitingDocument Proc yaradilmalidir Senedin hazirki levelinde mesul user kimdirse sadece ona uygun senedler getirilir.


qeyd : Sql week 14 icersinde screenshotlara nezer yetirin orada cedvellerde hansi datalar gosterilmelidir suutunlara baxin.

1.a Userlerin insert edilmesi
    CreateById yeni bu emeliyyati hansi user yerine yetiribse onun idsini menimsedmek ucun istifade edilir.
    Buna gorede evvelceden cedvele insert edilen userleri dinamik sekilde hansi cedvelde creatBy varsa ora assign ede bilmelisiz,
    GetCurrentUser func yaradaraq username ve passworda uygun eger dbda varsa onun idsin geri donderib istifade ede bilersiz createBylar ucun
1.b Doc levellerin insert edilmesi
  - doclevelelleri getiren view yaradilmalidir.
  - doclevelId
  - Name
  - UserId
  - Username
  1.b.a Doc level ucun mesul userin update edilmesi 
    verilen username esasen dbdan user tapilir ve yeni responseUseridye assign edilir.
1.c Document Get By Id proc
1.d Document Comment Create proc 
1.e GetAllDocumentCommentByDocId proc 
    Username
    Comment
    Date
1.f CreateDocumentApprovalRequest proc 
    User documenti ya approve edir ya reject edir,
    her iki emeliyyatdada idye gore document tapilir, documentin hazirki docLevelIdsine gore current Level tapilir
    approve olarsa current levelin order + 1 yeni next level tapilir,
    reject olarse current levelin order - 1 yen prev levele tapilir - eger current level ozu ele 1 deyilse 

    tapilan evvelki ve ya novbeti levelId docLevelId-ye menimsedilir doc update olur 
    her bir halda DocApprovalRequest  ve DocHistory cedveline insert emeliyyati apariliacaq. 
1.g GetAllHistoryByDocId proc 


Umumi insert , delete , update emeliyyatlarindan sonra trigger islemeli ve elave edilen , redakte edilen ve ya silinen setr gosterilmelidir.*/