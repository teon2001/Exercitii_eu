using ConsoleApp1.Boxes;
using ConsoleApp1.Materials;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Publicis!");
            
            Console.WriteLine("----------------EX1-----------------");
            // ------------------------------------------EX1----------------------------------
            List<IMaterial> l1 = new List<IMaterial>();
            List<IMaterial> l2 = new List<IMaterial>();

            IBox b1 = new NormalBox(2, l1);
            IBox b2 = new RecycleBox(2, l2);

            IMaterial r1 = new Recyclable(4, 5, true);
            IMaterial r2 = new Recyclable(1, 7, true);
            IMaterial r3 = new Recyclable(6, 90, true);
            IMaterial r4 = new Recyclable(2, 1, true);

            IMaterial s1 = new Standard(11, 39, false);
            IMaterial s2 = new Standard(1, 20, false);
            IMaterial s3 = new Standard(3, 20, false);


            List<IMaterial> allMaterials = new List<IMaterial>();
            allMaterials.Add(r1);
            allMaterials.Add(s1);
            allMaterials.Add(s3);
            allMaterials.Add(s2);
            allMaterials.Add(r2);
            allMaterials.Add(r3);
            allMaterials.Add(r4);


            foreach (IMaterial m in allMaterials) {
                m.MessageForThePlanet();

                if (m is Recyclable && b2.RemainingCapacity() != 0) {
                    b2.Materials.Add(m);
                } else if (b1.RemainingCapacity() != 0) {
                    b1.Materials.Add(m);
                }
                if (b1.RemainingCapacity() == 0 && b2.RemainingCapacity() == 0) {
                    break;
                }
            }

            Console.WriteLine(b1.Materials.Count);
            Console.WriteLine(b2.Materials.Count);


            // ------------------------------------------EX2----------------------------------
            Console.WriteLine();
            Console.WriteLine("----------------EX2-----------------");
            Ex2 ex2 = new Ex2(56);
            ex2.Fibo();


            // ------------------------------------------EX3----------------------------------
            Console.WriteLine("\n");
            Console.WriteLine("----------------EX3-----------------");

            string one = new string("a");
            char hundred = 'd';
            int maxLimit = (int)hundred;
            for (int i = one.Length; i <= maxLimit; i += one.Length)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

        }
    }
}