select

bo.Name,
cl.Name as ClassType,
cl.ClassId ,
bo.BaseOperationId,
COUNT (*) as COUNT_OP
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

 isnull(ro.Disabled,0) = 0 
   and ro.EndTime > '2020-11-01'
   and  ro.EndTime < '2021-04-12'
  and isnull (ro.EndTime,0)> 0
  and IsNull(labor.banchLabor ,-1)=-1

GROUP BY bo.Name,
cl.Name,
cl.ClassId ,
bo.BaseOperationId

 order By COUNT_OP desc
