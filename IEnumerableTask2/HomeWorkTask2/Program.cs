using System;
using System.Collections.Generic;

namespace HomeWorkTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Entity> entities = new List<Entity>
            {
                new Entity { Id = 1, ParentId = 0, Name = "Root entity"},
                new Entity { Id = 2, ParentId = 1, Name = "Child of 1 entity"},
                new Entity { Id = 3, ParentId = 1, Name = "Child of 1 entity"},
                new Entity { Id = 4, ParentId = 2, Name = "Child of 2 entity"},
                new Entity { Id = 5, ParentId = 4, Name = "Child of 4 entity"},
            };

            var dictionary = ReturnDictionaryAndList(entities);

            static Dictionary<int, List<Entity>> ReturnDictionaryAndList(List<Entity> entities)
            {
                var dictionary = new Dictionary<int, List<Entity>>();

                foreach (var entity in entities)
                {
                    dictionary.TryAdd(entity.ParentId, new List<Entity>());
                    dictionary[entity.ParentId].Add(entity);
                }

                return dictionary;
            }
        }
    }
}