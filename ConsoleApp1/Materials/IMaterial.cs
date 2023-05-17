using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Materials
{
    interface IMaterial
    { 
        int Size { get; set; }
        int Weight { get; set; }
        bool IsRecyclable { get; set;  }

        void MessageForThePlanet();
    }
}
