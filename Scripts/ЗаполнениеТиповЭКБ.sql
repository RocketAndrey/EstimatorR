USE [Estimator]
GO
DECLARE @name nvarchar(50);
DECLARE @Counter int;

select @name= N'Ôוננטעמגûו ןנטבמנû';

SELECT @Counter=count([Name]) from [ClassECB] where [Name] = @name;

IF @Counter=0
	INSERT INTO [dbo].[ClassECB]([Name])VALUES (@name)
GO
select * from [ClassECB]

