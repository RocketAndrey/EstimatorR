/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
declare @companyHistoryID int;
select @companyHistoryID = CompanyHistoryID from CompanyHistory where
YearOfNorms= 2019;
if isnull(@companyHistoryID,0)=0 
begin 
INSERT INTO [dbo].[CompanyHistory]
           ([OverHead]
           ,[Margin]
           ,[PensionTax]
           ,[CompanyName]
           ,[YearOfNorms])
     VALUES
           (186.36
           ,19.8
           ,30.2
           ,N'АО КБ Ракета'
           ,2019)

end

select @companyHistoryID = CompanyHistoryID from CompanyHistory where
YearOfNorms= 2019;

delete from [CalcFactor] where [CompanyHistoryID]=@companyHistoryID;

INSERT INTO [dbo].[CalcFactor]
           ([CompanyHistoryID]
           ,[FactorName]
           ,[FactorValue])
     VALUES
           (@companyHistoryID
           ,N'Трудопотери 5%'
           ,1.05)

INSERT INTO [dbo].[CalcFactor]
([CompanyHistoryID]
,[FactorName]
,[FactorValue])
VALUES
(@companyHistoryID
,N' Ежедневнная подготовка/уборка рабочего места (20 мин.день) '
,1.043)

INSERT INTO [dbo].[CalcFactor]
([CompanyHistoryID]
,[FactorName]
,[FactorValue])
VALUES
(@companyHistoryID
,N'Технологические перерываы согласно СанПиН 2.2.2.542-96 10 мин/час'
,1.05)

delete from StaffItem

INSERT INTO [dbo].[StaffItem]
           ([CompanyHistoryID]
           ,[QualificationID]
           ,[Count]
           ,[Salary])
	select @companyHistoryID,[Qualification].QualificationID,5,10000 from [dbo].[Qualification]

UPDATE [dbo].[StaffItem]
   SET 
      [Salary] = 913.75
 WHERE [QualificationID] = 
 (select[QualificationID] from Qualification where 
 Name = N'Руководитель темы')

 UPDATE [dbo].[StaffItem]
   SET 
      [Salary] = 586.31
 WHERE [QualificationID] = 
 (select[QualificationID] from Qualification where 
 Name = N'Ведущий инженер')

 UPDATE [dbo].[StaffItem]
   SET 
      [Salary] = 512.5
 WHERE [QualificationID] = 
 (select[QualificationID] from Qualification where 
 Name = N'Инженер 1 категории')

 UPDATE [dbo].[StaffItem]
   SET 
      [Salary] = 341.67
 WHERE [QualificationID] = 
 (select[QualificationID] from Qualification where 
 Name = N'Инженер 2 категории')

 UPDATE [dbo].[StaffItem]
   SET 
      [Salary] = 214.40
 WHERE [QualificationID] = 
 (select[QualificationID] from Qualification where 
 Name = N'Техник 1 категории')


GO
