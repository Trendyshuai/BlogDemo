using BlogDemo.Core.Interfaces;
using System.Collections.Generic;

namespace BlogDemo.Infrastructure.Services
{
    public abstract class PropertyMapping<TSource, TDestination> : IPropertyMapping
        where TDestination : IEntity
    {
        // Resource上可能是Name, 映射到Entity上可能是FirstName和LastName。所以是List
        public Dictionary<string, List<MappedProperty>> MappingDictionary { get; }

        protected PropertyMapping(Dictionary<string, List<MappedProperty>> mappingDictionary)
        {
            MappingDictionary = mappingDictionary;
            MappingDictionary[nameof(IEntity.Id)] = new List<MappedProperty>
            {
                new MappedProperty{Name = nameof(IEntity.Id), Revert = false}
            };
        }
    }
}
