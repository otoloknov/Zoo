using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Fish
{
    public class Shark : Fish
    {
        public Shark(string name, int depth)
        {
            Name = name;
            DepthOfDiving = depth;
        }
        public override void Talk()
        {
            Console.WriteLine("IM TALK = Im a {0}. My name is {1}, I could download on {2}", typeof(Shark), Name, DepthOfDiving);
        }

        public override void Swimming()
        {
            Console.WriteLine("IM SWIMMING = Im a {0}. My name is {1}, I could download on {2}", typeof(Shark), Name, DepthOfDiving);
        }
    }
}
