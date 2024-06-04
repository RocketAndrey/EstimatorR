use   Estimator


declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = N'07_заполнение истории цены ';
select @scriptNumber = 07;

BEGIN TRANSACTION



		   if (select count(*) from [database_updates] where[ScriptNumber] = 7) = 0 
		   BEGIN   
			   INSERT INTO [dbo].[database_updates]
			   ([ScriptNumber]
			   ,[ScriptName]
			   ,[ScriptDate] )
				VALUES
			   (@scriptNumber
			   ,@scriptName
			   ,Getdate())
				update [XLSXElementType] set [ImportedPrice] = [ElementPrice],[PriceType] = 0

				INSERT INTO [dbo].[ElementPriceHistory]
						   ([XLSXElementTypeID]
						   ,[CustomerRequestID]
						   ,[PriceType]
						   ,[PriceAmount]
						   ,[CreateDate])
				select id,e.CustomerRequestID,0,ElementPrice,c.CreateDate
				FROM [dbo].[XLSXElementType] X, ElementImports E,CustomerRequests c
				WHERE E.ElementImportID = x.ElementImportID and x.ElementPrice >0 
				AND c.CustomerRequestID= e.CustomerRequestID
				COMMIT
			END
			ELSE ROLLBACK 

GO



