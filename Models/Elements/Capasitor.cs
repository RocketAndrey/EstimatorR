using System;

using System.Text;
using Estimator.Helpers;

namespace Estimator.Models.Elements
{
    public class Capasitor:Element
    {
        public Capasitor()
        {
            this.Template = "NL-TCR";
        }
        public Capasitor(string capasitorName, string template)
        {
            this.Template = template; ;
            this.Parce(capasitorName);
        }
        /// <summary
        /// Емкость в пФ
        /// </summary>
        public double Capacity { get; set; }

        /// <summary>
        /// Номинальное напряжение,В 
        /// </summary>
        public int RatedVoltage { get; set; }

        /// <summary>
        /// Обозначение группы ТКЕ
        /// </summary>
        public string TCGroup 
        { get; 
          set; 
        }
        /// <summary>
        /// Точность конденсатора
        /// </summary>
        public string Accuracy {  get; set; }   

        /// <summary>
        /// Гальваническое покрытие N
        /// </summary>
        public string Electroplating { get; set; }

        /// <summary>
        ///Видоразмер
        /// </summary>
        public string TypeSize { get; set; }

        public void Parce(string capName)
        {
            string parcedValue = "";

            string leftPart = "";
            string rightPart = "";

            double multiplier = 1;
            int parcedLenght = 0;

            //подготовка наименования,  удаление лишних данных  
            capName = capName.Trim();
            if (capName.Length > 10)
            {
                if (capName.Substring(0, 11).ToUpper() == "КОНДЕНСАТОР") { capName = capName.Substring(11, capName.Length - 11); }
            }
            if (capName.Length > 14)
            {
                if (capName.Substring(0, 15).ToUpper() == "ЧИП-КОНДЕНСАТОР") { capName = capName.Substring(15, capName.Length - 15); }
            }
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
                    if (Char.ToUpper(leftPart[i]) == 'Н') { multiplier = 1000; }// нанофарады
                    if (Char.ToUpper(leftPart[i]) == 'К' & Char.ToUpper(leftPart[i - 1]) == 'М') { multiplier = 1000000; }//микрофарады

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

            Double resultValue = 0;

            if (Double.TryParse(parcedValue, out resultValue)) { Capacity = resultValue * multiplier; }



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
            TCGroup = Funct.ReplaceEngChar( parcedValue);


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

            ///точность конденсатора
            int indexP = rightPart.IndexOf('±');
            int indexZ = rightPart.IndexOf('%');
            //Если нашли точность 
            if (indexP > -1 & indexZ > -1)
            {
                parcedValue = rightPart.Substring(indexP , indexZ - indexP);
                this.Accuracy = parcedValue.Trim();
                rightPart = rightPart.Substring(indexZ + 1).Trim();
            }


            //    //а теерь разбираем все остльное 


            //удаляем первое тире если необходимо
            if (rightPart.Substring(0, 1) == "-")
            {
                rightPart = rightPart.Substring(1);
            }

            rightPart = rightPart.Replace(' ', '-');

            string[] words = rightPart.Split('-');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "N") { Electroplating = words[i]; }
                if (words[i] == "А") { Automat = words[i]; }

                int value = 0; 

                if (int.TryParse (words[i],out value)) { TypeSize = value.ToString(); }

            }
        }
    }
}
