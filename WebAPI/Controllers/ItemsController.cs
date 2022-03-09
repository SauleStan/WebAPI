using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        // GET: api/<ItemsController>
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            throw new NotImplementedException();
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
