USE [Estimator]
GO
DECLARE @name nvarchar(150);
declare @code nvarchar(4);
declare @ElementTypeID int;
declare @OperationID int;
DECLARE @Counter int;
declare @order int;
declare @TestChainItemID int;
declare @OperationGroup int;
Declare @sampleCount int;

BEGIN TRANSACTION;


--ВВЕДИ НАЗВАНИЕ ОПЕРАЦИИ, КОД И 
select @code=N'С24' , @name= N'Испытания на сохраняемость', @OperationGroup=4, @sampleCount =5, @order = 432;
--select @code=N'С23' , @name= N'Испытания на безотказность', @OperationGroup=4, @sampleCount =10, @order = 431;
--ПРОВЕРЯЕМ БЫЛА ЛИ ТАКАЯ ОПЕРАЦИЯ
SELECT @OperationID =ISNULL(OperationID,0)
from [Operation] where [Name] = @name And [Code]=@code;



IF ISNULL(@OperationID,0)= 0
BEGIN 
--СОЗДАЁМ ОПЕРАЦИЮ
	INSERT INTO [dbo].[Operation]
           ([Name]
           ,[Code]
           ,[DPO],IsExecuteDefault,OperationGroupID,SampleCount)
     VALUES
           (@name,@code, 0,1,@OperationGroup,@sampleCount)
		--ПОЛУЧАЕМ ИД НОВОЙ ОПЕРАЦИИ
		select @OperationID= MAX(OperationID) from Operation;


--СОЗДАЕМ НОВЫЕ ЗВЕНЬЯ  ЦЕПОЧКИ для всех  элементов в программе испытанй 
INSERT INTO [dbo].[TestChainItem]
			   ([ElementTypeID]
			   ,[OperationID]
			   ,[Order])
		 select ElementTypeID,@OperationID,@order from ElementType where ProgramID = 5
		--ЗАДАЕМ ТРУДОЕМКОСТИ ПО СПЕЦИАЛЬНОСТЯМ
		INSERT INTO [dbo].[TestAction]
           ([QualificationID]
           ,[BatchLabor]
           ,[ItemLabor]
           ,[TestChainItemID]
           ,[KitLabor])
		  SELECT  QualificationID,0,0,TestChainItemID, 0 from Qualification, TestChainItem
		  where TestChainItem.[Order]= @order
END

commit;
GO



