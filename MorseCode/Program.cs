using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class Program
    {
        

        


        static void Main(string[] args)
        {
            const string morsePath = "morse.csv";

            var morseKey = new List<Translator>();

            using (var reader = new StreamReader(morsePath))
            {
                while (reader.Peek() > -1)
                {
                    var code = reader.ReadLine();
                    var split = code.Split(',');
                    var translator = new Translator(split);
                    morseKey.Add(translator);
                }
            }

            foreach (var item in morseKey)
            {
                Console.WriteLine(item);
            }




           





        }
    }
}
