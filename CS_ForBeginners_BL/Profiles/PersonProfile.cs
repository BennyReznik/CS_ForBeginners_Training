using AutoMapper;
using CS_ForBeginners_BL.Models;
using CS_ForBeginners_DAL.Entities;

namespace CS_ForBeginners_BL.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<PersonModel, PersonEntity>().ReverseMap();
        }
    }
}
