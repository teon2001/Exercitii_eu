using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ex2
    {
        public int parameter { get; set; }

        public Ex2(int parameter)
        {
            this.parameter = parameter;
        }

        public void Fibo()
        {
            int a = 0, b = 1, c = a + b;
            List<int> list = new List<int>();
            list.Add(a);

            while (c <= parameter)
            {
                list.Add(c);
                c = a + b;
                a = b;
                b = c;
            }

            var desc = list.OrderByDescending(num => num);
            foreach (var num in desc)
            {
                Console.Write(num + " - ");
            }
        }
    }
}
