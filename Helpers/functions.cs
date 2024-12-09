using System.Security.Cryptography.Xml;
using Microsoft.AspNetCore.Razor.Language;

namespace Estimator.Helpers
{

    public  class Funct

    {
        /// <summary>
        /// функция удалает из строки все пробелы и переводит в верхний регистр 
        /// </summary>
        /// <param name="value">Исходная строка</param>
        /// <returns></returns>
        public static string PrepareStr(string value)
        {
            if (value == null) { return ""; }
            // новая строка для записи строки без пробелов
        
            return PrepareWhiteSpaces(value).Trim().ToUpper();
        }
        /// <summary>
        /// функция удалает из строки все пробелы запятые и точки с запятой и переводит в верхний регистр 
        /// </summary>
        /// <param name="value">Исходная строка</param>
        /// <returns></returns>
        public static string PrepareDatasheet(string value)
        {
            if (value == null) { return ""; }
            value = PrepareWhiteSpaces (value);  
            // новая строка для записи строки без пробелов
            string newstr = "";
            // цикл
            for (int i = 0; i < value.Length; i++)
            {
                // если елемент i-ый елемент не пробел - пишем его в новую строку "newstr"
                if (value[i] != ' ' &&  value[i] != ',' &&  value[i] != ';')
                {
                    // - пишем его в новую строку "newstr"
                    newstr += value[i];
                }
            }
            //еще разок, что то не удалюются
            //char[] MyChar = { ' ', ',', ';', ':'};
            //newstr = newstr.Replace(" ", "").Replace(",","").Replace(";","").Replace 

            return newstr.Trim().ToUpper();
        }
        /// <summary>
        /// Заменяет все виды пробeлов на обычный
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string PrepareWhiteSpaces(string word)
        {
            // новая строка для записи строки без пробелов
            string newstr = "";
            char symvol;


            // цикл
            for (int i = 0; i < word.Length; i++)
            {
                 symvol = word[i];

                // если елемент i-ый елемент специальный пробел то заменяем его на обыкновенный
                if (char.IsWhiteSpace(symvol) && symvol != ' ')
                {
                    // - пишем его в новую строку "newstr"
                    symvol = ' ';
                }
             
                newstr += symvol;
            }

            return newstr; 
        }
        /// <summary>
        /// удаляет все пробклы из строки 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string RemoveWhiteSpaces(string word)
        {
            // новая строка для записи строки без пробелов
            string newstr = "";
            char symvol;


            // цикл
            for (int i = 0; i < word.Length; i++)
            {
                symvol = word[i];
           
                // если елемент i-ый елемент специальный пробел то заменяем его на обыкновенный
                if (!char.IsWhiteSpace(symvol))
                {
                    // - пишем его в новую строку "newstr"
                    newstr += symvol;
                }

             
            }

            return newstr;

        }
        /// <summary>
        /// Заменяет все английские буквы на русские 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string ReplaceEngChar(string word)
        {
            string rus = "аАвВсСеЕкКмМнНоОрРтТхХ";
            string eng = "aAbBcCeEkKmMnHoOpPtTxX";
            string newstr = "";
            if (string.IsNullOrEmpty(word)) { return string.Empty ; }   
            for (int i = 0; i < word.Length; i++)
            {
                bool replaced= false;   
                for (int j = 0; j < eng.Length; j++)
                {
                    if (word[i] == eng[j])
                    {
                        newstr += rus[j];
                        replaced = true;
                    }
                }    
                if(!replaced) { newstr  += word[i]; }
            }
            return newstr;

        }
        /// <summary>
        /// Проверка на соответствие диапазону вида : 1000000<R<=10000000

        /// </summary>
        /// <param name="range"> диапазон вида 1000000/<R/<=10000000</param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool InRange(string range, double value)
        {
            double maxValue = double.MaxValue;
            double minValue = double.MinValue;
            double textValue = 0;
            bool lessOrEqual = false;
            bool greaterOrEqual = false;

            int indexOfLetter = 0;
            if (string.IsNullOrEmpty(range)) { return false; }
            
          
            range = RemoveWhiteSpaces(range);


            ///ищем букву
            bool isLetterIntext = false;
            for (int i = 0; i < range.Length; i++)
            {
                if (char.IsLetter(range[i]))
                { indexOfLetter = i;
                    isLetterIntext = true;
                    break; 
                }
            }
         
            /// буквы нет !
            if (!isLetterIntext)
            {
                //тогда наверно проверим на равенсттво
                if (double.TryParse(range, out textValue))
                {
                    return (value == textValue);
                }
                else
                {
                    return false;
                }
            }
            // вот это условие явно тоже что и следующее, надо поправить
            //выражения типа К>10, K<10
            if (indexOfLetter  == 0 & range.Length > 2)
            {
               

                if (range.Substring(indexOfLetter + 1, 2) == ">=" | range.Substring(indexOfLetter + 1, 2) == "=>")
                {
                    minValue = double.Parse(range.Substring(indexOfLetter + 3, range.Length - 3));
                    lessOrEqual = true;
                }
                else if (range.Substring(indexOfLetter + 1, 1) == ">")
                {
                    minValue = double.Parse(range.Substring(indexOfLetter + 2, range.Length - 2));
                }

            }
            //нижняя граница
            if (indexOfLetter > 1)
            {
                if (range.Substring(indexOfLetter - 2, 2) == "<=")
                {
                    minValue = double.Parse(range.Substring(0, indexOfLetter - 2));
                    lessOrEqual = true;
                }
                else if (range.Substring(indexOfLetter - 1, 1) == "<")
                {
                    minValue = double.Parse(range.Substring(0, indexOfLetter - 1));
                }
            } 
            //верхняя граница
            if ((range.Length - indexOfLetter) > 1)
            {
                if (range.Substring(indexOfLetter + 1, 2) == "<=")
                {
                    maxValue = double.Parse(range.Substring(indexOfLetter + 3));
                    greaterOrEqual = true;
                }
                else if (range.Substring(indexOfLetter + 1, 1) == "<")
                {
                    maxValue = double.Parse(range.Substring(indexOfLetter + 2));
                }
            }
            bool result = false;

            if (lessOrEqual) { result = (value >= minValue); } else { result = (value > minValue); }
            
            if (result)
            {
                if (greaterOrEqual) { result = (value <= maxValue); } else { result = (value < maxValue); }
            }

            return result;
        }
    }
}
