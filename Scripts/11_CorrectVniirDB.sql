use   Estimator


declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = N'11_CorrectVniirDB';
select @scriptNumber = 11;

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

					Update DirVniir  set CodeManufacturer = 9
					where Manufacturer LIKE N'%пеяспя%' and  isnull (CodeManufacturer,'-') = '-' 
					COMMIT
			END
				
			
			ELSE ROLLBACK 

GO

