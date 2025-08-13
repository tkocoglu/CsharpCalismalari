using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegete
{
    //54.baş
    //public delegate void FullNameDelegate(string isim, string soyisim);
    //54.sonn

    //55.baş
    //public delegate bool promosyonDeleget(isci isci);

    //public class isci
    //{
    //    public string isim { get; set; }
    //    public string soyisim { get; set; }
    //    public int maas { get; set; }
    //    public int tecrube { get; set; }
    //    public string sehir { get; set; }

    //    public static void promosyon(List<isci> isci, promosyonDeleget promosyonDelegate)
    //    {
    //        foreach (var item in isci)
    //        {
    //            if (promosyonDelegate(item))
    //            {
    //                Console.WriteLine(item.isim + " " + item.soyisim);
    //            }
    //        }
    //    }
    //}
    //55.sonn
    internal class Program
    {
        public static void Main(string[] args)
        {
            //54.baş
            //FullNameDelegate fullNameDelegate1 = new FullNameDelegate(FullNameMethod1);
            //FullNameDelegate fullNameDelegate2 = new FullNameDelegate(FullNameMethod2);
            //FullNameDelegate fullNameDelegate3 = new FullNameDelegate(FullNameMethod3);

            //FullNameDelegate ZincirDelegate = fullNameDelegate1 + fullNameDelegate2 + fullNameDelegate3;
            //ZincirDelegate("fattih", "çakır");
            //54.son

            //55.baş
            //isci i1 = new isci { isim = "fatiha", soyisim = "çağaloğlu", maas = 1000, tecrube = 1, sehir = "istanbul" };
            //isci i2 = new isci { isim = "aslı", soyisim = "çağaloğlu", maas = 2000, tecrube = 2, sehir = "aydın" };
            //isci i3 = new isci { isim = "kibariye", soyisim = "çağaloğlu", maas = 3000, tecrube = 3, sehir = "manisa" };
            //isci i4 = new isci { isim = "latife", soyisim = "çağaloğlu", maas = 4000, tecrube = 4, sehir = "mersin" };
            //isci i5 = new isci { isim = "deniz", soyisim = "çağaloğlu", maas = 5000, tecrube = 5, sehir = "elazığ" };

            //List<isci> isciler = new List<isci>();
            //isciler.Add(i1);
            //isciler.Add(i2);
            //isciler.Add(i3);
            //isciler.Add(i4);
            //isciler.Add(i5);

            //isci.promosyon(isciler, i => i.tecrube >= 4);
            //54.son

        }
        //54.baş
        //public static void FullNameMethod1(string isim, string soyisim)
        //{
        //    Console.WriteLine(isim + " " + soyisim);
        //}
        //public static void FullNameMethod2(string isim, string soyisim)
        //{
        //    Console.WriteLine(isim.ToUpper() + " " + soyisim.ToUpper());
        //}
        //public static void FullNameMethod3(string isim, string soyisim)
        //{   
        //        Console.WriteLine(soyisim.ToUpper() + " " + isim.ToUpper());
        //}
        //54.sonn


        //public delege bool Predicate<in T>(T obj);
        //public delegate TResult  Func<in T,out TResult>(T arg);
    }
}
