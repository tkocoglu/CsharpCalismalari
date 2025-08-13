using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UdemyCsharp.Program;

namespace UdemiCsharp
{
    partial class Product : ikinci
    {
        public int ikinciProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ikinciMethod()
        {
            throw new NotImplementedException();
        }

        public void method1()
        {

        }
     public string method2()
        {
            return "gs";
        }
    }

    // partial interface
    internal partial interface Iornek
    {
        void ornek2();
    }
}

