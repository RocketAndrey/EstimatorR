use   [u1000209_ESTIMATOR]

/****** Object:  Table [dbo].[database_updates]    Script Date: 26.06.2023 16:54:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[database_updates]') AND type in (N'U'))
DROP TABLE [dbo].[database_updates]
GO

/****** Object:  Table [dbo].[database_updates]    Script Date: 26.06.2023 16:54:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[database_updates](
	[ScriptNumber] [int] NOT NULL,
	[ScriptName] [varchar](50) NOT NULL,
	[ScriptDate] [datetime] NOT NULL
) ON [PRIMARY]
GO




declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = '01_ДобавитьНормативы2021';
select @scriptNumber = 01;

select @year = 2021


INSERT INTO [dbo].[database_updates]
           ([ScriptNumber]
           ,[ScriptName]
           ,[ScriptDate])
     VALUES
           (@scriptNumber
           ,@scriptName
           ,Getdate())


declare @2020ID int

BEGIN TRANSACTION
select @2020ID = CompanyHistoryID  from CompanyHistory where YearOfNorms = @year

if isnull(@2020ID,0) = 0 
BEGIN
INSERT INTO [dbo].[CompanyHistory]
           ([OverHead]
           ,[Margin]
           ,[PensionTax]
           ,[CompanyName]
           ,[YearOfNorms]
           ,[AdditionalSalary])
     VALUES
           (0
           ,0
           ,0
           ,N'АО КБ Ракета'
           ,@year
           ,0)
select @2020ID = max(CompanyHistoryID) from CompanyHistory where YearOfNorms = @year
end


UPDATE [dbo].[CompanyHistory]
   SET [OverHead] = 170.64
      ,[Margin] =20
      ,[PensionTax] =19.6

      ,[AdditionalSalary] =7.96
 WHERE  CompanyHistoryID = @2020ID

	delete from  StaffItem where CompanyHistoryID =  @2020ID
		--специальности
	Insert into StaffItem (CompanyHistoryID,QualificationID,[Count],Salary)
	Select @2020ID,QualificationID,[Count],Salary from StaffItem where CompanyHistoryID = 1

	delete from  [CalcFactor] where CompanyHistoryID =  @2020ID
	--повторяем из предыдущего года
	Insert Into [dbo].[CalcFactor]([CompanyHistoryID],FactorName , FactorValue )
	select @2020ID ,  FactorName , FactorValue  from  CalcFactor where  CompanyHistoryID =(select CompanyHistoryID from CompanyHistory where YearOfNorms = @year-1 )
	

--руководитель темы
UPDATE [dbo].[StaffItem]
   SET [Salary] = 1320.00
 WHERE CompanyHistoryID = @2020ID and QualificationID = 1
 --ведущий инженер
UPDATE [dbo].[StaffItem]
   SET [Salary] = 667.61
 WHERE CompanyHistoryID = @2020ID and QualificationID = 2
 --инженер 1 категории
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 561.88
 WHERE CompanyHistoryID = @2020ID and QualificationID = 3
 --инженер 2 категории
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 348.04
 WHERE CompanyHistoryID = @2020ID and QualificationID = 4
 --техник
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 275.00
 WHERE CompanyHistoryID = @2020ID and QualificationID = 5

 COMMIT
GO




