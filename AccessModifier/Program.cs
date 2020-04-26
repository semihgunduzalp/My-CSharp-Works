using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        protected int Id { get; set; }

        public void Save()
        {
            
        }

        public void Delete()
        {
            
        }
    }

    class Student:Customer
    {
        public void Save2()
        {
            
        }
    }

    public class Course   //default modifier is "internal" (internet verilen sınıf tüm proje içinde kullanılabilir) - bu class'ı PUBLİC yaparak diğer sınıflarda ve projelerde kullanabildik
    {
        public string Name { get; set; }
    }
}
