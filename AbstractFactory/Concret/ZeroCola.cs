using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concret
{
    internal class ZeroCola : ICola
    {
        public int fizzyLevel { get; set; } = 0;
        public string bottleType { get; set; }

        public ZeroCola()
        {
            Console.WriteLine("Zero Cola!");
        }

        public void Drink()
        {
            throw new NotImplementedException();
        }
    }
}