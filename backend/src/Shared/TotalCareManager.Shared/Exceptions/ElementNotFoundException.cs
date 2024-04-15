namespace TotalCareManager.Shared.Exceptions
{
    public sealed class ElementNotFoundException : AppException
    {
        public ElementNotFoundException(string searchArea) : base($"Nie znaleziono elementu {searchArea}")
        {
        }
    }
}