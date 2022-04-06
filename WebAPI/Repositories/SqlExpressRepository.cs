using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class SqlExpressRepository : IItemsRepository, ICharactersRepository
    {
        private DataContext _dataContext;
        public SqlExpressRepository(DataContext context)
        {
            _dataContext = context;
        }

        public Task AddCharacterAsync([FromBody] Character character)
        {
            throw new NotImplementedException();
        }

        public async Task AddItemAsync(Item item)
        {
            await _dataContext.Items.AddAsync(item);
            await _dataContext.SaveChangesAsync();
        }

        public Task AddToCharacterInventoryAsync(Guid characterId, Guid itemId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCharacterAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFromCharacterInventoryAsync(Guid characterId, Guid itemId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteItemAsync(Guid id)
        {
            var dbItem = await GetItemAsync(id);
            await Task.Run(()=>_dataContext.Remove(dbItem));
            await _dataContext.SaveChangesAsync();
        }

        public Task<ActionResult<Character>> GetCharacterAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Item>> GetCharacterInventoryAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Character>> GetCharactersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Item> GetItemAsync(Guid id)
        {
            return await _dataContext.FindAsync<Item>(id);
        }

        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await Task.Run(() => _dataContext.Items);
        }

        public Task UpdateCharacterAsync(Guid id, [FromBody] Character character)
        {
            throw new NotImplementedException();
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
