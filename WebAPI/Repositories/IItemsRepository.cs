using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface IItemsRepository
    {
        public IEnumerable<Item> GetItems();
        public Item GetItem(Guid id);
        public void DeleteItem(Guid id);
        public void UpdateItem(Guid id, Item item);
    }
}
