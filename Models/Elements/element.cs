namespace Estimator.Models.Elements
{
    public class Element

    {
        /// <summary>
        /// Тип (например Р1-12)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Шаблон для разбора  правой части наименования резистора или конденсатора
        /// </summary>
        public string Template { get; set; }

       
    }
}
