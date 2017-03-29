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

            var morseKey = new Dictionary<string, string>();

            using (var reader = new StreamReader(morsePath))
            {
                while (reader.Peek() > -1)
                {
                    var code = reader.ReadLine();
                    var split = code.Split(',');
                    morseKey.Add(split[0], split[1]);
                    
                }
            }

            //foreach (var item in morseKey)
            //{
            //    Console.WriteLine(item.Key +item.Value);
            //}

            Console.WriteLine("Enter something and I'll translate it to morse code");
            var userInput = Console.ReadLine();

            foreach (var input in userInput)
            {
                Console.Write(morseKey[input.ToString()]);
            }



           





        }
    }
}
