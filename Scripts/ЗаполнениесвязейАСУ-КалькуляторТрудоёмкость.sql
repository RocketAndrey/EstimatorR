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
--Анализ упаковки, проверка сопроводительной документации, проверка внешнего вида и маркировки, упаковка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (167 , 279,  57  )
END
--Микросхемы ИП
Begin
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 344,  58  )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 1,   61 )
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 246, 57   )
--Проверка габаритных, установочных и присоединительных размеров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 4, 59   )
--Анализ сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 260,   55 )
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 32,62    )
--Испытание на воздействие повышенной температуры среды при эксплуатации
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 272,  75  )
--Испытание на воздействие пониженной температуры среды при эксплуатации
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 273,  77  )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 98,79    )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 2, 57   )
--Отбор на термомеханику
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 164, 2574   )
--Испытание на вибропрочность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 268,70    )
--Испытание на виброустойчивость 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 269, 70   )
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 130, 74   )
--Испытание на воздействие атмосферного пониженного  давления 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 133, 85 )
--Электротермотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 84, 665   )
--Контроль по ужесточенным нормам 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 81,  667  )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 100,  668  )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 259,2592    )
--Испытания на безотказность
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 104, 1768   )
--Нанесение отличительной маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1286 , 20,2619    )

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
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 10408,356    )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 10407,  355  )
--Контроль внешнего вида и сопроводительной документации
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 351,363    )
--Упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 261,2447    )
--Анализ упаковки, проверка сопроводительной документации, проверка внешнего вида и маркировки, упаковка
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 279,  365  )
--Испытание на воздействие пониженной температуры среды при транспортировании и хранении 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 275,  386  )
--Испытание на воздействие повышенной температуры среды при транспортировании и хранении  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 274, 384   )
--Испытания на виброустойчивость  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (426 , 168, 378   )


END
--КОНТРОЛЬНЫЕ ТОЧКИ
BEGIN
--Идентификация ЭКБ ИП 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 344, 366   )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 1, 369   )
--Проверка внешнего вида и контроль качества маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 154,   365 )
--Проверка габаритных, установочных и присоединительных размеров
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 4,  367  )
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 32, 370   )
--Отбор на термомеханику  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 164,2581    )

