using Predavanje_OOP.Enums;

namespace Predavanje_OOP.Classes
{
    public class Owner
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<HuntingLicenseCategory> HuntingLicenseCategories { get; set; }

        public bool CheckForRequiredHuntingLicenseCategory(HuntingLicenseCategory huntingLicenseCategory)
        {
            return HuntingLicenseCategories.Contains(huntingLicenseCategory);
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} - {DateOfBirth}";
        }
    }
}
