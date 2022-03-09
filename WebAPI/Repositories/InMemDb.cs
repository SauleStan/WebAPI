using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class InMemDb : IItemsRepository
    {
        private List<Item> ItemsList = new (){
            new Item("Nickle", 1),
            new Item("Food", 8),
            new Item("Pocket Knife", 2)
        };

        public void AddItem(Item item)
        {
            ItemsList.Add(item);
        }

        public void DeleteItem(Guid id)
        {
            ItemsList.RemoveAll(item => item.Id == id);
        }

        public Item GetItem(Guid id)
        {
            return ItemsList.SingleOrDefault(item => item.Id == id);
        }

        public IEnumerable<Item> GetItems()
        {
            return ItemsList;
        }

        public void UpdateItem(Guid id, Item item)
        {
            throw new NotImplementedException();
        }
    }
}