--Испытание на вибропрочность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 268, 378   )
--Испытания на виброустойчивость
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 168,  378  )
--Испытание на  воздействие одиночных ударов 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 130,382    )
--Испытание на воздействие повышенной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 272,  383  )
--Испытание на воздействие повышенной температуры среды при транспортировании и хранении 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 274,  384  )
--Испытание на воздействие пониженной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 273,  385  )
--Испытание на воздействие пониженной температуры среды при транспортировании и хранении 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 275,  386  )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 10407,  355  )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (982 , 10408, 356   )
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
--Проверка габаритных, установочных и присоединительных размеров, проверка массы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 10435, 235   )
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
--Испытание на воздействие синусоидальной вибрации
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 357,246    )
--Испытание на ударную прочность при воздействии механических ударов одиночного действия  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 10393,250    )
--Испытание на  ударную прочность при воздействии механических ударов многократного действия 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 122,  248  )
--Испытание на воздействие повышенной температуры среды при транспортировании и хранении  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 274, 252   )
--Испытание на воздействие повышенной влажности воздуха 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 107,257    )
--Испытание на воздействие пониженной температуры среды при транспортировании и хранении  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 275, 254   )
--Испытание на воздействие атмосферного пониженного  давления 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 133,261    )
--Испытание на воздействие повышенного давления  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 131, 262   )
--Испытание на способность к пайке 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 138,   1924 )--как у микросхем
--Анализ упаковки, проверка сопроводительной документации, проверка внешнего вида и маркировки, упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 279, 233   )
--Нанесение отличительной маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 20, 2629   )
--Термоциклы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 349,  775  )
--Испытания на виброустойчивость
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 168,  246  )
--Оценка показателей безотказности (пусть будут ужесточенные нормы)
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 10426,930    )
--Восстановление диэлектрика  (пусть будет повышенная температура)
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (611 , 10432, 253   )
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
--Отбор на термомеханику 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 164,   2581 )
--Анализ упаковки, проверка сопроводительной документации, проверка внешнего вида и маркировки, упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1232 , 279, 365   )

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
--Испытания на воздействие широкополосной случайной вибрации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 10387,  27  )
--Испытание на воздействие синусоидальной вибрации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 357, 26   )
--Испытание на ударную прочность при воздействии механических ударов одиночного действия 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 10393,30    )
--Испытание на  ударную прочность при воздействии механических ударов многократного действия
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 122, 28   )
--Испытание на воздействие повышенной температуры среды при транспортировании и хранении 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 274, 32   )
--Испытание на воздействие атмосферного пониженного  давления 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 133, 41   )
--Отбор на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 165,  2573  )
--Испытание на вибропрочность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 268, 26   )
--Рентгено-телевизионный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 51,870    )
--Контроль электрических параметров и функциональный контроль при повышенной  температуре  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 57,  19  )
--Контроль электрических параметров и функциональный контроль при пониженной  температуре  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 58,   20 )
--Испытание на воздействие повышенной влажности воздуха 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 107,  37  )
--Испытание на воздействие пониженной температуры среды при транспортировании и хранении 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 275,34    )
--Испытание на воздействие повышенного давления 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 131, 42   )
--Испытание на пожарную безопасность
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 132, 42   )
--Испытания на безотказность
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1287 , 104,  1767  )

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
--Отбор на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 165,  2574  )
--Отбор для испытаний на специальные факторы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 331, 2574   )
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
--Упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 261,  2440  )
--Испытание на ударную прочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 270, 72   )
--Испытание на воздействие повышенной температуры среды при транспортировании и хранении  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 274,76    )
--Испытание на воздействие пониженной температуры среды при транспортировании и хранении 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 275,78    )
--Испытание на воздействие повышенной влажности воздуха  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 107,  82  )
--Подготовка для испытаний на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 10423, 49   )
--Проверка внешнего вида, разборчивости и содержания маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 263,  57  )
--Испытания на вибропрочность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 106, 70   )
--Контроль электрических параметров после воздействия повышенной влажности 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 35,  67  )
--Испытание на воздействие атмосферного пониженного давления при эксплуатации
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 376, 85   )
--Испытание на воздействие атмосферного пониженного давления при хранении 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 377,  85  )
--Испытание на воздействие повышенного давления
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 131, 86   )
--Испытания на сохраняемость 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 105, 1781   )
--Отбор на РФА  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1288 , 151,  2574  )
END
--ИС корпусные высокой степени интеграции
BEGIN
--Анализ технических спецификаций, выбор критериев параметров - годности 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 10407,  2130  )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 10408,  2131  )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 10409,2132    )
--Разработка проектов печатных плат оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 10410,2133    )
--Сборочно-монтажные работы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 10411, 2134   )
--Разработка конструкторской документации для технологической оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 10412,  2135  )

--Калибровка (аттестация) оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 10422,  2136  )
--Разработка специального программного обеспечения для тестирования ЭКБ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 10414,  2137  )
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 246, 2114   )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 1,2092    )
--Проверка наличия посторонних частиц в подкорпусном пространстве
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 146,  2093  )
--Контроль электрических параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 22,   2095 )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 81,2097    )
--Отбор на РФА 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 151,  2573  )
--Контроль качества маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 145,   2119 )

