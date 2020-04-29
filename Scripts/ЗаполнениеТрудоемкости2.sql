use Estimator
select*  from Operation
where OperationGroupID =2

Select * from Qualification

Update TestAction set BatchLabor=30,ItemLabor= 1
where TestActionID in (select TestActionID from TestChainItem, TestAction 
where TestAction.TestChainItemID = TestChainItem.TestChainItemID   and OperationID = 21 and QualificationID=4 )
