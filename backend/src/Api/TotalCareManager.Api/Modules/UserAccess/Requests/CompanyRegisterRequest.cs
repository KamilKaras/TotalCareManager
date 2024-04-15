namespace TotalCareManager.Api.Modules.UserAccess.Requests
{
    public sealed class CompanyRegisterRequest
    {
        public string CompanyName { get; init; }
        public int CompanyTypeId { get; init; }
        public string NipNumber { get; init; }
        public string UserName { get; init; }
        public string UserEmail { get; init; }
        public string UserPhone { get; init; }
    }
}