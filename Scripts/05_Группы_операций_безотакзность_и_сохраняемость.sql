use   [u1000209_ESTIMATOR]



declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = '05_������ �������� - ������������� � �������������';
select @scriptNumber = 05;



INSERT INTO [dbo].[database_updates]
           ([ScriptNumber]
           ,[ScriptName]
           ,[ScriptDate])
     VALUES
           (@scriptNumber
           ,@scriptName
           ,Getdate())

BEGIN TRANSACTION
 Declare @relID int, @OpID  int
		INSERT INTO [dbo].[OperationGroup]
           ([Code]
           ,[Name])
		  VALUES
           (N'���'
           ,N'�������������')

	
		   select @relID = max (OperationGroupID) from [OperationGroup]

		   select @OpID = OperationID  from [dbo].[Operation] where Code= N'�23'

		  

			UPDATE [dbo].[Operation]
		   SET  [OperationGroupID] = @relID
			WHERE OperationID = @OpID

			INSERT INTO [dbo].[OperationGroup]
           ([Code]
           ,[Name])
			VALUES
           (N'C���'
           ,N'�������������')

		   
		   select @relID = max (OperationGroupID) from [OperationGroup]

		   select @OpID = OperationID  from [dbo].[Operation] where Code= N'�24'

		  

  			WHERE OperationID = @OpID
Commit 
GO




