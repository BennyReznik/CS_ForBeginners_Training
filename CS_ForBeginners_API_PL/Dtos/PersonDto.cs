using System.ComponentModel.DataAnnotations;

namespace CS_ForBeginners_API_PL.Dtos
{
    public class PersonDto
    {
        public PersonDto()
        {

        }

        public PersonDto(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
