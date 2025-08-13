using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            basekisi.ucret = 1000;
            isci isci = new isci("fattih", "çallığlu");
            isci.yaz();
            isci.çalış();
            isci.ucretyaz();
            // basekisi basekisi = new basekisi(); // abstract classtan doğrudan nesne oluşturulamaz.
        }
    }
    //abstract sınıflarla çalışmak
    internal abstract class basekisi
    {
        public static int ucret;//abstract sınıfın doğrudan sadece static elemanlarına ulaşabiliriz.
        public string isim { get; set; }
        public string soyisim { get; set; }
        public void yaz()
        {
            Console.WriteLine(isim + " " + soyisim);
        }
        public void ucretyaz()
        {
            Console.WriteLine("ücret:" + ucret);
        }

        public basekisi(string name, string surname)//methodlu constractor tanımladığımızda alt kılaslarda kulanabilmek için iplemnt edmeliyiz.
        {
            this.isim = name;
            this.soyisim = surname;
        }

        public abstract void çalış();
    }

    internal class isci : basekisi
    {
        public isci(string name, string surname) : base(name, surname)
        {
            Console.WriteLine($"{name}  ile  {surname} yazıldı");
        }

        public override void çalış()
        {
            Console.WriteLine("isci sınıfı çalıştı");
        }
    }
}
