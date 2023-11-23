use   [u1000209_ESTIMATOR]



declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = '05_Группы операций - безотакзность и сохраняемость';
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
           (N'Без'
           ,N'Безотказность')

	
		   select @relID = max (OperationGroupID) from [OperationGroup]

		   select @OpID = OperationID  from [dbo].[Operation] where Code= N'С23'

		  

			UPDATE [dbo].[Operation]
		   SET  [OperationGroupID] = @relID
			WHERE OperationID = @OpID

			INSERT INTO [dbo].[OperationGroup]
           ([Code]
           ,[Name])
			VALUES
           (N'Cохр'
           ,N'Сохраняемость')

		   
		   select @relID = max (OperationGroupID) from [OperationGroup]

		   select @OpID = OperationID  from [dbo].[Operation] where Code= N'С24'

		  

  			WHERE OperationID = @OpID
Commit 
GO




