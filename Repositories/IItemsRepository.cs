using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DOTNET_API.Entities;

namespace DOTNET_API.Repositories
{
    public interface IItemsRepository 
    {
        Task<Item> GetItemAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task CreateItemAsync(Item item);
        Task UpdateItemAsync(Item item);
        Task DeleteItemAsync(Guid id);
    
    }
}