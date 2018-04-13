using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Animals.Mammal
{
    public abstract class Mammal : Animal
    {
        public int AgeDays { get; set; }
        public abstract void Walk();
    }
}
