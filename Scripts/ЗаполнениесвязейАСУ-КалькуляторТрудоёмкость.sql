USE [asulive]

delete from [dbo].[Estimator_TestChainItem]

BEGIN
--МИКРОСХЕМЫ
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
--Отбор для испытаний на специальные факторы
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 331, 2574   )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 2,  632  )
--Отбор на безотказность
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 165,  2574  )

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
--Кратковременные испытания на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 10425,  1768  )
--Испытание на способность к пайке
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 138,  678  )
--Проверка прочности выводов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 136,  684  )
--Контроль качества маркировки
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 145,680    )
--Контроль содержания паров воды внутри корпуса* 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 142,  681  )
--Визуальный внутренний контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 143, 682   )
--Контроль качества кристалла и металлизации на РЭМ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 139, 683   )
--Контроль прочности внутренних соединений 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 244,684    )
--Испытание на сдвиг кристалла 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 245, 685   )
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
--Ускоренные испытания на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 10421,1775    )
--Испытание на вибропрочность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 268,  378  )
--Испытание на виброустойчивость  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 269, 378   )
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 130, 382   )
--Испытание на воздействие атмосферного пониженного  давления  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 133,  293  )
--Отбор на термомеханику 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 164, 2581   )
--Отбор на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 165, 2581  )
--Нанесение отличительной маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 20,2631    )
--Испытание на воздействие повышенной влажности воздуха  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 107, 389   )
--Испытания на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 104,1775    )
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
--Испытания на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 104,1772    )
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 246,  773  )
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 2,773    )
--Контроль электрических параметров
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 22,  779  )
--Приемка партии по результатам ДПО
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 259,2601    )
--Отбор на термомеханику  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 164,2578    )
--Упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 261,2444    )
--Определение массы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 292,   235 )
--Испытание на  воздействие одиночных ударов
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 130,250    )
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 272,251    )
--Испытание на воздействие пониженной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 273,  253  )
--Испытание на воздействие изменения температуры среды  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 98,  255  )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 10407, 223   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 10408, 224   )
--Испытание на вибропрочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 268, 246   )

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
--Ускоренные испытания на безотказность
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 10421,  1767  )
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 246, 13   )
--Анализ технических спецификаций, выбор критериев параметров - годности
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 10407, 3   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 10408, 4   )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 10409,  5  )
--Разработка проектов печатных плат оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 10410,6    )
--Сборочно-монтажные работы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 10411, 7   )
--Разработка конструкторской документации для технологической оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 10412, 8   )
--Калибровка (аттестация) оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 10422,   9 )
--Разработка специального программного обеспечения для тестирования ЭКБ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 10414,  10  )
--Проверка массы, габаритных, установочных и присоединительных размеров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 10382,  15  )
--Контроль внешнего вида и сопроводительной документации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 351,13    )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 81,  2147  )
--Электротермотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 84,  2178  )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 100, 2181   )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 259, 2613   )
--Испытание на способность к 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 138, 2189   )
--Проверка прочности выводов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 136, 2190   )
--Контроль качества маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 145,2191    )
--Визуальный внутренний контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 143,  2193  )
--контроль качества кристалла и металлизации на РЭМ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 243, 2194   )
--Испытание на герметичность
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 67, 2182)
--Проверка наличия посторонних частиц в подкорпусном пространстве 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 146,2183    )
--Отбор на термомеханику 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 164, 2573   )
--Отбор для испытаний на надёжность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 340,  2573  )
--Отбор для испытаний на специальные факторы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 331,   2573 )
--Отбор на РФА  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 151, 2573   )
--Проверка внешнего вида
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 2,  13  )
--Определение массы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 292,  15  )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 98,  35  )

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
--Ускоренные испытания на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 10421, 1768   )
--Испытания на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 104,  1768  )
--Отбор на термомеханику  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 164,2574)
--Разработка проектов печатных плат оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 10410, 50   )
--Сборочно-монтажные работы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 10411, 51   )
--Разработка конструкторской документации для технологической оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 10412,52    )
--Калибровка (аттестация) оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 10422, 53   )
--Разработка специального программного обеспечения для тестирования ЭКБ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 10414,54    )
--Контроль внешнего вида и сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 351,  57  )
--Проверка массы, габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 10382, 59   )
--Нанесение отличительной маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 20,2620 )
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
--Испытание на воздействие повышенной влажности воздуха  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 107,477    )
--Ускоренные испытания на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10421,1777)
--Отбор на термомеханику 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 164,2583)
--Отбор на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 165,2583)
--Испытание на герметичность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 67, 1917   )
--Проверка наличия посторонних частиц в подкорпусном пространстве  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 146,1918    )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 259,2616    )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 2,1923    )
--Нанесение отличительной маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 20,1926  )
--Анализ технических спецификаций, выбор критериев параметров - годности 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10407,443    )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10408,444    )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10409,445    )
--Разработка проектов печатных плат оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10410,446    )
--Сборочно-монтажные работы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10411,447    )
--Разработка конструкторской документации для технологической оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10412,448)
--Калибровка (аттестация) оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10422, 449   )
--Разработка специального программного обеспечения для тестирования ЭКБ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10414,450 )
--Проверка массы, габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10382, 455   )

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
--Испытания на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 104, 1777   )
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 2, 2064   )
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 246, 2069   )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 1, 2042   )
--Проверка наличия посторонних частиц в подкорпусном пространстве 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 146, 2043   )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 81, 2044   )
--Отбор на РФА  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 151, 2583   )
--Электротермотренировка   
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 84,2046    )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 100, 2048   )
--Испытание на герметичность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 67,2063    )
--Приемка партии по результатам ДПО 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 259, 2065   )
--Контроль качества маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 145,2069    )
--Испытание на способность к пайке  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 138,  2067  )
--Визуальный внутренний контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 143,  2071  )
--контроль качества кристалла и металлизации на РЭМ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 243, 2072   )
--Проверка прочности выводов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 136, 2068   )
--Упаковка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 261,  2077  )
--Нанесение отличительной маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 20,2066    )
END
--Аналоговые ИС высокой степени интеграции
BEGIN
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 260, 11   )
--Идентификация ЭКБ ИП 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 344,  14  )
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 246, 13   )
--Проверка массы, габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 10382,15 )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 1,17)
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 32, 18   )
--Испытание на воздействие изменения температуры среды  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 98, 2144   )
--Электротермотренировка   
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 84, 2145 )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 81,2147    )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 100, 2148   )
--Испытание на герметичность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 67, 2149   )
--Проверка наличия посторонних частиц в подкорпусном пространстве  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 146,2150    )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 259, 2615   )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 2,2155    )
--Нанесение отличительной маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 20, 2643   )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 10407,2164    )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 10408, 2165   )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 10409, 2166   )
--Разработка проектов печатных плат оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 10410, 2167   )
--Сборочно-монтажные работы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 10411,2168    )
--Разработка конструкторской документации для технологической оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 10412,2169    )
--Калибровка (аттестация) оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 10422, 2170   )
--Разработка специального программного обеспечения для тестирования ЭКБ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 10414,  2171  )

