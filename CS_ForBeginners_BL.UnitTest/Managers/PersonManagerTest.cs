using AutoMapper;
using CS_ForBeginners_BL.Managers;
using CS_ForBeginners_BL.Profiles;
using CS_ForBeginners_DAL.Entities;
using CS_ForBeginners_DAL.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CS_ForBeginners_BL.UnitTest.Managers
{
    [TestClass]
    public class PersonManagerTest
    {
        private static PersonManager _personManager;
        private static Mock<IPersonRepository> _personRepository;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            var people = new List<PersonEntity>();
            people.Add(new PersonEntity { Id = 1, Age = 30, Name = "p1" });
            people.Add(new PersonEntity { Id = 1, Age = 20, Name = "p2" });
            _personRepository = new Mock<IPersonRepository>();
            _personRepository.Setup(m => m.GetAll()).ReturnsAsync(people);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new PersonProfile());
            });

            var mapper = new Mapper(config);

            _personManager = new PersonManager(mapper, _personRepository.Object);
        }

        [TestMethod]
        public async Task GetPeopleAverageAge_TwoPeopleAverageIs25_ReturnedAverageIs25()
        {
            // Arrange

            // Act
            var actualResult = await _personManager.GetPeopleAverageAge();

            // Assert
            Assert.AreEqual(25, actualResult);
        }
    }
}
