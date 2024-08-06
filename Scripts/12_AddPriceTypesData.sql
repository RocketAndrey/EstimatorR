use   Estimator


declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = N'12_AddPriceTypesData';
select @scriptNumber = 12;

BEGIN TRANSACTION



		   if (select count(*) from [database_updates] where[ScriptNumber] = @scriptNumber) = 0 
		   BEGIN
		   INSERT INTO [dbo].[database_updates]
			   ([ScriptNumber]
			   ,[ScriptName]
			   ,[ScriptDate] )
				VALUES
			   (@scriptNumber
			   ,@scriptName
			   ,Getdate())
Declare @Pr int 
INSERT INTO [dbo].[PriceItemType]
           ([PriceItemTypeName])
     VALUES
           (N'�����')

--��������� ���������� ������������
INSERT INTO [dbo].[PriceItemType]
           ([PriceItemTypeName])
     VALUES
           (N'��������� ���������� �������������')

select @Pr= max (PriceItemTypeID ) from PriceItemType 


INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property0',N'�������������,R ��')
INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property1',N'��������,P ��')
INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property2',N'���, TCR')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property3',N'����� �������� %')
INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property4',N'����������')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property5',N'�����������')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property6',N'���������� ���������')
--������������ ���������� ������� ������������
INSERT INTO [dbo].[PriceItemType]
           ([PriceItemTypeName])
     VALUES
           (N'������������ ���������� ������� ������������')

select @Pr= max (PriceItemTypeID ) from PriceItemType 

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property0',N'���')
INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property1',N'����������, �')
INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property2',N'�������')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property3',N'����� �������� %')
INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property4',N'����������, ��')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property5',N'���������� %')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property6',N'����������')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property7',N'��������')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property8',N'���-��')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property9',N'���������� �����')
					COMMIT
			END
				
			
			ELSE ROLLBACK 

GO

