namespace Estimator.Models
{
    /// <summary>
    /// Конкретный тип ЭКБ для конкретной заявки
    /// </summary>
    public class Element
    {
        public int ElementID { get; set; }
        public string ElementText { get; set; }

        public int CustomerRequestID { get; set; }
        /// <summary>
        /// Заявка
        /// </summary>
        public CustomerRequest CustomerRequest { get; set; }
        public int? ElementTypeID { get; set; }
        /// <summary>
        /// Присвоенный тип согласно программы
        /// </summary>
        public int? ElementType { get; set; }
        /// <summary>
        /// колличество элементов данного типономинала
        /// </summary>
        public int Count { get; set; }
    }
}
