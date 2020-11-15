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

--Испытания на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 104, 1768)

END

--ОПТОРЕЛЕ(ПП)
BEGIN
--Идентификация ЭКБ ИП 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (261 , 344, 498 )
--Сериализация изделий (присвоение индивидуального номера)
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (261 , 1, 687 )
--Проверка внешнего вида и контроль качества маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (261 , 154, 497   )
--Проверка габаритных, установочных и присоединительных размеров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (261 , 4,   499 )
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (261 , 260, 495 )
--Проверка наличия посторонних частиц в подкорпусном пространстве \
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (261 , 146,697)
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (261 , 32,688 )
END

--СОЕДИНИТЕЛИ
BEGIN

--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 344,366 )
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

--Проверка внешнего вида и контроль качества маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 154,365 )

--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 88, 801   )
--Контроль по ужесточенным нормам 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 81,  802  )
--Контроль дрейфа параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 100, 802   )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 2,803 )
--Испытание на воздействие изменения температуры среды  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 98,799)
END
--КОНДЕНСАТОРЫ
BEGIN
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 32,238 )
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem]([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 344, 234   )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 1,   237 )
--Проверка внешнего вида и контроль качества маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 154,    233)
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 4,  235  )
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 260, 231   )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 81,778    )
--Термоциклирование при максимальных значениях повышенной и пониженной температуре  среды по ТД изготовителя  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 10394, 775   )
--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 88,776    )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 100, 778   )
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
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 344,  366  )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 1,369    )
--Проверка внешнего вида и контроль качества маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 154,365   )
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 4,367    )
--Анализ сопроводительной документации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 260, 363   )
--Термоциклирование при максимальных значениях повышенной и пониженной температуре  среды по ТД изготовителя 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 10394,  799  )
--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 88,  800  )
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

--Нанесение отличительной маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 20, 803   )

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
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 344, 14   )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 1, 17   )
--Проверка внешнего вида и контроль качества маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 154, 13   )
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 4,15    )
--Анализ сопроводительной документации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 260,11    )

end
--ИС средней степени интеграции
BEGIN
--Проверка внешнего вида и контроль качества маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 154, 57   )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 10407, 47   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 10408,  48  )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 10409, 49   )
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
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 98, 475   )

--Проверка внешнего вида и контроль качества маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 154, 453   )
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
--Испытание на воздействие атмосферного пониженного  давления  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 133, 481   )
--Испытание на воздействие повышенного давления  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 131,  482  )

--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 100,1916    )
--Электротермотренировка   
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 84,  1913  )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 81, 1915   )

end
--ИС корпусные средней степени интеграции
BEGIN
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 246, 57   )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 1,61    )
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 4,59    )
--Анализ сопроводительной документации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 260,55    )
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 32,841    )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 10407,1355    )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 10408, 1364   )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 10409,1393    )
--Разработка проектов печатных плат оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 10410,  1422  )
--Сборочно-монтажные работы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 10411, 1451   )
--Разработка конструкторской документации для технологической оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 10412,1480    )
--Калибровка (аттестация) оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 10422,1509    )
--Разработка специального программного обеспечения для тестирования ЭКБ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 10414, 1538   )

END
--ИС корпусные низкой степени интеграции
BEGIN
--Контроль электрических параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 22,2045    )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 10407,2080    )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 10408, 2081   )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 10409,2082    )
--Разработка проектов печатных плат оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 10410, 2083   )
--Сборочно-монтажные работы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 10411,2084    )
--Разработка конструкторской документации для технологической оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 10412,2085    )
--Калибровка (аттестация) оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 10422,2086    )
--Разработка специального программного обеспечения для тестирования ЭКБ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 10414,2087    )
END
--Аналого-цифровые преобразователи(средняя степень)
Begin
--Испытание на воздействие повышенной влажности воздуха 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (699 , 107,  37  )
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (699 , 32,  62  )

END
--Операционные усилители
BEGIN
--Испытание на воздействие повышенной влажности воздуха  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1254 , 107,477    )
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1254 , 32, 458   )
END
--Четырехканальные цифровые изоляторы
BEGIN
--Испытание на воздействие повышенной влажности воздуха  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1248 , 107, 477   )
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1248 , 32,  458  )
END
--Реле контроля фаз
BEGIN
--Испытание на воздействие повышенной влажности воздуха 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1251 , 107,477)
END
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
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 344, 498   )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 1, 501   )
--Проверка внешнего вида и контроль качества маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 154,  497  )
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 4, 499   )
--Анализ сопроводительной документации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 260,495    )
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 246,  497  )
--Испытание на воздействие повышенной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 272, 515   )
--Испытание на воздействие пониженной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 273, 517   )
--Испытание на вибропрочность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 268, 510   )
--Испытание на виброустойчивость
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 269,  510  )
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 130,514    )
--Испытание на воздействие атмосферного пониженного  давления  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 133,525    )
END
--ПП корпусные
BEGIN
--Анализ сопроводительной документации
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1326 , 260, 495 )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1326 , 1, 501   )
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1326 , 246,497   )
--Контроль электрических параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1326 , 22,884   )
--Анализ технических спецификаций, выбор критериев параметров - годности 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1326 , 10407,   1337 )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1326 , 10408,  1366  )
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

