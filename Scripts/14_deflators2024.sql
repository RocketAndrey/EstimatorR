use   Estimator


declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = N'14_Deflators2024';
select @scriptNumber = 14;

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

			INSERT INTO [dbo].[Deflators] ([Year] ,[Value]) VALUES (2023,108.2)
			INSERT INTO [dbo].[Deflators] ([Year] ,[Value]) VALUES (2024,106.1)
			INSERT INTO [dbo].[Deflators] ([Year] ,[Value]) VALUES (2025,105.5)
			INSERT INTO [dbo].[Deflators] ([Year] ,[Value]) VALUES (2026,103.9)


					COMMIT
			END
				
			
			ELSE ROLLBACK 

GO

select * from [Deflators]