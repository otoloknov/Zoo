using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Reptile
{
    public abstract class Reptile : Animal
    {
        public int Lenght { get; set; }
        public abstract void Crawl();
    }
}
