using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul08_1302204068
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public static List <string> bintang1 = new List<string>
        {
            "Tim Robbins", "Morgan Freeman", "Bob Guntom", "William Sandler"
        }

        public static List<string> bintang1 = new List<string>
        {
            "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
