
namespace Predavanje_OOP.Classes.Animal.WildAnimal
{
    public class Eagle : WildAnimal
    {
        public Eagle(DateTime dateOfBirth) : base(dateOfBirth) { }

        public override void Voice()
        {
            Console.WriteLine("hhhhhhh");
        }
    }
}