--Анализ упаковки, проверка сопроводительной документации, проверка внешнего вида и маркировки, упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 279, 2089   )
--Электротермотренировка   
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 84, 2096   )
--Контроль дрейфа параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 100,2098    )
--Испытание на герметичность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 67,  2113  )
--Приемка партии по результатам ДПО 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 259,2115    )
--Проверка внешнего вида
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 2, 2114   )
--Испытание на способность к пайке 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 138, 2117   )
--Проверка прочности выводов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1327 , 136, 2118   )
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
--Испытания на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 104, 1777   )
--Отбор на термомеханику 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 164,2583)
--Отбор на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 165,2583)
--Отбор на РФА 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 151, 2583   )
--Отбор для испытаний на надёжность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 340, 2583   )
--Отбор для испытаний на специальные факторы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 331, 2583   )
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
--Определение массы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 292,  455  )
--Испытания по определению резонансных частот конструкции  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 152,  464  )
--Испытание на воздействие синусоидальной вибрации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 357, 466   )
--Испытание на ударную прочность при воздействии механических ударов одиночного действия 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10393,470    )
--Испытание на  ударную прочность при воздействии механических ударов многократного действия  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 122, 468   )
--Испытание на способность к пайке
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 138,  1924  )
--Термотренировка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 88, 1913   )
--Контроль содержания паров воды внутри корпуса* 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 142,  1927  )
--Контроль качества маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 145, 1926   )
--Визуальный внутренний контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 143,  1928  )
--контроль качества кристалла и металлизации на РЭМ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 243,1929    )
--Анализ технологии изготовления (делаем как РЭМ)
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10429,  1929  )
--Анализ упаковки, проверка сопроводительной документации, проверка внешнего вида и маркировки, упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 279, 2481   )
--Контроль прочности внутренних соединений 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 244,   1930 )
--Испытание на сдвиг кристалла  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 245, 1931  )

--Подготовка для испытаний на безотказность
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10423, 445   )
--Испытания на виброустойчивость
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 168, 466   )

--Проверка маркировки на прочность
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10431,1926    )
--Контроль электрических параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 22, 458   )
--Упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 261, 2449   )

--Оценка показателей безотказности  (ужесточ нормы)
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1289 , 10426, 2047   )

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
--Проверка наличия посторонних частиц в подкорпусном пространстве 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 146,  839  )
--Контроль электрических параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 22,841    )
--Контроль по ужесточенным нормам
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 81,843    )
--Отбор на РФА  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 151,  2574  )
--Электротермотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 84,   842 )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 100, 844   )
--Испытание на герметичность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 67,  859  )
--Приемка партии по результатам ДПО 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 259,   861 )
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 2, 860   )
--Анализ упаковки, проверка сопроводительной документации, проверка внешнего вида и маркировки, упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 279,  860  )
--Нанесение отличительной маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 20, 862   )
--Упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 261, 875   )
--Контроль качества маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 145, 867   )
--Контроль содержания паров воды внутри корпуса*  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 142, 868   )
--Испытание на способность к пайке 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 138, 865   )
--Проверка прочности выводов 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 136, 866   )
--Визуальный внутренний контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 143,  869  )
--контроль качества кристалла и металлизации на РЭМ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 243,   870 )
--Контроль прочности внутренних соединений
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 244, 871   )
--Испытание на сдвиг кристалла 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1329 , 245,  872  )
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
--Анализ упаковки, проверка сопроводительной документации, проверка внешнего вида и маркировки, упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 279,  2069  )
--Анализ сопроводительной документации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 260, 2069   )
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
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 32, 2045   )
--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 88,  2046  )
--Испытание на воздействие изменения температуры среды
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 98, 1912   )
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 32, 2045   )
--Контроль содержания паров воды внутри корпуса*  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 142,  2070  )
--Контроль прочности внутренних соединений 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 244, 2073)
--Испытание на сдвиг кристалла 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1282 , 245, 2074)
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
--Термоциклы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 349, 2144   )
--Контроль электрических параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 22,2141    )
--Упаковка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1335 , 261,2480    )
END
---Аналоговые ИС средней степени интеграции
Begin
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 1,660    )
--Проверка массы, габаритных, установочных и присоединительных размеров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 10382, 659   )
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 246,  659  )
--Идентификация ЭКБ ИП 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 344, 2414   )
--Анализ сопроводительной документации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 260, 659   )
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 32,  661  )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 98, 664   )
--Электротермотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 84, 665   )
--Определение массы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 292, 659   )
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 4,659    )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 81,  667  )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 100, 668   )
--Испытание на герметичность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 67, 669   )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 259, 2592   )
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 2,  675  )
--Нанесение отличительной маркировки
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 20, 2620   )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 10407, 1570   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 10408,  1594  )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 10409, 1618   )
--Разработка проектов печатных плат оснастки
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 10410,1642    )
--Сборочно-монтажные работы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 10411, 1666   )
--Разработка конструкторской документации для технологической оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 10412, 1690   )
--Калибровка (аттестация) оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 10422, 1714   )
--Разработка специального программного обеспечения для тестирования ЭКБ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 10414,1738    )
--Проверка наличия посторонних частиц в подкорпусном пространстве
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 146, 670   )
--Контроль электрических параметров
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 22,  671  )
--Термоциклы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1336 , 349,664    )
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
--Проверка наличия посторонних частиц в подкорпусном пространстве 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1337 , 146, 1918   )
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
--Отбор на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 165,   2584 )
--Ускоренные испытания на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 10421, 1778   )
--Испытания на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1293 , 104, 1778   )
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
--Проверка прочности выводов 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 136, 705   )
--Контроль прочности внутренних соединений 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 244, 709   )
--Испытание на сдвиг кристалла 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 245,  710  )
--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 344, 498   )
--Проверка габаритных, установочных и присоединительных размеров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 4,  499  )
--контроль качества кристалла и металлизации на РЭМ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 243, 708   )
--Анализ упаковки, проверка сопроводительной документации, проверка внешнего вида и маркировки, упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 279, 497   )

