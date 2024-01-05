namespace TotalCareManager.Api.Modules.UserAccess.Requests
{
    public sealed class GroupRegisterRequest
    {
        public string GroupName { get; init; }
        public string NipNumber { get; init; }
        public string CompanyName { get; init; }
        public string Name { get; init; }
        public string Email { get; init; }
        public string Phone { get; init; }
    }
}