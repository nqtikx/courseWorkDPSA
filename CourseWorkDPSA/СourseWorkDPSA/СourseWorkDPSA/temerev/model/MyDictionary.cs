using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursac.temerev.model
{
    class MyDictionary
    {
        private static Dictionary<char, int> dictionary;
        private static Dictionary<char, string> dictionarySecond;

        public MyDictionary()
        {
            dictionary = new Dictionary<char, int>();
            dictionarySecond = new Dictionary<char, string>();
        }

        

        public void setDictionary(Dictionary<char, int> dict)
        {
            dictionary = dict;
        }

        public Dictionary<char, int> getDictionary()
        {
            return dictionary;
        }

        public Dictionary<char, string> getDictioinarySecond()
        {
            return dictionarySecond;
        }

    }
}
