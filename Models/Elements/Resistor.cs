using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics.Contracts;

namespace Estimator.Models.Elements
{
    public class Resistor:Element
    {
      
        /// <summary>
        /// Сопротивление в ОМ
        /// </summary>
        public double Resistance { get; set; }
        /// <summary>
        /// Мощность
        /// </summary>
        public string Power { get; set; }
        /// <summary>
        /// Точность резистора
        /// </summary>
        public string TRR { get; set; }
        /// <summary>
        /// Уровень шумов резистора
        /// </summary>
        public string NoiseLevel { get; set; }
        /// <summary>
        /// ТКС - температурный коэфициент сопротивления
        /// </summary>
        /// 
        public string TCR { get; set; }
        /// <summary>
        /// Обозначение резисторв для автоматического монтажа
        /// </summary>
        public string Automat { get; set; }

        /// <summary>
        /// Вид упаковки
        /// </summary>
        public string Packing { get; set; }
        /// <summary>
        /// Маркировка
        /// </summary>
        public string Marking { get; set; }

  
        public Resistor(string resistorName)
        {
            base.Template = "NL-TCR";
            this.Parce(resistorName);
        }
        public Resistor()
        {
            this.Template = "NL-TCR";
        }
        public Resistor(string resistorName, string template)
        {
            this.Template = template; ;
            this.Parce(resistorName);
        }
        public void Parce(string resistorName)
        {
            string parcedValue = "";

            string leftPart = "";
            string rightPart = "";
            int multiplier = 1;
            int parcedLenght = 0;

            //подготовка наименования,  удаление лишних данных  
            resistorName = resistorName.Trim();

            if (resistorName.Substring(0, 8).ToUpper() == "РЕЗИСТОР") { resistorName = resistorName.Substring(8, resistorName.Length - 8); }
            if (resistorName.Substring(0, 12).ToUpper() == "ЧИП-РЕЗИСТОР") { resistorName = resistorName.Substring(12, resistorName.Length - 12); }

            resistorName = resistorName.Trim();

            if (resistorName.ToUpper().Contains("ОМ"))
            {
                leftPart = resistorName.Substring(0, resistorName.ToUpper().IndexOf("ОМ"));
                rightPart = resistorName.Substring(resistorName.ToUpper().IndexOf("ОМ"));
            }

            bool digitsBegin = false;

            ///вычисляем сопротивление 
            for (int i = leftPart.Length - 1; i > 0; i--)
            {

                if (!(Char.IsWhiteSpace(leftPart[i]) || leftPart[i] == '-'))
                {
                    if (Char.ToUpper(leftPart[i]) == 'К') { multiplier = 1000; }
                    if (Char.ToUpper(leftPart[i]) == 'М') { multiplier = 1000000; }

                    if (Char.IsDigit(leftPart[i]) || leftPart[i] == ',' || leftPart[i] == '.')
                    {
                        digitsBegin = true;
                        if (leftPart[i] == ',' || leftPart[i] == '.')
                        {
                            parcedValue = ',' + parcedValue;
                        }
                        else
                        {
                            parcedValue = leftPart[i] + parcedValue;
                        }

                    }
                }
                else
                {
                    if (digitsBegin) { break; }

                }
                parcedLenght++;
            }

            double resultValue = 0;

            if (Double.TryParse(parcedValue, out resultValue)) { Resistance = resultValue * multiplier; }


            //вычисляем мощность 
            leftPart = leftPart.Substring(0, leftPart.Length - parcedLenght);

            digitsBegin = false;
            //убираем слова Вт 
            leftPart = leftPart.Replace("Вт", "");
            //
            parcedLenght = 0;
            parcedValue = "";

            for (int i = leftPart.Length - 1; i > 0; i--)
            {

                if (!(Char.IsWhiteSpace(leftPart[i]) || leftPart[i] == '-'))
                {
                    digitsBegin = true;
                    parcedValue = leftPart[i] + parcedValue;
                }
                else
                {
                    if (digitsBegin) { break; }

                }
                parcedLenght++;
            }
            this.Power = parcedValue;

            // а теперь тип 
            leftPart = leftPart.Substring(0, leftPart.Length - parcedLenght);
            if (leftPart.Substring(leftPart.Length - 1, 1) == "-") ;
            leftPart = leftPart.Substring(0, leftPart.Length - 1);

            this.Type = leftPart;

            ///точность резистора
            int indexP = rightPart.IndexOf('±');
            int indexZ = rightPart.IndexOf('%');

            parcedValue = rightPart.Substring(indexP + 1, indexZ - indexP - 1);
            this.TRR = parcedValue.Trim();

            //а теерь разбираем все остльное 
            rightPart = rightPart.Substring(indexZ + 1).Trim();

            //удаляем первое тире если необходимо
            if (rightPart.Substring(0, 1) == "-")
            {
                rightPart = rightPart.Substring(1);
            }

            rightPart = rightPart.Replace(' ', '-');

            string[] words = rightPart.Split('-');

            ///Зазбирам шаблон 
            string[] templates = Template.Split('-');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
                for (int j = 0; j < templates.Length; j++)
                {
                    //Уровень шумов
                    if (j == i & templates[j] == "NL") { NoiseLevel = words[i]; }
                    // ТКС
                    if (j == i & templates[j] == "TCR") { TCR = words[i][0].ToString(); }
                    //Автомонтаж
                    if (j == i & templates[j] == "AUTO" & words[i][0] == 'А')
                    {
                        Automat = "A";
                    }
                    //Упаковка
                    if (j == i & templates[j] == "PC")
                    {
                        Packing = words[i][0].ToString();
                    }
                    //Маркировка
                    if (j == i & templates[j] == "MR" & words[i][0] == 'М')
                    {
                        Marking = words[i][0].ToString();
                    }
                }
            }
        }

    }
}
