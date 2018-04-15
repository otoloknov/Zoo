using System.Security.Permissions;
using Animals.Interfaces;

namespace Animals
{
    public static class AnimalClassifier
    {
        public static bool IsAnimalPredator(Animal animalForClassification)
        {
            return animalForClassification is IPredator;
        }

        public static bool IsAnimalaCat(Animal animalForClassification)
        {
            return animalForClassification is ICat;
        }
        public static bool IsAnimalaWaterLover(Animal animalForClassification)
        {
            return animalForClassification is IWaterLover;
        }
    }
}
