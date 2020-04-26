﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance //KALITIM (MİRAS)
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3] //Person Array yapıldı...
            {
                new Customer
                {
                    FirstName = "Semih"
                },
                new Student
                {
                    FirstName = "Ahmet"
                },
                new Person
                {
                    FirstName = "Salih"
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
                Console.ReadLine();
            }
        }
    }


    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}

