namespace TotalCareManager.Shared.Domain
{
    public interface IBusinessRule
    {
        string Message { get; }

        bool IsBroken();
    }
}