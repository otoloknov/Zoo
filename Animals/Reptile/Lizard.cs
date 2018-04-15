using System;

namespace Animals.Reptile
{
    public class Lizard : Reptile
    {
        public Lizard(string name, int lenght)
        {
            Name = name;
            Lenght = lenght;
        }

        public override void Talk()
        {
            Console.WriteLine("IM TALK = Im a {0}. My name is {1}, I could download on {2}", typeof(Lizard), Name, Lenght);
        }

        public override void Crawl()
        {
            Console.WriteLine("IM CRAWILNG = Im a {0}. My name is {1}, I could download on {2}", typeof(Lizard), Name, Lenght);
        }
    }
}
