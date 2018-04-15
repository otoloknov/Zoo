using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using Animals;


namespace ZooLibrary
{
    public class ZooManager
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Education { get; set; }

        public ZooManager(string name, int age, string education)
        {
            Name = name;
            Age = age;
            Education = education;
        }

        public void CloseOpenZoo(string action, Zoo currentZoo)
        {
            Console.WriteLine("Current status {0}", currentZoo.ZooState);
            currentZoo.ChangeZooState(action);
        }

        public void ToPlaceAnimalsOnCages(List<Animal> listOfAnimals, Zoo currentZoo)
        {
            foreach (var identifyAnimal in listOfAnimals)
            {
                if (AnimalClassifier.IsAnimalPredator(identifyAnimal))
                    currentZoo.PutAnAnimalInPredatorsCage(identifyAnimal);
                else if (AnimalClassifier.IsAnimalaWaterLover(identifyAnimal))
                            currentZoo.PutAnAnimalInWater(identifyAnimal);
                    else if (AnimalClassifier.IsAnimalaCat(identifyAnimal))
                            currentZoo.PutAnAnimalInNonPredatorsCage(identifyAnimal);
                        else currentZoo.PutAnAnimalInNonPredatorsCage(identifyAnimal);
            }
        }
    }
}
