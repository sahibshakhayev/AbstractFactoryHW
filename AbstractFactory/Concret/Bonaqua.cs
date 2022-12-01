using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concret
{
    internal class Bonaqua : ICola
    {
        public int fizzyLevel { get; set; } = 0;
        public string bottleType { get; set; }

        public Bonaqua()
        {
            Console.WriteLine("Bonaqua!");
        }

        public void Drink()
        {
            throw new NotImplementedException();
        }
    }
}