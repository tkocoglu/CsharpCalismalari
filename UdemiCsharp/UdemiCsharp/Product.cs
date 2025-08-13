using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UdemyCsharp.Program;

namespace UdemiCsharp
{
    partial class Product : birinci
    {
        public string  Name { get; set; }
        public  string Surname { get; set; }
        public int Age { get; set; }
        public int birinciProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void birinciMethod()
        {
            throw new NotImplementedException();
        }
    }

    // partial interface
    internal partial interface Iornek
    {
        void ornek1();
    }
}
