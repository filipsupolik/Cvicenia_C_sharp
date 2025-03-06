using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie2_triedy
{
    class Person
    {
        private string _firstName;

        public Person()
        {
        }

        public Person(string firstName, string lastName, DateTime? dateOfBirth, Gender gender = Gender.UNKNOWN)
        {
            _firstName = firstName;
            LastName = lastName;
            Birthdate =  dateOfBirth == null ? DateTime.Now : dateOfBirth;

            Age = Birthdate == null ? 0 : DateTime.Now.Year - Birthdate.Value.Year;
            FullName = $"{FirstName} {LastName}";
        }

        public int Age { get; }
        public DateTime? Birthdate { get; set; }
        public string FirstName { get => _firstName; set => _firstName = FirstName; }
        public string FullName { get; }
        public Gender Gender { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Person person &&
                   _firstName == person._firstName &&
                   Age == person.Age &&
                   Birthdate == person.Birthdate &&
                   FirstName == person.FirstName &&
                   FullName == person.FullName &&
                   Gender == person.Gender &&
                   LastName == person.LastName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_firstName, Age, Birthdate, FirstName, FullName, Gender, LastName);
        }

        public override string? ToString()
        {
            return $"{FirstName} {LastName} ({Age})";
        }
    }

    public enum Gender
    {
        UNKNOWN,
        MALE,
        FEMALE
    }
}
