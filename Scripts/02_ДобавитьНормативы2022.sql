use   Estimator_160224


declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = '02_ДобавитьНормативы2022';
select @scriptNumber = 02;

select @year = 2022


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
   SET [OverHead] = 154.9
      ,[Margin] =25
      ,[PensionTax] =17.64

      ,[AdditionalSalary] =7.99
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
   SET [Salary] = 706.48
 WHERE CompanyHistoryID = @2020ID and QualificationID = 2
 --инженер 1 категории
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 577.5
 WHERE CompanyHistoryID = @2020ID and QualificationID = 3
 --инженер 2 категории
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 558.21
 WHERE CompanyHistoryID = @2020ID and QualificationID = 4
 --техник
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 312.88
 WHERE CompanyHistoryID = @2020ID and QualificationID = 5

 COMMIT
GO




