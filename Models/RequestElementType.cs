using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        /// Колличество партиий        public CustomerRequest CustomerRequest { get; set; }
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
        /// Возвращает коллескцию специальностей с трудоемкостями
        /// </summary>

        [NotMapped]
        public Dictionary<string, RequestQualLaborSummary> QualificationLaborSummary
        {
            get
            {
                if (RequestOperations != null)

                {
                    Dictionary<string, RequestQualLaborSummary> returnSummary = new Dictionary<string, RequestQualLaborSummary>();

                    //   перебираем все операции для данного типа ЭКБ в заявке      

                    foreach (RequestOperation itemRO in RequestOperations)
                    {
                        if (itemRO.TestChainItem != null)
                        {
                            //перебераем все шаги технологической цепочки
                            if(itemRO.TestChainItem.TestActions!=null)
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
                                        returnSummary.Add(itemAc.Qualification.Name, itemRQLS);
                                    }
                                    if (itemRO.IsExecute)
                                    {
                                        // добавляем трудоемкость для данной специальности;

                                        returnSummary[itemAc.Qualification.Name].LaborSummary += (itemRO.RequestElementType.BatchCount * itemAc.BatchLabor +
                                            itemRO.RequestElementType.ItemCount * itemAc.ItemLabor +
                                            itemRO.RequestElementType.KitCount * itemAc.KitLabor) * itemRO.ExecuteCount;

                                    }

                                }
                            }
                        }

                    }
                    return returnSummary;
                }
                else
                {
                    return null;
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
                return result/60;
            }
        }

    }  
}
