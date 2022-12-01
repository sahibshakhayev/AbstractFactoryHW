using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstract
{
    internal interface IJuiceFactory
    {
        ICola CreateCola();
        IPepsi CreatePepsi();
    }
}
