using System.Collections.Generic;
using CS_ForBeginners_API_BL.Models;

namespace CS_ForBeginners_API_BL.Managers
{
    public interface IPersonManager
    {
        void AddPerson(PersonModel person);

        void DeletePerson(int id);

        IEnumerable<PersonModel> GetAll();

        PersonModel GetById(int id);

        void UpdatePerson(PersonModel person);
    }
}
