use   u1000209_ESTIMATOR


declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = N'10_XSLXElementType_ImportedName';
select @scriptNumber = 10;

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

					UPDATE XLSXElementType Set ImportedElementName = ElementName,
					ImportedDatasheet = Datasheet
					
					UPDATE XLSXElementType Set ElementName = '',
					Datasheet = ''

					COMMIT
			END
				
			
			ELSE ROLLBACK 

GO

