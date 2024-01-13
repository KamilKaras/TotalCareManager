using TotalCareManager.Shared.Domain;

namespace UserAccess.Domain.Clubs.Enumerations
{
    public sealed class ClubType : Enumeration<ClubType>
    {
        public static readonly ClubType FightClub = new(1, "Klub sportów walki");
        public static readonly ClubType SportClub = new(2, "Klub sportowy");
        public static readonly ClubType Gym = new(3, "Siłownia");
        public static readonly ClubType FitnessClub = new(3, "Klub fitnes");
        public static readonly ClubType Kindergarden = new(4, "Przedszkole");

        private ClubType(int id, string value) : base(id, value)
        {
        }
    }
}