using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstract
{
    internal interface IPepsi
    {
        int fizzyLevel { get; set; }

        string bottleType { get; set; }

        bool hasGift { get; set; }
        void Drink();
    }
}