--Проверка габаритных, установочных и присоединительных размеров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 4,  15  )
--Определение массы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 292, 15   )

END
--Аналоговые ИС низкой степени интеграции
BEGIN
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 10407,  1932  )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 10408, 1933   )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 10409, 1934   )
--Разработка проектов печатных плат оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 10410, 1935   )
--Сборочно-монтажные работы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 10411,  1936  )
--Разработка конструкторской документации для технологической оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 10412, 1937   )
--Калибровка (аттестация) оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 10422,  1938  )
--Разработка специального программного обеспечения для тестирования ЭКБ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 10414, 1939   )
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 260, 451   )
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 344,  454  )
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 246, 453   )
--Проверка массы, габаритных, установочных и присоединительных размеров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 10382, 455   )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 1, 457   )
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 32, 1909   )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 81,  1915  )
--Проверка габаритных, установочных и присоединительных размеров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 4,  455  )
--Определение массы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 292, 455   )
--Контроль электрических параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 22,   1909 )
--Термоциклы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 349, 1912   )
--Термотренировка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 88,  1913  )
--Электротермотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 84,  1913  )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 259,  2616  )
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 2, 1907   )
--Нанесение отличительной маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 20,  2644  )
--Упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 261,2481    )
--Испытание на воздействие изменения температуры среды  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 98,  475  )
--Контроль дрейфа параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 100,  1916  )
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
--Отбор на термомеханику  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 164, 2584   )
--Испытание на воздействие повышенной температуры среды при транспортировании и хранении  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 274, 516   )
--Испытание на воздействие пониженной температуры среды при транспортировании и хранении
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 275, 518   )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 10407, 487   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 10408, 488   )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 10409, 489   )
--Разработка проектов печатных плат оснастки
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 10410,490    )
--Сборочно-монтажные работы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 10411,491    )
--Разработка конструкторской документации для технологической оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 10412, 492   )
--Калибровка (аттестация) оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 10422, 493   )
--Разработка специального программного обеспечения для тестирования ЭКБ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 10414, 494   )
--Нанесение отличительной маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 20,  2621  )
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
--Испытания на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1326 , 104,1778   )
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1326 , 2,  497  )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1326 , 10409,1395   )
--Разработка проектов печатных плат оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1326 , 10410, 1424   )
--Сборочно-монтажные работы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1326 , 10411, 1453   )
--Разработка конструкторской документации для технологической оснастки
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1326 , 10412, 1482   )
--Калибровка (аттестация) оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1326 , 10422, 1511   )
--Разработка специального программного обеспечения для тестирования ЭКБ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1326 , 10414, 1540   )
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
--Контроль электрических параметров
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 22,  688  )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 81,694    )
--Электротермотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 84, 692   )
--Проверка наличия посторонних частиц в подкорпусном пространстве  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 146,697    )
--Контроль ВАХ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 64, 699   )
--Контроль дрейфа параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 100, 2593   )
--Контроль "m" - характеристик 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 76, 700   )
--Испытание на герметичность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 67,696    )
--Приемка партии по результатам ДПО 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 259,  2593  )
--Нанесение отличительной маркировки
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 20, 2621   )
--Проверка внешнего вида
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 2,701    )
--Упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 261, 2458   )
--Контроль качества маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 145, 706   )
--Испытание на способность к пайке  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 138,704    )
--Визуальный внутренний контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 143, 707   )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 10407,  1571  )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 10408,  1595  )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 10409, 1619   )
--Разработка проектов печатных плат оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 10410,   1643 )
--Сборочно-монтажные работы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 10411, 1667   )
--Разработка конструкторской документации для технологической оснастки
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 10412,  1691  )
--Калибровка (аттестация) оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 10422,  1715  )
--Разработка специального программного обеспечения для тестирования ЭКБ
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 10414, 1739   )
--Отбор на РФА 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 151,  2584  )
END 
--Диоды
 BEGIN
 --Контроль электрических параметров, функциональный контроль 
 insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 32, 688   )
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 246, 686   )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 1, 687   )
--Контроль электрических параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 22, 688   )
--Контроль по ужесточенным нормам
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 81,694    )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 10407, 1571   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 10408,  1595  )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 10409,  1619  )
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
--Испытание на воздействие повышенной влажности воздуха 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1301 , 107,389    )
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
--Испытания на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1301 , 104, 1775   )
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
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1318 , 2,233    )
--Испытания на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1318 , 104,  1772  )
--Контроль электрических параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1318 , 22, 238   )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1318 , 10409, 1399  )
--Разработка проектов печатных плат оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1318 , 10410, 1428   )
--Сборочно-монтажные работы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1318 , 10411,1457    )
--Разработка конструкторской документации для технологической оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1318 , 10412,1486    )
--Калибровка (аттестация) оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1318 , 10422,  1515  )
end
--Конденсаторы керамические защищенные, пленочные и комбинированные
Begin
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 246,  233  )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 10407,1339   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 10408,  1368  )
--Контроль электрических параметров
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 22,238    )
--Испытания на безотказность
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 104, 1772   )