--Контроль качества кристалла и металлизации на РЭМ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 139, 708   )
--Проверка внешнего вида и контроль качества маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 154,  701  )
--Анализ технологии изготовления
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (357 , 10429,  708  )

END 
--Транзисторные сборки
BEGIN
--Испытание на способность к пайке
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (354 , 138, 704   )
--Контроль качества маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (354 , 145,706    )
--Визуальный внутренний контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (354 , 143,  707  )
--Контроль прочности внутренних соединений 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (354 , 244,  709  )
--Испытание на сдвиг кристалла 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (354 , 245,  710  )
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
--Отбор на термомеханику 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 164, 2584   )
--Испытание на вибропрочность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 268,510    )
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 130, 514   )
--Испытание на воздействие повышенной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 272, 515   )
--Испытание на воздействие пониженной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 273,  517  )
--Идентификация ЭКБ ИП 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 344, 498   )
--Проверка габаритных, установочных и присоединительных размеров
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 4,  499  )
--Отбор для испытаний на надёжность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 340, 2584   )
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 2,   497 )
--Определение массы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 292, 499   )
--Испытание на воздействие синусоидальной вибрации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 357, 510   )

--Испытание на ударную прочность при воздействии механических ударов одиночного действия  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 10393, 514   )
--Испытание на  ударную прочность при воздействии механических ударов многократного действия
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 122, 513   )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 98,  519  )
--Испытание на воздействие повышенной температуры среды при транспортировании и хранении  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 274,516    )
--Испытание на воздействие повышенной влажности воздуха  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 107, 521   )
--Испытание на воздействие пониженной температуры среды при транспортировании и хранении 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 275, 518   )
--Испытание на воздействие атмосферного пониженного  давления 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 133,   525 )
--Испытание на воздействие повышенного давления
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 131,  526  )
--Анализ упаковки, проверка сопроводительной документации, проверка внешнего вида и маркировки, упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 279,497   )
--Электротермотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 84, 692   )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 100,  695  )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 259, 2593   )
--Испытание на способность к пайке 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 138,   704 )


--Разработка проектов печатных плат оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 10410,  1619  )
--Сборочно-монтажные работы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 10411, 1667   )
--Разработка конструкторской документации для технологической оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 10412,1691    )
--Калибровка (аттестация) оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 10422,  1715  )
--Разработка специального программного обеспечения для тестирования ЭКБ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 10414, 1739   )

--Отбор на РФА  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 151, 2584   )
--Контроль качества маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 145, 899   )
--Проверка прочности выводов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 136, 898   )

--Проверка внешнего вида и контроль качества маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 154, 686   )
--Анализ технологии изготовления 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 10429, 708   )
--Испытания на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 104,  1778  )
END
--диоды оп
BEGIN
--Контроль "m" - характеристик 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 76,  889  )
--Контроль ВАХ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 64,  889  )
--Визуальный внутренний контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (337 , 143,  900  )
end
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
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1018 , 2,  321  )
--Испытание на воздействие соляного (морского) тумана
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1018 , 159,347    )
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
--ВИЛКИ
BEGIN
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (411 , 246,  1068  )
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

