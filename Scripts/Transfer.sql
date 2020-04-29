/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
Use Arhive
go
USE [Arhive]
GO
/*
INSERT INTO [Arhive].[dbo].[Operation]
           ([Name]
           ,[Code]
           ,[DPO])
SELECT [Name]
      ,[Code]
      ,[DPO]
  FROM [Estimator].[dbo].[Operation]
  
INSERT INTO [Arhive].[dbo].[Customer]
           ([Name]
           ,[INN])
SELECT 
      [Name]
      ,[INN]
  FROM [Estimator].[dbo].[Customer]
  
  

INSERT INTO [Arhive].[dbo].[ClassECB]
           ([Name])
   select [Name] from Estimator.dbo.ClassECB
   */


GO


GO

