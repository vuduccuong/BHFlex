alter table DeviceInfos add note nvarchar(300)

select * from Factorys
select * from DeviceInfos

select * from Parts inner join Factorys on Parts.IdFactory = Factorys.Id 
where Factorys.NameFactory = 'BHFlex V1'

sp_rename 'DeviceInfos.idDevice', 'idDeviceType', 'COLUMN';
alter table DeviceInfos add idDevice varchar(30)

select id from TypeDevices where NameDeviceType='PDA 1D'
select Id from TypeDevices where NameDeviceType='Printer Ink'
insert into DeviceInfos(Id,NameDevice,NameUser,nameTypeDeviceInfos,IPAdress,Model,BuyDate,IdDevice,IdPartment,isDelete) values()

select di.nameTypeDeviceInfos , di.IPAdress, di.BuyDate, di.Model,di.note, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id inner join Parts p on pt.IdPart = p.Id inner join Factorys fa on p.IdFactory = fa.Id inner join Locations lc on fa.IdLocation = lc.Id where di.NameDevice='"PDA 1D"' and di.isDelete='0'

insert into DeviceInfos(id,nameTypeDeviceInfos,NameDevice,IPAdress,Model,BuyDate,Note,IdDevice,IdPartment,isDelete) values('test','afafasf','PDA 1D','168.158.165.145','Sam Sung',07/03/2019,'note','a42f2f12-2431-45af-97b6-358abdf31ba6','a3bd5125-bcf2-454f-92a9-befa1f877990','0')

--drop table DeviceInfos
Create table DeviceInfos
(
Id int identity(1,3) primary key NOT NULL, --Guid
nameTypeDeviceInfos nvarchar(100),
NameDevice nvarchar(255) NOT NULL,
NameUser nvarchar(200),
idDevice varchar(100), -- Ma so Devices == nameTypeDeviceInfos (hơi thừa)
MACAdress varchar(30), --Dia chi MAC
IPAdress varchar(15), -- Dia chi IP
Model varchar(max), -- Loai may: Dell, Samsung
NameGroup nvarchar(200) default N'WORK GROUP',
CPU varchar(200),
RAM varchar(200),
HDD varchar(200),
OS varchar(200), -- He dieu hanh
SoftWare nvarchar(max),
BuyDate datetime,
IdPartment varchar(100) NOT NULL,
IdDeviceType varchar(100) NOT NULL, --Thiet bi thuoc phong nao
CreateBy nvarchar(255) default N'admin',
CreateDate datetime,
UpdateBy nvarchar(255) default N'admin',
UpdateDate datetime,
Note nvarchar(200),
isDelete bit,
)

select * from DeviceInfos

update DeviceInfos set id='',NameDevice='', IPAdress='',Model='',BuyDate='',IdPartment='' where nameTypeDeviceInfos=''