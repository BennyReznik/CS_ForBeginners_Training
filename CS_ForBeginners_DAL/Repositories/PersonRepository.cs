using CS_ForBeginners_DAL.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

        public void AddPerson(PersonEntity person)
        {
            _allPeople.Add(person);
            PersistToFile();
        }

        public void DeletePerson(int id)
        {
            var index = _allPeople.FindIndex(p => p.Id == id);
            _allPeople.RemoveAt(index);
            PersistToFile();
        }

        public IEnumerable<PersonEntity> GetAll()
        {
            return _allPeople;
        }

        public PersonEntity GetById(int id)
        {
            return _allPeople.FirstOrDefault(p => p.Id == id);
        }

        public void UpdatePerson(PersonEntity person)
        {
            DeletePerson(person.Id);
            AddPerson(person);
        }

        private void PersistToFile()
        {
            var json = JsonConvert.SerializeObject(_allPeople);
            File.WriteAllText("people.json", json);
        }
    }
}
