use Asulive
---Операции для которых  не установлена связь АСУ-калькулятор 
/*
select
'--'+bo.Name + char(10)+char(13)+
'insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])
VALUES ('+ cast ( cl.ClassId as nvarchar(10))  +' , '+ cast ( bo.BaseOperationId as nvarchar (10)) + ', ' + '   )'
as Operend,
cl.ClassId ,
cl.Name as ClassType,
bo.BaseOperationId,
w.TypeNominal as [Тип ЭРИ],
cl.Name as ClassType,
ui.LastName +' '+ ui.FN as [Сотрудник],
       bo.Name as [Операция],
eet.TestChainItemID,
(labor.banchLabor* 1.1466  + labor.ItemLabor* l.QTY* 1.1466)/60 as OperationLabor ,
       l.PrefixNumber + '-' +t.TestTypeId+ '-' + CAST(l.Number AS varchar) + ISNULL(CASE WHEN l.SuffixNumber LIKE 'о' THEN NULL ELSE l.SuffixNumber END, '') as [№ МК],
	   w.QTY,l.QTY as OperationQTY,
	      convert(nvarchar(2),MONTH (ro.EndTime)) + ' ' + convert(nvarchar(4),YEAR (ro.EndTime)) as EndMonth,
       CAST (ro.EndTime as DATE) as [Дата],w.WareId,
	   cl.ClassId,
	  -- eet.[E_ElementTypeID],
	   ct.Number as ContractNumber,
ct.CreationDate as ContractDate, 
org.ShortName as Organization
from RouteOperation as ro
 INNER JOIN UserInfo as ui on ro.UserID=ui.UserId
 INNER JOIN Operation as o on ro.OperationId=o.OperationId
 INNER JOIN Test as t on t.TestId=o.TestId
 INNER JOIN BaseOperation as bo on bo.BaseOperationId=o.baseOperationId
 INNER JOIN Lot as l on ro.LotId=l.LotId
 INNER JOIN Wares as w on l.WareId=w.WareId
 Inner JOIN [Contract] ct on ct.ContractId = w.ContractId
 inner join Organization org on org.OrganizationId= ct.SupplierId 
 inner join ClassType cl on cl.ClassId = w.ClassId
 left OUTER  join Estimator_TestChainItem  eet on eet.AsuClassID = cl.ClassId and eet.[AsuBaseOperationID] =  bo.BaseOperationId
 left outer join (select eta.TestChainItemID  , sum (eta.BatchLabor) as banchLabor,sum(eta.ItemLabor) as ItemLabor 
from Estimator.dbo.TestAction eta 
group by  eta.TestChainItemID ) labor on 
labor.TestChainItemID = eet.[TestChainItemID] 

 where 
-- isnull(eeo.E_OperationID,0)=0 and 
 isnull(ro.Disabled,0) = 0 
   and ro.EndTime > '2020-09-01'
   and  ro.EndTime < '2020-10-01'
  and isnull (ro.EndTime,0)> 0
  and IsNull(labor.banchLabor ,-1)=-1
  And bo.BaseOperationId not in (164,151)
 order By cl.ClassId, [№ МК], [Дата]
 */

-- select etc.TestChainItemID,  etc.ElementTypeID, e.Name  ,etc.OperationID ,o.Name 
--from 
--Estimator.dbo.TestChainItem etc, ElementType e, Operation o
--where   e.ElementTypeID = etc.ElementTypeID and o.OperationID=etc.OperationID 
--and e.ElementTypeID =8
--order by etc.[Order]


 declare @Month int,@Year int
 select @Month = 9, @Year = 2020
 select 
cl.Name as ClassType,
w.TypeNominal as [Тип ЭРИ],
ui.LastName +' '+ ui.FN as [Сотрудник],
'Учет и регистрация ЭКБ' as [Операция],
(labor.banchLabor* 1.1466  + labor.ItemLabor* S.QTY* 1.1466)/60 as OperationLabor,
l.PrefixNumber +  '-' + CAST(l.Number AS varchar) + ISNULL(CASE WHEN l.SuffixNumber LIKE 'о' THEN NULL ELSE l.SuffixNumber END, '') as [№ МК],
 S.QTY as OperationQTY,
