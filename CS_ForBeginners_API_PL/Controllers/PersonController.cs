using AutoMapper;
using CS_ForBeginners_API_BL.Managers;
using CS_ForBeginners_API_BL.Models;
using CS_ForBeginners_API_PL.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace CS_ForBeginners_API_PL.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonManager _personManager;
        private readonly IMapper _mapper;

        public PersonController(IPersonManager personManager, IMapper mapper)
        {
            _personManager = personManager;
            _mapper = mapper;
        }

        // GET api/<PersonController>
        [HttpGet]
        public IEnumerable<PersonDto> GetAllPeople()
        {
            return _mapper.Map<IEnumerable<PersonDto>>(_personManager.GetAll());
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public PersonDto Get(int id)
        {
            return _mapper.Map<PersonDto>(_personManager.GetById(id));
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] PersonDto person)
        {
            _personManager.AddPerson(_mapper.Map<PersonModel>(person));
        }

        // PUT api/<PersonController>
        [HttpPut]
        public void Put([FromBody] PersonDto person)
        {
            _personManager.UpdatePerson(_mapper.Map<PersonModel>(person));
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _personManager.DeletePerson(id);
        }
    }
}
