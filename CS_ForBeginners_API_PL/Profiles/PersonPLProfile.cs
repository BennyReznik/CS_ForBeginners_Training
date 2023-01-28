using AutoMapper;
using CS_ForBeginners_API_BL.Models;
using CS_ForBeginners_API_PL.Dtos;

namespace CS_ForBeginners_API_PL.Profiles
{
    public class PersonPLProfile : Profile
    {
        public PersonPLProfile()
        {
            CreateMap<PersonDto, PersonModel > ().ReverseMap();
        }
    }
}
