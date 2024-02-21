use   Estimator_160224



declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = '03_ДобавитьНормативы2023';
select @scriptNumber = 03;

select @year = 2023


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
   SET [OverHead] = 154.27
      ,[Margin] =25
      ,[PensionTax] =17.5

      ,[AdditionalSalary] =7.55
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
   SET [Salary] = 1581.13
 WHERE CompanyHistoryID = @2020ID and QualificationID = 1
 --ведущий инженер
UPDATE [dbo].[StaffItem]
   SET [Salary] = 757.61
 WHERE CompanyHistoryID = @2020ID and QualificationID = 2
 --инженер 1 категории
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 666.50
 WHERE CompanyHistoryID = @2020ID and QualificationID = 3
 --инженер 2 категории
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 581.43
 WHERE CompanyHistoryID = @2020ID and QualificationID = 4
 --техник
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 358.29
 WHERE CompanyHistoryID = @2020ID and QualificationID = 5


 COMMIT
GO




