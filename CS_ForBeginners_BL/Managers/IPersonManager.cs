using CS_ForBeginners_BL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CS_ForBeginners_BL.Managers
{
    public interface IPersonManager
    {
        Task AddPerson(PersonModel person);

        Task DeletePerson(int id);

        Task<IEnumerable<PersonModel>> GetAll();

        Task<PersonModel> GetById(int id);

        Task UpdatePerson(PersonModel person);
    }
}
