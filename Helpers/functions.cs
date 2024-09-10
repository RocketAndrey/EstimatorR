using System.Security.Cryptography.Xml;

namespace Estimator.Helpers
{

    public  class Funct

    {
        /// <summary>
        /// функция удалает из строки все пробелы и переводит в нижний регистр 
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
        /// функция удалает из строки все пробелы запятые и точки с запятой и переводит в нижний регистр 
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
        /// Заменяет все виды пробклов на обычный
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
    }
}
