using AbstractFactory.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concret
{
    internal class NormalPepsi : IPepsi
    {
        public int fizzyLevel { get; set; } = 80;
        public string bottleType { get; set; }
        public bool hasGift { get; set; }

        public NormalPepsi()
        {
            Console.WriteLine("Normal Pepsi!");
        }

        public void Drink()
        {
            throw new NotImplementedException();
        }
    }
}
