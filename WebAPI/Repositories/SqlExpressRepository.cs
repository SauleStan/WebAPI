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

        public async Task AddCharacterAsync([FromBody] Character character)
        {
            await _dataContext.Characters.AddAsync(character);
            await _dataContext.SaveChangesAsync();
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

        public async Task DeleteCharacterAsync(Guid id)
        {
            var dbCharacter = await GetCharacterAsync(id);
            var dbItems = await Task.Run(() => _dataContext.Items.Where(x => x.CharacterId == id));
            foreach (var dbItem in dbItems)
            {
                dbItem.CharacterId = null;
            }
            await Task.Run(() => _dataContext.Characters.Remove(dbCharacter));
            await _dataContext.SaveChangesAsync();
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

        public async Task<Character> GetCharacterAsync(Guid id)
        {
            return await _dataContext.Characters.FindAsync(id);
        }

        public Task<IEnumerable<Item>> GetCharacterInventoryAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Character>> GetCharactersAsync()
        {
            return await Task.Run(() => _dataContext.Characters);
        }

        public async Task<Item> GetItemAsync(Guid id)
        {
            return await _dataContext.FindAsync<Item>(id);
        }

        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await Task.Run(() => _dataContext.Items);
        }

        public async Task UpdateCharacterAsync(Guid id, Character character)
        {
            Character dbCharacter = await GetCharacterAsync(id);
            dbCharacter.Name = character.Name;
            dbCharacter.CharacterClass = character.CharacterClass;
            dbCharacter.Level = character.Level;
            dbCharacter.Health = character.Health;
            dbCharacter.Experience = character.Experience;
            if(character.Inventory != null)
            {
                dbCharacter.Inventory = character.Inventory;
            }

            await Task.Run(() => _dataContext.Update(dbCharacter));
            await _dataContext.SaveChangesAsync();
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
