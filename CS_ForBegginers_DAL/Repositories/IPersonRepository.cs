using CS_ForBeginners_DAL.Entities;
using System.Collections.Generic;

namespace CS_ForBeginners_DAL.Repositories
{
    public interface IPersonRepository
    {
        public IEnumerable<PersonEntity> GetAll();

        public PersonEntity GetById(int id);

        public void AddPerson(PersonEntity person);

        public void UpdatePerson(PersonEntity person);

        public void DeletePerson(int id);
    }
}
