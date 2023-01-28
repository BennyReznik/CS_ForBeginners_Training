using System.Collections.Generic;
using AutoMapper;
using CS_ForBeginners_API_BL.Models;
using CS_ForBeginners_API_DAL.Entities;
using CS_ForBeginners_API_DAL.Repositories;

namespace CS_ForBeginners_API_BL.Managers
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonManager(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public void AddPerson(PersonModel person)
        {
            _personRepository.AddPerson(_mapper.Map<PersonEntity>(person));
        }

        public void DeletePerson(int id)
        {
            _personRepository.DeletePerson(id);
        }

        public IEnumerable<PersonModel> GetAll()
        {
            return _mapper.Map<IEnumerable<PersonModel>>(_personRepository.GetAll());
        }

        public PersonModel GetById(int id)
        {
            return _mapper.Map<PersonModel>(_personRepository.GetById(id));
        }

        public void UpdatePerson(PersonModel person)
        {
            _personRepository.UpdatePerson(_mapper.Map<PersonEntity>(person));
        }
    }
}
