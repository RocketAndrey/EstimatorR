use Estimator

update TestProgram set ParentProgramID =4 where TestProgramID= 5 

update ElementType set ChildElementTypeID = 2 where ElementTypeID = 73 
update ElementType set ChildElementTypeID = 2 where ElementTypeID = 74

update ElementType set ChildElementTypeID = 1 where ElementTypeID = 98
update ElementType set ChildElementTypeID = 2 where ElementTypeID = 75
update ElementType set ChildElementTypeID = 13 where ElementTypeID = 99

update ElementType set ChildElementTypeID = 1 where ElementTypeID = 100
update ElementType set ChildElementTypeID = 2 where ElementTypeID = 76
update ElementType set ChildElementTypeID = 13 where ElementTypeID = 101

update ElementType set ChildElementTypeID = 14 where ElementTypeID = 77
update ElementType set ChildElementTypeID = 9 where ElementTypeID = 78
update ElementType set ChildElementTypeID = 5 where ElementTypeID = 79

update ElementType set ChildElementTypeID = 9 where ElementTypeID = 80
update ElementType set ChildElementTypeID = 96 where ElementTypeID = 81
update ElementType set ChildElementTypeID = 6 where ElementTypeID = 82

update ElementType set ChildElementTypeID = 6 where ElementTypeID = 83--катушки индуктивности
update ElementType set ChildElementTypeID = 12 where ElementTypeID = 84--ферриты
update ElementType set ChildElementTypeID = 8 where ElementTypeID = 85--конденсаторы

update ElementType set ChildElementTypeID = 8 where ElementTypeID = 97--конденсаторы электролитические
update ElementType set ChildElementTypeID = 7 where ElementTypeID = 86--резисторы
update ElementType set ChildElementTypeID = 11 where ElementTypeID = 87--изделия коммутационные

update ElementType set ChildElementTypeID = 11 where ElementTypeID = 88--микропереключатели
update ElementType set ChildElementTypeID = 109 where ElementTypeID = 89--источники тока
update ElementType set ChildElementTypeID = 108 where ElementTypeID = 90--кабельные сборки

update ElementType set ChildElementTypeID = 108 where ElementTypeID = 91--кабели
update ElementType set ChildElementTypeID = 108 where ElementTypeID = 92--кабели
update ElementType set ChildElementTypeID = 108 where ElementTypeID = 93--кабели

update ElementType set ChildElementTypeID = 108 where ElementTypeID = 94--кабели
update ElementType set ChildElementTypeID = 108 where ElementTypeID = 95--кабели


select e.ElementTypeID ,e.Name, e.ChildElementTypeID, e2.[Name]  from ElementType e
LEFT JOIN ElementType e2 on e.ChildElementTypeID = e2.ElementTypeID
where e.ProgramID <>2   
order by e.ProgramID,e.[Order] 
