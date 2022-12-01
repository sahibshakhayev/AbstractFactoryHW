using AbstractFactory.Abstract;
using AbstractFactory.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concret
{
    internal class RegularFactory : IJuiceFactory
    {
        public ICola CreateCola() => new NormalCola();


        public IPepsi CreatePepsi() => new NormalPepsi();
        

        
       
    }
}
