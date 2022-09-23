use   [u1000209_ESTIMATOR]

declare @2020ID int

select @2020ID = CompanyHistoryID  from CompanyHistory where YearOfNorms = 2021

if isnull(@2020ID,0) = 0 
BEGIN
BEGIN TRANSACTION
INSERT INTO [dbo].[CompanyHistory]
           ([OverHead]
           ,[Margin]
           ,[PensionTax]
           ,[CompanyName]
           ,[YearOfNorms]
           ,[AdditionalSalary])
     VALUES
           (170.64
           ,20
           ,19.6
           ,N'АО КБ Ракета'
           ,2021
           ,7.96)
		select @2020ID = max(CompanyHistoryID) from CompanyHistory 
		--специальности
		Insert into StaffItem (CompanyHistoryID,QualificationID,[Count],Salary)
		Select @2020ID,QualificationID,[Count],Salary from StaffItem where CompanyHistoryID = 1
	--коофициенты
	Insert Into [dbo].[CalcFactor]([CompanyHistoryID],FactorName , FactorValue )
	select @2020ID ,  FactorName , FactorValue  from  CalcFactor 
	COMMIT
END 

--руководитель темы
UPDATE [dbo].[StaffItem]
   SET [Salary] = 963.75
 WHERE CompanyHistoryID = @2020ID and QualificationID = 1
 --ведущий инженер
UPDATE [dbo].[StaffItem]
   SET [Salary] = 636.31
 WHERE CompanyHistoryID = @2020ID and QualificationID = 2
 --инженер 1 категории
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 562.5
 WHERE CompanyHistoryID = @2020ID and QualificationID = 3
 --инженер 2 категории
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 391.67
 WHERE CompanyHistoryID = @2020ID and QualificationID = 4
 --техник
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 254.40
 WHERE CompanyHistoryID = @2020ID and QualificationID = 5
GO


select CompanyHistoryID,QualificationID,[Count],Salary  from StaffItem 



select * from CompanyHistory