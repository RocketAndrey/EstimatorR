use Estimator 
BEGIN TRANSACTION


--2.создаем временную таблицу с трудоемкостями
Create table #testAct
(QualificationID int,[BatchLabor] int, [ItemLabor] int,[KitLabor] int )
insert into #testAct values (1,0,0,0)--руководитель темы
insert into #testAct values (2,0,0,0)--ведущий инженер
insert into #testAct values (3,0,0,0)--инженер 1 кат
insert into #testAct values (4,30,0,0)--инженер 2 кат 
insert into #testAct values (5,0,0,0)--техник
--3 создаем операцию  отбор образцов

 Declare @OperationID int 
 select @OperationID= OperationId from Operation where [Name]= N'Отбор образцов'
 If isnull(@OperationID,0)=0 
 BEGIN
 INSERT INTO [dbo].[Operation]
           ([Name]
           ,[Code]
           ,[DPO]
           ,[IsExecuteDefault]
           ,[OperationGroupID]
           ,[SampleCount]
           )
     VALUES (N'Отбор образцов' ,'С30',0 ,1 ,4 ,-1)
select @OperationID= OperationId from Operation where [Name]= N'Отбор образцов'
 END
--CИ
If isnull(@OperationID,0) >0 
Begin
--добавляем операцию в цепочку
INSERT INTO [dbo].[TestChainItem]
           ([ElementTypeID],[OperationID],[Order],[Description],[GroupOperation],[OldTesChainItemId])

select e.ElementTypeID,@OperationID,215, N'Отбор образцов для СИ, безотказности,  сохраняемости и спец.факторов ',1,null from ElementType e
LEFT JOIN TestChainItem c on c.ElementTypeID = e.ElementTypeID and c.OperationID= @OperationID  
where
isnull(c.ElementTypeID,0) =0  
and e.ProgramID =  5


--заполняем трудоемкости для учета и регистрации
insert  into TestAction ([TestChainItemID],[QualificationID],[BatchLabor],[ItemLabor],[KitLabor])
select TestChainItemId,a.QualificationID,a.BatchLabor,a.ItemLabor,a.KitLabor from  
TestChainItem t,ElementType e, #testAct  a
where e.ProgramID = 5 and e.ElementTypeID=t.ElementTypeID and t.OperationID= @OperationID
end 

commit 