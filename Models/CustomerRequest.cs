using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estimator.Models
{
    /// <summary>
    /// заявка на проведение испытаний 
    /// </summary>
    public class CustomerRequest

    {
        public int CustomerRequestID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "№ исх.")]
        public string RequestNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата исх.")]
        public DateTime RequestDate { get; set; }
        [Required]
        [StringLength(250)]
        [Display(Name = "Описание заявки")]
        public string Description { get; set; }
      /// <summary>
      /// Используется при обработке новой заявки
      /// </summary>
        public bool IsProceed { get; set; }
        public int TestProgramID { get; set; }
        public TestProgram Program { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public IEnumerable<RequestElementType> RequestElementTypes { get; set; }

      [NotMapped]
        public List<RequestOperationGroup> OperationGroups
        {

            get

            {
                if (RequestElementTypes != null)
                {


                    Dictionary<string, RequestOperationGroup> returnGroup = new Dictionary<string, RequestOperationGroup>();
                    //перебираем все типы ЭКБ

                    foreach (var itemRET in RequestElementTypes)
                    {
                        //перебираем операции для данного типа ЭРИ
                        if (itemRET.RequestOperations != null)
                        {
                            foreach (var itenRO in itemRET.RequestOperations)
                            {
                                RequestOperationGroup itemROG;
                                //Если нет такой группы то добавляем её
                                if (itenRO.TestChainItem.Operation != null)
                                {
                                    if (!returnGroup.ContainsKey(itenRO.TestChainItem.Operation.OperationGroup.Code))
                                    {
                                        itemROG = new RequestOperationGroup();
                                        itemROG.OperationGroupID = itenRO.TestChainItem.Operation.OperationGroup.OperationGroupID;
                                        itemROG.Code = itenRO.TestChainItem.Operation.OperationGroup.Code;
                                        itemROG.Name = itenRO.TestChainItem.Operation.OperationGroup.Name;
                                        returnGroup.Add(itenRO.TestChainItem.Operation.OperationGroup.Code, itemROG);

                                    }
                                    RequestQualLaborSummary itemRQLS;

                                    foreach (var itemTA in itenRO.TestChainItem.TestActions)
                                    {
                                        if (!returnGroup[itenRO.TestChainItem.Operation.OperationGroup.Code].IsQualificationInList(itemTA.Qualification.Name))
                                        {
                                            itemRQLS = new RequestQualLaborSummary();
                                            itemRQLS.QualificationID = itemTA.QualificationID;
                                            itemRQLS.Name = itemTA.Qualification.Name;
                                            returnGroup[itenRO.TestChainItem.Operation.OperationGroup.Code].QualificationLaborSummary.Add(itemRQLS);

                                        }
                                        //Cкладываем трудоёмкости по специальностям
                                        returnGroup[itenRO.TestChainItem.Operation.OperationGroup.Code].QualificationLaborSummary.Single(e => e.Name == itemTA.Qualification.Name).LaborSummary += itemTA.LaborSummary(itemRET.BatchCount, itemRET.ItemCount, itemRET.KitCount);


                                    }
                                }


                            }
                        }
                     }
                 
                    return returnGroup.Values.ToList();

                }
                else
                { return null; }
            }
      
        }
        public IEnumerable<Element> Elements { get; set; }
        
      
    }
}
