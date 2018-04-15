using System;
using Animals.Interfaces;

namespace Animals.Fish
{
    public class GoldenFish : Fish, IWaterLover
    {
        public GoldenFish(string name, int depth)
        {
            Name = name;
            DepthOfDiving = depth;
        }
        public override void Talk()
        {
            Console.WriteLine("IM TALK = Im a {0}. My name is {1}, I could download on {2}",typeof(GoldenFish),Name,DepthOfDiving);
        }

        public override void Swimming()
        {
            Console.WriteLine("IM SWIMMING = Im a {0}. My name is {1}, I could download on {2}", typeof(GoldenFish), Name, DepthOfDiving);
        }

        public void CanDive()
        {
            Console.WriteLine("I will diving now. Max depth = {0}", DepthOfDiving);
        }
    }
}
