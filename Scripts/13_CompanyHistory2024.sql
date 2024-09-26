use   Estimator


declare @scriptNumber int, @year int;
declare @scriptName nvarchar (100);
select @scriptName = N'13_CompanyHistory2024';
select @scriptNumber = 13;

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
			   declare @companyHistoryID int;

select @companyHistoryID = CompanyHistoryID from CompanyHistory where
YearOfNorms= 2024;
if isnull(@companyHistoryID,0)=0 
begin 

INSERT INTO [dbo].[CompanyHistory]
           ([OverHead]
           ,[Margin]
           ,[PensionTax]
		   ,[AdditionalSalary]
           ,[CompanyName]
           ,[YearOfNorms],
		   [ProductionExpenses],
		   [GeneralionExpenses])
     VALUES
           (0
           ,25
           ,17.23
		   ,6.85
           ,N'�� �� ������'
           ,2024
		   ,43.06
		   ,110.21)

end

select @companyHistoryID = CompanyHistoryID from CompanyHistory where YearOfNorms= 2024;

delete from [CalcFactor] where [CompanyHistoryID]=@companyHistoryID;

INSERT INTO [dbo].[CalcFactor]
           ([CompanyHistoryID]
           ,[FactorName]
           ,[FactorValue])
     VALUES
           (@companyHistoryID
           ,N'����������� 5%'
           ,1.05)

INSERT INTO [dbo].[CalcFactor]
([CompanyHistoryID]
,[FactorName]
,[FactorValue])
VALUES
(@companyHistoryID
,N' ����������� ����������/������ �������� ����� (20 ���.����) '
,1.043)

INSERT INTO [dbo].[CalcFactor]
([CompanyHistoryID]
,[FactorName]
,[FactorValue])
VALUES
(@companyHistoryID
,N'��������������� ��������� �������� ������ 2.2.2.542-96 10 ���/���'
,1.05)


INSERT INTO [dbo].[StaffItem]
           ([CompanyHistoryID]
           ,[QualificationID]
           ,[Count]
           ,[Salary])
	select @companyHistoryID,[Qualification].QualificationID,5,10000 from [dbo].[Qualification]

UPDATE [dbo].[StaffItem]
   SET 
      [Salary] = 1795.75
 WHERE [QualificationID] = 
 (select[QualificationID] from Qualification where 
 Name = N'������������ ����')

 UPDATE [dbo].[StaffItem]
   SET 
      [Salary] = 807.63
 WHERE [QualificationID] = 
 (select[QualificationID] from Qualification where 
 Name = N'������� �������')

 UPDATE [dbo].[StaffItem]
   SET 
      [Salary] = 670.00
 WHERE [QualificationID] = 
 (select[QualificationID] from Qualification where 
 Name = N'������� 1 ���������')

 UPDATE [dbo].[StaffItem]
   SET 
      [Salary] = 590.00
 WHERE [QualificationID] = 
 (select[QualificationID] from Qualification where 
 Name = N'������� 2 ���������')

 UPDATE [dbo].[StaffItem]
   SET 
      [Salary] = 480.13
 WHERE [QualificationID] = 
 (select[QualificationID] from Qualification where 
 Name = N'������ 1 ���������')
					COMMIT
			END
				
			
			ELSE ROLLBACK 

GO

