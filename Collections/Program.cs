using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            List<string> cities=new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            List<Customer> customers=new List<Customer>();
            customers.Add(new Customer{Id=1,FirstName = "Engin"});
            customers.Add(new Customer{Id=2,FirstName = "Derin"});

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //Console.WriteLine(cities[2]);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
