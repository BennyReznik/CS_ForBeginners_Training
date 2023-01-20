using CS_ForBeginners_BL.Models;
using System.Collections.Generic;

namespace CS_ForBeginners_BL.Managers
{
    public interface IPersonManager
    {
        public void AddPerson(PersonModel person);

        public void DeletePerson(int id);

        public IEnumerable<PersonModel> GetAll();

        public PersonModel GetById(int id);

        public void UpdatePerson(PersonModel person);
    }
}
