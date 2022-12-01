using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concret
{
    internal class PepsiMango : IPepsi
    {
        public int fizzyLevel { get; set; } = 80;
        public string bottleType { get; set; }
        public bool hasGift { get; set; }

        public PepsiMango()
        {
            Console.WriteLine("Pepsi Mango!");
        }

        public void Drink()
        {
            throw new NotImplementedException();
        }
    }
}