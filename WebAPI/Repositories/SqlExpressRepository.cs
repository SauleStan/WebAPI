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
            throw new NotImplementedException();
        }

        public void DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            return _dataContext.Items;
        }

        public void UpdateItem(Guid id, Item item)
        {
            throw new NotImplementedException();
        }
    }
}