--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1297 , 130,514    )
--Испытание на вибропрочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1297 , 268, 510   )
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1297 , 272, 515   )
--Испытание на воздействие пониженной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1297 , 273, 517   )
--Испытание на воздействие атмосферного пониженного  давления  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1297 , 133, 525   )
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
--Цифровые датчики температуры (проводим как транзисторы)
BEGIN
--Испытание на воздействие повышенной влажности воздуха  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1245 , 107,521    )
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1245 , 32, 502   )
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
--Приемка партии по результатам ДПО 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 259,802)
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
--Конденсаторы оксидно-полупроводниковые с выводами, конденсаторные сборки
begin
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1318 , 246,233    )
--Анализ технических спецификаций, выбор критериев параметров - годности 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1318 , 10407, 1341   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1318 , 10408,1370    )
end
--Конденсаторы керамические защищенные, пленочные и комбинированные
Begin
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 246,  233  )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 10407,1339   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 10408,  1368  )
end
--Конденсаторы объёмно-пористые танталовые, оксидно-электролитичекие алюминиевые
begin
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1320 , 246,233    )
--Анализ технических спецификаций, выбор критериев параметров - годности 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1320 , 10407,1343    )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1320 , 10408,1372    )
end
--Конденсаторы керамические незащищенные
begin
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1321 , 246,233    )
end
--РЕЗИСТОРЫ
BEGIN
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 344, 190   )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 1, 193   )
--Проверка внешнего вида и контроль качества маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 154, 189   )
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 4,191)
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 260,  790  )
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 32,   794 )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 81,795 )
--Термоциклирование при максимальных значениях повышенной и пониженной температуре  среды по ТД изготовителя  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 10394,792 )
END
--Резисторы постоянные и переменные
BEGIN
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1306 , 246,  790 )
END
--Резисторы постоянные и переменные прецизионные
BEGIN
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 246,   1312 )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 10407,  1363  )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 10408,1392    )
END
--Индуктивности
BEGIN
--Идентификация ЭКБ ИП 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 344,278    )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 1,  281  )
--Проверка внешнего вида и контроль качества маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 154,  277  )
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 4, 279   )
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 260, 275   )
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 246,  277  )
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 32,  282  )
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 272,   295 )
--Испытание на воздействие пониженной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 273,297    )
--Испытание на воздействие изменения температуры среды  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 98, 299   )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 81,794 )
--Термоциклирование при максимальных значениях повышенной и пониженной температуре  среды по ТД изготовителя  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 10394,  761  )
--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 88, 762   )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 100,  794  )
END
--Моточные изделия
begin
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1311 , 344,146    )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1311 , 1, 149   )
--Проверка внешнего вида и контроль качества маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1311 , 154, 145   )
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1311 , 4, 147   )
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1311 , 260,143    )
end
--Резонаторы кварцевые
BEGIN
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 344,  2538  )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 1,  2541  )
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 246,  2537  )
--Проверка габаритных, установочных и присоединительных размеров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 4,2539    )
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 260,2535    )

END
---ПРЕДОХРАНИТЕЛИ 
BEGIN

--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 246,541    )
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 4, 543   )
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 260,  539  )
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 344,  542  )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 1,   545 )
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 32,   546 )
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 272,  559  )
--Испытание на воздействие пониженной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 273,  561  )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 98, 563   )


END
--Генераторы кварцевые (временно приравниваем к Резонаторам )
BEGIN
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 344,  2538  )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 1, 2541   )
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 246,2537    )
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 4,2539    )
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 260, 2535   )
END
--Ферритовые приборы
BEGIN
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 344, 410   )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 1, 413   )
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 246,409    )
--Проверка габаритных, установочных и присоединительных размеров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 4, 411   )
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 260, 407   )
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 32,414    )
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 272, 427   )
--Испытание на воздействие пониженной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 273, 429   )
--Испытание на воздействие изменения температуры среды  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 98, 431   )
END
--Комплектующие изделия (КИ)
BEGIN
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1342 , 344, 2218   )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1342 , 1, 2221   )
--Проверка внешнего вида и контроль качества маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1342 , 154, 2217   )
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1342 , 4,2219    )
--Анализ сопроводительной документации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1342 , 260,  2215  )
END
END


--select c.TestChainItemID ,tc.AsuClassID,e.[Name], tc.AsuBaseOperationID, o.Name   from Estimator_TestChainItem tc,Estimator.dbo.TestChainItem c, Estimator.dbo.Operation o, Estimator.dbo.ElementType e
--where e.ElementTypeID= c.ElementTypeID and o.OperationID = c.OperationID 
--and tc.TestChainItemID= c.TestChainItemID 



--ОПЕРАЦИИ
