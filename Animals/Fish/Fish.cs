using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Fish
{
    public abstract class Fish : Animal
    {
        public int DepthOfDiving { get; set; }
        public abstract void Swimming();
    }
}
