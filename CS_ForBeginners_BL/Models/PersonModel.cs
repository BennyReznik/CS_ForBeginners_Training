using System;

namespace CS_ForBeginners_BL.Models
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

        public override string ToString()
        {
            return $"Name: {Name}," +
                   $"{Environment.NewLine} Id: {Id}," +
                   $"{Environment.NewLine} Age: {Age} " +
                   $"{Environment.NewLine}";
        }
    }
}
