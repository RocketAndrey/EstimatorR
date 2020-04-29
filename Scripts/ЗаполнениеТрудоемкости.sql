USE [Estimator]
GO



UPDATE [dbo].[TestAction]
   SET [BatchLabor] = 6
      ,[ItemLabor] = 0
      
 WHERE [QualificationID] = 1 AND TestActionId= 397


select[TestActionID],[dbo].[Operation].OperationID, [Code],[dbo].[Operation].[Name],TestAction.[QualificationID],[dbo].[Qualification].[Name],[BatchLabor],[ItemLabor],[dbo].[TestChainItem].[TestChainItemID],
[dbo].[ElementType].[Name]

from TestAction,Qualification,[dbo].[TestChainItem],[dbo].[Operation],[dbo].[ElementType]

where TestAction.[QualificationID]=[dbo].[Qualification].[QualificationID]
and [dbo].[TestAction].[TestChainItemID]=[dbo].[TestChainItem].[TestChainItemID]
and [dbo].[TestChainItem].[OperationID]=[dbo].[Operation].OperationID
and [dbo].[ElementType].ElementTypeID=[dbo].[TestChainItem].[ElementTypeID]
and [dbo].[Operation].OperationID= 1 and [Qualification].[QualificationID]= 1
order by [dbo].[Qualification].[Name],[dbo].[ElementType].[Order]