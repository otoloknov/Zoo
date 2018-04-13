using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Fish;
using Animals.Mammal;
using Animals.Reptile;

namespace SolutionsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallShark = new Shark("SmallShark #1",100);
            var smallTiger = new Tiger("SmallTiger #1",560);
            var smallFrog = new Frog("SmallFrog #1", 45);

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
