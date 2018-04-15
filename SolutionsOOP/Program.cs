using System;
using System.Collections.Generic;
using ZooLibrary;
using Animals;
using Animals.Mammal;
using Animals.Reptile;

namespace SolutionsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new Zoo with default enetered paramters
            var newZoo = new Zoo("Zoo #1","Street 1","Closed");
            //create new Zoo Manager with preDefault parameters
            var newZooManager = new ZooManager("Kolya",33,"Master degree");
            //delcare list of animal for futher adding by manual or XML way.
            var loadedAminalsFromXml = new List<Animal>();

            // manual generation
            var newFrog = new Frog("Frog #1",10);
            loadedAminalsFromXml.Add(newFrog);

            var newHorse = new Horse("Horse #1", 30);
            loadedAminalsFromXml.Add(newHorse);

            var newTiger = new Tiger("Tiger #1", 12);
            loadedAminalsFromXml.Add(newTiger);

            var newCat = new Cat("Cat #1", 12);
            loadedAminalsFromXml.Add(newCat);

            //display list of manual generated Animals
            Console.WriteLine("Manual Initialized list of animals: ");
            foreach (var currentAnimal in loadedAminalsFromXml)
            {
                Console.WriteLine("   ----->>> " + currentAnimal.Name);
            }
            //Action for Zoo Manager = to Place Animals in Cages
            newZooManager.ToPlaceAnimalsOnCages(loadedAminalsFromXml,newZoo);
            //Display result
            newZoo.PrintListOfAnimalInCages();

            //try to parse data from XML file
            var parsedXml = new XmlFileParser();
            // parsing...
            loadedAminalsFromXml = parsedXml.TryToParseXml();

            Console.WriteLine("");
            // list of animals that should be added from extranal XML file
            Console.WriteLine("Want to add");
            foreach (var currentAnimal in loadedAminalsFromXml)
            {
                Console.WriteLine("   ----->>> " +currentAnimal.Name);
            }

            //Action for Zoo Manager = to Place Animals in Cages
            newZooManager.ToPlaceAnimalsOnCages(loadedAminalsFromXml, newZoo);
            Console.WriteLine("...\nAdded successfully\n");

            //Display result
            newZoo.PrintListOfAnimalInCages();


            Console.ReadLine();
        }
    }
}
