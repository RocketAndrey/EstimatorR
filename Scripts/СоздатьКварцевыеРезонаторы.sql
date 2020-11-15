use Estimator
Declare @ElementTypeID int,@order int;
Declare @NewElementTypeID int;
Declare @NewName nvarchar(100);
Declare @BaseOldName nvarchar(100);
Declare @BaseNewName nvarchar(100);

BEGIN TRANSACTION


select @NewName= N'Кварцевые резонаторы',
@BaseOldName=N'Полупроводниковые приборы',
@BaseNewName=N'Полупроводниковые приборы',
@order = 105 ;


Select @ElementTypeID=ElementTypeID from ElementType where Name= @BaseOldName

update ElementType set [Name]=@BaseNewName
where ElementTypeID = @ElementTypeID

Select @NewElementTypeID=ElementTypeID from ElementType 
where Name= @NewName

Select @ElementTypeID=ElementTypeID from ElementType 
where Name= @BaseNewName

if isnull(@NewElementTypeID,0)=0
begin

INSERT INTO [dbo].[ElementType]
           ([Name]
           ,[Order]
           ,[ProgramID]
           ,[ClassECBID])
     SELECT
           @NewName,
          @order ,[ProgramID],[ClassECBID]
	FROM [ElementType] where ElementTypeID = @ElementTypeID

End

Begin
	Select @NewElementTypeID=ElementTypeID from ElementType 
	where Name= @NewName

INSERT INTO [dbo].[TestChainItem]
           ([ElementTypeID]
           ,[OperationID]
           ,[Order]
           ,[Description]
           ,[GroupOperation],[OldTesChainItemId])

Select @NewElementTypeID,OperationID,[Order],Description,GroupOperation,TestChainItemID
From TestChainItem where ElementTypeID = @ElementTypeID 


INSERT INTO [dbo].[TestAction]
           ([QualificationID]
           ,[BatchLabor]
           ,[ItemLabor]
           ,[TestChainItemID]
           ,[KitLabor])

     select e.QualificationID,
			e.BatchLabor,
			e.ItemLabor,
			t2.TestChainItemID,
			e.KitLabor 
	from TestAction e, TestChainItem t, TestChainItem t2
	where e.TestChainItemID= t.TestChainItemID 
	and t2.[OldTesChainItemId] = t.TestChainItemID
	and t.ElementTypeID = @ElementTypeID 

	update TestChainItem set OldTesChainItemId =null
end 

commit   
