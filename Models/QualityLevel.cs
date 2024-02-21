using System.ComponentModel.DataAnnotations;
namespace Estimator.Models
{
   /// <summary>
   /// Уровень качества для ЭКБ ОП
   /// </summary>
    public enum QualityLevel
    {
        [Display(Name = "ОТК")]
        Commercial=0,
        [Display(Name = "ВП")]
        Military =1,
        [Display(Name = "ОС")]
        Special = 2,
        [Display(Name = "ОСМ")]
        SmallSpeial = 3 
    }
}
