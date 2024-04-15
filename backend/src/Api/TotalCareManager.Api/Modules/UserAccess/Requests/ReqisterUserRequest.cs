namespace TotalCareManager.Api.Modules.UserAccess.Requests
{
    public sealed class RegisterUserRequest
    {
        public string Name { get; init; }
        public string Email { get; init; }
        public string Phone { get; init; }
        public string CompanyId { get; init; }
    }
}