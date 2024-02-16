use   Estimator_160224


declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = N'06_добавление ключей из тестовой базы';
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
 
Insert into Estimator_160224.dbo.ElementKey (ElementTypeID,[key])

select ec.ElementTypeID,ec.[Key]
from  ESTIMATOR.dbo.ElementKey ec 
where isnull((select [key] from Estimator_160224.dbo.ElementKey e where  e.[key]= ec.[key] and e.ElementTypeID=ec.ElementTypeID) ,'')=''

Commit 
GO



