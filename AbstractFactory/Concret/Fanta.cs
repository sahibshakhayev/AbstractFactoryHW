using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concret
{
    internal class Fanta : ICola
    {
        public int fizzyLevel { get; set; } = 80;
        public string bottleType { get; set; }

        public Fanta()
        {
            Console.WriteLine("Fanta!");
        }

        public void Drink()
        {
            throw new NotImplementedException();
        }
    }
}