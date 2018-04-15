using System;
using System.Collections.Generic;
using Animals;

namespace ZooLibrary
{
    public class Zoo
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string ZooState { get; private set; }

        public Zoo(string name, string adress, string state)
        {
            Name = name;
            Adress = adress;
            ZooState = state;
        }

        private readonly List<Animal> _cagesForNonPredators = new List<Animal>();
        private readonly List<Animal> _cagesForPredators = new List<Animal>();
        private readonly List<Animal> _cagesWithWatter = new List<Animal>();

        public void PutAnAnimalInNonPredatorsCage(Animal animal)
        {
            _cagesForNonPredators.Add(animal);
        }
        public void PutAnAnimalInPredatorsCage(Animal animal)
        {
            _cagesForPredators.Add(animal);
        }
        public void PutAnAnimalInWater(Animal animal)
        {
            _cagesWithWatter.Add(animal);
        }

        public void PrintListOfAnimalInCages()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("List of animals in non Predator cage:");
            foreach (var nonPredator in _cagesForNonPredators)
            {
                Console.Write(nonPredator.Name + " , ");
            }
            
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("List of animals in Predator cage:");
            foreach (var predator in _cagesForPredators)
            {
                Console.Write(predator.Name + " , ");
            }
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("List of animals in Water pool:");
            foreach (var waterAnimal in _cagesWithWatter)
            {
                Console.Write(waterAnimal.Name + " , ");
            }
            Console.WriteLine("\n----------------------------------");
            Console.ResetColor();
        }

        public void ChangeZooState(string newState)
        {
            ZooState = newState;
        }
    }
}
