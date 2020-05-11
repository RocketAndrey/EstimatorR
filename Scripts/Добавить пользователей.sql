USE [Estimator]
GO

INSERT INTO [dbo].[User]
           ([Email]
           ,[Password])
     VALUES
           ('aan@kbrocket.ru','111111')
INSERT INTO [dbo].[User]
           ([Email]
           ,[Password])
     VALUES
           ('viv@kbrocket.ru','123456')
		   USE [Estimator]
GO

UPDATE [dbo].[User]
   SET 
      [Family] = N'Аскерко'
      ,[Name] = N'Андрей'
      ,[Role] = 1

 WHERE [Email]= 'aan@kbrocket.ru'

 UPDATE [dbo].[User]
   SET 
      [Family] = N'Волков'
      ,[Name] = N'Игорь'
      ,[Role] = 1

 WHERE [Email]= 'viv@kbrocket.ru'
GO


GO

