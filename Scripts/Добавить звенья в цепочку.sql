USE [Estimator]
GO
DECLARE @name nvarchar(150);
declare @code nvarchar(4);
declare @ElementTypeID int;
declare @OperationID int;
DECLARE @Counter int;
declare @order int;
declare @TestChainItemID int;
declare @OperationGroup int;
Declare @sampleCount int;

BEGIN TRANSACTION;

Select @ElementTypeID = 35 --���������� ������� � ������� ���
--����� �������� ��������, ��� � 
--select @code=N'�1' , @name= N'�������� �������� ���� � ����������', @OperationGroup=2, @sampleCount =-1, @order = 11;
--select @code=N'�1.1' , @name= N'�������� ���������������� ���������� ����-��� � �������� � ���������� �������� �� ��������� �-2 ��', @OperationGroup=2, @sampleCount =-1;
--select @code=N'�1.3' , @name= N'�������� ���������������� ���������� ������� � �������� � ���������� �������� �� ������������ ������', @OperationGroup=2, @sampleCount =-1;
--select @code=N'�2.1' , @name= N'����������������� (3-10 ������ � ������������ � ��)', @OperationGroup=3, @sampleCount =-1;
--select @code=N'D2.2' , @name= N'��������� �� �������������� �� ��', @OperationGroup=3, @sampleCount =-1;
--select @code=N'D2.3' , @name= N'��������� ���������������� ���������� ������� � �������� � ���������� �������� �� �1.1', @OperationGroup=3, @sampleCount =-1;
--select @code=N'D2.4' , @name= N'�������� ���������������� ���������� ������� � �������� � ���������� �������� �� ������������ ������', @OperationGroup=3, @sampleCount =-1;
--select @code=N'D2.5' , @name= N'�������� ������������ ������� � �������� � ����������� �������� � ������� �������� ����������� ���������� �����', @OperationGroup=3, @sampleCount =-1;

--select @code=N'�5' , @name= N'������� ������ �� ����������� ���', @OperationGroup=3, @sampleCount =-1;
--select @code=N'�' , @name= N'��������� ������������� ���������� ��', @OperationGroup=6, @sampleCount =-1;
--select @code=N'�' , @name= N'���������� ���������', @OperationGroup=6, @sampleCount =-1;
select @code=N'�7' , @name= N'�������� ������������� ����������  �� ����������� ��', @OperationGroup=3, @sampleCount =-1;
select @order =350

--��������� ���� �� ����� ��������
SELECT @OperationID =ISNULL(OperationID,0)
from [Operation] where [Name] = @name And [Code]=@code;



IF ISNULL(@OperationID,0)= 0
BEGIN 
--������� ��������
	INSERT INTO [dbo].[Operation]
           ([Name]
           ,[Code]
           ,[DPO],IsExecuteDefault,OperationGroupID,SampleCount)
     VALUES
           (@name,@code, 0,1,@OperationGroup,@sampleCount)
		--�������� �� ����� ��������
		select @OperationID= MAX(OperationID) from Operation;
END

--select @order = MAX([Order])+10 from TestChainItem  where ElementTypeID=@ElementTypeID 

--������� ����� ������  ������� ��� ����  ��������� � ��������� �������� 
INSERT INTO [dbo].[TestChainItem]
			   ([ElementTypeID]
			   ,[OperationID]
			   ,[Order])
		 values (@ElementTypeID,@OperationID,@order)
		--������ ������������ �� ��������������
		select @TestChainItemID =max (TestChainItemID) from TestChainItem 
		INSERT INTO [dbo].[TestAction]
           ([QualificationID]
           ,[BatchLabor]
           ,[ItemLabor]
           ,[TestChainItemID]
           ,[KitLabor])
		  SELECT  QualificationID,0,0,@TestChainItemID, 0 from Qualification
		  

commit;

GO



