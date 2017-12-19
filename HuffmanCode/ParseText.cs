using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HuffmanCode
{
   public class ParseText
    {
        private string text;
        Dictionary<Char, int> charToFrequency = new Dictionary<char, int>();
        public ParseText(string text)
        {
            this.text = text;
            this.Parse();
        }
        //public ParseText(File file)
        //{

        //}
        public string Original_Message
        {
            get
            {
                return text;
            }
        }
        public Dictionary<Char, int> getCharToFrequencyList
        {
            get
            {
                return charToFrequency;
            }
        }
        public void Parse()
        {
            for(int i = 0; i < text.Length; i++)
            {
                if (!(charToFrequency.ContainsKey(text[i]))){
                    charToFrequency.Add(text[i], 1);
                }
                else
                {
                    charToFrequency[text[i]]++;
                }
            }
        }
    }
}
