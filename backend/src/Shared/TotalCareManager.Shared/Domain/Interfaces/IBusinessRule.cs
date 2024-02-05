namespace TotalCareManager.Shared.Domain.Interfaces
{
    public interface IBusinessRule
    {
        string Message { get; }

        bool IsBroken();
    }
}