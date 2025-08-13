using System;
using UdemiCsharp;


//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace UdemyCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("tayyip koçoğlu");
            ////List<string> mylist = new List<string>();
            //string name = "tayyip koçoğlu";  //c# strongly-typed bir dildir

            //int deger = 04; //build in data type

            //Console.WriteLine(typeof(Int16)); //Int16 değer = 1; //4 bayt
            //Console.WriteLine(typeof(Int32));//Int32 değer2 = 2; //8 bayt
            //Console.WriteLine(typeof(Int64)); //Int64 değer3= 3; //16 bayt
            //8. VİDEODA KALDIK

            //value type li değişkenler bellekte stackte tutulur refrans tipli olanlar ise heap adı verdiğimiz bölgede refarans olarak turulur.
            //Değer Tipleri: “int”, “long”, “float”, “double”, “decimal”, “char”, “bool”, “byte”, “short”, “struct”, “enum”
            //Referans Tipleri: “string”, “object”, “class”, “interface”, “array”, “delegate”, “pointer”

            //property uygulaması gerçekleşti.
            //ogrenci o = new ogrenci();
            //
            //o.Name = "tayyip";
            //o.Surname = "koçoğlu";
            //o.Age = 19;
            //
            //Console.WriteLine(o.Name);
            //Console.WriteLine(o.Surname);
            //Console.WriteLine(o.Age);

            Product product = new Product();//----partial class çalışması----

            prod p = new prod();
            p.caliş();
            
        }

        //----partial class çalışması----
        public interface birinci
        {
            void birinciMethod();

            int birinciProperty { get; set; }
        }

        public interface ikinci
        {
            void ikinciMethod();

            int ikinciProperty { get; set; }
        }



        //internal class ornek //user definet data type 
        //{ }


        //internal class ogrenci // property keywordu için oluşturulan class
        //{
        //    private string _name;
        //    private string _surname;
        //    private int _age;

        //    public string Name { get { return _name.ToUpper(); } set { _name = value; } }
        //    public string Surname { get { return _surname.ToUpper(); } set { _surname = value; } }
        //    public int Age
        //    {
        //        get { return _age; }
        //        set
        //        {
        //            if (value > 20)
        //            {
        //                throw new Exception("öğrenci yaşı 20'den büyük olamaz.");
        //            }
        //            _age = value;
        //        }

        //    }
        //}
    }

    partial class prod
    {
        partial void ornek(string value);
    }

    partial class prod
    {
        public void caliş()
        {
            ornek("fattih");
        }

        partial void ornek(string value)
        {
            Console.WriteLine(value);
        }
    }
    
}