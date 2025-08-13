using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ınterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IDataExtra i = new IDataExtra(); //interfacelerde nesne oluşturulamaz. 

            //bir interfacenin üyesini açık exclipt olarak implement etme
            //Iüçgen uçgen = new oluştur();
            //uçgen.çiz();
            //Ikare kare = new oluştur();
            //kare.çiz();
        }
    }
    //internal interface IDataExtra
    //{
    //    string tumdataGetir();

    //    string tümdataSil();
    //}
    //internal interface IDataIslem:IDataExtra
    //{

    //    string getItem {  get; set; }

    //    void ekle (string veri);

    //    void sil(string veriId);
    //    string oku (string veriId);

    //    string güncelle(string veriId);
    //}

    //internal class krtasye : IDataIslem
    //{
    //    public string getItem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    //    public void ekle(string veri)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public string güncelle(string veriId)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public string oku(string veriId)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void sil(string veriId)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public string tumdataGetir()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public string tümdataSil()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //--bir interfacenin üyesini açık exclipt olarak implement etme--
//    internal class oluştur:Ikare,Iüçgen
//    {
//        void Ikare.çiz()
//        {
//            Console.WriteLine("Ikare interfacsi çizildi");
//        }

//        void Iüçgen.çiz()
//        {
//            Console.WriteLine("Iüçgen interfacesi çizildi");
//        }

//    }
//    interface Ikare
//    {
//        void çiz();
//    }

//    interface Iüçgen
//    {
//        void çiz();
//    }
//}
