using CS_ForBeginners_DAL.Entities;
using CS_ForBeginners_DAL.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CS_ForBeginners_DAL.Repositories
{
    public class PersonService : IPersonRepository
    {
        private const string MediaType = "application/json";
        private readonly IHttpClientFactory _clientFactory;

        public PersonService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IEnumerable<PersonEntity>> GetAll()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                "api/person");

            var client = _clientFactory.CreateClient(DalConstants.PersonApi);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<PersonEntity>>(content);
        }

        public async Task<PersonEntity> GetById(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                $"api/person/{id}");

            var client = _clientFactory.CreateClient(DalConstants.PersonApi);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PersonEntity>(content);
        }

        public async Task AddPerson(PersonEntity person)
        {
            var content = new StringContent(JsonConvert.SerializeObject(person), Encoding.UTF8, MediaType);

            var client = _clientFactory.CreateClient(DalConstants.PersonApi);
            var response = await client.PostAsync("api/person", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdatePerson(PersonEntity person)
        {
            var content = new StringContent(JsonConvert.SerializeObject(person), Encoding.UTF8, MediaType);

            var client = _clientFactory.CreateClient(DalConstants.PersonApi);
            var response = await client.PutAsync("api/person", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeletePerson(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete,
                "api/person");

            var client = _clientFactory.CreateClient(DalConstants.PersonApi);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
        }
    }
}