--Контроль внешнего вида и сопроводительной документации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 351,773    )
--Идентификация ЭКБ ИП 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 344, 773   )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 1,237    )
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 246, 773   )
--Проверка габаритных, установочных и присоединительных размеров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 4, 235   )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 100, 778   )
--Отбор на термомеханику  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 164,  2578  )
--Нанесение отличительной маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 20,  2629  )
--Анализ технических спецификаций, выбор критериев параметров - годности 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 10407, 1579 )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 10408,1603)
--Упаковка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1305 , 261,  2444  )
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

--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 81, 927   )
--Приемка партии по результатам ДПО 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 259,  933 )
--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1319 , 88, 929   )

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
--Конденсаторы оксидно-полупроводниковые безвыводные
begin
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1322 , 246, 981   )
--Контроль электрических параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1322 , 22, 974   )
--Контроль по ужесточенным нормам 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1322 , 81, 979   )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1322 , 98, 975   )
--Приемка партии по результатам ДПО 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1322 , 259,982    )
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1322 , 2, 981   )
--Упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1322 , 261,  984  )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1322 , 10407, 1342   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1322 , 10408,1371    )
END
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
--Проверка габаритных, установочных и присоединительных размеров, проверка массы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 10435, 191   )
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
--Анализ упаковки, проверка сопроводительной документации, проверка внешнего вида и маркировки, упаковка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 279,  188  )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 2,189    )
--Испытание на воздействие соляного (морского) тумана  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 159, 215   )

--Испытания на виброустойчивость 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 168,  202  )

--Испытание на воздействие повышенной температуры среды при транспортировании и хранении 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 274, 208  )
--Испытание на воздействие пониженной температуры среды при транспортировании и хранении
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (373 , 275,  210  )
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
--Оценка показателей безотказности 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 10426,  1773  )
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
--Термоциклы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 349,  761  )
--Отбор для испытаний на специальные факторы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 331,  2579  )
--Нанесение отличительной маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 20,  2627  )
--Упаковка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 261,2445    )
--Контроль электрических параметров
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 22,   282 )
--Анализ технических спецификаций, выбор критериев параметров - годности 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 10407,   267 )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 10408,  268  )
--Анализ упаковки, проверка сопроводительной документации, проверка внешнего вида и маркировки, упаковка
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 279, 277   )
--Испытания на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (378 , 104,  1773  )
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
--Испытание на вибропрочность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 268,  2550  )
--Испытание на виброустойчивость 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 269,  2550  )
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 130, 2554   )
--Отбор на термомеханику 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 164,  2588  )
--Отбор на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 165,  2588  )
--Контроль электрических параметров, функциональный контроль  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 32, 2542   )
--Испытание на воздействие повышенной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 272,2555    )
--Испытание на воздействие пониженной температуры среды при эксплуатации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 273, 2557   )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 98,2559    )
--Термотренировка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 88, 769   )
--Контроль по ужесточенным нормам 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 81, 1915   )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 100, 1916   )
--Испытание на герметичность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 67,  1917  )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 259,  2616  )
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 2,  1923  )
--Нанесение отличительной маркировки
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 20,2644    )
--Испытания на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (398 , 104,398    )
END

---Кварцевые генераторы ОП
BEGIN
--Анализ технических спецификаций, выбор критериев параметров - годности
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (394 , 10407,  1350  )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (394 , 10408, 1379   )
--Проверка внешнего вида и контроль качества маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (394 , 154, 409   )
--Анализ технологии изготовления 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (394 , 10429,  870  )
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

