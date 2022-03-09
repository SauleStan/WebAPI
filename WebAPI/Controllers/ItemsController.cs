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
        public IEnumerable<Item> GetItems()
        {
            var items = _itemsRepository.GetItems();
            return items;
        }

        // GET api/<ItemsController>/{id}
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = _itemsRepository.GetItem(id);
            if (item is null)
            {
                return NotFound();
            }
            return item;
        }

        // POST api/<ItemsController>
        [HttpPost]
        public void AddItem([FromBody] ItemNoIdDto newItem)
        {
            Item item = new(newItem.Name, newItem.Price);
            _itemsRepository.AddItem(item);
        }

        // PUT api/<ItemsController>/{id}
        [HttpPut("{id}")]
        public void UpdateItem(Guid id, [FromBody] Item item)
        {
            _itemsRepository.UpdateItem(id, item);
        }

        // DELETE api/<ItemsController>/{id}
        [HttpDelete("{id}")]
        public void DeleteItem(Guid id)
        {
            _itemsRepository.DeleteItem(id);
        }
    }
}
