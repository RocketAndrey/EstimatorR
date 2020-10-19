USE [asulive]

delete from [dbo].[Estimator_TestChainItem]
--МИКРОСХЕМЫ
BEGIN
BEGIN
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 268,  70  )
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 269, 70   )
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 130, 74   )
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 32,  62  )
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 273, 33   )
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 272, 31  )
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 133,  41  )
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 84,638)
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 344, 632 )
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 1,633  )
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 246,  15  )
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 260,11    )
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 4,15)
---Нанесение отличительной маркировки
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 20,   2440 )
--Испытание на воздействие изменений температуры среды
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 349,79 )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 81, 640   )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 100,  641  )
--Испытание на герметичность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 67,  642  )
--Проверка наличия посторонних частиц в подкорпусном пространстве  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 146,  643  )
--Приемка партии по результатам ДПО 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 259, 640   )
--Отбор для испытаний на специальные факторы=сериализация
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 331, 633   )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 2,  632  )
--Отбор на безотказность= сериализация
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 165,  633  )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 98, 637   )
--Испытание на воздействие повышенной температуры среды при транспортировании и хранении  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 274,   76 )
--Испытание на воздействие пониженной температуры среды при транспортировании и хранении 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 275,    78)
--Испытание на воздействие повышенной влажности воздуха  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 107,   37 )
END

--СОЕДИНИТЕЛИ
BEGIN

--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 344,366    )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 1,369)
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 246,365)
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 4,367)
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 260,363)
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 32,370)
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 272,383)
--Испытание на воздействие пониженной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 273,385 )
--Термоциклы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 349,387)
END
--КОНДЕНСАТОРЫ
BEGIN
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 32,238 )
END
--КРЕПЕЖИ
begin
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (731 , 32, 370   )
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (731 , 272,   383 )
--Испытание на воздействие пониженной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (731 , 273,385    )
--Испытание на воздействие изменения температуры среды  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (731 , 98,387)
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (731 , 130,382)
END
--ДАТЧИКИ ТОКА
BEGIN
--Испытания на прочность при воздействии синусоидальной вибрации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (787 , 371, 71   )
--Испытание на  воздействие одиночных ударов 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (787 , 130,  74  )
end
--контакторы
begin
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (880 , 32,  370  )
--Испытания на прочность при воздействии синусоидальной вибрации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (880 , 371,  378  )
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (880 , 130,  382  )
--
end 
--Датчики напряжения
BEGIN
--Испытания на прочность при воздействии синусоидальной вибрации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1027 , 371,  70  )
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1027 , 130,74)

END

--Разъемы
BEGIN
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 32,370)
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 130,382 )
--Испытание на воздействие повышенной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 272,383)
--Испытание на воздействие пониженной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 273,385)
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 98,387)
--Испытание на вибропрочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 268,378)
END
--ИС высокой степени интеграции
begin 
--Испытания на прочность при воздействии синусоидальной вибрации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 371,26)
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 130,30)
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 272,31)
--Испытание на воздействие повышенной температуры среды (предельная), прочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 10390,32)
--Испытание на воздействие пониженной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 273,33)

--Испытание на воздействие пониженной температуры среды (предельная), прочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 10391,34)
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 32,18)
end
--ИС средней степени интеграции
BEGIN
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 32, 62)
--Испытание на воздействие пониженной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 273, 77)
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 272, 75)
--Термоциклы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 349,79)
--Испытания на прочность при воздействии синусоидальной вибрации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 371, 70)
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 130,74)
--Испытание на воздействие повышенной температуры среды (предельная), прочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 10390,76)
--Испытание на воздействие пониженной температуры среды (предельная), прочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 10391,78)
--Испытание на воздействие изменения температуры среды  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 98,637)
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 81,640)
--Электротермотренировка   
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 84,638)
--Контроль дрейфа параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 100,641)
--Проверка наличия посторонних частиц в подкорпусном пространстве  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 146,643)
--Испытание на герметичность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 67,642)
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 259,640)
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 2,632)
--Испытание на вибропрочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 268, 70)
--Испытание на виброустойчивость  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 269,70)
--Идентификация ЭКБ ИП 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 344,58    )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 1, 61   )
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 246,  57  )
--Проверка габаритных, установочных и присоединительных размеров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 4, 59   )
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 260,  55  )
--Испытание на воздействие атмосферного пониженного  давления 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 133,  85  )
END
--ИС малой степени интеграции
begin
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 32, 458   )
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 272,471    )
--Испытание на воздействие пониженной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 273,473)
--Термоциклы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 349,475)
--Испытания на прочность при воздействии синусоидальной вибрации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 371,466    )
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 130, 470  )
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 344,454    )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 1,457  )
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 246, 453   )
--Проверка габаритных, установочных и присоединительных размеров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 4,455)
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 260,451)
--Испытание на воздействие повышенной температуры среды (предельная), прочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10390,472)
--Испытание на воздействие пониженной температуры среды (предельная), прочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10391,474)
--Испытание на вибропрочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 268,466)
--Испытание на виброустойчивость 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 269,466)
--Испытание на воздействие повышенной температуры среды при транспортировании и хранении  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 274, 472   )
--Испытание на воздействие пониженной температуры среды при транспортировании и хранении 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 275,  473  )
end

