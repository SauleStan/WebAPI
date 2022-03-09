using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository _itemsRepository = new InMemDb();
        // GET: api/<ItemsController>
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = _itemsRepository.GetItems();
            return items;
        }

        // GET api/<ItemsController>/{id}
        [HttpGet("{id}")]
        public Item GetItem(int id)
        {
            throw new NotImplementedException();
        }

        // POST api/<ItemsController>
        [HttpPost]
        public void AddItem([FromBody] Item item)
        {
            throw new NotImplementedException();
        }

        // PUT api/<ItemsController>/{id}
        [HttpPut("{id}")]
        public void PutItem(int id, [FromBody] Item item)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<ItemsController>/{id}
        [HttpDelete("{id}")]
        public void DeleteItem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