convert(nvarchar(2),MONTH (s.DeliveryDate)) + ' ' + convert(nvarchar(4),YEAR (s.DeliveryDate)) as EndMonth,
CAST (s.DeliveryDate as DATE) as [Дата],
ct.Number as ContractNumber,
ct.CreationDate as ContractDate, 
org.ShortName as Organization

from Lot as l  
	 inner join Store_WaresLot as sw on l.LotId=sw.LotId
	 inner join Store as s on s.StoreWareId=sw.StoreWareId
	 inner join UserInfo as ui on s.StoreUserId=ui.UserId
	 INNER JOIN Wares as w on l.WareId=w.WareId
 Inner JOIN [Contract] ct on ct.ContractId = w.ContractId
 inner join Organization org on org.OrganizationId= ct.ClientId 
 inner join ClassType cl on cl.ClassId = w.ClassId
 left outer join (select eta.TestChainItemID  , sum (eta.BatchLabor) as banchLabor,sum(eta.ItemLabor) as ItemLabor 
from Estimator.dbo.TestAction eta 
group by  eta.TestChainItemID ) labor on 
labor.TestChainItemID = 12

where l.LotTypeId='ОС'
and MONTH(s.DeliveryDate)=@Month and YEAR (s.DeliveryDate)=@Year
UNION
--Оформление документации на отгрузку
select 
cl.Name as ClassType,
w.TypeNominal as [Тип ЭРИ],
ui.LastName +' '+ ui.FN as [Сотрудник],
'Оформление документации на отгрузку' as [Операция],
(labor.banchLabor * 1.1466  + labor.ItemLabor* l.QTY* 1.1466)/60 as OperationLabor,
l.PrefixNumber +  '-' + CAST(l.Number AS varchar) + ISNULL(CASE WHEN l.SuffixNumber LIKE 'о' THEN NULL ELSE l.SuffixNumber END, '') as [№ МК],
 l.QTY as OperationQTY,
convert(nvarchar(2),MONTH (o.CreationDate)) + ' ' + convert(nvarchar(4),YEAR (o.CreationDate)) as EndMonth,
CAST (o.CreationDate as DATE) as [Дата],
ct.Number as ContractNumber,
ct.CreationDate as ContractDate, 
org.ShortName as Organization
from Outletter as o
     inner join Lot_Outletter as lo on o.OutletterId=lo.OutletterId
	 Inner Join Lot as L on l.LotId =  lo.LotId
     inner join UserInfo as ui on lo.UserId=ui.UserId
	 INNER JOIN Wares as w on L.WareId=w.WareId
 Inner JOIN [Contract] ct on ct.ContractId = o.ContractId
 inner join Organization org on org.OrganizationId= ct.ClientId 
 inner join ClassType cl on cl.ClassId = w.ClassId
 left outer join (select eta.TestChainItemID  , sum (eta.BatchLabor) as banchLabor,sum(eta.ItemLabor) as ItemLabor 
from Estimator.dbo.TestAction eta 
group by  eta.TestChainItemID ) labor on 
labor.TestChainItemID = 2510

where o.Sent=1 and 
YEAR (o.CreationDate) = @Year and  MONTH (o.CreationDate) = @Month

UNION
SELECT 
cl.Name as ClassType,
w.TypeNominal as [Тип ЭРИ],
ui.LastName +' '+ ui.FN as [Сотрудник],
'Подготовка протоколов и заключений по результатам испытаний' as [Операция],
(labor.banchLabor* 1.1466  + labor.ItemLabor* l.QTY* 1.1466)/60 as OperationLabor,
l.PrefixNumber +  '-' + CAST(l.Number AS varchar) + ISNULL(CASE WHEN l.SuffixNumber LIKE 'о' THEN NULL ELSE l.SuffixNumber END, '') as [№ МК],
 l.QTY as OperationQTY,
