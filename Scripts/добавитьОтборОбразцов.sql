use Estimator 
BEGIN TRANSACTION


--2.������� ��������� ������� � ��������������
Create table #testAct
(QualificationID int,[BatchLabor] int, [ItemLabor] int,[KitLabor] int )
insert into #testAct values (1,0,0,0)--������������ ����
insert into #testAct values (2,0,0,0)--������� �������
insert into #testAct values (3,0,0,0)--������� 1 ���
insert into #testAct values (4,30,0,0)--������� 2 ��� 
insert into #testAct values (5,0,0,0)--������
--3 ������� ��������  ����� ��������

 Declare @OperationID int 
 select @OperationID= OperationId from Operation where [Name]= N'����� ��������'
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
     VALUES (N'����� ��������' ,'�30',0 ,1 ,4 ,-1)
select @OperationID= OperationId from Operation where [Name]= N'����� ��������'
 END
--C�
If isnull(@OperationID,0) >0 
Begin
--��������� �������� � �������
INSERT INTO [dbo].[TestChainItem]
           ([ElementTypeID],[OperationID],[Order],[Description],[GroupOperation],[OldTesChainItemId])

select e.ElementTypeID,@OperationID,215, N'����� �������� ��� ��, �������������,  ������������� � ����.�������� ',1,null from ElementType e
LEFT JOIN TestChainItem c on c.ElementTypeID = e.ElementTypeID and c.OperationID= @OperationID  
where
isnull(c.ElementTypeID,0) =0  
and e.ProgramID =  5


--��������� ������������ ��� ����� � �����������
insert  into TestAction ([TestChainItemID],[QualificationID],[BatchLabor],[ItemLabor],[KitLabor])
select TestChainItemId,a.QualificationID,a.BatchLabor,a.ItemLabor,a.KitLabor from  
TestChainItem t,ElementType e, #testAct  a
where e.ProgramID = 5 and e.ElementTypeID=t.ElementTypeID and t.OperationID= @OperationID
end 

commit 