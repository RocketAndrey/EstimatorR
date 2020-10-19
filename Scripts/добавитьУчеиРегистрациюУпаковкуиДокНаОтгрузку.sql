use Estimator 
BEGIN TRANSACTION
--- 1.удаляем везде учет и регистрацитю ЭКБ

--2.создаем временную таблицу с трудоемкостями
Create table #testAct
(QualificationID int,[BatchLabor] int, [ItemLabor] int,[KitLabor] int )
insert into #testAct values (1,0,0,0)--руководитель темы
insert into #testAct values (2,0,0,0)--ведущий инженер
insert into #testAct values (3,0,0,0)--инженер 1 кат
insert into #testAct values (4,5,0,0)--инженер 2 кат 
insert into #testAct values (5,10,0,0)--техник
--3 создаем операцию  учет и регистрация ЭКБ для ДИ ИП для
--ДИ ЭКБ ИП
INSERT INTO [dbo].[TestChainItem]
           ([ElementTypeID],[OperationID],[Order],[Description],[GroupOperation],[OldTesChainItemId])

select e.ElementTypeID,12,100,N'Учет и регистрация на складе',1,null from ElementType e
LEFT JOIN TestChainItem c on c.ElementTypeID = e.ElementTypeID and c.OperationID=12
where
isnull(c.ElementTypeID,0) =0  
and e.ProgramID =  4
--заполняем трудоемкости для учета и регистрации
insert  into TestAction ([TestChainItemID],[QualificationID],[BatchLabor],[ItemLabor],[KitLabor])
select TestChainItemId,a.QualificationID,a.BatchLabor,a.ItemLabor,a.KitLabor from  
TestChainItem t,ElementType e, #testAct  a
where e.ProgramID = 4 and e.ElementTypeID=t.ElementTypeID and t.OperationID= 12
--обновляем трудоемкости для Учета и регистрации для СИ и ДИ ОП
--инженер 2 кат
Update [dbo].[TestAction] set BatchLabor = 5 where QualificationID= 4 
and [TestChainItemID] in (
select TestChainItemId from  
TestChainItem t,ElementType e
where  e.ElementTypeID=t.ElementTypeID and t.OperationID in( 12,495)
)
--техник
Update [dbo].[TestAction] set BatchLabor = 10 where QualificationID= 5
and [TestChainItemID] in (
select TestChainItemId from  
TestChainItem t,ElementType e
where  e.ElementTypeID=t.ElementTypeID and t.OperationID in( 12,495)
)
/*

*/
-- Упаковка
--3 создаем операцию  Упаковка  для СИ 
INSERT INTO [dbo].[TestChainItem]
           ([ElementTypeID],[OperationID],[Order],[Description],[GroupOperation],[OldTesChainItemId])

select e.ElementTypeID,498 ,450 ,N'Упаковка на складе',1,null from ElementType e
LEFT JOIN TestChainItem c on c.ElementTypeID = e.ElementTypeID and c.OperationID=498
where
isnull(c.ElementTypeID,0) =0  and 
 e.ProgramID =  5
 --3 создаем операцию  Упаковка  для ДИ ИП
INSERT INTO [dbo].[TestChainItem]
           ([ElementTypeID],[OperationID],[Order],[Description],[GroupOperation],[OldTesChainItemId])

select e.ElementTypeID,498 ,450 ,N'Упаковка на складе',1,null from ElementType e
LEFT JOIN TestChainItem c on c.ElementTypeID = e.ElementTypeID and c.OperationID=498
where
isnull(c.ElementTypeID,0) =0  and 
 e.ProgramID =  4

