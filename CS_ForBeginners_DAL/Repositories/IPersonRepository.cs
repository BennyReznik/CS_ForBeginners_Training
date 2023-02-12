using CS_ForBeginners_DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CS_ForBeginners_DAL.Repositories
{
    public interface IPersonRepository
    {
        Task<IEnumerable<PersonEntity>> GetAll();

        Task<PersonEntity> GetById(int id);

        Task AddPerson(PersonEntity person);

        Task UpdatePerson(PersonEntity person);

        Task DeletePerson(int id);
    }
}
