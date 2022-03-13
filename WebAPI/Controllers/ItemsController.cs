using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Models.DTO;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemsController(IItemsRepository repository)
        {
            _itemsRepository = repository;
        }

        // GET: api/<ItemsController>
        [HttpGet]
        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            var items = await _itemsRepository.GetItemsAsync();
            return items;
        }

        // GET api/<ItemsController>/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItemAsync(Guid id)
        {
            var item = await _itemsRepository.GetItemAsync(id);
            if (item is null)
            {
                return NotFound();
            }
            return item;
        }

        // POST api/<ItemsController>
        [HttpPost]
        public async Task AddItemAsync([FromBody] ItemNoIdDto newItem)
        {
            Item item = new(newItem.Name, newItem.Price);
            await _itemsRepository.AddItemAsync(item);
        }

        // PUT api/<ItemsController>/{id}
        [HttpPut("{id}")]
        public async Task UpdateItemAsync(Guid id, [FromBody] ItemNoIdDto item)
        {
            Item newItem = new(item.Name, item.Price);
            await _itemsRepository.UpdateItemAsync(id, newItem);
        }

        // DELETE api/<ItemsController>/{id}
        [HttpDelete("{id}")]
        public async Task DeleteItemAsync(Guid id)
        {
            await _itemsRepository.DeleteItemAsync(id);
        }
    }
}
