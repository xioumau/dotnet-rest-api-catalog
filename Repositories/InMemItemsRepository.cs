using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;

namespace Catalog.Repositories
{
    
    public class InMemItemsRepository : IItemsRepository
    {
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/new-operator#:~:text=Beginning%20with%20C%23%209.0%2C%20constructor%20invocation%20expressions%20are%20target%2Dtyped.%20That%20is%2C%20if%20a%20target%20type%20of%20an%20expression%20is%20known%2C%20you%20can%20omit%20a%20type%20name%2C%20as%20the%20following%20example%20shows%3A
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreateDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Sword", Price = 20, CreateDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Shield", Price = 17, CreateDate = DateTimeOffset.UtcNow },
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

    }
}