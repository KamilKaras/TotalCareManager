using System.Reflection;

namespace TotalCareManager.Shared.Domain
{
    public abstract class Enumeration<T> : IComparable<T> where T : Enumeration<T>
    {
        private static readonly IReadOnlyList<T> _values = CreateEnumerationList();

        protected Enumeration(int id, string value)
        {
            Id = id;
            Value = value;
        }

        public int Id { get; }

        public string Value { get; }

        public static IReadOnlyList<T> GetAll() => _values;

        public static bool Exists(int id) => GetAll()
           .Any(x => x.Id == id);

        public static T? FromId(int id)
        {
            var all = GetAll();
            return all.FirstOrDefault(item => item.Id == id) ?? null;
        }

        public int CompareTo(T? other) => Id.CompareTo(other?.Id ?? -1);

        public override bool Equals(object? obj) => obj is Enumeration<T> other && Id.Equals(other.Id);

        public override int GetHashCode() => Id.GetHashCode();

        private static IReadOnlyList<T> CreateEnumerationList()
        {
            return typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
               .Where(f => f.FieldType == typeof(T))
               .Select(f => f.GetValue(null))
               .Cast<T>()
               .ToList();
        }
    }
}