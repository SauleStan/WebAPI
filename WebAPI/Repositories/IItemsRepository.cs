using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface IItemsRepository
    {
        public Task<IEnumerable<Item>> GetItemsAsync();
        public Item GetItem(Guid id);
        public void DeleteItem(Guid id);
        public void UpdateItem(Guid id, Item item);
        public void AddItem(Item item);
    }
}
