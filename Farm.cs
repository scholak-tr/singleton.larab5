using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.larab5
{
    class Farm
    {
        private Ducks[] ducks;
        private static Farm duckfarm;

        public static Farm Get()
        {
            if (duckfarm == null)
            {
                duckfarm = new Farm();
            }
            return duckfarm;
        }

        public void Add(Ducks[] ducks)
        {
            this.ducks = ducks;
        }
        public void Show()
        {
            Console.WriteLine("Утки:");
            foreach (var duck in ducks)
            {
                Console.WriteLine(duck.Name);
            }
        }
    }
}
