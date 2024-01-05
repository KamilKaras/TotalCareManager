namespace TotalCareManager.Shared.Exceptions
{
    public class InvalidEntityIdValueException : AppException
    {
        public InvalidEntityIdValueException() : base("Not valid value for Entity Id")
        {
        }
    }
}