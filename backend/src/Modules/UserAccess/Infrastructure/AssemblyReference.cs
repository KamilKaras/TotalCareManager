using System.Reflection;

namespace UserAccess.Infrastructure
{
    public static class AssemblyReference
    {
        public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
    }
}