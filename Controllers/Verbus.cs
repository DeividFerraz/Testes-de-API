using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Verbus : ControllerBase
    {
        // GET: api/<Verbus>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Verbus>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Verbus>
        [HttpPost]
        public void Post([FromBody] VerboVM value)
        {
            Console.WriteLine($"inseriu o Id {value.Id} e nome {value.Name}");
        }

        // PUT api/<Verbus>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] VerboVM value)
        {
            Console.WriteLine($"Atualizou {value.Name}");
        }

        // DELETE api/<Verbus>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine($"deletou {id}");
        }
    }
    public class VerboVM
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
