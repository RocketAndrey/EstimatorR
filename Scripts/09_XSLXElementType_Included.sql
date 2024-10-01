use   u1000209_ESTIMATOR


declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = N'09_XSLXElementType_Included';
select @scriptNumber = 09;

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

					UPDATE XLSXElementType Set Included =1 ,MinPackingSize=1,PackingSample =1 
					COMMIT
			END
				
			
			ELSE ROLLBACK 

GO

