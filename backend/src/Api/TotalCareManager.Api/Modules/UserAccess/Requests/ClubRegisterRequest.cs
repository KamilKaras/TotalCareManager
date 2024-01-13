namespace TotalCareManager.Api.Modules.UserAccess.Requests
{
    public sealed class ClubRegisterRequest
    {
        public string ClubName { get; init; }
        public int ClubTypeId { get; init; }
        public string NipNumber { get; init; }
        public string CompanyName { get; init; }
        public string UserName { get; init; }
        public string UserEmail { get; init; }
        public string UserPhone { get; init; }
    }
}