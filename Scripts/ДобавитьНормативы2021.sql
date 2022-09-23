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
           ,N'�� �� ������'
           ,2021
           ,7.96)
		select @2020ID = max(CompanyHistoryID) from CompanyHistory 
		--�������������
		Insert into StaffItem (CompanyHistoryID,QualificationID,[Count],Salary)
		Select @2020ID,QualificationID,[Count],Salary from StaffItem where CompanyHistoryID = 1
	--�����������
	Insert Into [dbo].[CalcFactor]([CompanyHistoryID],FactorName , FactorValue )
	select @2020ID ,  FactorName , FactorValue  from  CalcFactor 
	COMMIT
END 

--������������ ����
UPDATE [dbo].[StaffItem]
   SET [Salary] = 963.75
 WHERE CompanyHistoryID = @2020ID and QualificationID = 1
 --������� �������
UPDATE [dbo].[StaffItem]
   SET [Salary] = 636.31
 WHERE CompanyHistoryID = @2020ID and QualificationID = 2
 --������� 1 ���������
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 562.5
 WHERE CompanyHistoryID = @2020ID and QualificationID = 3
 --������� 2 ���������
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 391.67
 WHERE CompanyHistoryID = @2020ID and QualificationID = 4
 --������
 UPDATE [dbo].[StaffItem]
   SET [Salary] = 254.40
 WHERE CompanyHistoryID = @2020ID and QualificationID = 5
GO


select CompanyHistoryID,QualificationID,[Count],Salary  from StaffItem 



select * from CompanyHistory