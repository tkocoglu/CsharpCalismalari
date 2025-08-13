using System;


namespace Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit veri dönüşümü
            //int sayi = 100;
            //long sayi2 = sayi;

            //explicit veri dönüşümü
            //long sayi3 = 500;
            //int sayi4 = (int) sayi3; // veri kaybı yok duruma göre olabilir.  

            //int değer = 100; //value tip
            //object değer2 = değer; // boxing işlemi

            //object değer3 = 100;
            //int değer4 = (int)değer3; //unboxing işlemi

            //Console.WriteLine(değer4);
            //casting
            //long say = 100;
            //int say1 = (int) say;

            //string veri = "34";
            //int veri2 = int.Parse(veri);
            //Console.WriteLine(veri2);
            //Console.ReadKey();

            //string veri = "tayyip";
            //int result;
            //bool veri2 = int.TryParse(veri, out result);
            //Console.WriteLine(veri2);
            //Console.WriteLine(result) ;


            //--is ve as operatörleri--
            //Object[] dizi = { "fatih", 5, 5.4, false, "mehmet", true, 40 };

            //foreach (var item in dizi) 
            //{ 
            //  if (item is bool)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Object[] dizi = { "fatih", 5, 5.4, false, "mehmet", true, 40 };

            //foreach (var item in dizi)
            //{
            //    string veri = item as string;
            //    Console.WriteLine(veri);
            //}

            //uyestruct u = new uyestruct(20);//structan nesne oluşturma

            //uye.editör editor = new uye.editör(); //nested type classtan nesne oluşturma
            
        }
    }
    //--const keywordunun kulanımı--
    //internal class Kare
    //{
    //    public const double PI = 3.14;

    //    public readonly int kdv;
    //    public Kare()
    //    {
    //        kdv = 18;
    //    }
    //  }

    //--struct örneği--
    //internal struct uyestruct
    //    {
    //    public int yas { get; set; }

    //    public uyestruct(int yas2)
    //        {
    //         yas = yas2;
    //        }
    //    }

    //nested type: class içerisinde class oluşturma durumudur.
    //internal class uye
    //    {
    //    public string name { get; set; }
    //    public class editör
    //         {
    //        public string  editörName { get; set; }
    //        }
    //    }


    }
