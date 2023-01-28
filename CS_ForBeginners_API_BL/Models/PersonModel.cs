using System;
using System.Collections.Generic;
using System.Text;

namespace CS_ForBeginners_API_BL.Models
{
    public class PersonModel
    {
        public PersonModel(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
