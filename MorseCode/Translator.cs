using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    public class Translator
    {
        public string Key { get; set; }
        public string Code { get; set; }
        public override string ToString()
        {
            return $"{Key},{Code}";
        }
        public Translator()
        {

        }
        public Translator(string[] data)
        {
            Key = data[0];
            Code = data[1];
        }

    }
}
