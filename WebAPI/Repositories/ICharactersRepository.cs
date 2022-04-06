using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface ICharactersRepository
    {
        Task AddCharacterAsync([FromBody] Character character);
        Task DeleteCharacterAsync(Guid id);
        Task<ActionResult<Character>> GetCharacterAsync(Guid id);
        Task<IEnumerable<Character>> GetCharactersAsync();
        Task UpdateCharacterAsync(Guid id, [FromBody] Character character);
        Task<IEnumerable<Item>> GetCharacterInventoryAsync(Guid id);
        Task AddToCharacterInventoryAsync(Guid characterId, Guid itemId);
        Task DeleteFromCharacterInventoryAsync(Guid characterId, Guid itemId);
    }
}