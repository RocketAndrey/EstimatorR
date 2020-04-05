namespace Estimator.Models
{
    /// <summary>
    /// Описывает 1 шаг технологической цепочки т.е. трудоемкость конкретной  квалификации работника
    /// привыполнении данной операции
    /// </summary>
    public class TestAction
    {
        public int TestActionID { get; set; }
        public int QualificationID { get; set; }
        /// <summary>
        /// Квалификация работника выполняющего операцию
        /// </summary>
        public Qualification Qualification { get; set; }
        ///
        public int TestChainItemID { get; set; }
        /// <summary>
        /// Шаг технологической цепочки
        /// </summary>
        public TestChainItem TestChainItem { get; set; }

        /// <summary>
        /// трудоёмкость в минутах для партии
        /// </summary>
        public int BatchLabor { get; set; }
        /// <summary>
        /// трудоёмкость в минутах для одного изделия
        /// </summary>
        public decimal ItemLabor { get; set; }
        /// <summary>
        /// Трудоемкость изготовления оснастки (для операций изготовления оснастки)
        /// </summary>
        public int KitLabor { get; set; }
        /// <summary>
        /// Трудоемкось для данной специальности 
        /// </summary>
        /// <param name="banchCount"></param>
        /// <param name="itemCount"></param>
        /// <param name="kitCount"></param>
        /// <returns></returns>
     

    }
}
