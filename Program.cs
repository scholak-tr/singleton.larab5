using System;
using System.Collections.Generic;
using System.Linq;

namespace singleton.larab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = Farm.Get();
            var f2 = Farm.Get();
            var f3 = Farm.Get();
            var f4 = Farm.Get();

            var farmList1 = new List<Farm>() { f1, f2 };
            var farmList2 = new List<Farm>() { f3, f4 };

            bool Equal = Enumerable.SequenceEqual(farmList1, farmList2);

            Console.WriteLine(Equal);
            Console.ReadKey();
        }
    }
}