--Контроль электрических параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 22, 1109   )
--Контроль по ужесточенным нормам 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 81,  1111  )
--Испытание на воздействие изменения температуры среды
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 98, 1110   )
--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 88,  1113  )
--Контроль дрейфа параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 100,  1115  )
--Приемка партии по результатам ДПО 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 259, 1118   )
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 2,1117    )
--Нанесение отличительной маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 20,  1119  )
--Упаковка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1081 , 261,  1120  )
END
--ФЕРРИТОВЫЕ ПРИБОРЫ ОП
BEGIN
--Анализ технических спецификаций, выбор критериев параметров - годности 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (385 , 10407, 1362   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (385 , 10408, 1391   )
--Проверка внешнего вида, разборчивости и содержания маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (385 , 263, 1794   )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (385 , 1,  413  )
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
--Контроль электрических параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (385 , 22,  414  )

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
--Дроссели

BEGIN
--Идентификация ЭКБ ИП 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (377 , 344,  146  )
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (377 , 1,   149 )
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (377 , 246, 145   )
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (377 , 4, 147   )
END

--Блоки трансформаторов
BEGIN
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (376 , 246,  1228  )
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
--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1354 , 88, 713   )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1354 , 100,716    )
--Приемка партии по результатам ДПО 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1354 , 259, 2594   )
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1354 , 2,711    )
--Упаковка
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1354 , 261, 2459   )
--Нанесение отличительной маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1354 , 20,2622    )
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
--Испытание на воздействие синусоидальной вибрации  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 357,  290  )
--Испытание на ударную прочность при воздействии механических ударов одиночного действия  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 10393,  294  )
--Испытание на  ударную прочность при воздействии механических ударов многократного действия
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 122, 292   )
--Испытание на воздействие повышенной температуры среды при транспортировании и хранении  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 274,296    )
--Испытание на воздействие повышенной влажности воздуха  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 107, 301   )
--Испытание на воздействие пониженной температуры среды при транспортировании и хранении  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 275,298    )
--Испытание на воздействие атмосферного пониженного  давления 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 133, 305   )
--Испытание на воздействие повышенного давления  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 131,306    )
--Испытание на способность к пайке 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 138, 704   )
--Испытания на безотказность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (402 , 104, 1773   )
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
--РОЗЕТКИ
begin
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (421 , 246,   1068 )
END
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
--Проверка внешнего вида и маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 246,   101 )
--Проверка габаритных, установочных и присоединительных размеров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 4,  103  )
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 32, 106   )
--Испытание на воздействие повышенной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 272, 119   )
--Испытание на воздействие пониженной температуры среды при эксплуатации
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 273, 121   )
--Испытание на воздействие изменения температуры среды  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 98,  123  )
--Отбор на термомеханику  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 164,2575    )
--Отбор на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 165, 2575   )
--Отбор для испытаний на специальные факторы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 331,2575    )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 10407, 91   )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 10408, 93   )


--Идентификация ЭКБ ИП  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 344,   102 )
--Термотренировка
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 88,1150    )
--Сериализация изделий (присвоение индивидуального номера)
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 1,   105 )
--Контроль по ужесточенным нормам 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 81, 1154   )
--Контроль дрейфа параметров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 100, 1154   )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 259,  1164  )
--Нанесение отличительной маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 20,  1165  )

--Испытание на вибропрочность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 268,   114 )
--Испытание на  воздействие одиночных ударов 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 130,  118  )
end

--РЕЛЕ ОП
Begin
--Разработка проектов печатных плат оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 10410,  1439  )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 10409,   1410 )
--Сборочно-монтажные работы 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 10411, 1468   )
--Разработка специального программного обеспечения для тестирования ЭКБ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 10414, 1555   )
--Калибровка (аттестация) оснастки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 10422,  1555  )
--Разработка конструкторской документации для технологической оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 10412,  1497  )
--Контроль электрических параметров
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 22, 1149   )
--Отбор на РФА
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 151, 2575   )
--Приработка переключателей 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 134,  1153  )
--Испытание на воздействие пониженной температуры  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (420 , 73, 1151  )
end
--Вентили
begin
--Проверка внешнего вида 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 2,  409  )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 1, 413   )
--Контроль электрических параметров, функциональный контроль 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 32,  414  )
--Ускоренные испытания на безотказность
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 10421, 1776   )
--Идентификация ЭКБ ИП 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 344,  410  )
--Проверка внешнего вида и маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 246, 409   )
--Проверка габаритных, установочных и присоединительных размеров  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 4, 411   )
--Испытание на воздействие повышенной температуры среды при эксплуатации
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 272,427    )
--Испытание на воздействие пониженной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 273,  429  )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 98,431    )
--Анализ технических спецификаций, выбор критериев параметров - годности  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 10407,399    )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 10408, 400   )

