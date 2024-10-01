use   u1000209_ESTIMATOR


declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = N'08_TestProgramRuchipsDB';
select @scriptNumber = 08;

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

					UPDATE TestProgram Set UseRuChipsDB =1  where TestProgramID = 2 
					COMMIT
			END
				
			
			ELSE ROLLBACK 

GO

