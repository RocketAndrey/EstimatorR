USE [Estimator]
GO
DECLARE @name nvarchar(50);
DECLARE @ID int;
DECLARE @Counter int;
Declare @ProgramID int;
Declare @CounterChains int;

select @name= N'Предохранители';
select @ProgramID = [TestProgramID] from TestProgram where RTRIM(LTRIM([Name]))= N'СИ ЭКБ ИП Общая'

SELECT @counter= Count(*) from [ElementType] where [Name] = @name and [ProgramID]=@ProgramID;
select @ID=ElementTypeID from [ElementType]  where [Name] = @name and [ProgramID]=@ProgramID;

select @CounterChains = COUNT(*) from [TestChainItem] where ElementTypeID=@ID

Print @Counter;
Print @CounterChains;
print @ID 

IF @Counter=1 and @CounterChains = 0 
BEGIN
	INSERT INTO [dbo].[TestChainItem]
			   ([ElementTypeID]
			   ,[OperationID]
			   ,[Order])
	select ElementTypeID,OperationID,OperationID from Operation,[ElementType]
	where ElementTypeID=@ID
	INSERT INTO [dbo].[TestAction]
           ([QualificationID]
           ,[BatchLabor]
           ,[ItemLabor]
           ,[TestChainItemID])
		SELECT [QualificationID], 0,0,TestChainItemID from [TestChainItem],[Qualification]
		WHERE [ElementTypeID] =@ID
	
END 





