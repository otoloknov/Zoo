using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Reptile
{
    public class Frog : Reptile
    {
        public Frog(string name, int lenght)
        {
            Name = name;
            Lenght = lenght;
        }

        public override void Talk()
        {
            Console.WriteLine("IM TALK = Im a {0}. My name is {1}, I could download on {2}", typeof(Frog), Name, Lenght);
        }

        public override void Crawl()
        {
            Console.WriteLine("IM CRAWILNG = Im a {0}. My name is {1}, I could download on {2}", typeof(Frog), Name, Lenght);
        }
    }
}