convert(nvarchar(2),MONTH (cp.Request)) + ' ' + convert(nvarchar(4),YEAR (cp.Request)) as EndMonth,
CAST (cp.Request as DATE) as [Дата],
ct.Number as ContractNumber,
ct.CreationDate as ContractDate, 
org.ShortName as Organization

FROM TemplateDocument td
JOIN CoordinatePerson cp ON td.TemplateDocumentId = cp.TemplateDocumentId
JOIN Template t ON td.TemplateId = t.TemplateId
JOIN DocumentType dt ON t.DocumentTypeId = dt.DocumentTypeId
JOIN CoordinatePersonRoles cpr ON cp.CoordinatePersonRolesId = cpr.CoordinatePersonRolesId
JOIN UserInfo ui on ui.UserId = cp.UserId
 Inner Join Lot as L on l.LotId =  td.LotId
 
	 INNER JOIN Wares as w on L.WareId=w.WareId
 Inner JOIN [Contract] ct on ct.ContractId = w.ContractId
 inner join Organization org on org.OrganizationId= ct.ClientId 
 inner join ClassType cl on cl.ClassId = w.ClassId
 left outer join (select eta.TestChainItemID  , sum (eta.BatchLabor) as banchLabor,sum(eta.ItemLabor) as ItemLabor 
from Estimator.dbo.TestAction eta 
group by  eta.TestChainItemID ) labor on 
labor.TestChainItemID = 44


WHERE cpr.Name = 'ГОП'
AND cp.Response IS NOT NULL AND cp.Request IS NOT NULL
and YEAR(cp.Request) = @Year and MONTH(cp.Request)  =@Month 

Union

select
cl.Name as ClassType,
w.TypeNominal as [Тип ЭРИ],
ui.LastName +' '+ ui.FN as [Сотрудник],
bo.Name as [Операция],
(labor.banchLabor* 1.1466  + labor.ItemLabor* l.QTY* 1.1466)/60 as OperationLabor ,
l.PrefixNumber + '-' +t.TestTypeId+ '-' + CAST(l.Number AS varchar) + ISNULL(CASE WHEN l.SuffixNumber LIKE 'о' THEN NULL ELSE l.SuffixNumber END, '') as [№ МК],
l.QTY as OperationQTY,
convert(nvarchar(2),MONTH (ro.EndTime)) + ' ' + convert(nvarchar(4),YEAR (ro.EndTime)) as EndMonth,
CAST (ro.EndTime as DATE) as [Дата],
ct.Number as ContractNumber,
ct.CreationDate as ContractDate, 
org.ShortName as Organization
from RouteOperation as ro
 INNER JOIN UserInfo as ui on ro.UserID=ui.UserId
 INNER JOIN Operation as o on ro.OperationId=o.OperationId
 INNER JOIN Test as t on t.TestId=o.TestId
 INNER JOIN BaseOperation as bo on bo.BaseOperationId=o.baseOperationId
 INNER JOIN Lot as l on ro.LotId=l.LotId
 INNER JOIN Wares as w on l.WareId=w.WareId
 Inner JOIN [Contract] ct on ct.ContractId = w.ContractId
 inner join Organization org on org.OrganizationId= ct.ClientId 
 inner join ClassType cl on cl.ClassId = w.ClassId
 left OUTER  join Estimator_TestChainItem  eet on eet.AsuClassID = cl.ClassId and eet.[AsuBaseOperationID] =  bo.BaseOperationId
 left outer join (select eta.TestChainItemID  , sum (eta.BatchLabor) as banchLabor,sum(eta.ItemLabor) as ItemLabor 
from Estimator.dbo.TestAction eta 
group by  eta.TestChainItemID ) labor on 
labor.TestChainItemID = eet.[TestChainItemID] 

 where 
-- isnull(eeo.E_OperationID,0)=0 and 
 isnull(ro.Disabled,0) = 0 
   and MONTH (ro.EndTime) =@Month
   and  YEAR (ro.EndTime) = @year
  and isnull (ro.EndTime,0)> 0
  