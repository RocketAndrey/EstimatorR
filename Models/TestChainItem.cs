using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Estimator.Models
{
    // шаг технологической цепочки
    public class TestChainItem
    {

        public int TestChainItemID { get; set; }
        public int ElementTypeID { get; set; }
        /// <summary>
        /// Тип изделия
        /// </summary>
        public ElementType ElementType { get; set; }

        public int OperationID { get; set; }
        /// <summary>
        /// Операция технологической цепочки
        /// </summary>
        public Operation Operation { get; set; }

        /// <summary>
        /// порядок операции в технологической цепочке
        /// </summary>
        public int Order { get; set; }
        public IEnumerable<TestAction> TestActions { get; set; }
        /// <summary>
        /// трудоемкость операции для 1 изделия, 1 партия, 1 оснастка. Описывает вес операции
        /// </summary>

        public decimal LaborWeight
        {
            get

            {
                decimal result = 0;

                if (TestActions != null)
                {
                    foreach (var item in TestActions)
                    {
                        result = result + item.BatchLabor + item.ItemLabor + item.KitLabor;
                    }
                    return result;
                }
                else
                {
                    return -1;
                }

            }
        }
        [StringLength(1000)]
        [DisplayFormat(NullDisplayText = "Нет описания")]
        public String Description { get; set; }
        [Display(Name = "Группировка")]
        public int GroupOperation { get; set; }

    }
}
