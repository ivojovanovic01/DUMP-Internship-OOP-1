using System;

namespace Predavanje_OOP.Classes.Animal.WildAnimal
{
    public class WildAnimal : Animal
    {
        public int Health { get; protected set; }
        public WildAnimal(DateTime dateOfBirth) : base(dateOfBirth) 
        {
            Health = 100;
        }

        public virtual bool Damage(Owner owner)
        {
            if (Health == 0)
                return false;

            Health = (Health < 20) ? 0 : Health - 20;
            return true;
        }
    }
}
