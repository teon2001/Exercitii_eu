using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Materials
{
    class Recyclable : IMaterial
    {
        public int Size { get; set; }
        public int Weight { get; set; }
        public bool IsRecyclable { get; set; }

        public Recyclable(int size, int weight, bool recyclable)
        {
            Size = size;
            Weight = weight;
            IsRecyclable = recyclable;
        }

        public void MessageForThePlanet()
        {
            Console.WriteLine("I am good for the Planet.");
        }
    }
}
