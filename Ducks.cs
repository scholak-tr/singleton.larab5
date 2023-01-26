using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton.larab5
{
       abstract class Ducks
     {
        public string Name { get; }
        public Ducks(string Name)
        {
            this.Name = Name;
        }
    }
}
