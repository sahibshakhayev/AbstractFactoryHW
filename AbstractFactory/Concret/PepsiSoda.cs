using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concret
{
    internal class PepsiSoda : IPepsi
    {
        public int fizzyLevel { get; set; } = 0;
        public string bottleType { get; set; }
        public bool hasGift { get; set; }

        public PepsiSoda()
        {
            Console.WriteLine("Pepsi Soda!");
        }

        public void Drink()
        {
            throw new NotImplementedException();
        }
    }
}