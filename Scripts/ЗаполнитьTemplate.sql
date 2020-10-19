use Estimator
delete from TestProgramTemplate
delete from TestProgramTemplateItem

declare @ProgramID int,@TemplateID int ;
select @ProgramID = 5 ; 
insert into TestProgramTemplate(TemplateName,TestProgramID) values (N'Входной контроль КП ЭКБ', @ProgramID)


select @TemplateID = max(TestProgramTemplateID) from TestProgramTemplate

insert into TestProgramTemplateItem (TestProgramTemplateID,OperationID,IsExecute,ExecuteCount )
select  distinct @TemplateID, OperationID ,0,1 from TestChainItem t, ElementType e
where e.ElementTypeID =t.ElementTypeID 
and e.ProgramID = @ProgramID 

update TestProgramTemplateItem set IsExecute =1 
where OperationID in (11,12,13,14,15,21,498,500);

--154ТВВФ001
insert into TestProgramTemplate(TemplateName,TestProgramID) values (N'154.ТВВФ001', @ProgramID)

select @TemplateID = max(TestProgramTemplateID) from TestProgramTemplate

insert into TestProgramTemplateItem (TestProgramTemplateID,OperationID,IsExecute,ExecuteCount )
select distinct  @TemplateID, OperationID ,1,1 from TestChainItem t, ElementType e
where e.ElementTypeID =t.ElementTypeID 
and e.ProgramID = @ProgramID 

update TestProgramTemplateItem set IsExecute =0 
where  OperationID in (19,20,28,36,37,38,39,40,42,43);

select * from TestProgramTemplateItem

SET IDENTITY_INSERT ElementKey  off;  

SET IDENTITY_INSERT ElementType  off;  