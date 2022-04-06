using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharactersRepository _charactersRepository;

        public CharacterController(ICharactersRepository repository)
        {
            _charactersRepository = repository;
        }

        // GET: api/<CharactersController>
        [HttpGet]
        public async Task<IEnumerable<Character>> GetCharactersAsync()
        {
            var characters = await _charactersRepository.GetCharactersAsync();
            return characters;
        }

        // GET api/<CharactersController>/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacterAsync(Guid id)
        {
            var character = await _charactersRepository.GetCharacterAsync(id);
            if(character is null)
            {
                return NotFound();
            }
            return character;
        }

        // POST api/<CharacterController>
        [HttpPost]
        public async Task AddCharacterAsync([FromBody] Character character)
        {
            await _charactersRepository.AddCharacterAsync(character);
        }

        // PUT api/<CharactersController>/{id}
        [HttpPut("{id}")]
        public async Task UpdateCharacterAsync(Guid id, [FromBody] Character character)
        {
            await _charactersRepository.UpdateCharacterAsync(id, character);
        }

        // DELETE api/<CharactersController>/{id}
        [HttpDelete("{id}")]
        public async Task DeleteCharacterAsync(Guid id)
        {
            await _charactersRepository.DeleteCharacterAsync(id);
        }
    }
}
