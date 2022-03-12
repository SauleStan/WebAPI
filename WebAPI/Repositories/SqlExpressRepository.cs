using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class SqlExpressRepository : IItemsRepository
    {
        private DataContext _dataContext;
        public SqlExpressRepository(DataContext context)
        {
            _dataContext = context;
        }
        public void AddItem(Item item)
        {
            _dataContext.Items.Add(item);
            _dataContext.SaveChanges();
        }

        public void DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(Guid id)
        {
            return _dataContext.Find<Item>(id);
        }

        public IEnumerable<Item> GetItems()
        {
            return _dataContext.Items;
        }

        public void UpdateItem(Guid id, Item item)
        {
            var dbItem = _dataContext.Find<Item>(id);
            dbItem.Name = item.Name;
            dbItem.Price = item.Price;
            _dataContext.Update(dbItem);
            _dataContext.SaveChanges();
        }
    }
}
