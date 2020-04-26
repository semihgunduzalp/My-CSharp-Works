using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "my name is semih gündüzalp";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "mY nAME iS zUhAl gÜnDüZAlP"; 



            bool result3 = sentence.EndsWith("p");
            bool result4 = sentence.StartsWith("my name");
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ","-");
            var result13 = sentence.Remove(2,4);

            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";


            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
