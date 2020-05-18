Declare @ContractId int;

select @ContractId = Contract.ContractId from Contract
where code ='���'


/*
select * from Contract where ClientId= 105
/*105  ��� ����� */
*/
SELECT mn.Name as �������������, dbo.Wares.TypeNominal AS �����������,
c2.Name AS ���,
dbo.Wares.TU1 + ' ' + dbo.Wares.TU2 AS [������������ �����-������������], 
l.ManufacturingDate AS [���� ������������], 
l.PartNumber AS [����� ������], 
l.QTY AS [���-�� � ������],
dbo.Wares.EquipmentNumber AS [���-�� ����� � ���], 
 mk.PrefixNumber + '-'  + CAST(mk.Number AS VARCHAR(32)) + (CASE WHEN (mk.SuffixNumber IS NULL) THEN ('') ELSE mk.SuffixNumber END) AS [� ��������� ��]
FROM  dbo.Wares INNER JOIN
         dbo.Lot AS l ON dbo.Wares.WareId = l.WareId INNER JOIN
         dbo.ClassType AS c ON dbo.Wares.ClassId = c.ClassId INNER JOIN
         dbo.ClassType AS c1 ON c.ParentId = c1.ClassId INNER JOIN
         dbo.ClassType AS c2 ON c1.ParentId = c2.ClassId INNER JOIN
         dbo.Lot AS mk ON mk.ParentId = l.LotId INNER JOIN
         dbo.Test AS t ON t.TestId = mk.TestId  INNER JOIN
		 Manufactory mn  on mk.ManufactoryId= mn.ManufactoryId LEFT  JOIN
		 Countries cr on cr.CountryId =mn.CountryId

WHERE (dbo.Wares.TypeNominal  in ('IRL5NJ7404SCS', 
'VDNF64G08RS50MS8V25-III',
'2N3019CSM',
'2N5666U3',
'1N6487US',
'HFB35HB20C',
'LFE100-461-50',
'LFE100-461-80',
'LDCD/ 100-5R-40/SP',
'LDCD/100-7-14/SP',
'LDCD/ 100-15-30/SP',
'MS12TL-313S-02',
'VJ2225Y185JLBAJ5G',
'��-080205-2',
'DEMA9SNMBFR022',
'DAMA15SNMBFR022',
'62SMA-0-0-1/-111NE',
'64SMA-0-0-1/-111NE',
'R125252000',
'R143608000') ) AND (l.LotTypeId = '�')

