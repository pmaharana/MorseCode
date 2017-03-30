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
        const string morsePath = "morse.csv";
        public static Dictionary<string, string> ReadMorseCodeFile()

        {
            var rv = new Dictionary<string, string>();
            using (var reader = new StreamReader(morsePath))
            {
                while (reader.Peek() > -1)
                {
                    var code = reader.ReadLine();
                    var split = code.Split(',');
                    rv.Add(split[0], split[1]);
                }
            }
            return rv;
        }

        static string ConvertToMorse(string input,  Dictionary<string, string> morseKey)
        {
            var userMorse = "";
            foreach (var x in input)
            {
                userMorse += morseKey[x.ToString()] + ", ";

            }
            
            return userMorse;
        }

       
        static int ToContinueOrNot(string message)   
        {
            var input = message;
            int number = 0;
            bool wasFormatCorrect = int.TryParse(input, out number);
            while (!wasFormatCorrect)
            {
                Console.WriteLine("Enter 1 or 2, nothing else");
                input = Console.ReadLine();
                wasFormatCorrect = int.TryParse(input, out number);
            }
            return number;
        }  //method to continue or not 




        static void Main(string[] args)
        {
            var morseKey = ReadMorseCodeFile();
            var userMorse = "";
            bool continueMorse = true;
            int count = 0;
            int userAnswer = 0;
            var userPath = "useranswer.csv";
            while (continueMorse == true)
            {
                Console.WriteLine("Please enter something and I will convert it into morse code");
                var userInput = Console.ReadLine().ToUpper();

                ConvertToMorse(userInput, morseKey);
                //foreach (var input in userInput)
                //{
                //    userMorse += morseKey[input.ToString()] + ", ";

                //}
                //Console.WriteLine(userMorse);

                using (var writer =  File.AppendText(userPath))
                {
                    writer.WriteLine(userInput);
                    writer.WriteLine(ConvertToMorse(userInput, morseKey));
                }
                Console.WriteLine("");
                Console.WriteLine("Keep translating? Enter 1 to continue or 2 to end");
                userAnswer = ToContinueOrNot(Console.ReadLine());
                if (userAnswer == 1)
                {
                    continueMorse = true;
                }
                else
                {
                    continueMorse = false;
                }
                count++;
            }
            
            













            //foreach (var item in morseKey)  Reading everyrthing from dictionary
            //{
            //    Console.WriteLine(item.Key +item.Value);
            //}







        }

        public class Dictionary<T>
        {
        }
    }
}
