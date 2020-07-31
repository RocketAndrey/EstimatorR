using DocumentFormat.OpenXml.Office.CustomUI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace Estimator.Models
{
    /// <summary>
    /// заявка на проведение испытаний 
    /// </summary>
    public class CustomerRequest

    {
        private List<RequestOperationLaborSummary> _operationSummary;
        private List<RequestOperationGroup> _operationGroups;
        public CustomerRequest()
        {
            CompanyHistory = new CompanyHistory();
            RequestDate = DateTime.Now;
            UseTemplate = false;
        }

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


        private void CalculateGroups()
        {

            if (RequestElementTypes != null)
            {

                //коллекция групп операций
                Dictionary<string, RequestOperationGroup> returnGroup = new Dictionary<string, RequestOperationGroup>();
                //коллекция операций 
                Dictionary<string, RequestOperationLaborSummary> returnOperations = new Dictionary<string, RequestOperationLaborSummary>();
                decimal labor;
                //перебираем все типы ЭКБ

                foreach (var itemRET in RequestElementTypes)
                {

                    if (itemRET.RequestOperations != null & itemRET.ItemCount > 0)
                    {
                        //перебираем операции для данного типа ЭРИ
                        foreach (var itemRO in itemRET.RequestOperations)
                        {
                            RequestOperationGroup itemROG;
                            RequestOperationLaborSummary itemROLS;
                          

                            if (itemRO.TestChainItem.Operation != null)
                            {
                                //Если нет такой группы то добавляем её в коллекцию групп
                                if (!returnGroup.ContainsKey(itemRO.TestChainItem.Operation.OperationGroup.Code))
                                {
                                    itemROG = new RequestOperationGroup(this);
                                    itemROG.OperationGroupID = itemRO.TestChainItem.Operation.OperationGroup.OperationGroupID;
                                    itemROG.Code = itemRO.TestChainItem.Operation.OperationGroup.Code;
                                    itemROG.Name = itemRO.TestChainItem.Operation.OperationGroup.Name;
                                    returnGroup.Add(itemRO.TestChainItem.Operation.OperationGroup.Code, itemROG);

                                }
                                //Если нет такой операции то добавляем её в коллекцию операций
                                if (!returnOperations.ContainsKey(itemRO.TestChainItem.Operation.OperationID.ToString()))
                                {
                                    itemROLS = new RequestOperationLaborSummary(this);
                                    itemROLS.OperationID = itemRO.TestChainItem.Operation.OperationID;
                                    itemROLS.OperationCode = itemRO.TestChainItem.Operation.Code;
                                    itemROLS.OperationName = itemRO.TestChainItem.Operation.Name;
                                    itemROLS.Order = itemRO.TestChainItem.Order;
                                    returnOperations.Add(itemRO.TestChainItem.Operation.OperationID.ToString(), itemROLS);

                                }

                                RequestQualLaborSummary itemRQLS;
                                //перебираем все специальности
                                foreach (var itemTA in itemRO.TestChainItem.TestActions)
                                {
                                    // если нет такой специальности у Групп операций то добавляем её
                                    if (!returnGroup[itemRO.TestChainItem.Operation.OperationGroup.Code].IsQualificationInList(itemTA.Qualification.Name))
                                    {
                                        itemRQLS = new RequestQualLaborSummary();
                                        itemRQLS.QualificationID = itemTA.QualificationID;
                                        itemRQLS.Name = itemTA.Qualification.Name;
                                        itemRQLS.CustomerRequest = this;
                                        returnGroup[itemRO.TestChainItem.Operation.OperationGroup.Code].QualificationLaborSummary.Add(itemRQLS);

                                    }
                                    // если нет такой специальности у  операций то добавляем её
                                    if (!returnOperations[itemRO.TestChainItem.Operation.OperationID.ToString()].IsQualificationInList(itemTA.Qualification.Name))
                                    {
                                        itemRQLS = new RequestQualLaborSummary();
                                        itemRQLS.QualificationID = itemTA.QualificationID;
                                        itemRQLS.Name = itemTA.Qualification.Name;
                                        itemRQLS.CustomerRequest = this;
                                        returnOperations[itemRO.TestChainItem.Operation.OperationID.ToString()].QualificationLaborSummary.Add(itemRQLS);

                                    }
                                    //вычисление труlоёмкости;
                                    labor = 0;
                                    //Cкладываем трудоёмкости по специальностям
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
                                                // берем объём выборки из заявки умнож. на кол-во партий, если 0 то с выборкой ничего не делают()
                                                sampleCount = itemRO.SampleCount* itemRO.RequestElementType.BatchCount;
                                                break;

                                        }
                                        //вычисление группировкиж
                                        int groupOperationCount = 0;
                                        int result = 0;
                                        groupOperationCount = Math.DivRem(sampleCount, itemRO.TestChainItem.GroupOperation, out result);
                                        if (result != 0)
                                        {
                                            groupOperationCount += 1;
                                        }
                                        if (itemRO.RequestElementType.ItemCount == 0)
                                        {
                                            groupOperationCount = 0;
                                        }
                                        ///какой - то кривой способ
                                        
                                        // добавляем трудоемкость для данной специальности;
                                        labor = ((itemRO.RequestElementType.BatchCount * itemTA.BatchLabor) +
                                           groupOperationCount * itemTA.ItemLabor +
                                            itemRO.RequestElementType.KitCount * itemTA.KitLabor) * itemRO.ExecuteCount * (itemRO.IsExecute ? 1 : 0)
                                             * CompanyHistory.TotalFactor; ;

                                

                                    }


                                    returnGroup[itemRO.TestChainItem.Operation.OperationGroup.Code].QualificationLaborSummary.Single(e => e.Name == itemTA.Qualification.Name).LaborSummary += labor;
                                    returnOperations[itemRO.TestChainItem.Operation.OperationID.ToString()].QualificationLaborSummary.Single(e => e.Name == itemTA.Qualification.Name).LaborSummary += labor;
                                }


                            }


                        }
                    }
                }

                _operationSummary = returnOperations.Values.OrderBy(e => e.Order).ToList();
                _operationGroups = returnGroup.Values.ToList();
            }
            else
            {
                _operationSummary = new List<RequestOperationLaborSummary>();
                _operationGroups = new List<RequestOperationGroup>();
            }

        }
        [NotMapped]
        public List<RequestQualLaborSummary> QualificationSummary
        {

            get
            {
                Dictionary<string, RequestQualLaborSummary> returnGroup = new Dictionary<string, RequestQualLaborSummary>();
                if (OperationGroups != null)
                {
                    foreach (var itemOG in OperationGroups)
                    {
                        foreach (var itemQ in itemOG.QualificationLaborSummary)
                        {
                            if (!returnGroup.ContainsKey(itemQ.QualificationID.ToString()))
                            {
                                RequestQualLaborSummary item = new RequestQualLaborSummary();
                                item.LaborSummary = 0;
                                item.Name = itemQ.Name;
                                item.QualificationID = itemQ.QualificationID;
                                item.CustomerRequest = this;

                                returnGroup.Add(itemQ.QualificationID.ToString(), item);
                            }
                            returnGroup[itemQ.QualificationID.ToString()].LaborSummary += itemQ.LaborSummary;
                        }
                    }
                    return returnGroup.Values.ToList();
                }
                else
                { return null; }

            }
        }

        [NotMapped]
        public List<RequestOperationLaborSummary> OperationSummary
        {
            get
            {
                if (_operationSummary != null)
                {
                    CalculateGroups();
                }
                return _operationSummary;

            }
        }
        [NotMapped]
        public List<RequestOperationGroup> OperationGroups
        {
            get
            {
                if (_operationGroups == null)
                {
                    CalculateGroups();
                }
                return _operationGroups;
            }
        }
        /// <summary>
        /// Основная заработная плата
        /// </summary>
        [NotMapped]
        public decimal BasicSalary
        {
            get
            {
                decimal result;
                result = 0;

                if (OperationGroups != null)
                {
                    foreach (var itemOG in OperationGroups)
                    {
                        result += itemOG.Salary;
                    }

                }
                return result;
            }
        }
        /// <summary>
        /// Дополнительная заработная плата
        /// </summary>
        [NotMapped]
        public decimal TotalSalary
        {
            get
            {
                return AdditionalSalary + BasicSalary;
            }
        }
        /// <summary>
        /// Дополнительная заработная плата
        /// </summary>
        [NotMapped]
        public decimal AdditionalSalary
        {
            get
            {
                return CompanyHistory.AdditionalSalary/100 * BasicSalary;
            }
        }
        /// <summary>
        /// Средняя заработная плата
        /// </summary>
        [NotMapped]
        public decimal AverageSalary
        {
            get
            {
                if (TotalLabor > 0)
                {
                    return BasicSalary / (TotalLabor / 168);
                }
                else
                { return 0; }
            }
        }

        /// <summary>
        /// накладные расходы
        /// </summary>
        [NotMapped]
        public decimal OverHead
        {
            get
            {
                return CompanyHistory.OverHead / 100 * BasicSalary;
            }
        }

        [NotMapped]
        public decimal PensionTax
        {
            get
            {
                return CompanyHistory.PensionTax / 100 * TotalSalary;
            }
        }
        /// <summary>
        /// производственная себестоимость 
        /// </summary>
        [NotMapped]
        public decimal InputCost
        {
            get
            {
                return TotalSalary + PensionTax + OverHead;
            }
        }
        [NotMapped]
        public decimal TotalCost
        {
            get
            {
                return InputCost + Margin;
            }
        }
        [NotMapped]
        public decimal Margin
        {
            get
            {
                return InputCost * CompanyHistory.Margin / 100;
            }
        }
        [NotMapped]
        public decimal TotalLabor
        {
            get
            {
                decimal result;
                result = 0;

                if (OperationGroups != null)
                {
                    foreach (var itemOG in OperationGroups)
                    {
                        result += itemOG.LaborSummary;
                    }

                }
                return result / 60;
            }
        }
        [NotMapped]
        public CompanyHistory CompanyHistory { get; set; }
        [NotMapped]
        public int TotalBanchCount
        {
            get
            {
                int result = 0;
                if (RequestElementTypes != null)
                {
                    foreach (var item in RequestElementTypes)
                    {
                        result += item.BatchCount;
                    }
                }
                return result;

            }
        }
        [NotMapped]
        public int TotalItemCount
        {
            get
            {
                int result = 0;
                if (RequestElementTypes != null)
                {
                    foreach (var item in RequestElementTypes)
                    {
                        result += item.ItemCount;
                    }
                }

                return result;

            }
        }
        [NotMapped]
        public int TotalKitCount
        {
            get
            {
                int result = 0;
                if (RequestElementTypes != null)
                {
                    foreach (var item in RequestElementTypes)
                    {
                        result += item.KitCount;
                    }
                }
                return result;

            }
        }
        [NotMapped]
        public decimal AveragePartCost
        {
            get
            {
                if (TotalBanchCount > 0)
                {
                    return (TotalCost / TotalBanchCount);
                }
                else
                {
                    return 0;

                }
            }
        }
        /// <summary>
        /// соотношение заработной платы к итоговой стоимости 
        /// </summary>
        [NotMapped]
        public decimal TotalRatio
        {
            get
            {
                return CompanyHistory.TotalRatio;
            }
        }
        /// <summary>
        /// Ссылка на родительскую заявку ( когда заявка создана из другой заявки)
        /// </summary>
        public int? ParentCustomerRequestID
        {
            get;
            set;
        }
        public int? CreateUserID { get; set; }
        public User CreateUser { get; set; }
        public DateTime CreateDate { get; set; }


        public int? LastModificateUserID { get; set; }

        public User LastModificateUser { get; set; }
        public DateTime ModificateDate { get; set; }
        /// <summary>
        /// использоват ьшаблон при выборе операция программы
        /// </summary>
        [NotMapped]
        public bool UseTemplate { get; set;}
        [NotMapped]
        public int TestProgramTemplateID { get; set; }

    }
}
