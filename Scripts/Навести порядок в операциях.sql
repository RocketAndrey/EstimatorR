USE [Estimator]
GO
select * from [OperationGroup]

INSERT INTO [dbo].[OperationGroup]
           ([Code]
           ,[Name])
     VALUES
           (N'ВыхК'
           ,N'Выходной контроль')
GO


select * from Operation
Update Operation set OperationGroupID=6 where code in ( N'У', N'П',N'В6')

update Operation set OperationGroupID =2  where code =N'С'

Update Operation set OperationGroupID=3
 where Code in  (N'В2',N'В2.1', N'До1',
N'До2',
N'До3',
N'До4',
N'Дун',
N'Ддр',
N'В3',
N'До5',
N'Дм',
N'Дут',
N'Пр',
N'Дпли',
N'Пр0',
N'В1.2',
N'Двах',
N'Дс',
N'Двах',
N'До41',
N'Дсбо',
N'Кср',
N'Дутэ',
N'С',
N'О1',
N'О2',
N'О3',
N'О4',
N'О5',
N'О6',
N'О7',
N'Пр',
N'В2',
N'В5',
N'М',
N'Д1',
N'Д2',
N'Д4',
N'Д5',
N'Д6',
N'Д7',
N'Д8',
N'Д9',
N'Д10',
N'Д11',
N'Д12',
N'Д13',
N'Д14',
N'Д15П',
N'Д16П',
N'O5K',
N'О6К',
N'О7.1',
N'О8',
N'О8.1',
N'О3Р',
N'О7С',
N'О7.1',
N'О4.1',
N'О6Р',
N'О7.1',
N'О9',
N'О4С',
N'Д2м',
N'Д1м')