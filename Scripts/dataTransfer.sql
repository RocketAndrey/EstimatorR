USE [master]
GO
Insert into Estimator.dbo.Customer
	([Name]
      ,[INN])
SELECT 
      [Имя]
      ,left([ИНН],10)
  FROM [master].dbo.[Контрагенты]
GO


