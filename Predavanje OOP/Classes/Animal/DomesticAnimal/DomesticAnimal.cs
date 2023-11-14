
namespace Predavanje_OOP.Classes.Animal.DomesticAnimal
{
    public class DomesticAnimal : Animal
    {
        public string Name { get; set; }
        public DateTime DateOfLastVaccination { get; private set; }
        public Owner Owner { get; set; }
        public DomesticAnimal(DateTime dateOfBirth) : base(dateOfBirth) { }

        public bool CheckIsVaccinated()
        {
            return DateOfLastVaccination > DateTime.Now.AddYears(-1);
        }

        public bool Vaccinate()
        {
            if (CheckIsVaccinated()) return false;

            DateOfLastVaccination = DateTime.Now;
            return true;
        }

        public override string ToString()
        {
            return base.ToString()
                + $"Ime: {Name}\n"
                + $"Vlasnik: {Owner}\n"
                + $"Datum cijepiva: {DateOfLastVaccination}\n";
        }
    }
}
