use Estimator 
BEGIN TRANSACTION
--- 1.������� ����� ���� � ������������ ���

--2.������� ��������� ������� � ��������������
Create table #testAct
(QualificationID int,[BatchLabor] int, [ItemLabor] int,[KitLabor] int )
insert into #testAct values (1,0,0,0)--������������ ����
insert into #testAct values (2,0,0,0)--������� �������
insert into #testAct values (3,0,0,0)--������� 1 ���
insert into #testAct values (4,5,0,0)--������� 2 ��� 
insert into #testAct values (5,10,0,0)--������
--3 ������� ��������  ���� � ����������� ��� ��� �� �� ���
--�� ��� ��
INSERT INTO [dbo].[TestChainItem]
           ([ElementTypeID],[OperationID],[Order],[Description],[GroupOperation],[OldTesChainItemId])

select e.ElementTypeID,12,100,N'���� � ����������� �� ������',1,null from ElementType e
LEFT JOIN TestChainItem c on c.ElementTypeID = e.ElementTypeID and c.OperationID=12
where
isnull(c.ElementTypeID,0) =0  
and e.ProgramID =  4
--��������� ������������ ��� ����� � �����������
insert  into TestAction ([TestChainItemID],[QualificationID],[BatchLabor],[ItemLabor],[KitLabor])
select TestChainItemId,a.QualificationID,a.BatchLabor,a.ItemLabor,a.KitLabor from  
TestChainItem t,ElementType e, #testAct  a
where e.ProgramID = 4 and e.ElementTypeID=t.ElementTypeID and t.OperationID= 12
--��������� ������������ ��� ����� � ����������� ��� �� � �� ��
--������� 2 ���
Update [dbo].[TestAction] set BatchLabor = 5 where QualificationID= 4 
and [TestChainItemID] in (
select TestChainItemId from  
TestChainItem t,ElementType e
where  e.ElementTypeID=t.ElementTypeID and t.OperationID in( 12,495)
)
--������
Update [dbo].[TestAction] set BatchLabor = 10 where QualificationID= 5
and [TestChainItemID] in (
select TestChainItemId from  
TestChainItem t,ElementType e
where  e.ElementTypeID=t.ElementTypeID and t.OperationID in( 12,495)
)
/*

*/
-- ��������
--3 ������� ��������  ��������  ��� �� 
INSERT INTO [dbo].[TestChainItem]
           ([ElementTypeID],[OperationID],[Order],[Description],[GroupOperation],[OldTesChainItemId])

select e.ElementTypeID,498 ,450 ,N'�������� �� ������',1,null from ElementType e
LEFT JOIN TestChainItem c on c.ElementTypeID = e.ElementTypeID and c.OperationID=498
where
isnull(c.ElementTypeID,0) =0  and 
 e.ProgramID =  5
 --3 ������� ��������  ��������  ��� �� ��
INSERT INTO [dbo].[TestChainItem]
           ([ElementTypeID],[OperationID],[Order],[Description],[GroupOperation],[OldTesChainItemId])

select e.ElementTypeID,498 ,450 ,N'�������� �� ������',1,null from ElementType e
LEFT JOIN TestChainItem c on c.ElementTypeID = e.ElementTypeID and c.OperationID=498
where
isnull(c.ElementTypeID,0) =0  and 
 e.ProgramID =  4

--��������� ������� � �������������� 
delete from #testAct
insert into #testAct values (1,0,0,0)--������������ ����
insert into #testAct values (2,0,0,0)--������� �������
insert into #testAct values (3,0,0,0)--������� 1 ���
insert into #testAct values (4,0,0,0)--������� 2 ��� 
insert into #testAct values (5,10,0.1,0)--������
--3 ������� ��������  ���� � ����������� ��� ��� �� �� ���
--��������� ������������ ��� ��������
insert  into TestAction ([TestChainItemID],[QualificationID],[BatchLabor],[ItemLabor],[KitLabor])
select TestChainItemId,a.QualificationID,a.BatchLabor,a.ItemLabor,a.KitLabor from  
TestChainItem t,ElementType e, #testAct  a
where e.ProgramID = 5 and e.ElementTypeID=t.ElementTypeID and t.OperationID= 498

insert  into TestAction ([TestChainItemID],[QualificationID],[BatchLabor],[ItemLabor],[KitLabor])
select TestChainItemId,a.QualificationID,a.BatchLabor,a.ItemLabor,a.KitLabor from  
TestChainItem t,ElementType e, #testAct  a
where e.ProgramID = 4 and e.ElementTypeID=t.ElementTypeID and t.OperationID= 498

--������
Update [dbo].[TestAction] set BatchLabor = 10,ItemLabor =0.1 where QualificationID= 5
and [TestChainItemID] in (
select TestChainItemId from  
TestChainItem t,ElementType e
where  e.ElementTypeID=t.ElementTypeID and t.OperationID in( 498))



--������������ �� ��������
 --3 ������� ��������  ��� �� ��������
INSERT INTO [dbo].[TestChainItem]
           ([ElementTypeID],[OperationID],[Order],[Description],[GroupOperation],[OldTesChainItemId])

select e.ElementTypeID,500 ,460 ,N'���������� ������������ �� ��������',1,null from ElementType e
LEFT JOIN TestChainItem c on c.ElementTypeID = e.ElementTypeID and c.OperationID=500
where
isnull(c.ElementTypeID,0) =0  and 
 e.ProgramID =  4

 INSERT INTO [dbo].[TestChainItem]
           ([ElementTypeID],[OperationID],[Order],[Description],[GroupOperation],[OldTesChainItemId])

select e.ElementTypeID,500 ,520 ,N'���������� ������������ �� ��������',1,null from ElementType e
LEFT JOIN TestChainItem c on c.ElementTypeID = e.ElementTypeID and c.OperationID=500
where
isnull(c.ElementTypeID,0) =0  and 
 e.ProgramID =  5


--��������� ������� � �������������� 
delete from #testAct
insert into #testAct values (1,0,0,0)--������������ ����
insert into #testAct values (2,0,0,0)--������� �������
insert into #testAct values (3,0,0,0)--������� 1 ���
insert into #testAct values (4,5,0,0)--������� 2 ��� 
insert into #testAct values (5,10,0.1,0)--������
--3 ������� ��������  ���� � ����������� ��� ��� �� �� ���
--��������� ������������ ��� ������������ �� ��������
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