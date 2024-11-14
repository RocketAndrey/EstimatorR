using System;

using System.Text;

namespace Estimator.Models.Elements
{
    public class Capasitor:Element
    {
        public Capasitor()
        {
            this.Template = "NL-TCR";
        }
        public Capasitor(string resistorName, string template)
        {
            this.Template = template; ;
            this.Parce(resistorName);
        }
       
        /// <summary>
        /// Емкость в пФ
        /// </summary>
        public decimal Capacity { get; set; }

        /// <summary>
        /// Номинальное напряжение,В 
        /// </summary>
        public int RatedVoltage { get; set; }

        /// <summary>
        /// Обозначение группы ТКЕ
        /// </summary>
        public string TCGroup { get; set; }

      
        public void Parce(string capName)
        {
            string parcedValue = "";

            string leftPart = "";
            string rightPart = "";

            decimal multiplier = 1;
            int parcedLenght = 0;

            //подготовка наименования,  удаление лишних данных  
            capName = capName.Trim();

            if (capName.Substring(0, 8).ToUpper() == "КОНДЕНСАТОР") { capName = capName.Substring(11, capName.Length - 8); }
            if (capName.Substring(0, 12).ToUpper() == "ЧИП-КОНДЕНСАТОР") { capName = capName.Substring(15, capName.Length - 12); }

            capName = capName.Trim();

            if (capName.ToUpper().Contains("Ф"))
            {
                leftPart = capName.Substring(0, capName.ToUpper().IndexOf("Ф"));
                rightPart = capName.Substring(capName.ToUpper().IndexOf("Ф"));
            }

            bool digitsBegin = false;

            //   вычисляем емкость 
            for (int i = leftPart.Length - 1; i > 0; i--)
            {

                if (!(Char.IsWhiteSpace(leftPart[i]) || leftPart[i] == '-'))
                {
                    if (Char.ToUpper(leftPart[i]) == 'Н') { multiplier = 1000M; }// нанофарады
                    if (Char.ToUpper(leftPart[i]) == 'К' & Char.ToUpper(leftPart[i - 1]) == 'М') { multiplier = 1000000M; }//микрофарады

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

            decimal resultValue = 0;

            if (Decimal.TryParse(parcedValue, out resultValue)) { Capacity = resultValue * multiplier; }



            //    //вычисляем группу по ТКЕ  
            leftPart = leftPart.Substring(0, leftPart.Length - parcedLenght);


            digitsBegin = false;

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
            TCGroup = parcedValue;
            //todo разбор имени конденсатора

            // номинальное напряжение 
            leftPart = leftPart.Substring(0, leftPart.Length - parcedLenght);
            string tempLeftPart = leftPart;

            digitsBegin = false;

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
            // теперь надо определить что мы нашли  ? Температурную нестабильность или Номинальное напряжение ?
            if (parcedValue[parcedValue.Length - 1] == 'В')
            {
                int voltage = 0; ;
                int.TryParse(parcedValue.Substring(0, parcedValue.Length - 1), out voltage);
                RatedVoltage = voltage;

                leftPart = leftPart.Substring(0, leftPart.Length - parcedLenght);
            }
            else
            {
                leftPart = tempLeftPart;
            }


            //    // а теперь тип 
            if (leftPart.Substring(leftPart.Length - 1, 1) == "-") { leftPart = leftPart.Substring(0, leftPart.Length - 1); }

            this.Type = leftPart;

            //    ///точность резистора
            //    int indexP = rightPart.IndexOf('±');
            //    int indexZ = rightPart.IndexOf('%');

            //    parcedValue = rightPart.Substring(indexP + 1, indexZ - indexP - 1);
            //    this.TRR = parcedValue.Trim();

            //    //а теерь разбираем все остльное 
            //    rightPart = rightPart.Substring(indexZ + 1).Trim();

            //    //удаляем первое тире если необходимо
            //    if (rightPart.Substring(0, 1) == "-")
            //    {
            //        rightPart = rightPart.Substring(1);
            //    }

            //    rightPart = rightPart.Replace(' ', '-');

            //    string[] words = rightPart.Split('-');

            //    ///Зазбирам шаблон 
            //    string[] templates = Template.Split('-');

            //    for (int i = 0; i < words.Length; i++)
            //    {
            //        words[i] = words[i].Trim();
            //        for (int j = 0; j < templates.Length; j++)
            //        {
            //            //Уровень шумов
            //            if (j == i & templates[j] == "NL") { NoiseLevel = words[i]; }
            //            // ТКС
            //            if (j == i & templates[j] == "TCR") { TCR = words[i][0].ToString(); }
            //            //Автомонтаж
            //            if (j == i & templates[j] == "AUTO" & words[i][0] == 'А')
            //            {
            //                Automat = "A";
            //            }
            //            //Упаковка
            //            if (j == i & templates[j] == "PC")
            //            {
            //                Packing = words[i][0].ToString();
            //            }
            //            //Маркировка
            //            if (j == i & templates[j] == "MR" & words[i][0] == 'М')
            //            {
            //                Marking = words[i][0].ToString();
            //            }
            //        }
            //    }
        }
    }
}
