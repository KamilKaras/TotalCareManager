using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TotalCareManager.Shared.Domain;

namespace TotalCareManager.Shared.DbAccess
{
    public class EntityIdConverter<EntityIdValue> : ValueConverter<EntityIdValue, Guid>
        where EntityIdValue : EntityId
    {
        public EntityIdConverter(ConverterMappingHints mappingHints = null)
            : base(id => id.Value, value => Create(value), mappingHints)
        {
        }

        private static EntityIdValue Create(Guid id) => Activator.CreateInstance(typeof(EntityIdValue), id) as EntityIdValue;
    }
}