using CS_ForBeginners_API_DAL.Entities;
using System.Collections.Generic;

namespace CS_ForBeginners_API_DAL.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<PersonEntity> GetAll();

        PersonEntity GetById(int id);

        void AddPerson(PersonEntity person);

        void UpdatePerson(PersonEntity person);

        void DeletePerson(int id);
    }
}
