using Predavanje_OOP.Enums;

namespace Predavanje_OOP.Classes.Animal.DomesticAnimal
{
    public class Dog : DomesticAnimal
    {
        public DogBreed Breed { get; set; }
        public static int DogsCounter { get; set; } = 0;

        public Dog(DateTime dateOfBirth) : base(dateOfBirth)
        {
            DogsCounter++;
            DogStore.Add(this);
        }
        public static void IncreaseDogsCounter(int numberOfDogs)
        {
            DogsCounter += numberOfDogs;
        }

        public override void Voice()
        {
            base.Voice();
            Console.WriteLine("Vau-vau");
        }

        public override string ToString()
        {
            return base.ToString()
                + $"Vrsta: {Breed}";
        }
    }
}
