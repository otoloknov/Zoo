using System;
using System.Collections.Generic;
using System.Xml;
using Animals;
using Animals.Fish;
using Animals.Mammal;
using Animals.Reptile;

namespace SolutionsOOP
{
    class AnimalToSort
    {
        public string Type { get; private set; }
        public string Name { get; private set; }
        public string AdditionalParmeter { get; private set; }

        public AnimalToSort(string type, string name, string additionalParmeter)
        {
            Type = type;
            Name = name;
            AdditionalParmeter = additionalParmeter;
        }
    }
    class XmlFileParser
    {
        public List<Animal> TryToParseXml()
        {
            List<Animal> listOfParsedAnimals = new List<Animal>();

            XmlDocument doc = new XmlDocument();
            doc.Load("ListOfAnimals.xml");

            foreach (XmlNode node in doc.DocumentElement)
            {
                string type = node.Attributes[0].Value;
                string name = node["Name"].InnerText;
                string additionalParameter = node["AdditionalParmeter"].InnerText;

                switch (type)
                {
                    case "Crocodile":
                        listOfParsedAnimals.Add(new Crocodile(name,int.Parse(additionalParameter)));
                        break;
                    case "Frog":
                        listOfParsedAnimals.Add(new Frog(name, int.Parse(additionalParameter)));
                        break;
                    case "Lizard":
                        listOfParsedAnimals.Add(new Lizard(name, int.Parse(additionalParameter)));
                        break;
                    case "Horse":
                        listOfParsedAnimals.Add(new Horse(name, int.Parse(additionalParameter)));
                        break;
                    case "Cat":
                        listOfParsedAnimals.Add(new Cat(name, int.Parse(additionalParameter)));
                        break;
                    case "Tiger":
                        listOfParsedAnimals.Add(new Tiger(name, int.Parse(additionalParameter)));
                        break;
                    case "GoldenFish":
                        listOfParsedAnimals.Add(new GoldenFish(name, int.Parse(additionalParameter)));
                        break;
                    case "Shark":
                        listOfParsedAnimals.Add(new Shark(name, int.Parse(additionalParameter)));
                        break;
                }
            }

            return listOfParsedAnimals;
        }
    }
}
