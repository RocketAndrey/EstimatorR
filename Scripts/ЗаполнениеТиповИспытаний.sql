USE [Estimator]
GO
DECLARE @name nvarchar(150);
declare @code nvarchar(4);

DECLARE @Counter int;

select @name= N'Подготовка протоколов и заключений по результатам СИ', @code=N'С22'

SELECT @Counter=count([Name]) from [Operation] where [Name] = @name;
IF @Counter= 0
	INSERT INTO [dbo].[Operation]
           ([Name]
           ,[Code]
           ,[DPO])
     VALUES
           (@name,@code, 0)

GO
select * from Operation

