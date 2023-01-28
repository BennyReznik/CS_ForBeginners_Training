using AutoMapper;
using CS_ForBeginners_API_BL.Models;
using CS_ForBeginners_API_DAL.Entities;

namespace CS_ForBeginners_API_BL.Profiles
{
    public class PersonBLProfile : Profile
    {
        public PersonBLProfile()
        {
            CreateMap<PersonModel, PersonEntity>().ReverseMap();
        }
    }
}
