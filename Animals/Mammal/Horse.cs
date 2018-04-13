using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Mammal
{
    class Horse : Mammal
    {
        public Horse(string name, int age)
        {
            Name = name;
            AgeDays = age;
        }
        public override void Talk()
        {
            Console.WriteLine("IM TALK = Im a {0}. My name is {1}, I could download on {2}", typeof(Horse), Name, AgeDays);
        }

        public override void Walk()
        {
            Console.WriteLine("IM WALKING = Im a {0}. My name is {1}, I could download on {2}", typeof(Horse), Name, AgeDays);
        }
    }
}
