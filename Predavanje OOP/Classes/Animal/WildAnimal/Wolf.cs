
namespace Predavanje_OOP.Classes.Animal.WildAnimal
{
    public class Wolf : WildAnimal
    {
        public Wolf(DateTime dateOfBirth) : base(dateOfBirth) { }

        public override void Voice()
        {
            Console.WriteLine("AuuuuuuAuuuu");
        }

        public override string ToString()
        {
            return $"Id: {Id}\n"
                + $"Helath: {Health}";
        }

        public override bool Damage(Owner owner)
        {
            if(!owner.CheckForRequiredHuntingLicenseCategory(Enums.HuntingLicenseCategory.W))
                return false;
            
            return base.Damage(owner);
        }
    }
}
