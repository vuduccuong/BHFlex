select Id from TypeDevices where NameDeviceType=

--Mỗi khu vực (VN, KR, JP, CN) có các nhà máy (BHFlex, DKT,..) Mỗi nhà máy có các bộ phận
--Mỗi bộ phận có các phòng ban
--Mỗi phòng có các loại thiết bị
--Mỗi loại thiết bị có nhiều thiết bị
--Mỗi thiết bị được giao cho 1 người sử dụng và có thông số cho trước
　
Create table Locations
(
Id varchar(100) primary key NOT NULL, --Guid
NameLocation nvarchar(255), --VietNamese, Korea
CodeLocation varchar(255), -- VN, KR
CreateBy nvarchar(255) default N'admin',
CreateDate datetime,
UpdateBy nvarchar(255) default N'admin',
UpdateDate datetime,
isDelete bit,
)
select * from Locations-- where NameLocation ='Chine';

delete from Locations where Id = 'Chi'

select * from Factorys where IdLocation = '181b7277-f1f0-405a-8d79-df3c4fc1e66a'

insert into Locations(Id, NameLocation,CodeLocation) values('Chi','Chine','Ch')
Create table Factorys
(
Id varchar(100) primary key NOT NULL, --Guid
NameFactory nvarchar(255) NOT NULL, --BHFlex, DKT
IdLocation varchar(100) NOT NULL, -- 
CreateBy nvarchar(255) default N'admin',
CreateDate datetime,
UpdateBy nvarchar(255) default N'admin',
UpdateDate datetime,
isDelete bit,
)
Create table Parts
(
Id varchar(100) primary key NOT NULL, --Guid
NamePart nvarchar(255) NOT NULL, --Ten bo phan
IdFactory varchar(100) NOT NULL, -- ID nha may
CreateBy nvarchar(255) default N'admin',
CreateDate datetime,
UpdateBy nvarchar(255) default N'admin',
UpdateDate datetime,
isDelete bit,
)
Create table Partments
(
Id varchar(100) primary key NOT NULL, --Guid
NamePartment nvarchar(255) NOT NULL, --Ten Phong
IdPart varchar(100) NOT NULL, -- ID bo phan
CreateBy nvarchar(255) default N'admin',
CreateDate datetime,
UpdateBy nvarchar(255) default N'admin',
UpdateDate datetime,
isDelete bit,
)
/*Create table Rooms
(
Id varchar(100) primary key NOT NULL,
NameRoom nvarchar(255) NOT NULL,
IdPartment varchar(100) NOT NULL,
CreateBy nvarchar(255) default N'admin',
CreateDate datetime,
UpdateBy nvarchar(255) default N'admin',
UpdateDate datetime,
isDelete bit,
)*/

Create table TypeDevices
(
Id varchar(100) primary key NOT NULL, --Guid
NameDeviceType nvarchar(255) NOT NULL, --Laptop, Desktop
CreateBy nvarchar(255) default N'admin',
CreateDate datetime,
UpdateBy nvarchar(255) default N'admin',
UpdateDate datetime,
isDelete bit,
)

select MONTH(BuyDate), DAY(BuyDate) from DeviceInfos where NameDevice='Desktop';
select * from DeviceInfos

select di.Id, di.IdDevice , di.NameUser, di.NameDevice, di.NameGroup, di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD, di.OS, di.BuyDate,di.SoftWare,di.Model, pt.NamePartment, p.NamePart, fa.NameFactory, lc.NameLocation 
from DeviceInfos di inner join Partments pt 
on di.IdPartment = pt.Id 
inner join Parts p 
on pt.IdPart = p.Id 
inner join Factorys fa 
on p.IdFactory = fa.Id 
inner join Locations lc 
on fa.IdLocation = lc.Id 
where di.NameDevice='Desktop' and di.isDelete='0';

