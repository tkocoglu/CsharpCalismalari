using System;

namespace ref_out
{
    internal class Program
    {
        static void Main(string[] args)
        {    //out ifadesi
             //int carpp;
             //int cikartmaaa;
             //int topla = islem(2,3,out carpp,out cikartmaaa);

            //Console.WriteLine(topla);
            //Console.WriteLine(carpp);
            //Console.WriteLine(cikartmaaa);

            //ref ifadesi
            //int a = 10;
            //Console.WriteLine("a değişkeninin değeri="+a);

            //getData(ref a);
            //Console.WriteLine("method çalıştıktan sonra__>a değiştikeninin değeri="+a);


            //using ifadesi
            //using (SqlConnection conn = new SqlConnection())
            //{

            //}

            //nulleybal veri tipi
            //int? x = null;
            //double? y = null;

            //list ifadeleri
            //string[] isimler = new string[5];
            //isimler[0] = "fattihler";

            //int[] sayilar = new int[5];
            //sayilar[3] = 1;

            //ArrayList veriler = new ArrayList();
            //veriler.Add("fattihh");
            //veriler.Add(04);
            //veriler.Add(new SqlConnection());

            //List<int> liste = new List<int>();
            //liste.Add(04);


            //params keywordu
            //Console.WriteLine(topla(new int[] {1,2,3,4,5}));
            //Console.WriteLine(topla( 1, 2, 3, 4, 5 ,6,7,8,9,10));

            //method overloading : birden fazla aynı isimden ve farklı parametrelerden method oluşturma işlemi
            ornek o = new ornek();
            Console.WriteLine(o.topla("fatmanur","kartal"));
            Console.WriteLine(o.topla(5,4));
        }

        //public static int islem(int a, int b, out int carp, out int cikarma)
        //{
        //    carp = a * b;
        //    cikarma = a - b;
        //    return a + b;
        //}

        //ref keywordu
        //public static void getData(ref int a)
        //{
        //    a = a + 10;
        //}

        //params keywordu
        //public static int topla(params int[] sayilar)
        //{
        //    int sum = 0;
        //    foreach (int item in sayilar)
        //    {
        //        sum += item;
        //    }
        //    return sum;
        //}

        //method overloading
        internal class ornek
        {
            public string topla(string isim,string soyisim)
            {
                return isim +" "+soyisim; 
            }

            public int topla(int a, int b)
            {
                return a+b;
            }
        }
    }
}
