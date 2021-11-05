using System;
using System.Collections.Generic;
using DOTNET_API.Entities;

namespace DOTNET_API.Repositories
{
    public interface IItemsRepository 
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Guid id);
    
    }
}