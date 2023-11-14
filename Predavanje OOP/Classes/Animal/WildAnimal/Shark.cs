
namespace Predavanje_OOP.Classes.Animal.WildAnimal
{
    public class Shark : WildAnimal
    {
        public Shark(DateTime dateOfBirth) : base(dateOfBirth) { }

        public override void Voice()
        {
            Console.WriteLine("ffffff");
        }
    }
}
