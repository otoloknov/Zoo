using System;
using Animals.Interfaces;

namespace Animals.Reptile
{
    public class Crocodile : Reptile, IPredator
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

        public void CanEatNotPredators()
        {
            Console.WriteLine("I can eat non Predators. just Hide.");
        }
    }
}
