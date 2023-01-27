using CS_ForBeginners_API_PL.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CS_ForBeginners_API_PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        // GET api/<PersonController>
        [HttpGet]
        public IEnumerable<PersonDto> GetAllPeople()
        {
            return new List<PersonDto>();
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] PersonDto person)
        {
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PersonDto person)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
