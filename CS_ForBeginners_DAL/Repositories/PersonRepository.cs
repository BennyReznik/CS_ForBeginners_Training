using CS_ForBeginners_DAL.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CS_ForBeginners_DAL.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private const string FileName = "people.json";
        private readonly List<PersonEntity> _allPeople;

        public PersonRepository()
        {
            if (File.Exists(FileName))
            {
                var allPeopleFromFile = File.ReadAllText(FileName);
                try
                {
                    _allPeople = JsonConvert.DeserializeObject<List<PersonEntity>>(allPeopleFromFile);
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("People failed to load from file");
                    Console.ForegroundColor = ConsoleColor.White;
                    _allPeople = new List<PersonEntity>();
                }
            }
            else
            {
                _allPeople = new List<PersonEntity>();
            }
        }

        public async Task AddPerson(PersonEntity person)
        {
            _allPeople.Add(person);
            await PersistToFile();
        }

        public async Task DeletePerson(int id)
        {
            var index = _allPeople.FindIndex(p => p.Id == id);
            _allPeople.RemoveAt(index);
            await PersistToFile();
        }

        public async Task<IEnumerable<PersonEntity>> GetAll()
        {
            return await Task.FromResult(_allPeople);
        }

        public async Task<PersonEntity> GetById(int id)
        {
            return await Task.FromResult(_allPeople.FirstOrDefault(p => p.Id == id));
        }

        public async Task UpdatePerson(PersonEntity person)
        {
            await DeletePerson(person.Id);
            await AddPerson(person);
        }

        private async Task PersistToFile()
        {
            var json = JsonConvert.SerializeObject(_allPeople);
            await File.WriteAllTextAsync("people.json", json);
        }
    }
}