--Полупроводниковые приборы
BEGIN
--Испытание на воздействие изменения температуры среды  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 98,   691 )
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 32,688)	
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 81,694 )	
--Электротермотренировка   
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 84, 692)	

--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 100, 695 )
--Проверка наличия посторонних частиц в подкорпусном пространстве
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 146,697    )
--Испытание на герметичность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 67, 696   )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 259,694 )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 2, 686   )
END

--Полупроводниковые и оптоэлектронные приборы
BEGIN
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1297 , 32, 688   )
--Контроль по ужесточенным нормам 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1297 , 81,694    )
--Испытание на герметичность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1297 , 67,696    )
--Испытание на способность к пайке 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1297 , 138,  704  )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1297 , 2,  686  )
--Контроль внешнего вида и сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1297 , 351,686    )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1297 , 1, 687   )
END

--Транзисторы
Begin
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 260,   495 )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 1, 501)
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 246, 497)

END 

--МОДУЛИ IGBT
BEGIN
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1018 , 32, 326   )
--Испытания на прочность при воздействии синусоидальной вибрации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1018 , 371,  334  )
--Испытание на  воздействие одиночных ударов 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1018 , 130,338    )
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1018 , 272,  339  )
END

--Реле контроля фаз
BEGIN
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1251 , 32,  106  )
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1251 , 272,  119  )
--Испытание на воздействие пониженной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1251 , 273,121    )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1251 , 98, 123   )
--Испытание на воздействие повышенной температуры среды при транспортировании и хранении  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1251 , 274, 120   )
--Испытание на воздействие пониженной температуры среды при транспортировании и хранении 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1251 , 275, 122   )
END

--Изделия коммутационные и соединители
BEGIN
--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1301 , 88, 800   )
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1301 , 32,  798  )
--Контроль по ужесточенным нормам 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1301 , 81, 802   )
--Приемка партии по результатам ДПО 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1301 , 259,  802)
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1301 , 2,797)
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1301 , 98, 387   )
--Испытание на вибропрочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1301 , 268,  379  )
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1301 , 130,  382  )
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1301 , 272, 383)
--Испытание на воздействие пониженной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1301 , 273, 385)
--Испытание на воздействие атмосферного пониженного  давления 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1301 , 133,  393  )
END

--Конденсаторы и конденсаторные сборки
BEGIN
--Испытание на воздействие изменения температуры среды
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 98,  775  )
--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 88, 776   )
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 32, 774  )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 81, 778   )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 259, 778   )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 2, 773   )

--Испытание на вибропрочность
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 268,  246  )
--Испытание на воздействие атмосферного пониженного  давления 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 133, 253   )

--Испытание на  воздействие одиночных ударов 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 130, 250)
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 272,251    )
--Испытание на воздействие пониженной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 273, 253   )

END

END
select c.TestChainItemID ,tc.AsuClassID,e.[Name], tc.AsuBaseOperationID, o.Name   from Estimator_TestChainItem tc,Estimator.dbo.TestChainItem c, Estimator.dbo.Operation o, Estimator.dbo.ElementType e
where e.ElementTypeID= c.ElementTypeID and o.OperationID = c.OperationID 
and tc.TestChainItemID= c.TestChainItemID 



--ОПЕРАЦИИ
