using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Reptile
{
    class Crocodile : Reptile
    {
        public Crocodile(string name, int lenght)
        {
            Name = name;
            Lenght = lenght;
        }

        public override void Talk()
        {
            Console.WriteLine("IM TALK = Im a {0}. My name is {1}, I could download on {2}", typeof(Crocodile), Name, Lenght);
        }

        public override void Crawl()
        {
            Console.WriteLine("IM CRAWILNG = Im a {0}. My name is {1}, I could download on {2}", typeof(Crocodile), Name, Lenght);
        }
    }
}