--Испытание на вибропрочность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 268,  422  )

--Отбор на термомеханику 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 164, 2582   )
--Отбор на безотказность  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 165,  2582  )
--Отбор для испытаний на специальные факторы  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 331,  2582  )
--Термотренировка 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 88, 1797   )
--Контроль по ужесточенным нормам  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 81, 1804   )
--Контроль дрейфа параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 100, 1804   )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 259,  1804  )
--Нанесение отличительной маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (333 , 20, 1805   )
end
--Модули питания
begin
--Анализ технических спецификаций, выбор критериев параметров - годности
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 10407,1361    )
--Разработка методик параметрического и функционального контроля ЭКБ в период проведения ВК и СИ
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 10408,1390    )
--Проверка внешнего вида, разборчивости и содержания маркировки
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 263,   1298 )
--Сериализация изделий (присвоение индивидуального номера)  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 1,   1288 )
--Контроль электрических параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 22,  1291  )
--Контроль по ужесточенным нормам 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 81, 1290   )
--Испытание на воздействие изменения температуры среды  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 98, 1292   )
--Термотренировка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 88, 1293   )
--Контроль дрейфа параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 100,1295    )
--Приемка партии по результатам ДПО  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 259, 1299   )
--Проверка внешнего вида
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 2,  1298  )
--Нанесение отличительной маркировки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 20,1300    )
--Упаковка  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 261, 1302   )
--Испытание на герметичность 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 67,  1296  )
--Разработка принципиальных электрических схем оснастки и выбор комплектующих 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 10409,   1419 )
--Сборочно-монтажные работы
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 10411,  1477  )
--Калибровка (аттестация) оснастки 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (871 , 10422, 1535   )
end
--Опытные образцы
BEGIN


--Испытание на воздействие повышенной влажности воздуха 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1372 , 107,345    )
--Испытание на воздействие пониженной температуры среды при транспортировании и хранении  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1372 , 275, 342   )
--Испытание на воздействие синусоидальной вибрации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1372 , 357,  334  )
--Испытание на воздействие повышенной температуры среды при транспортировании и хранении 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1372 , 274, 340   )
--Испытание на  воздействие одиночных ударов  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1372 , 130, 338   )
--Испытание на  ударную прочность при воздействии механических ударов многократного действия 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1372 , 122,  336  )
--Испытание на воздействие изменения температуры среды  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1372 , 98,343    )
--Проверка внешнего вида  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1372 , 2, 321   )
--Испытание на воздействие соляного (морского) тумана  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1372 , 159,347    )
--Контроль функционирования 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1372 , 55, 326   )
--Испытание на воздействие пониженной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1372 , 273,  339  )
--Испытание на воздействие повышенной температуры среды при эксплуатации 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1372 , 272, 341   )
--Испытание на прочность при транспортировании  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (1372 , 303, 336   )

END

--Сердечники
BEGIN
--Сериализация изделий (присвоение индивидуального номера) 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (386 , 1,   1805 )
--Проверка внешнего вида, разборчивости и содержания маркировки  
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (386 , 263,1794    )
--Контроль электрических параметров 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (386 , 22,  1795  )
--Контроль по ужесточенным нормам 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (386 , 81, 1796   )
--Испытание на воздействие изменения температуры среды 
insert into [dbo].[Estimator_TestChainItem] ([AsuClassID],[AsuBaseOperationID],[TestChainItemID])  VALUES (386 , 98, 431   )
END


END
--select c.TestChainItemID ,tc.AsuClassID,e.[Name], tc.AsuBaseOperationID, o.Name   from Estimator_TestChainItem tc,Estimator.dbo.TestChainItem c, Estimator.dbo.Operation o, Estimator.dbo.ElementType e
--where e.ElementTypeID= c.ElementTypeID and o.OperationID = c.OperationID 
--and tc.TestChainItemID= c.TestChainItemID 



--ОПЕРАЦИИ
