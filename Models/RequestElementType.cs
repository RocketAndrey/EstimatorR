using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Estimator.Models
{
    /// <summary>
    /// Описфвает колличество партий и штук ЭКБ по типам в заявке 
    /// </summary>
    public class RequestElementType
    {
        public int RequestElementTypeID { get; set; }

        public int? ElementTypeID { get; set; }
        public ElementType ElementType { get; set; }

        public int CustomerRequestID { get; set; }
        public CustomerRequest CustomerRequest { get; set; }

        /// Колличество партиий        

        /// <summary>

        /// </summary>
        [Display(Name = "Партий")]
        public int BatchCount { get; set; }
        /// <summary>
        /// Коилличестово изделий
        /// </summary>
        [Display(Name = "Штук")]
        public int ItemCount { get; set; }
        /// <summary>
        /// Количество недостающей оснастки
        /// </summary>
        [Display(Name = "Нет остнастки, типов")]
        public int KitCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Order { get; set; }

        public IEnumerable<RequestOperation> RequestOperations { get; set; }
        /// <summary>
        /// Возвращает коллескцию специальностей с трудоемкостями дл я данного типа
        /// </summary>

        [NotMapped]
        public Dictionary<string, RequestQualLaborSummary> QualificationLaborSummary
        {
            get
            {
                ///if (RequestOperations != null & ItemCount>0 )
                    if (RequestOperations != null)

                    {
                    Dictionary<string, RequestQualLaborSummary> returnSummary = new Dictionary<string, RequestQualLaborSummary>();

                    //   перебираем все операции для данного типа ЭКБ в заявке      

                    foreach (RequestOperation itemRO in RequestOperations)
                    {
                        if (itemRO.TestChainItem != null)
                        {
                            //перебераем все шаги технологической цепочки
                            if (itemRO.TestChainItem.TestActions != null)
                            {
                                foreach (TestAction itemAc in itemRO.TestChainItem.TestActions)
                                {
                                    RequestQualLaborSummary itemRQLS;

                                    //Проверяем есть ли в коллекции специальностей таковая
                                    if (!returnSummary.ContainsKey(itemAc.Qualification.Name))
                                    {
                                        //если нет то добавляем таковую 
                                        itemRQLS = new RequestQualLaborSummary();
                                        itemRQLS.LaborSummary = 0;
                                        itemRQLS.Name = itemAc.Qualification.Name;
                                        itemRQLS.QualificationID = itemAc.Qualification.QualificationID;
                                        itemRQLS.CustomerRequest = CustomerRequest;
                                        returnSummary.Add(itemAc.Qualification.Name, itemRQLS);
                                    }
                                    if (itemRO.IsExecute)
                                    {
                                        //Вычисляем объём выборки
                                        int sampleCount;
                                        switch (itemRO.SampleCount)
                                        {
                                            case -1:
                                                //100%
                                                sampleCount = itemRO.RequestElementType.ItemCount;
                                                break;
                                            default:
                                                // берем объём выборки из заявки  умнож на кол-во партий, если 0 то с выборкой ничего не делают()
                                                sampleCount = itemRO.SampleCount* itemRO.RequestElementType.BatchCount ;
                                                break;

                                        }
                                        int groupOperationCount = 0;
                                        int result = 0;
                                        groupOperationCount = Math.DivRem(sampleCount, itemRO.TestChainItem.GroupOperation, out result);

                                        if (result != 0)
                                        {
                                            groupOperationCount += 1;
                                        }
                                        if ( itemRO.RequestElementType.ItemCount==0)
                                        {
                                            groupOperationCount = 0;
                                        }
                                        // добавляем трудоемкость для данной специальности;
                                        returnSummary[itemAc.Qualification.Name].LaborSummary +=( (itemRO.RequestElementType.BatchCount * itemAc.BatchLabor +
                                           groupOperationCount * itemAc.ItemLabor +
                                            itemRO.RequestElementType.KitCount * itemAc.KitLabor) * itemRO.ExecuteCount * (itemRO.IsExecute ? 1 : 0))
                                            * CustomerRequest.CompanyHistory.TotalFactor;

                                    }

                                }
                            }
                        }

                    }
                    return returnSummary;
                }
                else
                {
                    return new Dictionary<string, RequestQualLaborSummary>();
                }
            }
        }
        [Display(Name = "Трудоёмкость,час")]
        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public decimal LaborSummary
        {
            get
            {
                decimal result;
                result = 0;

                foreach (var itemRQLS in QualificationLaborSummary)
                {
                    result += itemRQLS.Value.LaborSummary;
                }
                return result / 60;
            }
        }
        [Display(Name = "Стоимость,руб")]
        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public decimal CostSummary
        {
            get
            {
                decimal result;
                result = 0;

                foreach (var itemRQLS in QualificationLaborSummary)
                {
                    result += itemRQLS.Value.CostSummary;
                }
                return result; 
          
            }
        }


    }
}
