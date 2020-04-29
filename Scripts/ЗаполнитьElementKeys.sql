use Estimator
select * from ElementType
delete from ElementKey
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(1,N'Микросхема1')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(2,N'Микросхема2')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(5,N'реле')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(6,N'трансформатор')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(7,N'резистор')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(7,N'сборкарезисторная')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(8,N'конденсатор')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(9,N'индуктивность')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(6,N'дроссель')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(10,N'модуль')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(11,N'соединитель')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(11,N'вилка')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(11,N'розетка')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(12,N'феррит')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(13,N'Микросхема3')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(14,N'транзистор')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(14,N'диод')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(14,N'стабилитрон')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(2,N'Микросхема')
INSERT INTO [dbo].[ElementKey]([ElementTypeID],[Key]) VALUES(96,N'Предохранитель')


GO

select * from ElementKey