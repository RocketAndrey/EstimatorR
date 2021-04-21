use Estimator 
BEGIN TRANSACTION


--2.создаем временную таблицу с трудоемкостями
Create table #testAct
(QualificationID int,[BatchLabor] int, [ItemLabor] decimal,[KitLabor] int )
insert into #testAct values (1,0,0,0)--руководитель темы
insert into #testAct values (2,0,0,0)--ведущий инженер
insert into #testAct values (3,0,0,0)--инженер 1 кат
insert into #testAct values (4,0,0,0)--инженер 2 кат 
insert into #testAct values (5,5,0.1,0)--техник
--3 создаем операцию  отбор образцов

 Declare @OperationID int 
 select @OperationID= OperationId from Operation where [Name]= N'Нанесение отличительной маркировки ИЦ'
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
     VALUES (N'Нанесение отличительной маркировки ИЦ' ,N'M',0 ,1 ,3 ,-1)
select @OperationID= OperationId from Operation where [Name]= N'Нанесение отличительной маркировки ИЦ'
 END
--CИ
If isnull(@OperationID,0) >0 
Begin
--добавляем операцию в цепочку
INSERT INTO [dbo].[TestChainItem]
           ([ElementTypeID],[OperationID],[Order],[Description],[GroupOperation],[OldTesChainItemId])

select e.ElementTypeID,@OperationID,440, N'Нанесение отличительной маркировки ИЦ: знак или белая точка',1,null from ElementType e
LEFT JOIN TestChainItem c on c.ElementTypeID = e.ElementTypeID and c.OperationID= @OperationID  
where
isnull(c.ElementTypeID,0) =0  
and e.ProgramID =  4


--заполняем трудоемкости для учета и регистрации
insert  into TestAction ([TestChainItemID],[QualificationID],[BatchLabor],[ItemLabor],[KitLabor])
select TestChainItemId,a.QualificationID,a.BatchLabor,a.ItemLabor,a.KitLabor from  
TestChainItem t,ElementType e, #testAct  a
where e.ProgramID = 4 and e.ElementTypeID=t.ElementTypeID and t.OperationID= @OperationID


end 

drop  table #testAct

commit  



 