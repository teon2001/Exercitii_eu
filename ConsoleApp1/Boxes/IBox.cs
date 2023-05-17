using ConsoleApp1.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Boxes
{
    interface IBox
    {
        int MaxCapacity { get; set; }
        List<IMaterial> Materials { get; set; }

        int RemainingCapacity();

    }
}
