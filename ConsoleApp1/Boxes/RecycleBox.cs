using ConsoleApp1.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Boxes
{
    class RecycleBox : IBox
    {
        public int MaxCapacity { get; set; }
        public List<IMaterial> Materials { get; set; }

        public RecycleBox(int maxCapacity, List<IMaterial> materials)
        {
            MaxCapacity = maxCapacity;
            Materials = materials;
        }
        public int RemainingCapacity()
        {
            int count = MaxCapacity - Materials.Count;
            Console.WriteLine("There are " + count + " recyclable materials left.");
            return count;
        }
    }
}
