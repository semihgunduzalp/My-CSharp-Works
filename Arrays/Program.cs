using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            students = new [4] {"", "", ""};
            string[] students2 = { "Engin", "Derin", "Salih" };
            //students2[3] = "Ahmet";

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[5, 3]
            {
                {"istanbul","izmit","balıkesir" },
                {"ankara","konya","kırıkkale" },
                {"antalya","adana","mersin" },
                {"rize","trabzon","samsun" },
                {"izmir","muğla","manisa" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }

                Console.WriteLine("*********");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
