using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concret
{
    internal class ZeroFactory : IJuiceFactory
    {
        public ICola CreateCola() => new ZeroCola();


        public IPepsi CreatePepsi() => new ZeroPepsi();

    }
}