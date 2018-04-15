using System;
using Animals.Interfaces;

namespace Animals.Mammal
{
    public class Tiger : Mammal , IPredator
    {
        public Tiger(string name, int age)
        {
            Name = name;
            AgeDays = age;
        }
        public override void Talk()
        {
            Console.WriteLine("IM TALK = Im a {0}. My name is {1}, I could download on {2}", typeof(Tiger), Name, AgeDays);
        }

        public override void Walk()
        {
            Console.WriteLine("IM WALKING = Im a {0}. My name is {1}, I could download on {2}", typeof(Tiger), Name, AgeDays);
        }
        public void CanEatNotPredators()
        {
            Console.WriteLine("I can eat non Predators. just Hide.");
        }
    }
}
