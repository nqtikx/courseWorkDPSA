using System;
using System.Collections.Generic;
using System.Linq;

namespace Сursac.temerev.util
{
    class WorkerWithDictionary
    {
        public static void parseOfStingToDictionary(string str, Dictionary<char, int> dict)
        {
            foreach (char c in str)
            {
                if (dict.ContainsKey(c)) //содержится ли указанный ключ в словаре
                {
                    dict[c]++;
                }
                else // в ином случае добавляем объект
                {
                    dict.Add(c, 1);
                }
            }
        }

        public static void FillingPrefixToDictionary(string str, string [] strPrefix, Dictionary<char, string> dict)
        {
            int i = 0;

            foreach (char c in str)
            {   
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, strPrefix[i].ToString());
                    i++;
                }
            }
        }

        public static int CountSymbols(Dictionary<char, int> dict)
        {
            return dict.Count;
        }


        public static Dictionary<char, double> changeFromAmountToPersent(Dictionary<char, int> dict)
        {
            Dictionary<char, double> withPersent = new Dictionary<char, double>();
            int total_amount = getTotalAmount(dict);

            foreach (char key in dict.Keys.ToList())
            {
                dict[key] = dict[key] / total_amount;
            }

            return withPersent;
        }

        private static int getTotalAmount(Dictionary<char, int> dict) // метод возвращает количество символов
        {
            int totalAmount = 0;

            foreach (int amount in dict.Values)
            {
                totalAmount += amount;
            }

            return totalAmount;
        }
    }
}
