using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstract
{
    internal interface ICola
    {
        int fizzyLevel { get; set; }

        string bottleType { get; set; }
        void Drink();
    }
}
