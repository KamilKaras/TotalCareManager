namespace TotalCareManager.Shared.Exceptions
{
    public abstract class AppException : Exception
    {
        protected AppException(string message) : base(message)
        {
        }
    }
}