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
            _dataContext.Remove(GetItemAsync(id));
            _dataContext.SaveChanges();
        }

        public async Task<Item> GetItemAsync(Guid id)
        {
            return await _dataContext.FindAsync<Item>(id);
        }

        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await Task.Run(() => _dataContext.Items);
        }

        public async Task UpdateItemAsync(Guid id, Item item)
        {
            var dbItem = await GetItemAsync(id);
            dbItem.Name = item.Name;
            dbItem.Price = item.Price;
            await Task.Run(()=>_dataContext.Update(dbItem));
            await _dataContext.SaveChangesAsync();
        }
    }
}
