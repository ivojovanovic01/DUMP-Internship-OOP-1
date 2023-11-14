using Predavanje_OOP.Classes.Animal.DomesticAnimal;

namespace Predavanje_OOP.Classes
{
    public static class DogStore
    {
        public static List<Dog> Dogs { get; } = new List<Dog>();

        public static void Add (Dog newDog)
        {
            Dogs.Add(newDog);
        }

        public static void PrintDogs()
        {
            foreach (var dog in Dogs)
                Console.WriteLine(dog.ToString());
        }
        public static bool Remove(Guid dogId)
        {
            foreach (var dog in Dogs)
            {
                if (dog.Id == dogId)
                {
                    Dogs.Remove(dog);
                    return true;
                }
            }

            return false;
        }
    }
}
