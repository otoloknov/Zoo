using System;

namespace SolutionsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallShark = new Animals.Fish.Shark("SmallShark #1",100);
            var smallTiger = new Animals.Mammal.Tiger("SmallTiger #1",560);
            var smallFrog = new Animals.Reptile.Frog("SmallFrog #1", 45);

            smallFrog.Crawl();
            smallFrog.Talk();

            Console.WriteLine("");

            smallShark.Swimming();
            smallShark.Talk();

            Console.WriteLine("");

            smallTiger.Talk();
            smallTiger.Walk();

            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
