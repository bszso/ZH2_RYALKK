using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZH2_API.Controllers
{
    [Route("api/tao")]
    [ApiController]
    public class TaoController : ControllerBase
    {
        // GET: api/<TaoController>
        [HttpGet]
        public IActionResult Get()
        {
            TaoModels.TaoConext context = new TaoModels.TaoConext();
            return Ok(context.Rooms.ToList());
        }

        // GET api/<TaoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TaoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TaoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TaoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
