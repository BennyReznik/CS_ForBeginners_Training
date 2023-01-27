using CS_ForBeginners_API_DAL.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace CS_ForBeginners_API_DAL.Repositories
{
    internal class PersonRepository : IPersonRepository
    {
        private const string FileName = "peopleApi.json";
        private readonly List<PersonEntity> _allPeople;

        internal PersonRepository()
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
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public PersonEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(PersonEntity person)
        {
            throw new NotImplementedException();
        }
    }
}