alter table DeviceInfos add pcName varchar(50);
select * from DeviceInfos
update DeviceInfos set 
select PcName from DeviceInfos
Create table DeviceInfos
(
Id varchar(100) primary key NOT NULL, --Guid
NameDevice nvarchar(255) NOT NULL,
NameUser nvarchar(200),
pcName varchar(50),
MACAdress varchar(30), --Dia chi MAC
IPAdress varchar(16), -- Dia chi IP
Model varchar(max), -- Loai may: Dell, Samsung
NameGroup nvarchar(200) default N'WORK GROUP',
CPU varchar(200),
RAM varchar(200),
HDD varchar(200),
 --alter table DeviceInfos drop column SSD
--SSD varchar(200),
OS varchar(200), -- He dieu hanh
SoftWare nvarchar(max),
BuyDate datetime,
IdPartment varchar(100) NOT NULL, 
IdDevice varchar(100) NOT NULL, --Thiet bi thuoc phong nao
CreateBy nvarchar(255) default N'admin',
CreateDate datetime,
UpdateBy nvarchar(255) default N'admin',
UpdateDate datetime,
isDelete bit,
)

　		insert into DeviceInfos(Id,NameDevice,NameUser,MACAdress,IPAdress,Model,CPU,RAM,HDD,OS,BuyDate,IdDevice,IdPartment) 
	values('Desktop001','Desktop','QuangHop','A3:B4:C5:D6:E7:GI','192.168.1.199','Dell i5','Plentium','DDR4 8G','HDD 500G','Windows 10 pro',2019/03/04,'ERP','8eb0f760-f7b2-43fa-b727-0e593e281b16')

/*
Create table Softwares
(
Id int identity primary key NOT NULL, --Guid
NameSoftWare nvarchar(255),
CreateBy nvarchar(255) default N'admin',
CreateDate datetime,
UpdateBy nvarchar(255) default N'admin',
UpdateDate datetime,
isDelete bit,
)
Create table SoftInDevice
(
Id varchar(20) primary key NOT NULL, --Guid
IdDevice varchar(20) NOT NULL,
IdSoftWare varchar(20) NOT NULL,
CreateBy nvarchar(255) default N'admin',
CreateDate datetime,
UpdateBy nvarchar(255) default N'admin',
UpdateDate datetime,
isDelete bit,
)
*/
select di.Id, di.IdDevice , di.NameUser, di.NameDevice, di.NameGroup,
 di.IPAdress, di.MACAdress, di.CPU, di.RAM, di.HDD,
                  di.OS, di.BuyDate,di.SoftWare,di.Model,
 pt.NamePartment,
 p.NamePart,
 fa.NameFactory,
 lc.NameLocation
  from DeviceInfos di inner join Partments pt on di.IdPartment = pt.Id
inner join Parts p on pt.IdPart = p.Id
inner join Factorys fa on p.IdFactory = fa.Id
inner join Locations lc on fa.IdLocation = lc.Id


--------------------------
drop table Rooms
select * from DeviceInfos

insert into TypeDevices(Id,NameDeviceType) values ('Type01','Laptop')

select * from Factorys
select * from Parts
Select * from Partments

select p.Id, p.NamePart,p.CreateBy,p.CreateDate, ft.NameFactory, lc.NameLocation from Parts p 
inner join Factorys ft on p.IdFactory = ft.Id
 inner join Locations lc on ft.IdLocation = lc.Id Where ft.Id = 'cbeb25f7-6e39-40f1-a778-829882ba0a44'
select CodeLocation from Locations where NameLocation ='VietName'

insert into DeviceInfos(Id,NameDevice,NameUser,MACAdress,IPAdress,Model,CPU,RAM,HDD,OS,BuyDate,IdDevice,IdPartment) values
('VNPC841841903', 'Desktop', 'CUONGVD', 'ABC', '192.168.84.184', 'Dell', 'ABC', '500Gb', '500Gb', 'Windows 10', '2019/03/05', 'c536e92f-13cd-41c5-9b86-c4033f8e195e', '8eb0f760-f7b2-43fa-b727-0e593e281b16')