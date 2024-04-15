using TotalCareManager.Shared.Domain;

namespace UserAccess.Domain.Companies.Enumerations
{
    public sealed class CompanyType : Enumeration<CompanyType>
    {
        public static readonly CompanyType FightClub = new(1, "Klub sportów walki");
        public static readonly CompanyType SportClub = new(2, "Klub sportowy");
        public static readonly CompanyType Gym = new(3, "Siłownia");
        public static readonly CompanyType FitnessClub = new(3, "Klub fitnes");
        public static readonly CompanyType Kindergarden = new(4, "Przedszkole");

        private CompanyType(int id, string value) : base(id, value)
        {
        }
    }
}