--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 2,  233  )

--Разработка принципиальных электрических схем оснастки и выбор комплектующих  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 10409, 1397   )

--Разработка проектов печатных плат оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 10410,1426    )
--Сборочно-монтажные работы
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 10411,  1455  )
--Разработка конструкторской документации для технологической оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 10412,  1484  )
--Калибровка (аттестация) оснастки
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 10422,1513    )
end
--Конденсаторы объёмно-пористые танталовые, оксидно-электролитичекие алюминиевые
begin
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1320 , 246,233    )
--Анализ технических спецификаций, выбор критериев параметров - годности 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1320 , 10407,1343    )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1320 , 10408,1372    )
--Испытания на безотказность
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1320 , 104, 1772   )
--Контроль электрических параметров
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1320 , 22,238    )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1320 , 2,  233  )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1320 , 10409, 225   )
--Разработка проектов печатных плат оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1320 , 10410,  226  )
--Сборочно-монтажные работы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1320 , 10411, 227   )
--Разработка конструкторской документации для технологической оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1320 , 10412, 228   )
--Калибровка (аттестация) оснастки
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1320 , 10422, 229   )
end
--Конденсаторы керамические незащищенные
begin
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1321 , 246,233    )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1321 , 10407,1340    )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1321 , 10408, 1369   )
--Контроль электрических параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1321 , 22,  942  )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1321 , 81, 841   )
--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1321 , 88, 943   )
--Испытание на воздействие повышенной влажности воздуха  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1321 , 107, 946   )
--Контроль сопротивления изоляции  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1321 , 277, 947   )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1321 , 259,951 )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1321 , 2,950)
--Упаковка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1321 , 261,953)
end
--РЕЗИСТОРЫ
BEGIN
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 344, 190   )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 1, 193   )
--Проверка внешнего вида и контроль качества маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 154, 189   )
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 246,189    )
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
--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 88,  1309  )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 100,446    )
--Отбор на термомеханику  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 164,2577    )
--Испытание на вибропрочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 268, 202   )
--Испытание на  воздействие одиночных ударов 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 130,206    )
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 272, 207   )
--Испытание на воздействие пониженной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 273,  209  )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 98,211    )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 10407,  179  )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 10408,180    )
END
--Резисторы постоянные и переменные
BEGIN
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1306 , 246,  790 )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1306 , 10407, 1344)
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1306 , 10408,1373)
--Контроль электрических параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1306 , 22,1027    )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1306 , 81, 1026   )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1306 , 259,1029    )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1306 , 2, 1028   )
--Упаковка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1306 , 261,1031    )
END
--Резисторы постоянные и переменные прецизионные
BEGIN
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 246,   1312 )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 10407,  1363  )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 10408,1392    )
--Контроль электрических параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 22, 1308 )
--Контроль по ужесточенным нормам 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 81, 1310   )
--Испытания на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 104,1771 )
--Приемка партии по результатам ДПО 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 259,1313    )
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 2,  1312  )
--Упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 261, 1315   )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 98, 1309   )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 10409, 1421   )
--Разработка проектов печатных плат оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 10410, 1450   )
--Сборочно-монтажные работы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 10411, 1479   )
--Разработка конструкторской документации для технологической оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 10412,1508    )
--Калибровка (аттестация) оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1307 , 10422,1537    )

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
--Испытания на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 104, 1773   )
--Отбор на термомеханику 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 164,  2579  )
--Отбор на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 165, 2579   )
--Испытание на вибропрочность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 268, 290   )
--Испытание на виброустойчивость  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 269, 290   )
--Испытание на воздействие атмосферного пониженного  давления 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 133,305    )
--Испытание на  воздействие одиночных ударов 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 130, 294   )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 2,  277  )
--Приемка партии по результатам ДПО 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 259,  2599  )

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
--Термотренировка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 88, 747   )
--Контроль по ужесточенным нормам 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 81, 749   )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 100,   749 )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 259, 2597   )
--Испытания на безотказность
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 104,1779    )
--Проверка внешнего вида
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 2, 541   )
--Отбор на термомеханику 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 164,  2585  )
--Отбор на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 165, 2585   )
--Испытание на вибропрочность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 268,  554 )
--Испытание на виброустойчивость 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 269,  554  )
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 130, 558   )
--Испытание на воздействие атмосферного пониженного  давления
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (554 , 133, 569   )
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
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 10407,  1350  )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 10408,  1379  )
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
--Испытания на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 104, 1776   )
--Отбор на термомеханику 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 164,  2582  )
--Отбор на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 165,2582    )
--Испытание на вибропрочность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 268,  422  )
--Испытание на виброустойчивость  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 269,  422  )
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 130,   426 )
--Испытание на воздействие атмосферного пониженного  давления 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 133,  437  )
--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 88, 769   )
--Контроль по ужесточенным нормам
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 81, 771   )
--Контроль дрейфа параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 100, 771   )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 259,2600   )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1315 , 2, 772   )
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
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1342 , 2, 2217   )
--Испытание на воздействие повышенной влажности воздуха  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1342 , 107,  2241  )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1342 , 98, 2239   )
--Испытание на воздействие пониженной температуры  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1342 , 73, 2237   )
--Испытание на воздействие повышенной температуры 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1342 , 70,2235    )
--Испытания на виброустойчивость  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1342 , 168,  2230  )
--Испытание на вибропрочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1342 , 268,2230    )
--Испытание на устойчивость при воздействии механических ударов многократного действия  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1342 , 287, 2233   )
--Испытание на  воздействие одиночных ударов 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1342 , 130,  2234  )
END
--Дроссели высокочастотные
Begin
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (928 , 246, 1267   )
--Контроль электрических параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (928 , 22, 1263   )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (928 , 81, 1262   )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (928 , 98,  1264  )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (928 , 259,1268    )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (928 , 2, 1267   )
--Упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (928 , 261,1271)
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (928 , 10407, 1359   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (928 , 10408,1388    )

end
--Фильтры пьезоэлектрические
BEGIN
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1354 , 246,1136    )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1354 , 1,1126    )
--Контроль электрических параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1354 , 22,  1128  )
--Контроль по ужесточенным нормам 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1354 , 81,1130    )
--Испытание на воздействие изменения температуры среды  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1354 , 98, 1129   )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1354 , 10407, 1351   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1354 , 10408, 1380   )
END
--фильтры
begin
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 32, 736   )
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 246,743    )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 1,  149  )
--Контроль электрических параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 22, 739   )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 81, 740   )
--Анализ технических спецификаций, выбор критериев параметров - годности 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 10407, 1574   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 10408, 1598   )
--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 88, 737   )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 100, 2596   )
--Приемка партии по результатам ДПО 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 259, 2596   )
--Отбор на термомеханику 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 164,  2579  )
--Отбор для испытаний на надёжность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 340, 2579   )
--Отбор для испытаний на специальные факторы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 331, 2579   )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 2,  743  )
--Упаковка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 261, 2461   )
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 344, 278   )
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 4,  279  )
--Определение массы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 292,279    )
--Испытания по определению резонансных частот конструкции 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 152, 288   )
--Испытание на вибропрочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 268,290    )
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 130,  294  )
--Испытание на воздействие повышенной температуры среды при эксплуатации
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 272,  295  )
--Испытание на воздействие пониженной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 273, 297   )
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 260,275    )
--Испытание на воздействие изменения температуры среды  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 98, 299   )
--Термоциклы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 349, 737   )
end
--Соединители низкочастотные прямоугольные и цилиндрические
begin
--Анализ технических спецификаций, выбор критериев параметров - годности 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1351 , 10407,   1347 )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1351 , 10408,1376    )
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1351 , 246,1068    )
--Контроль усилия расчленения гнезда с контрольным штырём 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1351 , 242,  1069  )
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1351 , 2,  1070  )
--Нанесение отличительной маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1351 , 20,  1071  )
end
--Соединители радиочастотные
begin
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (427 , 246, 1078   )
--Контроль параметров соединителей  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (427 , 14,   1079 )
--Проверка внешнего вида
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (427 , 2,  1080  )
--Упаковка
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (427 , 261,1082    )
--Анализ технических спецификаций, выбор критериев параметров - годности 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (427 , 10407,  1348  )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (427 , 10408,  1377  )

end
--РЕЛЕ 
begin
--Проверка внешнего вида
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 2, 730   )
--Испытание на способность к пайке 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 138,733    )

--Контроль качества маркировки
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 145,734    )

end
END


--select c.TestChainItemID ,tc.AsuClassID,e.[Name], tc.AsuBaseOperationID, o.Name   from Estimator_TestChainItem tc,Estimator.dbo.TestChainItem c, Estimator.dbo.Operation o, Estimator.dbo.ElementType e
--where e.ElementTypeID= c.ElementTypeID and o.OperationID = c.OperationID 
--and tc.TestChainItemID= c.TestChainItemID 



--ОПЕРАЦИИ
