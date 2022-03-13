using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface IItemsRepository
    {
        public Task<IEnumerable<Item>> GetItemsAsync();
        public Task<Item> GetItemAsync(Guid id);
        public void DeleteItem(Guid id);
        public Task UpdateItemAsync(Guid id, Item item);
        public Task AddItemAsync(Item item);
    }
}
