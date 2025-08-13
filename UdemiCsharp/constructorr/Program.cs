using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ornekClass ornek = new ornekClass("fattih",21);
            Console.WriteLine(ornek.isim);
        }
    }

    internal class ornekClass
    {
        public string isim { get; set; }
        public int yas { get; set; }

        public ornekClass()
        {

        }
        //parametreli konstractor
        public ornekClass(string isim, int yas)
        {
            this.isim = isim;
            this.yas = yas;
        }
        //copy constractor
        public ornekClass(ornekClass ornekClass)
        {
            this.isim = ornekClass.isim;
            this.yas = ornekClass.yas;
        }

        public static string soyisim { get; set; }

        //static constructor
        static ornekClass() //static constractorlar parametre almazlar
        {
            soyisim = "cizmeli";
            Console.WriteLine("static constructor çalıştı");
        }

        //private constructor  classın içerisinden başka bir yerde dışında bu classtan nesne üretilmesini kısıtlar
        //private ornekClass()
        //{

        //}
    }
}
