
namespace Predavanje_OOP.Classes.Animal
{
    public class Animal
    {
        public Guid Id { get; }
        public DateTime DateOfBirth { get; }

        protected int _hungerLevel;

        public Animal(DateTime dateOfBirth)
        {
            Id = Guid.NewGuid();
            DateOfBirth = dateOfBirth;
            _hungerLevel = 90;
        }

        public bool CheckIsHungry()
        {
            return _hungerLevel >= 50;
        }

        public bool Feed(int amountOfFood)
        {
            if (!CheckIsHungry() || amountOfFood > _hungerLevel) return false;

            _hungerLevel -= amountOfFood;

            return true;
        }

        public virtual void Voice()
        {
            Console.WriteLine("Glasanje životinja");
        }

        public override string ToString()
        {
            return $"Id: {Id}\n"
                + $"Datum rodenja {DateOfBirth}\n";
        }
    }
}
