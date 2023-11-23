use   [u1000209_ESTIMATOR]



declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = '04_Дополнить Связь ДИ и СИ ЭКБ ОП';
select @scriptNumber = 04;



INSERT INTO [dbo].[database_updates]
           ([ScriptNumber]
           ,[ScriptName]
           ,[ScriptDate])
     VALUES
           (@scriptNumber
           ,@scriptName
           ,Getdate())

BEGIN TRANSACTION
update ElementType set ChildElementTypeID=10
where ElementTypeID=89
update ElementType set ChildElementTypeID=106
where ElementTypeID in (90,91,92,93,94,95)

 COMMIT
GO




