using AutoMapper;
using CS_ForBeginners_BL.Models;
using CS_ForBeginners_DAL.Entities;
using CS_ForBeginners_DAL.Repositories;
using System.Collections.Generic;

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

        public void AddPerson(PersonModel person)
        {
            var mappedPerson = _mapper.Map<PersonEntity>(person);
            _personRepository.AddPerson(mappedPerson);
        }

        public void DeletePerson(int id)
        {
            _personRepository.DeletePerson(id);
        }

        public IEnumerable<PersonModel> GetAll()
        {
            var peopleEntities = _personRepository.GetAll();
            var mappedPeople = _mapper.Map<IEnumerable<PersonModel>>(peopleEntities);
            return mappedPeople;
        }

        public PersonModel GetById(int id)
        {
            var personEntity = _personRepository.GetById(id);
            var mappedPerson = _mapper.Map<PersonModel>(personEntity);
            return mappedPerson;
        }

        public void UpdatePerson(PersonModel person)
        {
            var mappedPerson = _mapper.Map<PersonEntity>(person);
            _personRepository.UpdatePerson(mappedPerson);
        }
    }
}
