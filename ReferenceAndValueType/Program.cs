﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[] { "ankara", "adana", "afyon" };//101
            string[] cities2 = new string[] { "bursa", "bolu", "balıkesir" };
            //101
            cities2 = cities1;
            cities1[0] = "istanbul";
            Console.WriteLine(cities2[0]);

            DataTable dataTable;
            DataTable dataTable2=new DataTable();
            dataTable = dataTable2;

            Console.ReadLine();
        }
    }
}
