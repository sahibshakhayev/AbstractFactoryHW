using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concret
{
    internal class FruitFactory : IJuiceFactory
    {
        public ICola CreateCola() => new Fanta();


        public IPepsi CreatePepsi() => new PepsiMango();

    }
}