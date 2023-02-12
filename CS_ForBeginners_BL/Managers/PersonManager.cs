using AutoMapper;
using CS_ForBeginners_BL.Models;
using CS_ForBeginners_DAL.Entities;
using CS_ForBeginners_DAL.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CS_ForBeginners_BL.Managers
{
    public class PersonManager : IPersonManager
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;

        public PersonManager(IMapper mapper, IPersonRepository personRepository)
        {
            _mapper = mapper;
            _personRepository = personRepository;
        }

        public async Task AddPerson(PersonModel person)
        {
            var mappedPerson = _mapper.Map<PersonEntity>(person);
            await _personRepository.AddPerson(mappedPerson);
        }

        public async Task DeletePerson(int id)
        {
            await _personRepository.DeletePerson(id);
        }

        public async Task<IEnumerable<PersonModel>> GetAll()
        {
            var peopleEntities = await _personRepository.GetAll();
            var mappedPeople = _mapper.Map<IEnumerable<PersonModel>>(peopleEntities);
            return mappedPeople;
        }

        public async Task<PersonModel> GetById(int id)
        {
            var personEntity = await _personRepository.GetById(id);
            var mappedPerson = _mapper.Map<PersonModel>(personEntity);
            return mappedPerson;
        }

        public async Task UpdatePerson(PersonModel person)
        {
            var mappedPerson = _mapper.Map<PersonEntity>(person);
            await _personRepository.UpdatePerson(mappedPerson);
        }
    }
}
