using CS_ForBeginners_BL.Models;
using System.Collections.Generic;

namespace CS_ForBeginners_BL.Managers
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
