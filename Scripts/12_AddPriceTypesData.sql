use   Estimator


declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = N'12_AddPriceTypesData';
select @scriptNumber = 12;

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
Declare @Pr int 
INSERT INTO [dbo].[PriceItemType]
           ([PriceItemTypeName])
     VALUES
           (N'Общий')

--Резисторы постоянные непроволочны
INSERT INTO [dbo].[PriceItemType]
           ([PriceItemTypeName])
     VALUES
           (N'Резисторы постоянные непроволочные')

select @Pr= max (PriceItemTypeID ) from PriceItemType 


INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property0',N'Сопротивление,R Ом')
INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property1',N'Мощность,P Вт')
INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property2',N'ТКС, TCR')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property3',N'Класс точности %')
INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property4',N'Маркировка')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property5',N'Колличество')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property6',N'Повышенная стойкость')
--Конденсаторы постоянной емкости керамические
INSERT INTO [dbo].[PriceItemType]
           ([PriceItemTypeName])
     VALUES
           (N'Конденсаторы постоянной емкости керамические')

select @Pr= max (PriceItemTypeID ) from PriceItemType 

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property0',N'ТКЕ')
INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property1',N'Напряжение, В')
INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property2',N'Емкость')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property3',N'Класс точности %')
INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property4',N'Отклонение, пФ')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property5',N'Отклонение %')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property6',N'Видоразмер')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property7',N'Покрытие')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property8',N'Кол-во')

INSERT INTO [dbo].[PricePropertyName] ([PriceItemTypeId] ,[PropertyName],[ElementPropertyName])
VALUES(@Pr ,N'Property9',N'Блистерная лента')
					COMMIT
			END
				
			
			ELSE ROLLBACK 

GO

