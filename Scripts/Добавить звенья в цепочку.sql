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

Select @ElementTypeID = 35 --Ферритовые изделия и приборы СВЧ
--ВВЕДИ НАЗВАНИЕ ОПЕРАЦИИ, КОД И 
--select @code=N'В1' , @name= N'Контроль внешнего вида и маркировки', @OperationGroup=2, @sampleCount =-1, @order = 11;
--select @code=N'В1.1' , @name= N'Контроль электромагнитных параметров изде-лий и приборов в нормальных условиях по категории С-2 ТУ', @OperationGroup=2, @sampleCount =-1;
--select @code=N'В1.3' , @name= N'Контроль электромагнитных параметров изделий и приборов в нормальных условиях по ужесточенным нормам', @OperationGroup=2, @sampleCount =-1;
--select @code=N'Д2.1' , @name= N'Термоциклирование (3-10 циклов в соответствии с ТУ)', @OperationGroup=3, @sampleCount =-1;
--select @code=N'D2.2' , @name= N'Испытания на вибропрочность по ТУ', @OperationGroup=3, @sampleCount =-1;
--select @code=N'D2.3' , @name= N'Измерение электромагнитных параметров изделий и приборов в нормальных условиях по В1.1', @OperationGroup=3, @sampleCount =-1;
--select @code=N'D2.4' , @name= N'Контроль электромагнитных параметров изделий и приборов в нормальных условиях по ужесточенным нормам', @OperationGroup=3, @sampleCount =-1;
--select @code=N'D2.5' , @name= N'Проверка устойчивости изделий и приборов к воздействию верхнего и нижнего значения температуры окружающей среды', @OperationGroup=3, @sampleCount =-1;

--select @code=N'В5' , @name= N'Приемка партии по результатам ДПО', @OperationGroup=3, @sampleCount =-1;
--select @code=N'М' , @name= N'Нанесение отличительной маркировки ИЦ', @OperationGroup=6, @sampleCount =-1;
--select @code=N'П' , @name= N'Оформление протокола', @OperationGroup=6, @sampleCount =-1;
select @code=N'О7' , @name= N'Проверка электрических параметров  на соответсвие ТУ', @OperationGroup=3, @sampleCount =-1;
select @order =350

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
END

--select @order = MAX([Order])+10 from TestChainItem  where ElementTypeID=@ElementTypeID 

--СОЗДАЕМ НОВЫЕ ЗВЕНЬЯ  ЦЕПОЧКИ для всех  элементов в программе испытанй 
INSERT INTO [dbo].[TestChainItem]
			   ([ElementTypeID]
			   ,[OperationID]
			   ,[Order])
		 values (@ElementTypeID,@OperationID,@order)
		--ЗАДАЕМ ТРУДОЕМКОСТИ ПО СПЕЦИАЛЬНОСТЯМ
		select @TestChainItemID =max (TestChainItemID) from TestChainItem 
		INSERT INTO [dbo].[TestAction]
           ([QualificationID]
           ,[BatchLabor]
           ,[ItemLabor]
           ,[TestChainItemID]
           ,[KitLabor])
		  SELECT  QualificationID,0,0,@TestChainItemID, 0 from Qualification
		  

commit;

GO