--обновляем таблицу с трудоемкостями 
delete from #testAct
insert into #testAct values (1,0,0,0)--руководитель темы
insert into #testAct values (2,0,0,0)--ведущий инженер
insert into #testAct values (3,0,0,0)--инженер 1 кат
insert into #testAct values (4,0,0,0)--инженер 2 кат 
insert into #testAct values (5,10,0.1,0)--техник
--3 создаем операцию  учет и регистрация ЭКБ для ДИ ИП для
--заполняем трудоемкости для упаковки
insert  into TestAction ([TestChainItemID],[QualificationID],[BatchLabor],[ItemLabor],[KitLabor])
select TestChainItemId,a.QualificationID,a.BatchLabor,a.ItemLabor,a.KitLabor from  
TestChainItem t,ElementType e, #testAct  a
where e.ProgramID = 5 and e.ElementTypeID=t.ElementTypeID and t.OperationID= 498

insert  into TestAction ([TestChainItemID],[QualificationID],[BatchLabor],[ItemLabor],[KitLabor])
select TestChainItemId,a.QualificationID,a.BatchLabor,a.ItemLabor,a.KitLabor from  
TestChainItem t,ElementType e, #testAct  a
where e.ProgramID = 4 and e.ElementTypeID=t.ElementTypeID and t.OperationID= 498

--техник
Update [dbo].[TestAction] set BatchLabor = 10,ItemLabor =0.1 where QualificationID= 5
and [TestChainItemID] in (
select TestChainItemId from  
TestChainItem t,ElementType e
where  e.ElementTypeID=t.ElementTypeID and t.OperationID in( 498))



--Документация на отгрузку
 --3 создаем операцию  док на отгрузку
INSERT INTO [dbo].[TestChainItem]
           ([ElementTypeID],[OperationID],[Order],[Description],[GroupOperation],[OldTesChainItemId])

select e.ElementTypeID,500 ,460 ,N'Оформление документации на отгрузку',1,null from ElementType e
LEFT JOIN TestChainItem c on c.ElementTypeID = e.ElementTypeID and c.OperationID=500
where
isnull(c.ElementTypeID,0) =0  and 
 e.ProgramID =  4

 INSERT INTO [dbo].[TestChainItem]
           ([ElementTypeID],[OperationID],[Order],[Description],[GroupOperation],[OldTesChainItemId])

select e.ElementTypeID,500 ,520 ,N'Оформление документации на отгрузку',1,null from ElementType e
LEFT JOIN TestChainItem c on c.ElementTypeID = e.ElementTypeID and c.OperationID=500
where
isnull(c.ElementTypeID,0) =0  and 
 e.ProgramID =  5


--обновляем таблицу с трудоемкостями 
delete from #testAct
insert into #testAct values (1,0,0,0)--руководитель темы
insert into #testAct values (2,0,0,0)--ведущий инженер
insert into #testAct values (3,0,0,0)--инженер 1 кат
insert into #testAct values (4,5,0,0)--инженер 2 кат 
insert into #testAct values (5,10,0.1,0)--техник
--3 создаем операцию  учет и регистрация ЭКБ для ДИ ИП для
--заполняем трудоемкости для документации на отгрузку
insert  into TestAction ([TestChainItemID],[QualificationID],[BatchLabor],[ItemLabor],[KitLabor])
select TestChainItemId,a.QualificationID,a.BatchLabor,a.ItemLabor,a.KitLabor from  
TestChainItem t,ElementType e, #testAct  a
where e.ProgramID = 5 and e.ElementTypeID=t.ElementTypeID and t.OperationID= 500

insert  into TestAction ([TestChainItemID],[QualificationID],[BatchLabor],[ItemLabor],[KitLabor])
select TestChainItemId,a.QualificationID,a.BatchLabor,a.ItemLabor,a.KitLabor from  
TestChainItem t,ElementType e, #testAct  a
where e.ProgramID = 4 and e.ElementTypeID=t.ElementTypeID and t.OperationID= 500

Update [dbo].[TestAction] set BatchLabor = 15,ItemLabor =0 where QualificationID= 5
and [TestChainItemID] in (
select TestChainItemId from  
TestChainItem t,ElementType e
where  e.ElementTypeID=t.ElementTypeID and t.OperationID in( 500))

commit 