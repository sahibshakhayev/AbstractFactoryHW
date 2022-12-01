using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concret
{
    internal class FizzyFactory : IJuiceFactory
    {
        public ICola CreateCola() => new Bonaqua();


        public IPepsi CreatePepsi() => new PepsiSoda();

    }
}
